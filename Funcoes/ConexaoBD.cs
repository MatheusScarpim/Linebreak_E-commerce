using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
    public class ConexaoBD
    {
        public static string RetornaConexaoBD()
        {
            try
            {
                StreamReader arquivo = new StreamReader("ConfiguracaoBancoDeDados.dll");
                StringBuilder sb = new StringBuilder();
                sb.Append("Server=").Append(arquivo.ReadLine()).Append(";");
                sb.Append("Port=").Append(arquivo.ReadLine()).Append(";");
                sb.Append("Database=").Append(arquivo.ReadLine()).Append(";");
                sb.Append("User Id=").Append(arquivo.ReadLine()).Append(";");
                sb.Append("Password=").Append(arquivo.ReadLine()).Append(";");
                arquivo.Close();
                return sb.ToString();

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
