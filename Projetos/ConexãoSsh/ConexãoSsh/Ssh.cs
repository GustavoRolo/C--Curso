using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace ConexãoSsh
{
    internal class Ssh
    {
        public bool sendCommand(string ipdevice, string ipLocal, List<string> comandos)
        {
            try
            {
                Console.WriteLine("Iniciando \r\n");
                using (var client = new SshClient(ipdevice, 3718, "zkteco", "90opl;././"))
                {
                    client.Connect();

                    ShellStream shellStream = client.CreateShellStream("xterm", 80, 24, 800, 600, 1024);

                    // Switch to root
                    SwithToRoot("solokeyL:\"", shellStream);

                    // Execute commands under root account
                    foreach (string comando in comandos)
                    {
                        WriteStream(comando, shellStream);
                        client.RunCommand(comando);

                    }

                    
                }

                return true;
            }
            catch
            {

                return false;
            }
        }


        private static void SwithToRoot(string password, ShellStream stream)
        {
            // Get logged in and get user prompt
            string prompt = stream.Expect(new Regex(@"[$>]"));

            // Send command and expect password or user prompt
            stream.WriteLine("su - root");
            prompt = stream.Expect(new Regex(@"([$#>:])"));

            // Check to send password
            if (prompt.Contains(":"))
            {
                // Send password
                stream.WriteLine(password);
                prompt = stream.Expect(new Regex(@"[$#>]"));

            }
        }

        private static void WriteStream(string cmd, ShellStream stream)
        {
            stream.WriteLine(cmd + "; echo this-is-the-end");
            while (stream.Length == 0)
                Thread.Sleep(500);
        }


    }
}

