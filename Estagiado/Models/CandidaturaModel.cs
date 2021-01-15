using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estagiado.Models
{
    public class CandidaturaModel
    {
        private int CodCandidato;
        private int CodVagaestagio;
        private double IprCandidato;
        private double DistanciaDoIprDaVaga;

        public int getCodCandidato()
        {
            return this.CodCandidato;
        }
        public void setCodCandidato(int cod_candidato)
        {
            if(cod_candidato != 0)
            {
                this.CodCandidato = cod_candidato;
            }
        }
        public int getCodVagaestagio()
        {
            return this.CodVagaestagio;
        }
        public void setCodVagaestagio(int cod_vagaestagio)
        {
            if(cod_vagaestagio != 0)
            {
                this.CodVagaestagio = cod_vagaestagio;
            }
        }
        public double getIprCandidato()
        {
            return this.IprCandidato;
        }
        public void setIprCandidato(double ipr_candidato)
        {
            if(ipr_candidato != 0.0)
            {
                this.IprCandidato = ipr_candidato;
            }
        }
        public double getDistanciaDoIprDaVaga()
        {
            return this.DistanciaDoIprDaVaga;
        }
        public void setDistanciaDoIprDaVaga(double distancia)
        {
            this.DistanciaDoIprDaVaga = distancia;
        }

        public CandidaturaModel()
        {
            this.CodCandidato = 0;
            this.CodVagaestagio = 0;
            this.IprCandidato = 0.0;
            this.DistanciaDoIprDaVaga = 0.0;
        }

        public double CalcularIprCandidato(double peso1, double peso2, double peso3)
        {
            return (peso1 + peso2 + peso3) / 3.00;
        }

        public double CalcularDistanciaDoIprDaVaga(double iprVaga, double iprCandidato)
        {
            double distacia = Math.Abs(iprVaga - iprCandidato);
            return distacia;
        }
    }
}
