using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estagiado.Models;
using Estagiado.DAO;

namespace Estagiado.Views
{
    public partial class FormAtualizarCadastroEmp : Form
    {
        private string IdEmpresa;
        public string getIdEmpresa()
        {
            return this.IdEmpresa;
        }
        public void setIdEmpresa(string id_empresa)
        {
            if (!id_empresa.Equals(""))
            {
                this.IdEmpresa = id_empresa;
            }
        }
        public FormAtualizarCadastroEmp()
        {
            InitializeComponent();
        }

        private void FormAtualizarCadastroEmp_Load(object sender, EventArgs e)
        {
            cbIdEmpresa.Text = getIdEmpresa();
            EmpresaDAO empresaDao = new EmpresaDAO();
            dgvEmpresa.DataSource = empresaDao.ReadEmpresas(int.Parse(cbIdEmpresa.Text));
        }
        private void dgvEmpresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNomeEmpresa.Text = dgvEmpresa.CurrentRow.Cells[0].Value.ToString();
            txtCnpjEmpresa.Text = dgvEmpresa.CurrentRow.Cells[1].Value.ToString();
            txtEmailEmpresa.Text = dgvEmpresa.CurrentRow.Cells[2].Value.ToString();
            txtSenhaEmpresa.Text = dgvEmpresa.CurrentRow.Cells[3].Value.ToString();
            txtWhatsappEmpresa.Text = dgvEmpresa.CurrentRow.Cells[4].Value.ToString();
            txtLinkEmpresa.Text = dgvEmpresa.CurrentRow.Cells[5].Value.ToString();
            txtEnderecoEmpresa.Text = dgvEmpresa.CurrentRow.Cells[6].Value.ToString();
            txtCidadeEmpresa.Text = dgvEmpresa.CurrentRow.Cells[7].Value.ToString();
            cbEstadoEmpresa.Text = dgvEmpresa.CurrentRow.Cells[8].Value.ToString();
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            EmpresaModel empresaModel = new EmpresaModel();
            empresaModel.Nome = txtNomeEmpresa.Text;
            empresaModel.Cnpj = txtCnpjEmpresa.Text;
            empresaModel.EmailRecrutamento = txtEmailEmpresa.Text;
            empresaModel.Senha = txtSenhaEmpresa.Text;
            empresaModel.Whatsapp = txtWhatsappEmpresa.Text;
            empresaModel.LinkRecrutamento = txtLinkEmpresa.Text;
            empresaModel.Endereco = txtEnderecoEmpresa.Text;
            empresaModel.Cidade = txtCidadeEmpresa.Text;
            empresaModel.Estado = cbEstadoEmpresa.Text;
            empresaModel.NivelAcesso = "Empresa";
            empresaModel.Id = int.Parse(cbIdEmpresa.Text);
            EmpresaDAO empresaDao = new EmpresaDAO();
            empresaDao.UpdateEmpresa(empresaModel);
            dgvEmpresa.DataSource = empresaDao.ReadEmpresas(int.Parse(cbIdEmpresa.Text));
        }
    }
}



/*
private void btnEncontrarIdComCnpj_Click(object sender, EventArgs e)
{
    EmpresaModel empresa = new EmpresaModel();
    empresa.Cnpj = txtBuscaPorCnpj.Text;
    VagaestagioDAO vaga = new VagaestagioDAO();
    cbIdEmpresa.DataSource = vaga.RecuperarIdEmpresa(empresa);
    cbIdEmpresa.DisplayMember = "ID";
    EmpresaDAO empresaDao = new EmpresaDAO();
    dgvEmpresa.DataSource = empresaDao.ReadEmpresas(int.Parse(cbIdEmpresa.Text));
}
*/
