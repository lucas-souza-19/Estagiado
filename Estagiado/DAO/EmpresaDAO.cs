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

        #region Método CreateEmpresa - registra uma nova empresa
        public void CreateEmpresa(EmpresaModel empresa)
        {
            try
            {
                string insertSql = @"insert into empresa (nome, cnpj, email_recrut, whatsapp, 
                                                          link_recrut, senha, endereco, cidade, 
                                                          estado, nivel_acesso) 
                                                  values (@nome, @cnpj, @email, @whatsapp, 
                                                          @link, @senha, @endereco, @cidade,
                                                          @estado, @nivel)";
                
                MySqlCommand comandoSql = new MySqlCommand(insertSql, connection);

                comandoSql.Parameters.AddWithValue("@nome", empresa.Nome);
                comandoSql.Parameters.AddWithValue("@cnpj", empresa.Cnpj);
                comandoSql.Parameters.AddWithValue("@email", empresa.EmailRecrutamento);
                comandoSql.Parameters.AddWithValue("@whatsapp", empresa.Whatsapp);
                comandoSql.Parameters.AddWithValue("@link", empresa.LinkRecrutamento);
                comandoSql.Parameters.AddWithValue("@senha", empresa.Senha);
                comandoSql.Parameters.AddWithValue("@endereco", empresa.Endereco);
                comandoSql.Parameters.AddWithValue("@cidade", empresa.Cidade);
                comandoSql.Parameters.AddWithValue("@estado", empresa.Estado);
                comandoSql.Parameters.AddWithValue("@nivel", empresa.NivelAcesso);

                connection.Open();

                comandoSql.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Empresa cadastrada com sucesso!");
            }
            catch (Exception erroCadastro)
            {
                MessageBox.Show("Erro ao cadastrar: " + erroCadastro);
            }
        }
        #endregion

        #region Método ReadEmpresas - busca empresas registradas através do ID da empresa e traz todos os dados
        public DataTable ReadEmpresas(int id)
        {
            string selectSql = @"SELECT e.nome as 'Nome', e.cnpj as 'CNPJ', e.email_recrut as 'Email', 
                                        e.senha as 'Senha', e.whatsapp as 'WhatsApp', e.link_recrut as 'Link', 
                                        e.endereco as 'Endereco', e.cidade as 'Cidade', e.estado as 'Estado' 
                                 FROM empresa AS e 
                                 WHERE id_unidd_empresa = @id";

            MySqlCommand comandoSql = new MySqlCommand(selectSql, connection);

            comandoSql.Parameters.AddWithValue("@id", id);

            connection.Open();

            comandoSql.ExecuteNonQuery();

            MySqlDataAdapter adaptadorDados = new MySqlDataAdapter(comandoSql);

            DataTable tbEmpresas = new DataTable();

            adaptadorDados.Fill(tbEmpresas);

            connection.Close();

            return tbEmpresas;
        }
        #endregion

        #region Método ReadEmpresas2 - busca o ID da empresa e o traz formatado e em forma de tabela
        public DataTable ReadEmpresas2(int id)
        {
            string selectSql = @"SELECT e.id_unidd_empresa as 'ID' 
                                 FROM empresa AS e 
                                 WHERE id_unidd_empresa = @id";

            MySqlCommand comandoSql = new MySqlCommand(selectSql, connection);

            comandoSql.Parameters.AddWithValue("@id", id);

            connection.Open();

            comandoSql.ExecuteNonQuery();

            MySqlDataAdapter adaptadorDados = new MySqlDataAdapter(comandoSql);

            DataTable tbEmpresas = new DataTable();

            adaptadorDados.Fill(tbEmpresas);

            connection.Close();

            return tbEmpresas;
        }
        #endregion

        #region Método RecuperarId - recupera o ID da empresa com o CNPJ e retona-o como string
        public string RecuperarId(string cnpj)
        {
            string selectSql = @"SELECT * FROM empresa WHERE cnpj = @cnpj";

            MySqlCommand comandoSql = new MySqlCommand(selectSql, connection);

            comandoSql.Parameters.AddWithValue("@cnpj", cnpj);

            connection.Open();

            MySqlDataReader data = comandoSql.ExecuteReader();

            if (data.Read())
            {
                string id = data.GetString("id_unidd_empresa");

                return id;
            }
            else
            {
                return "";
            }

        }
        #endregion

        #region Método UpdateEmpresa - atualiza os dados da empresa
        public void UpdateEmpresa(EmpresaModel empresa)
        {
            try
            {
                string updateSqlCmd = @"update empresa set nome = @nome, cnpj = @cnpj, email_recrut = @email, 
                                                           whatsapp = @whatsapp, link_recrut = @link, 
                                                           senha = @senha, endereco = @endereco, cidade = @cidade,
                                                           estado = @estado, nivel_acesso = @nivel
                                                     where id_unidd_empresa = @id";

                MySqlCommand comandoMysql = new MySqlCommand(updateSqlCmd, connection);

                comandoMysql.Parameters.AddWithValue("@nome", empresa.Nome);
                comandoMysql.Parameters.AddWithValue("@cnpj", empresa.Cnpj);
                comandoMysql.Parameters.AddWithValue("@email", empresa.EmailRecrutamento);
                comandoMysql.Parameters.AddWithValue("@whatsapp", empresa.Whatsapp);
                comandoMysql.Parameters.AddWithValue("@link", empresa.LinkRecrutamento);
                comandoMysql.Parameters.AddWithValue("@senha", empresa.Senha);
                comandoMysql.Parameters.AddWithValue("@endereco", empresa.Endereco);
                comandoMysql.Parameters.AddWithValue("@cidade", empresa.Cidade);
                comandoMysql.Parameters.AddWithValue("@estado", empresa.Estado);
                comandoMysql.Parameters.AddWithValue("@nivel", empresa.NivelAcesso);
                comandoMysql.Parameters.AddWithValue("@id", empresa.Id);

                connection.Open();

                comandoMysql.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Atualizado com sucesso!");
            }
            catch(Exception erroAtualizacao)
            {
                MessageBox.Show("Erro ao atualizar cadastro: " + erroAtualizacao);
            }
        }
        #endregion

        #region Método DeleteEmpresa - exclui os dados da empresa
        public void DeleteEmpresa(int id_empresa)
        {
            try
            {
                string deleteCmdSql = @"DELETE FROM empresa WHERE id_unidd_empresa = @id";

                MySqlCommand comandoMysql = new MySqlCommand(deleteCmdSql, connection);

                comandoMysql.Parameters.AddWithValue("@id", id_empresa);

                connection.Open();

                comandoMysql.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Dados excluídos com sucesso!");
            }
            catch(Exception erroDeletar)
            {
                MessageBox.Show("Erro ao excluir: " + erroDeletar);
            }
        }
        #endregion
    }
}

/*     
#region Método RecuperarIdEmpresa - recupera e retorna o Id da empresa
public DataTable RecuperarIdEmpresa(EmpresaModel empresa)
{
    string selectSql = "SELECT id_unidd_empresa as 'ID' FROM empresa WHERE cnpj = @cnpj";

    MySqlCommand cmdMysql = new MySqlCommand(selectSql, connection);

    cmdMysql.Parameters.AddWithValue("@cnpj", empresa.Cnpj);

    connection.Open();

    cmdMysql.ExecuteNonQuery();

    DataTable tbId = new DataTable();

    MySqlDataAdapter adapter = new MySqlDataAdapter(cmdMysql);

    adapter.Fill(tbId);

    connection.Close();

    return tbId;
}
#endregion
 */
