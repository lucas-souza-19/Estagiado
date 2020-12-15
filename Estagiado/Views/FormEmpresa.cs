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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncadastrarempresa_Click(object sender, EventArgs e)
        {
            EmpresaModel empresaModel = new EmpresaModel();

            empresaModel.Nome = txtNomeEmpresa.Text;
            empresaModel.Cnpj = txtCnpjEmpresa.Text;
            empresaModel.Fone = txtFoneEmpresa.Text;
            empresaModel.Ramal = txtRamalEmpresa.Text;
            empresaModel.Whatsapp = txtWhatsappEmpresa.Text;
            empresaModel.Link_recrutamento = txtLinkEmpresa.Text;
            empresaModel.Email_recrutamento = txtEmailEmpresa.Text;
            empresaModel.Senha = txtSenhaEmpresa.Text;

            EmpresaDAO empresaDao = new EmpresaDAO();
            empresaDao.CreateEmpresa(empresaModel);

            dgvEmpresa.DataSource = empresaDao.ReadEmpresas(); 
        }

        private void btnAlterarEmpresa_Click(object sender, EventArgs e)
        {
            EmpresaModel empresaModel = new EmpresaModel();
            empresaModel.Nome = txtNomeEmpresa.Text;
            empresaModel.Cnpj = txtCnpjEmpresa.Text;
            empresaModel.Fone = txtFoneEmpresa.Text;
            empresaModel.Ramal = txtRamalEmpresa.Text;
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

        private void FormEmpresa_Load(object sender, EventArgs e)
        {
            EmpresaDAO empresaDao = new EmpresaDAO();
            dgvEmpresa.DataSource = empresaDao.ReadEmpresas();
        }

        private void dgvEmpresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvEmpresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdEmpresa.Text = dgvEmpresa.CurrentRow.Cells[0].Value.ToString();
            txtNomeEmpresa.Text = dgvEmpresa.CurrentRow.Cells[1].Value.ToString();
            txtCnpjEmpresa.Text = dgvEmpresa.CurrentRow.Cells[2].Value.ToString();
            txtFoneEmpresa.Text = dgvEmpresa.CurrentRow.Cells[3].Value.ToString();
            txtRamalEmpresa.Text = dgvEmpresa.CurrentRow.Cells[4].Value.ToString();
            txtWhatsappEmpresa.Text = dgvEmpresa.CurrentRow.Cells[5].Value.ToString();
            txtLinkEmpresa.Text = dgvEmpresa.CurrentRow.Cells[6].Value.ToString();
            txtEmailEmpresa.Text = dgvEmpresa.CurrentRow.Cells[7].Value.ToString();
            txtSenhaEmpresa.Text = dgvEmpresa.CurrentRow.Cells[8].Value.ToString();
        }

    }
}
