    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Modelo_User
    {
        public int idusuario{ get; set; }
        public string cpf { get; set; }
        public string nomeusu { get; set; }
        public DateTime niver { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string numero { get; set; }
        public DateTime Data_Criado { get; set; }
        public DateTime Data_Excluido { get; set; }
    }
}
