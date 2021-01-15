using Estagiado.Conexao;
using Estagiado.Models;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Estagiado.DAO
{
    public class UniversidadeDAO
    {
        MySqlConnection conex;

        public UniversidadeDAO(){
            this.conex = ConnectionFactory.getConnection(); 
        }

        #region Início do Método CreateUniversidade - registra uma universidade
        public void CreateUniversidade(UniversidadeModel obj_universidade)
        {
            try
            {
                string cmdInsertSql = @"insert into universidade (nome, curso, avaliacao_mec, endereco, cidade, estado) 
                                                       values (@nome, @curso, @avaliacao_mec, @endereco, @cidade, @estado)";

                MySqlCommand cmdMySql = new MySqlCommand(cmdInsertSql, conex);

                cmdMySql.Parameters.AddWithValue("@nome", obj_universidade.getNome());
                cmdMySql.Parameters.AddWithValue("@curso", obj_universidade.getCurso());
                cmdMySql.Parameters.AddWithValue("@avaliacao_mec", obj_universidade.getAvaliacaoMec());
                cmdMySql.Parameters.AddWithValue("@endereco", obj_universidade.getEndereco());
                cmdMySql.Parameters.AddWithValue("@cidade", obj_universidade.getCidade());
                cmdMySql.Parameters.AddWithValue("@estado", obj_universidade.getEstado());

                conex.Open();

                cmdMySql.ExecuteNonQuery();

                conex.Close();

                MessageBox.Show("Universidade cadastrada com sucesso!");
            }
            catch (Exception erroCriacao)
            {
                MessageBox.Show("Erro ao registrar a universidade: " + erroCriacao);
            }
        }
        #endregion

        #region Método ReadUniversidade - recupera todas as universidades cadastradas
        public DataTable ReadUniversidade()
        {
            string cmdSelectSql = @"SELECT u.id_universidade as 'ID', 
                                           u.nome as 'Universidade', u.curso as 'Curso', 
                                           u.avaliacao_mec as 'Enade', u.endereco as 'Endereco', 
                                           u.cidade as 'Cidade', u.estado as 'Estado' 
                                           FROM universidade as u order by id_universidade desc";

            MySqlCommand cmdMySql = new MySqlCommand(cmdSelectSql, conex);

            conex.Open();

            cmdMySql.ExecuteNonQuery();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmdMySql);

            DataTable tblUniversidades = new DataTable();

            adapter.Fill(tblUniversidades);

            conex.Close();

            return tblUniversidades;
        }
        #endregion 

        #region Início do Método UpdateUniversidade - atualiza os dados da universidade
        public void UpdateUniversidade(UniversidadeModel obj_universidade)
        {
            try
            {
                string cmdUpdateSql = @"update universidade set nome = @nome, curso = @curso, avaliacao_mec = @avaliacao_mec, 
                                                            endereco = @endereco, cidade = @cidade, estado = @estado";
                MySqlCommand cmdMySql = new MySqlCommand(cmdUpdateSql, conex);

                cmdMySql.Parameters.AddWithValue("@nome", obj_universidade.getNome());
                cmdMySql.Parameters.AddWithValue("@curso", obj_universidade.getCurso());
                cmdMySql.Parameters.AddWithValue("@avaliacao_mec", obj_universidade.getAvaliacaoMec());
                cmdMySql.Parameters.AddWithValue("@endereco", obj_universidade.getEndereco());
                cmdMySql.Parameters.AddWithValue("@cidade", obj_universidade.getCidade());
                cmdMySql.Parameters.AddWithValue("@estado", obj_universidade.getEstado());

                conex.Open();

                cmdMySql.ExecuteNonQuery();

                conex.Close();

                MessageBox.Show("Dados atualizados com sucesso!");
            }
            catch (Exception erroUpdate)
            {
                MessageBox.Show("Erro ao atualizar os dados: " + erroUpdate);
            }
        }
        #endregion
    }
}
