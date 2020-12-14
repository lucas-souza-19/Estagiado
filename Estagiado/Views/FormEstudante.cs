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
            //os atributos do obj_estudante receberá os dados do formulario
            EstudanteModel obj_estudante = new EstudanteModel();
            obj_estudante.nome = txtNome.Text;
            obj_estudante.cpf = txtCpf.Text;
            obj_estudante.sexo = cbsexo.Text;
            obj_estudante.email = txtEmail.Text;
            obj_estudante.senha = txtSenha.Text;
            obj_estudante.telefone = txtFone.Text;
            obj_estudante.whatsapp = txtWhatsApp.Text;

            //o objeto acessaDadosEstudt acessa o método CreateEstudante e cadastra um novo estudante com o obj_estudante como parametro
            EstudantesDAO estudanteDao = new EstudantesDAO();
            estudanteDao.CreateEstudante(obj_estudante);

            dgvEstudante.DataSource = estudanteDao.ReadEstudantes();
        }

        private void FormEstudante_Load(object sender, EventArgs e)
        {
            EstudantesDAO listarEstudantes = new EstudantesDAO();
            dgvEstudante.DataSource = listarEstudantes.ReadEstudantes();
        }

        private void cbsexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
