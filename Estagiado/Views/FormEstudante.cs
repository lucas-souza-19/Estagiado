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
    public partial class FormEstudante : Form
    {
        public FormEstudante()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            EstudanteModel obj_estudante = new EstudanteModel();
            obj_estudante.nome = txtNome.Text;
            obj_estudante.cpf = txtCpf.Text;
            obj_estudante.sexo = cbsexo.Text;
            obj_estudante.email = txtEmail.Text;
            obj_estudante.senha = txtSenha.Text;
            obj_estudante.telefone = txtFone.Text;
            obj_estudante.whatsapp = txtWhatsApp.Text;

            EstudantesDAO estudanteDao = new EstudantesDAO();
            estudanteDao.CreateEstudante(obj_estudante);

            dgvEstudante.DataSource = estudanteDao.ReadEstudantes();
        }

        private void btnAlterarEstudante_Click(object sender, EventArgs e)
        {
            EstudanteModel obj_estudante = new EstudanteModel();
            obj_estudante.nome = txtNome.Text;
            obj_estudante.cpf = txtCpf.Text;
            obj_estudante.sexo = cbsexo.Text;
            obj_estudante.email = txtEmail.Text;
            obj_estudante.senha = txtSenha.Text;
            obj_estudante.telefone = txtFone.Text;
            obj_estudante.whatsapp = txtWhatsApp.Text;

            obj_estudante.id = int.Parse(txtIdEstudante.Text);

            EstudantesDAO estudanteDao = new EstudantesDAO();
            estudanteDao.UpdateEstudante(obj_estudante);

            dgvEstudante.DataSource = estudanteDao.ReadEstudantes();
        }

        private void btnExcluirEstudante_Click(object sender, EventArgs e)
        {
            EstudanteModel estudanteModel = new EstudanteModel();
            estudanteModel.id = int.Parse(txtIdEstudante.Text);

            EstudantesDAO estudantesDAO = new EstudantesDAO();
            estudantesDAO.DeleteEstudante(estudanteModel);

            dgvEstudante.DataSource = estudantesDAO.ReadEstudantes();
        }

        private void FormEstudante_Load(object sender, EventArgs e)
        {
            EstudantesDAO listarEstudantes = new EstudantesDAO();
            dgvEstudante.DataSource = listarEstudantes.ReadEstudantes();
        }

        private void cbsexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvEstudante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvEstudante_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdEstudante.Text = dgvEstudante.CurrentRow.Cells[0].Value.ToString();
            txtCpf.Text = dgvEstudante.CurrentRow.Cells[1].Value.ToString();
            txtNome.Text = dgvEstudante.CurrentRow.Cells[2].Value.ToString();
            cbsexo.Text = dgvEstudante.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvEstudante.CurrentRow.Cells[4].Value.ToString();
            txtFone.Text = dgvEstudante.CurrentRow.Cells[5].Value.ToString();
            txtWhatsApp.Text = dgvEstudante.CurrentRow.Cells[6].Value.ToString();
            txtSenha.Text = dgvEstudante.CurrentRow.Cells[7].Value.ToString();
        }

    }
}
