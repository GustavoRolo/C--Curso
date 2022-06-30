using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationProj
{
    public class Operation
    {

        public string sendCommand(string ip, string porta, string login, string senha,List<string> comandos)
        {
            string retorno = "";
            try {

                using (var client = new SshClient(ip,Convert.ToInt32(porta),login,senha))
                {
                    client.Connect();

                    foreach (string comando in comandos)
                    {
                        client.RunCommand(comando);
                        
                    }
                    client.Disconnect();
                    retorno = "Executado com sucesso";
                }
                return retorno;
            }
            catch(Exception ex)
            {
                retorno = "Erro - "+ ex.Message;
                return retorno;
            }
        }
    }
}
