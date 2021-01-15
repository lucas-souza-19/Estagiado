using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estagiado.Models
{
    public class UniversidadeModel
    {
        // 1 - definir os atributos
        private int IdUniversidade;
        private string Nome;
        private string Curso;
        private int AvaliacaoMec;
        private string Endereco;
        private string Cidade;
        private string Estado;

        // 2 - criar os métodos getters e setters
        public int getIdUniversidade()
        {
            return this.IdUniversidade;
        }
        public void setIdUniversidade(int id_universidade)
        {
            if(id_universidade > 0)
            {
                this.IdUniversidade = id_universidade;
            }
        }
        public string getNome()
        {
            return this.Nome;
        }
        public void setNome(string nome)
        {
            if(nome != "")
            {
                this.Nome = nome;
            }
        }
        public string getCurso()
        {
            return this.Curso;
        }
        public void setCurso(string curso)
        {
            if(curso != "")
            {
                this.Curso = curso;
            }
        }
        public int getAvaliacaoMec()
        {
            return this.AvaliacaoMec;
        }
        public void setAvaliacaoMec(int avaliacao_mec)
        {
            if(avaliacao_mec > 0)
            {
                this.AvaliacaoMec = avaliacao_mec;
            }
        }
        public string getEndereco()
        {
            return this.Endereco;
        }
        public void setEndereco(string endereco)
        {
            if(endereco != "") {
                this.Endereco = endereco;
            }
        }
        public string getCidade()
        {
            return this.Cidade;
        }
        public void setCidade(string cidade)
        {
            if(cidade != "")
            {
                this.Cidade = cidade;
            }
        }
        public string getEstado()
        {
            return this.Estado;
        }
        public void setEstado(string estado)
        {
            if(estado != "")
            {
                this.Estado = estado;
            }
        }

        // 3 - criar os construtores
        public UniversidadeModel()
        {
            this.IdUniversidade = 0;
            this.Nome = "Não informado";
            this.Curso = "Não informado";
            this.AvaliacaoMec = 0;
            this.Endereco = "Não informado";
            this.Cidade = "Não informado";
            this.Estado = "";
        }
    }
}
