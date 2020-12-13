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

        //Criar (CREATE) um novo estudante
        public void CreateEstudante(EstudanteModel obj_estudante)
        {
            try
            {
                string cmdInsertSql = @"insert into estudante (cpf, nome, sexo, email, fone, whatsapp, senha) values (@cpf, @nome, @sexo, @email, @fone, @whatsapp, @senha)";

                MySqlCommand executeComandoSql = new MySqlCommand(cmdInsertSql, conexaoComMySql);

                executeComandoSql.Parameters.AddWithValue("@cpf", obj_estudante.cpf);
                executeComandoSql.Parameters.AddWithValue("@nome", obj_estudante.nome);
                executeComandoSql.Parameters.AddWithValue("@sexo", obj_estudante.sexo);
                executeComandoSql.Parameters.AddWithValue("@email", obj_estudante.email);
                executeComandoSql.Parameters.AddWithValue("@fone", obj_estudante.telefone);
                executeComandoSql.Parameters.AddWithValue("@whatsapp", obj_estudante.whatsapp);
                executeComandoSql.Parameters.AddWithValue("@senha", obj_estudante.senha);

                conexaoComMySql.Open();

                executeComandoSql.ExecuteNonQuery();

                conexaoComMySql.Close();

                MessageBox.Show("Cadastrado com sucesso!");
            }
            catch (Exception erroNaCriacao)
            {
                MessageBox.Show("Erro na criação do usuario: " + erroNaCriacao);
            }
        }

        //ler (READ) os dados do estudante
        public DataTable ReadEstudantes()
        {
            string consultaSql = @"select * from estudante";

            MySqlCommand executeComandoSql2 = new MySqlCommand(consultaSql, conexaoComMySql);

            executeComandoSql2.ExecuteNonQuery();

            MySqlDataAdapter adaptadorDados = new MySqlDataAdapter(executeComandoSql2);

            DataTable tbEstudantes = new DataTable();

            adaptadorDados.Fill(tbEstudantes);

            conexaoComMySql.Close();

            return tbEstudantes;
        }

        //alterar (UPDATE) os dados do estudante
        public void UpdateEstudante(EstudanteModel obj_estudante)
        {
            try
            {
                string sqlComando2 = @"update estudante set cpf = @cpf, nome = @nome, sexo=@sexo, email = @email, fone = @fone, whatsapp = @whatsapp, senha = @senha where id = @id";

                MySqlCommand executarComandoSql2 = new MySqlCommand(sqlComando2, conexaoComMySql);

                executarComandoSql2.Parameters.AddWithValue("@cpf", obj_estudante.cpf);
                executarComandoSql2.Parameters.AddWithValue("@nome", obj_estudante.nome);
                executarComandoSql2.Parameters.AddWithValue("@sexo", obj_estudante.sexo);
                executarComandoSql2.Parameters.AddWithValue("@email", obj_estudante.email);
                executarComandoSql2.Parameters.AddWithValue("@fone", obj_estudante.telefone);
                executarComandoSql2.Parameters.AddWithValue("@whatsapp", obj_estudante.whatsapp);
                executarComandoSql2.Parameters.AddWithValue("@senha", obj_estudante.senha);

                executarComandoSql2.Parameters.AddWithValue("@id", obj_estudante.id);

                executarComandoSql2.ExecuteNonQuery();

                conexaoComMySql.Close();
            }
            catch(Exception erroNaAlteracao)
            {
                MessageBox.Show("Erro na alteração dos dados: " + erroNaAlteracao);
            }
        }

        //excluir (DELETE estudante
        public void DeleteEstudante(EstudanteModel estudante)
        {
            try
            {
                string sqlCmd = @"delete from estudante where id = @codigo_id";

                MySqlCommand execCmdSql = new MySqlCommand(sqlCmd, conexaoComMySql);
                execCmdSql.Parameters.AddWithValue("@id", estudante.id);

                execCmdSql.ExecuteNonQuery();

                conexaoComMySql.Close();
            }
            catch (Exception erroNaExclusao)
            {
                MessageBox.Show("Erro na exclusão dos dados: " + erroNaExclusao);
            }
        }
    }
}



















/*
 *jeito ensinado pelo prof Hugo
 string conexaoBD = "SERVER=localhost; DATABASE=estagiado_db; UID=root; PWD=;";
        MySqlConnection conect = null;
        MySqlCommand comandoSql;

        public DataTable ListarDados()
        {
            try
            {
                conect = new MySqlConnection(conexaoBD);
                comandoSql = new MySqlCommand("SELECT *FROM estagiado_db", conect);
                MySqlDataAdapter adaptadorDados = new MySqlDataAdapter();
                adaptadorDados.SelectCommand = comandoSql;
                DataTable tabelaDados = new DataTable();
                adaptadorDados.Fill(tabelaDados);
                return tabelaDados;
            }
            catch (Exception)
            {
                throw;
            }
        }
     */
