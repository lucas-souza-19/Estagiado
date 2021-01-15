using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estagiado.Models
{
    public class VagaestagioModel
    {
        public int IdVaga { get; set; }
        public string Nome { get; set; }
        public string Requisito1 { get; set; }
        public string Requisito2 { get; set; }
        public string Requisito3 { get; set; }
        public double ValRequisito1 { get; set; }
        public double ValRequisito2 { get; set; }
        public double ValRequisito3 { get; set; }
        public double IprVaga { get; set; }
        public int CodEmpresa { get; set; }

        public double CalcularIpr(double peso1, double peso2, double peso3)
        {
            return (peso1 + peso2 + peso3) / 3.00;
        }
    }
}
