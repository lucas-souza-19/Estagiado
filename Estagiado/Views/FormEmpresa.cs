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

        private void FormEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void btncadastrarempresa_Click(object sender, EventArgs e)
        {
            EmpresaModel empresa = new EmpresaModel();

            empresa.Nome = txtNomeEmpresa.Text;
            empresa.Cnpj = txtCnpjEmpresa.Text;
            empresa.Fone = txtFoneEmpresa.Text;
            empresa.Ramal = txtRamalEmpresa.Text;
            empresa.Whatsapp = txtWhatsappEmpresa.Text;
            empresa.Link_recrutamento = txtLinkEmpresa.Text;
            empresa.Email_recrutamento = txtEmailEmpresa.Text;
            empresa.Senha = txtSenhaEmpresa.Text;

            EmpresaDAO empresaDao = new EmpresaDAO();
            empresaDao.CreateEmpresa(empresa);
        }
    }
}
