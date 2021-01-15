using Estagiado.DAO;
using Estagiado.Models;
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
    public partial class FormExcluirContaEst : Form
    {
        public FormExcluirContaEst()
        {
            InitializeComponent();
        }

        private void btnEncontrarIdComCpf_Click(object sender, EventArgs e)
        {
            if(!txtCpfBusca.Text.Equals("") && !txtSenha.Text.Equals(""))
            {
                EstudantesDAO estudante = new EstudantesDAO();
                cbIdCandidato.DataSource = estudante.ReadEstudantes3(txtCpfBusca.Text, txtSenha.Text);
                if (cbIdCandidato.SelectedValue != null)
                {
                    cbIdCandidato.DisplayMember = "ID";
                    dgvEstudante.DataSource = estudante.ReadEstudantes2(int.Parse(cbIdCandidato.Text));
                }
                else
                {
                    MessageBox.Show("CPF ou senha incorretos!");
                }
            }
            else
            {
                MessageBox.Show("Digite seu CPF e sua Senha!");
            }
        }
        private void btnExcluirConta_Click(object sender, EventArgs e)
        {      
            if(dgvEstudante.RowCount != 0)
            {
                EstudanteModel estudanteModel = new EstudanteModel();
                estudanteModel.Id = int.Parse(cbIdCandidato.Text);
                EstudantesDAO estudantesDAO = new EstudantesDAO();
                estudantesDAO.DeleteEstudante(estudanteModel);
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Busque os seus dados para excluí-los!");
            }
        }
        private void FormExcluirContaEst_Load(object sender, EventArgs e)
        {

        }
    }
}
