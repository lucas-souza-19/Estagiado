using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estagiado.DAO;
using Estagiado.Models;

namespace Estagiado.Views
{
    public partial class FormEmpresa : Form
    {
        public FormEmpresa()
        {
            InitializeComponent();
        }

        private void btncadastrarempresa_Click(object sender, EventArgs e)
        {
            if (!txtNomeEmpresa.Text.Equals("") && !txtCnpjEmpresa.Text.Equals("") &&
                !txtSenhaEmpresa.Text.Equals("") && !txtSenhaEmpresa.Text.Equals("") &&
                !txtCidadeEmpresa.Text.Equals(""))
            {
                EmpresaDAO empresa = new EmpresaDAO();
                string id_empresa = empresa.RecuperarId(txtCnpjEmpresa.Text);
                if (id_empresa != "")
                {
                    MessageBox.Show("CNPJ já cadastrado. Tente logar no sistema!");
                }
                else
                {
                    EmpresaModel empresaModel = new EmpresaModel();
                    empresaModel.Nome = txtNomeEmpresa.Text;
                    empresaModel.Cnpj = txtCnpjEmpresa.Text;
                    empresaModel.EmailRecrutamento = txtEmailEmpresa.Text;
                    empresaModel.Whatsapp = txtWhatsappEmpresa.Text;
                    empresaModel.LinkRecrutamento = txtLinkEmpresa.Text;
                    empresaModel.Senha = txtSenhaEmpresa.Text;
                    empresaModel.Endereco = txtEnderecoEmpresa.Text;
                    empresaModel.Cidade = txtCidadeEmpresa.Text;
                    empresaModel.Estado = cbEstadoEmpresa.Text;
                    empresaModel.NivelAcesso = "Empresa";
                    EmpresaDAO empresaDao = new EmpresaDAO();
                    empresaDao.CreateEmpresa(empresaModel);
                }
            }
            else
            {
                MessageBox.Show("Nome, CNPJ, Email, Senha e Cidade são obrigatórios!");
            }
        }
        private void btnProximaEtapa_Click(object sender, EventArgs e)
        {
            EmpresaDAO empresa = new EmpresaDAO();
            string id_empresa = empresa.RecuperarId(txtCnpjEmpresa.Text);
            if (id_empresa != "") {              
                FormVagaestagio form = new FormVagaestagio();
                form.setIdEmpresa(id_empresa);
                form.Show();
            }
            else
            {
                MessageBox.Show("Preencha os dados e clique em Cadastrar antes de continuar!");
            }
        }
        private void txtSenhaEmpresa_TextChanged(object sender, EventArgs e)
        {

        }
        private void FormEmpresa_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


/*
private void btnAlterarEmpresa_Click(object sender, EventArgs e)
{
    EmpresaModel empresaModel = new EmpresaModel();
    empresaModel.Nome = txtNomeEmpresa.Text;
    empresaModel.Cnpj = txtCnpjEmpresa.Text;
    empresaModel.Fone = txtEnderecoEmpresa.Text;
    empresaModel.Ramal = txtCidadeEmpresa.Text;
    empresaModel.Whatsapp = txtWhatsappEmpresa.Text;
    empresaModel.Link_recrutamento = txtLinkEmpresa.Text;
    empresaModel.Email_recrutamento = txtEmailEmpresa.Text;
    empresaModel.Senha = txtSenhaEmpresa.Text;

    empresaModel.Id = int.Parse(txtIdEmpresa.Text);

    EmpresaDAO empresaDao = new EmpresaDAO();
    empresaDao.UpdateEmpresa(empresaModel);

    dgvEmpresa.DataSource = empresaDao.ReadEmpresas();
}

private void btnExcluirEmpresa_Click(object sender, EventArgs e)
{

    EmpresaModel empresaModel = new EmpresaModel();
    empresaModel.Id = int.Parse(txtIdEmpresa.Text);

    EmpresaDAO empresaDao = new EmpresaDAO();
    empresaDao.DeleteEmpresa(empresaModel);

    dgvEmpresa.DataSource = empresaDao.ReadEmpresas();
}

private void dgvEmpresa_CellClick(object sender, DataGridViewCellEventArgs e)
{

    txtIdEmpresa.Text = dgvEmpresa.CurrentRow.Cells[0].Value.ToString();
    txtNomeEmpresa.Text = dgvEmpresa.CurrentRow.Cells[1].Value.ToString();
    txtCnpjEmpresa.Text = dgvEmpresa.CurrentRow.Cells[2].Value.ToString();
    txtEnderecoEmpresa.Text = dgvEmpresa.CurrentRow.Cells[3].Value.ToString();
    txtCidadeEmpresa.Text = dgvEmpresa.CurrentRow.Cells[4].Value.ToString();
    txtWhatsappEmpresa.Text = dgvEmpresa.CurrentRow.Cells[5].Value.ToString();
    txtLinkEmpresa.Text = dgvEmpresa.CurrentRow.Cells[6].Value.ToString();
    txtEmailEmpresa.Text = dgvEmpresa.CurrentRow.Cells[7].Value.ToString();
    txtSenhaEmpresa.Text = dgvEmpresa.CurrentRow.Cells[8].Value.ToString();
}
*/
