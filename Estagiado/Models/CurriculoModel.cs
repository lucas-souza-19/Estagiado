using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estagiado.Models
{
    public class CurriculoModel
    {
        public int IdCurriculo { get; set; }
        public string FormacaoFinalizada { get; set; }
        public string CursoAtual { get; set; }
        public int AnoInicio { get; set; }
        public string SemestreInicio { get; set; }
        public int AnoTermino { get; set; }
        public string SemestreTermino { get; set; }
        public string TurnoCurso { get; set; }
        public string HabilidadesPraticas { get; set; }
        public string ConhecimentoTeorico { get; set; }
        public string HorasDiariasDisponivel { get; set; }
        public int CodEstudante { get; set; }
    }

}
