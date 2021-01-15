using Estagiado.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estagiado.Views
{
    public partial class FormMainEmpresa : Form
    {
        public FormMainEmpresa()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string email, senha;

            email = txtEmailLogin.Text;
            senha = txtSenhaLogin.Text;

            LoginDAO login = new LoginDAO();
            login.LoginEmpresa(email, senha);
        }
        private void btnCadastroEmpresas_Click(object sender, EventArgs e)
        {
            FormEmpresa formEmpresa = new FormEmpresa();
            formEmpresa.Show();
        }
        private void FormMainEmpresa_Load(object sender, EventArgs e)
        {

        }
    }
}
