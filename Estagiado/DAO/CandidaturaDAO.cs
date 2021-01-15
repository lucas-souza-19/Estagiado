using Estagiado.Conexao;
using Estagiado.Models;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Estagiado.DAO
{
    public class CandidaturaDAO
    {
        MySqlConnection connection;

        public CandidaturaDAO()
        {
            this.connection = ConnectionFactory.getConnection();
        }

        #region Método CreateCandidatura - candidata um estudante em uma vaga de estágio
        public void CreateCandidatura(CandidaturaModel candidatura)
        {
            try
            {
                string insertSql = @"insert into candidata_se (cod_candidato, cod_vagaestagio, ipr_candidato, distancia_ipr_vaga) 
                                                   values (@cod_cand, @cod_vaga, @ipr_cand, @dist_ipr)";

                MySqlCommand cmdMysql = new MySqlCommand(insertSql, connection);
                cmdMysql.Parameters.AddWithValue("@cod_cand", candidatura.getCodCandidato());
                cmdMysql.Parameters.AddWithValue("@cod_vaga", candidatura.getCodVagaestagio());
                cmdMysql.Parameters.AddWithValue("@ipr_cand", candidatura.getIprCandidato());
                cmdMysql.Parameters.AddWithValue("@dist_ipr", candidatura.getDistanciaDoIprDaVaga());
                connection.Open();

                cmdMysql.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Candidatura realizada com sucesso!");
            }
            catch (Exception erroCandidatura)
            {
                MessageBox.Show("Erro na candidatura: " + erroCandidatura);
            }
        }
        #endregion

        #region Método BuscarCandidados - traz os candiados a uma vaga conforme o ID da vaga
        public DataTable BuscarCandidatos(int id_vaga)
        {
            string buscar = @"SELECT e.nome as 'Nome', e.email as 'Email', e.fone as 'Telefone', 
                                     e.whatsapp as 'WhatsApp', e.endereco as 'Endereco', 
                                     e.cidade as 'Cidade', e.estado as 'Estado', e.sexo as 'Sexo', 
                                     c.ipr_candidato as 'IPR do Candidato', v.ipr_vaga as 'IPR da Vaga', c.distancia_ipr_vaga as 'Diferenca'
                              FROM candidata_se as c
                              JOIN estudante as e ON (cod_candidato = e.id_estudante)
                              JOIN vaga_estagio as v ON (cod_vagaestagio = v.id_vaga)
                              WHERE cod_vagaestagio = @id_vaga 
                              ORDER BY c.distancia_ipr_vaga ASC";
            ;

            MySqlCommand cmdMysql = new MySqlCommand(buscar, connection);

            cmdMysql.Parameters.AddWithValue("@id_vaga", id_vaga);

            connection.Open();

            cmdMysql.ExecuteNonQuery();

            DataTable tblCandidatos = new DataTable();

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmdMysql);

            dataAdapter.Fill(tblCandidatos);

            connection.Close();

            return tblCandidatos;
        }
        #endregion

        #region Método RecuperarMinhasVagas - traz as vagas que um estudante se candidatou, conforme o ID do estudante
        public DataTable RecuperarMinhasVagas(int id)
        {
            string recuperar = @"SELECT c.cod_candidato as 'Meu ID', 
                                        c.cod_vagaestagio as 'ID da Vaga', 
                                        v.nome as 'Vaga', v.requisito1 as 'Requisito 1', 
                                        v.requisito2 as 'Requisito 2', v.requisito3 as 'Requisito 3' 
                                 FROM candidata_se as c JOIN vaga_estagio as v 
                                 ON (c.cod_vagaestagio = v.id_vaga) 
                                 WHERE c.cod_candidato = @id order by cod_vagaestagio desc";

            MySqlCommand cmdMysql = new MySqlCommand(recuperar, connection);

            cmdMysql.Parameters.AddWithValue("@id", id);

            connection.Open();

            cmdMysql.ExecuteNonQuery();

            DataTable tblVagas = new DataTable();

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmdMysql);

            dataAdapter.Fill(tblVagas);

            connection.Close();

            return tblVagas;
        }
        #endregion
    }
}
