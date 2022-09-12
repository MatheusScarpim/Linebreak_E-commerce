    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Modelo_Produto
    {
        public int idPerfume { get; set; }
        public string Nomeper { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }
        public string Descricao { get; set; }
        public string Excluido { get; set; }
        public DateTime Data_Excluido { get; set; }
    }
}
