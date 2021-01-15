using Estagiado.Conexao;
using Estagiado.Models;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Estagiado.DAO
{
    public class CurriculoDAO
    {
        MySqlConnection conexao;

        public CurriculoDAO()
        {
            this.conexao = ConnectionFactory.getConnection();
        }

        #region Método CreateCurriculo - cadastra um novo curriculo
        public void CreateCurriculo(CurriculoModel curriculo)
        {
            try
            {
                string insertSql = @"insert into curriculo (formacao_finlzd, curso_atual, ano_inicio, semestre_inicio, 
                                                            ano_termino, semestre_termino, turno_curso, habilidds_praticas,
                                                            conhecmto_teorico, horas_diarias_disp, cod_estudante)
                                                    values (@formacao_finalizada, @curso_atual, @ano_inicio, @semestre_inicio,
                                                            @ano_termino, @semestre_termino, @turno_curso, @habilidades_praticas,
                                                            @conhecimento_teorico, @horas_diarias_disponiveis, @cod_estudante)";

                MySqlCommand cmdMySql = new MySqlCommand(insertSql, conexao);

                cmdMySql.Parameters.AddWithValue("@formacao_finalizada", curriculo.FormacaoFinalizada);
                cmdMySql.Parameters.AddWithValue("@curso_atual", curriculo.CursoAtual);
                cmdMySql.Parameters.AddWithValue("@ano_inicio", curriculo.AnoInicio);
                cmdMySql.Parameters.AddWithValue("@semestre_inicio", curriculo.SemestreInicio);
                cmdMySql.Parameters.AddWithValue("@ano_termino", curriculo.AnoTermino);
                cmdMySql.Parameters.AddWithValue("@semestre_termino", curriculo.SemestreTermino);
                cmdMySql.Parameters.AddWithValue("@turno_curso", curriculo.TurnoCurso);
                cmdMySql.Parameters.AddWithValue("@habilidades_praticas", curriculo.HabilidadesPraticas);
                cmdMySql.Parameters.AddWithValue("@conhecimento_teorico", curriculo.ConhecimentoTeorico);
                cmdMySql.Parameters.AddWithValue("@horas_diarias_disponiveis", curriculo.HorasDiariasDisponivel);
                cmdMySql.Parameters.AddWithValue("@cod_estudante", curriculo.CodEstudante);

                conexao.Open();

                cmdMySql.ExecuteNonQuery();

                conexao.Close();

                MessageBox.Show("Currículo cadastrado com sucesso!");
            }
            catch (Exception erroCreate)
            {
                MessageBox.Show("Erro ao cadastrar curriculo: " + erroCreate);
            }
        }
        #endregion

        #region Método ReadCurriculo - recupera o curriculo cadastrado através do ID do estudante
        public DataTable ReadCurriculo(int cod)
        {
            string selectSql = @"SELECT c.formacao_finlzd as 'Formacao Finalizada', c.curso_atual as 'Curso Atual', 
                                        c.ano_inicio as 'Ano de Inicio', c.semestre_inicio as 'Semestre de Inicio', 
                                        c.ano_termino as 'Ano de Termino', c.semestre_termino as 'Semestre de Termino', 
                                        c.turno_curso as 'Turno do Curso', c.habilidds_praticas as 'Habilidades Praticas', 
                                        c.conhecmto_teorico as 'Conhecimento Teorico', c.horas_diarias_disp as 'Horas Diarias Disponiveis' 
                                 FROM curriculo as c 
                                 WHERE cod_estudante = @cod";

            MySqlCommand cmdMySql = new MySqlCommand(selectSql, conexao);

            cmdMySql.Parameters.AddWithValue("@cod", cod);

            conexao.Open();

            cmdMySql.ExecuteNonQuery();

            DataTable tbCurriculos = new DataTable();

            MySqlDataAdapter adaptadorDados = new MySqlDataAdapter(cmdMySql);

            adaptadorDados.Fill(tbCurriculos);

            conexao.Close();

            return tbCurriculos;
        }
        #endregion

        #region Método EncontrarIdEstudante - encontra e retorna o Id do estudante
        public DataTable EncontrarIdEstudante(EstudanteModel estudante)
        {
            string selectSql = "SELECT id_estudante as 'ID' FROM estudante WHERE cpf = @cpf";

            MySqlCommand cmdMySql = new MySqlCommand(selectSql, conexao);

            cmdMySql.Parameters.AddWithValue("@cpf", estudante.Cpf);

            conexao.Open();

            cmdMySql.ExecuteNonQuery();

            DataTable tbId = new DataTable();

            MySqlDataAdapter adaptadorDados = new MySqlDataAdapter(cmdMySql);

            adaptadorDados.Fill(tbId);

            conexao.Close();

            return tbId;
        }
        #endregion

        #region Metodo UpdateCurriculo - atualiza o curriculo
        public void UpdateCurriculo(CurriculoModel curriculo)
        {
            try
            {
                string updateSql = @"update curriculo set formacao_finlzd = @formacao_finalizada, curso_atual = @curso_atual, 
                                                          ano_inicio = @ano_inicio, semestre_inicio = @semestre_inicio, 
                                                          ano_termino = @ano_termino, semestre_termino = @semestre_termino, 
                                                          turno_curso = @turno_curso, habilidds_praticas = @habilidades_praticas,
                                                          conhecmto_teorico = @conhecimento_teorico, horas_diarias_disp = @horas_diarias_disponiveis, 
                                                          cod_estudante = @cod_estudante where cod_estudante = @cod_estudante";
                                                     
                MySqlCommand cmdMySql = new MySqlCommand(updateSql, conexao);

                cmdMySql.Parameters.AddWithValue("@formacao_finalizada", curriculo.FormacaoFinalizada);
                cmdMySql.Parameters.AddWithValue("@curso_atual", curriculo.CursoAtual);
                cmdMySql.Parameters.AddWithValue("@ano_inicio", curriculo.AnoInicio);
                cmdMySql.Parameters.AddWithValue("@semestre_inicio", curriculo.SemestreInicio);
                cmdMySql.Parameters.AddWithValue("@ano_termino", curriculo.AnoTermino);
                cmdMySql.Parameters.AddWithValue("@semestre_termino", curriculo.SemestreTermino);
                cmdMySql.Parameters.AddWithValue("@turno_curso", curriculo.TurnoCurso);
                cmdMySql.Parameters.AddWithValue("@habilidades_praticas", curriculo.HabilidadesPraticas);
                cmdMySql.Parameters.AddWithValue("@conhecimento_teorico", curriculo.ConhecimentoTeorico);
                cmdMySql.Parameters.AddWithValue("@horas_diarias_disponiveis", curriculo.HorasDiariasDisponivel);
                cmdMySql.Parameters.AddWithValue("@cod_estudante", curriculo.CodEstudante);

                conexao.Open();

                cmdMySql.ExecuteNonQuery();

                conexao.Close();

                MessageBox.Show("Currículo atualizado com sucesso!");
            }
            catch (Exception erroUpdate)
            {
                MessageBox.Show("Erro ao atualizar o curriculo: " + erroUpdate);
            }
        }
        #endregion

        #region Método DeleteCurriculo - exclui o curriculo do estudante
        public void DeleteCurriculo(CurriculoModel curriculo)
        {
            try
            {
                string deleteSql = @"delete from curriculo where id_curriculo = @id";

                MySqlCommand comandoMySql = new MySqlCommand(deleteSql, conexao);
                comandoMySql.Parameters.AddWithValue("@id", curriculo.IdCurriculo);

                conexao.Open();

                comandoMySql.ExecuteNonQuery();

                conexao.Close();

                MessageBox.Show("Curriculo excluido com sucesso!");
            }
            catch (Exception erroDelete)
            {
                MessageBox.Show("Erro na exclusão dos dados: " + erroDelete);
            }
        }
        #endregion
    }
}
