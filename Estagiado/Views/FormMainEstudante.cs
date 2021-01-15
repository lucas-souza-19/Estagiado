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

namespace Estagiado.Views
{
    public partial class FormMainEstudante : Form
    {
        public FormMainEstudante()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string email, senha;

            email = txtEmailLogin.Text;
            senha = txtSenhaLogin.Text;

            LoginDAO login = new LoginDAO();
            login.LoginEstudante(email, senha);
        }
        private void btnCadatroEstudantes_Click(object sender, EventArgs e)
        {
            FormUniversidade formUniv = new FormUniversidade();
            formUniv.Show();
        }
        private void FormMainEstudante_Load(object sender, EventArgs e)
        {

        }
    }
}
