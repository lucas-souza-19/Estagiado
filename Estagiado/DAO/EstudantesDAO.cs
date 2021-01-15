using System;
using System.Data;
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
                string cmdInsertSql = @"insert into estudante (nome, cpf, sexo, email, fone, 
                                                               whatsapp, senha, endereco, cidade, 
                                                               estado, cod_universidade, nivel_acesso) 
                                                       values (@nome, @cpf,  @sexo, @email, @fone, 
                                                               @whatsapp, @senha, @endereco, @cidade,
                                                               @estado, @cod_universidade, @nivel_acesso)";

                MySqlCommand comandoSql = new MySqlCommand(cmdInsertSql, conexaoComMySql);

                comandoSql.Parameters.AddWithValue("@nome", obj_estudante.Nome);
                comandoSql.Parameters.AddWithValue("@cpf", obj_estudante.Cpf);             
                comandoSql.Parameters.AddWithValue("@sexo", obj_estudante.Sexo);
                comandoSql.Parameters.AddWithValue("@email", obj_estudante.Email);
                comandoSql.Parameters.AddWithValue("@fone", obj_estudante.Fone);
                comandoSql.Parameters.AddWithValue("@whatsapp", obj_estudante.Whatsapp);
                comandoSql.Parameters.AddWithValue("@senha", obj_estudante.Senha);
                comandoSql.Parameters.AddWithValue("@endereco", obj_estudante.Endereco);
                comandoSql.Parameters.AddWithValue("@cidade", obj_estudante.Cidade);
                comandoSql.Parameters.AddWithValue("@estado", obj_estudante.Estado);
                comandoSql.Parameters.AddWithValue("@cod_universidade", obj_estudante.CodUniversidade);
                comandoSql.Parameters.AddWithValue("@nivel_acesso", obj_estudante.NivelAcesso);

                conexaoComMySql.Open();

                comandoSql.ExecuteNonQuery();

                conexaoComMySql.Close();

                MessageBox.Show("Estudante cadastrado com sucesso!");
            }
            catch (Exception erroNaCriacao)
            {
                MessageBox.Show("Erro na criação do usuario: " + erroNaCriacao);
            }
        }
        #endregion

        #region Método ReadEstudante - busca e lista todos os estudantes e suas universidades
        public DataTable ReadEstudantes()
        {
            string cmdSelectSql = @"SELECT e.id_estudante as 'ID', e.nome as 'Nome', e.email as 'Email', 
                                           u.curso as 'Curso', u.nome as 'Universidade', 
                                           u.cidade as 'Localidade', 
                                           u.avaliacao_mec as 'Nota Enade', 
                                           e.cidade as 'Residencia', e.endereco as 'Endereco', 
                                           e.estado as 'Estado', e.whatsapp as 'WhatsApp', 
                                           e.fone as 'Telefone' 
                                    FROM estudante as e JOIN universidade as u 
                                    on (e.cod_universidade = u.id_universidade) order by Nome asc";

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

        #region Método ReadEstudantes2 - busca e lista os dados de um estudante atraves do seu ID
        public DataTable ReadEstudantes2(int id)
        {
            string cmdSelectSql = @"SELECT e.nome as 'Nome', e.cpf as 'CPF', e.sexo as 'Sexo', 
                                           e.email as 'Email', e.fone as 'Telefone', e.whatsapp as 'WhatsApp', 
                                           e.senha as 'Senha', e.endereco as 'Endereco', e.cidade as 'Cidade', 
                                           e.estado as 'Estado', e.cod_universidade as 'Universidade', e.id_estudante as 'ID' 
                                    FROM estudante as e 
                                    WHERE e.id_estudante = @id";

            MySqlCommand comandoSql = new MySqlCommand(cmdSelectSql, conexaoComMySql);

            comandoSql.Parameters.AddWithValue("@id", id);

            conexaoComMySql.Open();

            comandoSql.ExecuteNonQuery();

            DataTable tbEstudantes = new DataTable();

            MySqlDataAdapter adaptadorDados = new MySqlDataAdapter(comandoSql);

            adaptadorDados.Fill(tbEstudantes);

            conexaoComMySql.Close();

            return tbEstudantes;
        }
        #endregion

        #region Método ReadEstudantes3 - recupera o ID de um estudante através do seu email e da sua senha
        public DataTable ReadEstudantes3(string cpf, string senha)
        {
    
            string cmdSelectSql = @"SELECT e.id_estudante as 'ID' 
                                    FROM estudante as e 
                                    WHERE cpf = @cpf and senha = @senha";

            MySqlCommand comandoSql = new MySqlCommand(cmdSelectSql, conexaoComMySql);

            comandoSql.Parameters.AddWithValue("@cpf", cpf);
            comandoSql.Parameters.AddWithValue("@senha", senha);

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
                string cmdUpdateSql = @"update estudante set nome = @nome, cpf = @cpf, sexo = @sexo, email = @email, 
                                                             fone = @fone, whatsapp = @whatsapp, senha = @senha, 
                                                             endereco = @endereco, cidade = @cidade, estado = @estado,
                                                             cod_universidade = @cod_universidade, nivel_acesso = @nivel_acesso
                                                       where id_estudante = @id";

                MySqlCommand comandoMySql = new MySqlCommand(cmdUpdateSql, conexaoComMySql);

                comandoMySql.Parameters.AddWithValue("@nome", obj_estudante.Nome);
                comandoMySql.Parameters.AddWithValue("@cpf", obj_estudante.Cpf);
                comandoMySql.Parameters.AddWithValue("@sexo", obj_estudante.Sexo);
                comandoMySql.Parameters.AddWithValue("@email", obj_estudante.Email);
                comandoMySql.Parameters.AddWithValue("@fone", obj_estudante.Fone);
                comandoMySql.Parameters.AddWithValue("@whatsapp", obj_estudante.Whatsapp);
                comandoMySql.Parameters.AddWithValue("@senha", obj_estudante.Senha);
                comandoMySql.Parameters.AddWithValue("@endereco", obj_estudante.Endereco);
                comandoMySql.Parameters.AddWithValue("@cidade", obj_estudante.Cidade);
                comandoMySql.Parameters.AddWithValue("@estado", obj_estudante.Estado);
                comandoMySql.Parameters.AddWithValue("@cod_universidade", obj_estudante.CodUniversidade);
                comandoMySql.Parameters.AddWithValue("@nivel_acesso", obj_estudante.NivelAcesso);

                comandoMySql.Parameters.AddWithValue("@id", obj_estudante.Id);

                conexaoComMySql.Open();

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

        # region Método DeleteEstudante - exclui todas os dados do estudante, incluindo suas candidaturas e seu currículo
        public void DeleteEstudante(EstudanteModel obj_estudante)
        {
            try
            {
                string deltDependencia1 = @"DELETE FROM candidata_se WHERE cod_candidato = @id";
                string deltDependencia2 = @"DELETE FROM curriculo WHERE cod_estudante = @id";
                string deltEstudante = @"DELETE FROM estudante WHERE id_estudante = @id";
             

                MySqlCommand comandoMySql1 = new MySqlCommand(deltDependencia1, conexaoComMySql);
                comandoMySql1.Parameters.AddWithValue("@id", obj_estudante.Id);

                MySqlCommand comandoMysql2 = new MySqlCommand(deltDependencia2, conexaoComMySql);
                comandoMysql2.Parameters.AddWithValue("@id", obj_estudante.Id);

                MySqlCommand comandoMySql3 = new MySqlCommand(deltEstudante, conexaoComMySql);
                comandoMySql3.Parameters.AddWithValue("@id", obj_estudante.Id);

                conexaoComMySql.Open();

                comandoMySql1.ExecuteNonQuery();
                comandoMysql2.ExecuteNonQuery();
                comandoMySql3.ExecuteNonQuery();

                conexaoComMySql.Close();

                MessageBox.Show("Dados excluidos com sucesso!");
            }
            catch (Exception erroNaExclusao)
            {
                MessageBox.Show("Erro na exclusão dos dados: " + erroNaExclusao);
            }
        }
        #endregion
    }
}
