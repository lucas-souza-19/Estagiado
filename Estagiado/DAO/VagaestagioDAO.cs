using Estagiado.Conexao;
using Estagiado.Models;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Estagiado.DAO
{
    public class VagaestagioDAO
    {
        MySqlConnection connection;

        public VagaestagioDAO()
        {
            this.connection = ConnectionFactory.getConnection();
        }

        #region Método CreateVaga - registra uma nova vaga de estágio
        public void CreateVaga(VagaestagioModel vaga)
        {
            try
            {
                string insereSql = @"insert into vaga_estagio (nome, requisito1, requisito2, requisito3,
                                                               val_requisito1, val_requisito2, val_requisito3,
                                                               ipr_vaga, cod_empresa)
                                                       values (@nome, @requisito1, @requisito2, @requisito3,
                                                               @val_requisito1, @val_requisito2, @val_requisito3,
                                                               @ipr_vaga, @cod_empresa)";

                MySqlCommand cmdMysql = new MySqlCommand(insereSql, connection);

                cmdMysql.Parameters.AddWithValue("@nome", vaga.Nome);
                cmdMysql.Parameters.AddWithValue("@requisito1", vaga.Requisito1);
                cmdMysql.Parameters.AddWithValue("@requisito2", vaga.Requisito2);
                cmdMysql.Parameters.AddWithValue("@requisito3", vaga.Requisito3);
                cmdMysql.Parameters.AddWithValue("@val_requisito1", vaga.ValRequisito1);
                cmdMysql.Parameters.AddWithValue("@val_requisito2", vaga.ValRequisito2);
                cmdMysql.Parameters.AddWithValue("@val_requisito3", vaga.ValRequisito3);
                cmdMysql.Parameters.AddWithValue("@ipr_vaga", vaga.IprVaga);
                cmdMysql.Parameters.AddWithValue("@cod_empresa", vaga.CodEmpresa);

                connection.Open();

                cmdMysql.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Vaga cadastrada com sucesso!");
            }
            catch (Exception erroRegistro)
            {
                MessageBox.Show("Erro ao registrar a vaga: " + erroRegistro);
            }
        }
        #endregion

        #region Método ReadVaga - recupera todas as vagas cadastradas
        public DataTable ReadVaga()
        {
            string recuperar = @"SELECT v.id_vaga as 'ID', v.nome as 'Vaga', v.requisito1 as 'Requisito 1', 
                                        v.requisito2 as 'Requisito 2', v.requisito3 as 'Requisito 3', 
                                        e.nome as 'Empresa', e.email_recrut as 'Email', 
                                        e.cidade as 'Cidade', e.estado as 'Estado', 
                                        e.endereco as 'Endereco', e.link_recrut as 'Link', 
                                        e.whatsapp as 'WhatsApp' 
                                 FROM vaga_estagio as v JOIN empresa as e 
                                 ON (v.cod_empresa = e.id_unidd_empresa) order by ID desc";

            MySqlCommand cmdMysql = new MySqlCommand(recuperar, connection);

            connection.Open();

            cmdMysql.ExecuteNonQuery();

            DataTable tblVagas = new DataTable();

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmdMysql);

            dataAdapter.Fill(tblVagas);

            connection.Close();

            return tblVagas;
        }
        #endregion

        #region Método ReadVaga2 - recupera todas as vagas de uma empresa através do ID da empresa
        public DataTable ReadVaga2(int id_empresa)
        {
            string recuperar = @"SELECT v.id_vaga as 'ID', v.nome as 'Vaga', v.requisito1 as 'Requisito 1', 
                                        v.requisito2 as 'Requisito 2', v.requisito3 as 'Requisito 3', 
                                        v.val_requisito1 as 'Peso Requisito 1', v.val_requisito2 as 'Peso Requisito 2',
                                        v.val_requisito3 as 'Peso Requisito 3', v.cod_empresa as 'Meu ID'
                                 FROM vaga_estagio as v 
                                 WHERE v.cod_empresa = @id_empresa";

            MySqlCommand cmdMysql = new MySqlCommand(recuperar, connection);

            cmdMysql.Parameters.AddWithValue("@id_empresa", id_empresa);

            connection.Open();

            cmdMysql.ExecuteNonQuery();

            DataTable tblVagas = new DataTable();

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmdMysql);

            dataAdapter.Fill(tblVagas);

            connection.Close();

            return tblVagas;
        }
        #endregion

        #region Método UpdateVaga - atualiza os dados de um vaga de estágio
        public void UpdateVaga(VagaestagioModel vaga)
        {
            try
            {
                string atualizaSql = @"update vaga_estagio set nome = @nome, requisito1 = @requisito1, 
                                                               requisito2 = @requisito2, requisito3 = @requisito3,
                                                               val_requisito1 = @val_requisito1, 
                                                               val_requisito2 = @val_requisito2, 
                                                               val_requisito3 = @val_requisito3,
                                                               ipr_vaga = @ipr_vaga
                                                         where id_vaga = @id_vaga";

                MySqlCommand cmdMysql = new MySqlCommand(atualizaSql, connection);

                cmdMysql.Parameters.AddWithValue("@nome", vaga.Nome);
                cmdMysql.Parameters.AddWithValue("@requisito1", vaga.Requisito1);
                cmdMysql.Parameters.AddWithValue("@requisito2", vaga.Requisito2);
                cmdMysql.Parameters.AddWithValue("@requisito3", vaga.Requisito3);
                cmdMysql.Parameters.AddWithValue("@val_requisito1", vaga.ValRequisito1);
                cmdMysql.Parameters.AddWithValue("@val_requisito2", vaga.ValRequisito2);
                cmdMysql.Parameters.AddWithValue("@val_requisito3", vaga.ValRequisito3);
                cmdMysql.Parameters.AddWithValue("@ipr_vaga", vaga.IprVaga);
                cmdMysql.Parameters.AddWithValue("@id_vaga", vaga.IdVaga);

                connection.Open();

                cmdMysql.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Vaga atualizada com sucesso!");
            }
            catch (Exception erroAtualizacao)
            {
                MessageBox.Show("Erro ao atualizar a vaga: " + erroAtualizacao);
            }
        }
        #endregion

        #region Método DeleteVaga - exclui uma vaga de estágio
        public void DeleteVaga(int id_vaga)
        {
            try
            {
                string ExcluiDependecias = @"DELETE FROM candidata_se WHERE cod_vagaestagio = @id";
                string deleteSql = @"DELETE FROM vaga_estagio WHERE id_vaga = @id";

                MySqlCommand comandoMysql1 = new MySqlCommand(ExcluiDependecias, connection);
                MySqlCommand comandoMySql2 = new MySqlCommand(deleteSql, connection);

                comandoMysql1.Parameters.AddWithValue("@id", id_vaga);
                comandoMySql2.Parameters.AddWithValue("@id", id_vaga);

                connection.Open();

                comandoMysql1.ExecuteNonQuery();
                comandoMySql2.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Vaga excluida com sucesso!");
            }
            catch (Exception erroDelete)
            {
                MessageBox.Show("Erro na exclusão dos dados: " + erroDelete);
            }
        }
        #endregion

        #region Método RecuperarIprVaga - traz o IPR de uma vaga
        public double RecuperarIprVaga(int id)
        {
            string sqlLeitura = @"SELECT * FROM vaga_estagio WHERE id_vaga = @id";

            MySqlCommand cmdMysql = new MySqlCommand(sqlLeitura, connection);

            cmdMysql.Parameters.AddWithValue("@id", id);

            connection.Open();

            MySqlDataReader data = cmdMysql.ExecuteReader();

            data.Read();

            double valorIpr = double.Parse(data.GetString("ipr_vaga"));

            return valorIpr;
        }
        #endregion
    }
}

