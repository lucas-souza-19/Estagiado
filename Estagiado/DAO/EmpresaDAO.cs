using Estagiado.Conexao;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estagiado.Models;
using System.Data;

namespace Estagiado.DAO
{
    public class EmpresaDAO
    {
        MySqlConnection connection;

        public EmpresaDAO()
        {
            this.connection = ConnectionFactory.getConnection();
        }

        public void CreateEmpresa(EmpresaModel empresa)
        {
            try
            {
                string insertSql = @"insert into empresa (nome, cnpj, fone_comercial, ramal, email_recrut, whatsapp, link_recrut, senha) values (@nome, @cnpj, @fone, @ramal, @email, @whatsapp, @link, @senha)";
                
                MySqlCommand comandoSql = new MySqlCommand(insertSql, connection);

                comandoSql.Parameters.AddWithValue("@nome", empresa.Nome);
                comandoSql.Parameters.AddWithValue("@cnpj", empresa.Cnpj);
                comandoSql.Parameters.AddWithValue("@fone", empresa.Fone);
                comandoSql.Parameters.AddWithValue("@ramal", empresa.Ramal);
                comandoSql.Parameters.AddWithValue("@email", empresa.Email_recrutamento);
                comandoSql.Parameters.AddWithValue("@whatsapp", empresa.Whatsapp);
                comandoSql.Parameters.AddWithValue("@link", empresa.Link_recrutamento);
                comandoSql.Parameters.AddWithValue("@senha", empresa.Senha);

                connection.Open();

                comandoSql.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Cadastrado com sucesso!");
            }
            catch (Exception erroCadastro)
            {
                MessageBox.Show("Erro ao cadastrar: " + erroCadastro);
            }
        }

        public DataTable ReadEmpresas()
        {
            string selectSql = @"select * from empresa";

            MySqlCommand comandoSql2 = new MySqlCommand(selectSql, connection);

            comandoSql2.ExecuteNonQuery();

            MySqlDataAdapter adaptadorDados = new MySqlDataAdapter(comandoSql2);

            DataTable tbEmpresas = new DataTable();

            adaptadorDados.Fill(tbEmpresas);

            connection.Close();

            return tbEmpresas;
        }

        public void UpdateEmpresa(EmpresaModel empresa)
        {
            try
            {
                string updateSqlCmd = @"update empresa set nome = @nome, cnpj = @cnpj, fone_comercial = @fone, ramal = @ramal, email_recrut = @email, whatsapp = @whatsapp, link_recrut = @link, senha = @senha where id = @id";

                MySqlCommand comandoMysql3 = new MySqlCommand(updateSqlCmd, connection);

                comandoMysql3.Parameters.AddWithValue("@nome", empresa.Nome);
                comandoMysql3.Parameters.AddWithValue("@cnpj", empresa.Cnpj);
                comandoMysql3.Parameters.AddWithValue("@fone", empresa.Fone);
                comandoMysql3.Parameters.AddWithValue("@ramal", empresa.Ramal);
                comandoMysql3.Parameters.AddWithValue("@email", empresa.Email_recrutamento);
                comandoMysql3.Parameters.AddWithValue("@whatsapp", empresa.Whatsapp);
                comandoMysql3.Parameters.AddWithValue("@link", empresa.Link_recrutamento);
                comandoMysql3.Parameters.AddWithValue("@senha", empresa.Senha);

                comandoMysql3.Parameters.AddWithValue("@id", empresa.Id);

                comandoMysql3.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Atualizado com sucesso!");
            }
            catch(Exception erroAtualizacao)
            {
                MessageBox.Show("Erro ao atualizar cadastro: " + erroAtualizacao);
            }
        }

        public void DeleteEmpresa(EmpresaModel empresa)
        {
            try
            {
                string deleteCmdSql = @"delete from empresa where @id = id";

                MySqlCommand comandoMysql4 = new MySqlCommand(deleteCmdSql, connection);

                comandoMysql4.Parameters.AddWithValue("@id", empresa.Id);

                comandoMysql4.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Excluido com sucesso!");
            }
            catch(Exception erroDeletar)
            {
                MessageBox.Show("Erro ao excluir: " + erroDeletar);
            }
        }
    }
}
