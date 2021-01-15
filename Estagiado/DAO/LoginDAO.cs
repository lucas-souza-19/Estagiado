using Estagiado.Conexao;
using Estagiado.Views;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Estagiado.DAO
{
    public class LoginDAO
    {
        MySqlConnection connection;
        int id;
        public LoginDAO()
        {
            this.connection = ConnectionFactory.getConnection();
        }

        #region Método LoginEstudante - faz o login do estudante no sitema com email e senha; também controla o que será exibido ao estudante em FormMenu      
        public void LoginEstudante(string email, string senha)
        {
            try
            {
                string sqlLeitura = @"select * from estudante
                                      where email = @email and senha = @senha";

                MySqlCommand cmdMysql = new MySqlCommand(sqlLeitura, connection);

                cmdMysql.Parameters.AddWithValue("@email", email);
                cmdMysql.Parameters.AddWithValue("@senha", senha);

                connection.Open();

                MySqlDataReader data = cmdMysql.ExecuteReader();

                if (data.Read())
                {
                    string nivelAcesso = data.GetString("nivel_acesso");
                    id = int.Parse(data.GetString("id_estudante"));
                    if (nivelAcesso.Equals("Estudante"))
                    {
                        FormMenu menu = new FormMenu();
                        menu.MenuEmpresas.Enabled = false;
                        menu.MenuEmpresas.Visible = false;
                        menu.btnMaisIndicados.Visible = false;
                        CandidaturaDAO candidatura = new CandidaturaDAO();
                        menu.dgvMinhasVagas.DataSource = candidatura.RecuperarMinhasVagas(id);
                        VagaestagioDAO vaga = new VagaestagioDAO();
                        menu.dgvVagasOuEstudantes.DataSource = vaga.ReadVaga();
                        menu.cbVaga.DataSource = vaga.ReadVaga();
                        menu.cbVaga.DisplayMember = "ID";
                        EstudantesDAO estudante = new EstudantesDAO();
                        menu.cbId.DataSource = estudante.ReadEstudantes2(id);
                        menu.cbId.DisplayMember = "ID";
                        menu.cbId.Enabled = false;
                        menu.Show();
                        connection.Close(); 
                    }
                }
                else
                {
                    MessageBox.Show("Email ou senha incorretos!");
                    connection.Close();
                }
            }
            catch(Exception erroLogin)
            {
                MessageBox.Show("Erro ao logar, tente novamente! " + erroLogin);
                connection.Close();
            }
        }
        #endregion

        #region Método LoginEmpresa - faz o login da empresa no sitema com email e senha; também controla o que será exibido a empresa em FormMenu 
        public void LoginEmpresa(string email, string senha)
        {
            try
            {
                string sqlLeitura = @"select * from empresa
                                      where email_recrut = @email and senha = @senha";

                MySqlCommand cmdMysql = new MySqlCommand(sqlLeitura, connection);

                cmdMysql.Parameters.AddWithValue("@email", email);
                cmdMysql.Parameters.AddWithValue("@senha", senha);

                connection.Open();

                MySqlDataReader data = cmdMysql.ExecuteReader();

                if (data.Read())
                {
                    string nivelAcesso = data.GetString("nivel_acesso");
                    int id = int.Parse(data.GetString("id_unidd_empresa"));
                    if (nivelAcesso.Equals("Empresa"))
                    {
                        FormMenu menu = new FormMenu();
                        menu.MenuEstudantes.Enabled = false;
                        menu.MenuEstudantes.Visible = false;
                        menu.labelIdVaga.Visible = true;
                        menu.labelEscalaDominio.Visible = false;
                        menu.labelRequisito1.Visible = false;
                        menu.labelRequisito2.Visible = false;
                        menu.labelRequisito3.Visible = false;
                        menu.txtDomReq1.Visible = false;
                        menu.txtDomReq2.Visible = false;
                        menu.txtDomReq3.Visible = false;
                        menu.btnCandidatar.Visible = false;
                        EmpresaDAO empresaDao = new EmpresaDAO();
                        menu.cbId.DataSource = empresaDao.ReadEmpresas2(id);
                        menu.cbId.DisplayMember = "ID";
                        menu.cbId.Enabled = false;
                        EstudantesDAO estudantes = new EstudantesDAO();
                        menu.dgvVagasOuEstudantes.DataSource = estudantes.ReadEstudantes();
                        menu.cbVaga.DataSource = estudantes.ReadEstudantes();
                        menu.cbVaga.DisplayMember = "ID";
                        VagaestagioDAO vagas = new VagaestagioDAO();
                        menu.dgvMinhasVagas.DataSource = vagas.ReadVaga2(id);
                        menu.cbVaga.DataSource = vagas.ReadVaga2(id);
                        menu.cbVaga.DisplayMember = "ID";
                        menu.Show(); 
                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Email ou senha incorretos!");
                    connection.Close();
                }
            }
            catch (Exception erroLogin)
            {
                MessageBox.Show("Erro ao logar, tente novamente! " + erroLogin);
                connection.Close();
            }
        }
        #endregion
    }
}
