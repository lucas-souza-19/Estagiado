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
        public string Fone { get; set; }
        public string Ramal {get; set;}
        public string Email_recrutamento { get; set; }
        public string Whatsapp { get; set; }
        public string Link_recrutamento { get; set; }
        public string Senha { get; set; }
    }
}
