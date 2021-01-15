using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estagiado.Models
{
    public class EmpresaModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string EmailRecrutamento { get; set; }
        public string Whatsapp { get; set; }
        public string LinkRecrutamento { get; set; }
        public string Senha { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string NivelAcesso { get; set; }
    }
}
