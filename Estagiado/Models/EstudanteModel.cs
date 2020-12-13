using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estagiado.Models
{
    public class EstudanteModel
    {
        public int id { get; set; } //autoproperty
        public string cpf { get; set; }
        public string nome { get; set; }
        public string sexo { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string whatsapp { get; set; }
        public string senha { get; set; }
    }
}

/*
 * jeito ensinado pelo prof Hugo
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estagiado.DAO;

namespace Estagiado.Models
{
    public class EstudanteModel
    {
        EstudantesDAO estdao = new EstudantesDAO();
        public DataTable ListarDadosTabela()
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                estdao.ListarDados();
                return dadosTabela;
            }catch (Exception excecaoErro)
            {
                throw excecaoErro;
            }

        }
    }
}
*/

/*
public class EstudanteModel
    {
        public int id;
        public string cpf, nome, email, fone, whatsapp;
        public char sexo;

        //construtores
        public EstudanteModel()
        {
        }
        public EstudanteModel(int id, string cpf, string nome, string email, string whatsapp)
        {
            this.id = id;
            this.cpf = cpf;
            this.nome = nome;
            this.email = email;
            this.whatsapp = whatsapp;
        }
        public EstudanteModel(int id, string cpf, string nome, string email, string fone, string whatsapp, char sexo)
        {
            this.id = id;
            this.cpf = cpf;
            this.nome = nome;
            this.email = email;
            this.fone = fone;
            this.whatsapp = whatsapp;
            this.sexo = sexo;
        }

        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public string getCpf()
        {
            return cpf;
        }
        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }
        public string getNome()
        {
            return nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getEmail()
        {
            return email;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public string getFone()
        {
            return fone;
        }
        public void setFone(string fone)
        {
            this.fone = fone;
        }
        public string getWhatsapp()
        {
            return whatsapp;
        }
        public void setWhatsapp(string whatsapp)
        {
            this.whatsapp = whatsapp;
        }
        public char getSexo()
        {
            return sexo;
        }
        public void setSexo(char sexo)
        {
            this.sexo = sexo;
        }
    } 
*/
