using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace broski2._5
{
    class Axon
    {
        public static class Injector
        {
            public enum DllInjectionResult
            {
                DllNotFound,
                GameProcessNotFound,
                InjectionFailed,
                Success
            }

            public sealed class DllInjector
            {
                static readonly IntPtr INTPTR_ZERO = (IntPtr)0;

                [DllImport("kernel32.dll", SetLastError = true)]
                static extern IntPtr OpenProcess(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

                [DllImport("kernel32.dll", SetLastError = true)]
                static extern int CloseHandle(IntPtr hObject);

                [DllImport("kernel32.dll", SetLastError = true)]
                static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

                [DllImport("kernel32.dll", SetLastError = true)]
                static extern IntPtr GetModuleHandle(string lpModuleName);

                [DllImport("kernel32.dll", SetLastError = true)]
                static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, uint flAllocationType, uint flProtect);

                [DllImport("kernel32.dll", SetLastError = true)]
                static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] buffer, uint size, int lpNumberOfBytesWritten);

                [DllImport("kernel32.dll", SetLastError = true)]
                static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttribute, IntPtr dwStackSize, IntPtr lpStartAddress,
                    IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

                static DllInjector _instance;

                public static DllInjector GetInstance
                {
                    get
                    {
                        if (_instance == null)
                        {
                            _instance = new DllInjector();
                        }
                        return _instance;
                    }
                }

                DllInjector() { }

                public DllInjectionResult Inject(string sProcName, string sDllPath)
                {
                    if (!File.Exists(sDllPath))
                    {
                        return DllInjectionResult.DllNotFound;
                    }

                    uint _procId = 0;

                    Process[] _procs = Process.GetProcesses();
                    for (int i = 0; i < _procs.Length; i++)
                    {
                        if (_procs[i].ProcessName == sProcName)
                        {
                            _procId = (uint)_procs[i].Id;
                            break;
                        }
                    }

                    if (_procId == 0)
                    {
                        return DllInjectionResult.GameProcessNotFound;
                    }

                    if (!bInject(_procId, sDllPath))
                    {
                        return DllInjectionResult.InjectionFailed;
                    }

                    return DllInjectionResult.Success;
                }

                bool bInject(uint pToBeInjected, string sDllPath)
                {
                    IntPtr hndProc = OpenProcess((0x2 | 0x8 | 0x10 | 0x20 | 0x400), 1, pToBeInjected);

                    if (hndProc == INTPTR_ZERO)
                    {
                        return false;
                    }

                    IntPtr lpLLAddress = GetProcAddress(GetModuleHandle("kernel32.dll"), "LoadLibraryA");

                    if (lpLLAddress == INTPTR_ZERO)
                    {
                        return false;
                    }

                    IntPtr lpAddress = VirtualAllocEx(hndProc, (IntPtr)null, (IntPtr)sDllPath.Length, (0x1000 | 0x2000), 0X40);

                    if (lpAddress == INTPTR_ZERO)
                    {
                        return false;
                    }

                    byte[] bytes = Encoding.ASCII.GetBytes(sDllPath);

                    if (WriteProcessMemory(hndProc, lpAddress, bytes, (uint)bytes.Length, 0) == 0)
                    {
                        return false;
                    }

                    if (CreateRemoteThread(hndProc, (IntPtr)null, INTPTR_ZERO, lpLLAddress, lpAddress, 0, (IntPtr)null) == INTPTR_ZERO)
                    {
                        return false;
                    }

                    CloseHandle(hndProc);

                    return true;
                }
            }
        }
        public static class NamedPipes
        {
            public static string luapipename = "Axon";//Axon name of lua pipe

            [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            private static extern bool WaitNamedPipe(string name, int timeout);
            //function to check if the pipe exist
            public static bool NamedPipeExist(string pipeName)
            {
                try
                {
                    if (!WaitNamedPipe($"\\\\.\\pipe\\{pipeName}", 0))
                    {
                        int lastWin32Error = Marshal.GetLastWin32Error();
                        if (lastWin32Error == 0)
                        {
                            return false;
                        }
                        if (lastWin32Error == 2)
                        {
                            return false;
                        }
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

            //lua pipe function
            public static void LuaPipe(string script)
            {
                if (NamedPipeExist(luapipename))
                {
                    new Thread(() =>//lets run this in another thread so if roblox crash the ui/gui don't freeze or something
                    {
                        try
                        {
                            using (NamedPipeClientStream namedPipeClientStream = new NamedPipeClientStream(".", luapipename, PipeDirection.Out))
                            {
                                namedPipeClientStream.Connect();
                                using (StreamWriter streamWriter = new StreamWriter(namedPipeClientStream, Encoding.Default, 999999))//changed buffer to max 1mb since default buffer is 1kb
                                {
                                    streamWriter.Write(script);
                                    streamWriter.Dispose();
                                }
                                namedPipeClientStream.Dispose();
                            }
                        }
                        catch (IOException)
                        {
                            MessageBox.Show("An error occured connecting to the pipe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }).Start();
                }
                else
                {
                    MessageBox.Show("Inject Axon before using this!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        
        public static void Inject()
        {
            if (NamedPipes.NamedPipeExist(NamedPipes.luapipename))//check if the pipe exist
            {
                MessageBox.Show("Already injected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);//if the pipe exist that's mean that we don't need to inject
                return;
            }
            else if (!NamedPipes.NamedPipeExist(NamedPipes.luapipename))//check if the pipe don't exist
            {
                switch (Injector.DllInjector.GetInstance.Inject("RobloxPlayerBeta", AppDomain.CurrentDomain.BaseDirectory + "Axon.dll"))//Process name and dll directory
                {
                    case Injector.DllInjectionResult.DllNotFound://if can't find the dll
                        MessageBox.Show($"Could not find Axon DLL!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//display messagebox to tell that dll was not found
                        return;
                    case Injector.DllInjectionResult.GameProcessNotFound://if can't find the process
                        MessageBox.Show("Couldn't find RobloxPlayerBeta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//display messagebox to tell that proccess was not found
                        return;
                    case Injector.DllInjectionResult.InjectionFailed://if injection fails(this don't work or only on special cases)
                        MessageBox.Show("Injection failed! Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//display messagebox to tell that injection failed
                        return;
                }
                Thread.Sleep(3000);
                if (!NamedPipes.NamedPipeExist(NamedPipes.luapipename))//check if the pipe dont exist
                {
                    MessageBox.Show("Injection failed! Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//display that the pipe was not found so the injection was unsuccessful
                }
            }
        }
        public static void Execute(string script = "print(\"Hello World!\")")
        {
            if (NamedPipes.NamedPipeExist(NamedPipes.luapipename))//check if the pipe exist
            {
                NamedPipes.LuaPipe(script);//lua pipe function to send the script
            }
            else
            {
                MessageBox.Show($"Inject Axon before using this!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);//if the pipe can't be found a messagebox will appear
                return;
            }
        }
    }
}
