using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estagiado.Conexao;
using MySql.Data.MySqlClient;
using Estagiado.Models;
using System.Windows.Forms;

namespace Estagiado.DAO
{
    public class EstudantesDAO
    {
        MySqlConnection conexaoComMySql;

        public EstudantesDAO()
        {
            this.conexaoComMySql = ConnectionFactory.getConnection();
        }

        #region Método CreateEstudante - regitra um novo estudante
        public void CreateEstudante(EstudanteModel obj_estudante)
        {
            try
            {
                string cmdInsertSql = @"insert into estudante (cpf, nome, sexo, email, fone, whatsapp, senha) values (@cpf, @nome, @sexo, @email, @fone, @whatsapp, @senha)";

                MySqlCommand comandoSql = new MySqlCommand(cmdInsertSql, conexaoComMySql);

                comandoSql.Parameters.AddWithValue("@cpf", obj_estudante.cpf);
                comandoSql.Parameters.AddWithValue("@nome", obj_estudante.nome);
                comandoSql.Parameters.AddWithValue("@sexo", obj_estudante.sexo);
                comandoSql.Parameters.AddWithValue("@email", obj_estudante.email);
                comandoSql.Parameters.AddWithValue("@fone", obj_estudante.telefone);
                comandoSql.Parameters.AddWithValue("@whatsapp", obj_estudante.whatsapp);
                comandoSql.Parameters.AddWithValue("@senha", obj_estudante.senha);

                conexaoComMySql.Open();

                comandoSql.ExecuteNonQuery();

                conexaoComMySql.Close();

                MessageBox.Show("Cadastrado com sucesso!");
            }
            catch (Exception erroNaCriacao)
            {
                MessageBox.Show("Erro na criação do usuario: " + erroNaCriacao);
            }
        }
        #endregion

        #region Método ReadEstudante - busca e lista os estudantes
        public DataTable ReadEstudantes()
        {
            string cmdSelectSql = @"select * from estudante";

            MySqlCommand comandoSql = new MySqlCommand(cmdSelectSql, conexaoComMySql);

            conexaoComMySql.Open();

            comandoSql.ExecuteNonQuery();

            DataTable tbEstudantes = new DataTable();

            MySqlDataAdapter adaptadorDados = new MySqlDataAdapter(comandoSql);

            adaptadorDados.Fill(tbEstudantes);

            conexaoComMySql.Close();

            return tbEstudantes;
        }
        #endregion

        #region Método UpdateEstudante - atualiza os dados do estudante
        public void UpdateEstudante(EstudanteModel obj_estudante)
        {
            try
            {
                string cmdUpdateSql = @"update estudante set cpf = @cpf, nome = @nome, sexo=@sexo, email = @email, fone = @fone, whatsapp = @whatsapp, senha = @senha where id = @id";

                MySqlCommand comandoMySql = new MySqlCommand(cmdUpdateSql, conexaoComMySql);

                comandoMySql.Parameters.AddWithValue("@cpf", obj_estudante.cpf);
                comandoMySql.Parameters.AddWithValue("@nome", obj_estudante.nome);
                comandoMySql.Parameters.AddWithValue("@sexo", obj_estudante.sexo);
                comandoMySql.Parameters.AddWithValue("@email", obj_estudante.email);
                comandoMySql.Parameters.AddWithValue("@fone", obj_estudante.telefone);
                comandoMySql.Parameters.AddWithValue("@whatsapp", obj_estudante.whatsapp);
                comandoMySql.Parameters.AddWithValue("@senha", obj_estudante.senha);

                comandoMySql.Parameters.AddWithValue("@id", obj_estudante.id);

                comandoMySql.ExecuteNonQuery();

                conexaoComMySql.Close();

                MessageBox.Show("Atualizado com sucesso!");
            }
            catch(Exception erroNaAlteracao)
            {
                MessageBox.Show("Erro na alteração dos dados: " + erroNaAlteracao);
            }
        }
        #endregion

        # region Método DeleteEstudante - exclui estudante
        public void DeleteEstudante(EstudanteModel obj_estudante)
        {
            try
            {
                string cmdSqlDelete = @"delete from estudante where id = @id";

                MySqlCommand comandoMySql = new MySqlCommand(cmdSqlDelete, conexaoComMySql);
                comandoMySql.Parameters.AddWithValue("@id", obj_estudante.id);

                comandoMySql.ExecuteNonQuery();

                conexaoComMySql.Close();

                MessageBox.Show("Excluido com sucesso!");
            }
            catch (Exception erroNaExclusao)
            {
                MessageBox.Show("Erro na exclusão dos dados: " + erroNaExclusao);
            }
        }
        #endregion
    }
}
