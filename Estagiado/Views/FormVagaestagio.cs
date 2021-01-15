using Estagiado.DAO;
using Estagiado.Models;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Estagiado.Views
{
    public partial class FormVagaestagio : Form
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

        public FormVagaestagio()
        {
            InitializeComponent();
        }

        private void FormVagaestagio_Load(object sender, EventArgs e)
        {
            cbIdEmpresa.Text = getIdEmpresa();
            cbIdEmpresa.Enabled = false;
        }
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            FormMainEmpresa form = new FormMainEmpresa();
            form.Show();
        }
        private void btnCadastrarVaga_Click(object sender, EventArgs e)
        {
            if (txtTituloVaga.Text != "" && txtRequisito1.Text != "" && txtRequisito2.Text != "" &&
                txtRequisito3.Text != "" && txtPesoRequisito1.Text != "" && 
                txtPesoRequisito2.Text != "" && txtPesoRequisito3.Text != "")
            {
                VagaestagioModel vaga = new VagaestagioModel();
                vaga.Nome = txtTituloVaga.Text;
                vaga.Requisito1 = txtRequisito1.Text;
                vaga.Requisito2 = txtRequisito2.Text;
                vaga.Requisito3 = txtRequisito3.Text;
                bool p1ehNumero = Regex.IsMatch(txtPesoRequisito1.Text, @"^\d");
                bool p2ehNumero = Regex.IsMatch(txtPesoRequisito2.Text, @"^\d");
                bool p3ehNumero = Regex.IsMatch(txtPesoRequisito3.Text, @"^\d");
                if(p1ehNumero == true && p2ehNumero == true && p3ehNumero == true)
                {
                    vaga.ValRequisito1 = double.Parse(txtPesoRequisito1.Text);
                    vaga.ValRequisito2 = double.Parse(txtPesoRequisito2.Text);
                    vaga.ValRequisito3 = double.Parse(txtPesoRequisito3.Text);
                    if(vaga.ValRequisito1 >= 0.0 && vaga.ValRequisito1 <= 9.99 &&
                       vaga.ValRequisito2 >= 0.0 && vaga.ValRequisito2 <= 9.99 &&
                       vaga.ValRequisito3 >= 0.0 && vaga.ValRequisito3 <= 9.99)
                    {
                        vaga.IprVaga = vaga.CalcularIpr(vaga.ValRequisito1, vaga.ValRequisito2, vaga.ValRequisito3);
                        vaga.CodEmpresa = int.Parse(cbIdEmpresa.Text);
                        VagaestagioDAO vagaEstagio = new VagaestagioDAO();
                        vagaEstagio.CreateVaga(vaga);
                    }
                    else
                    {
                        MessageBox.Show("O valor de cada requisito precisa estar entre 0 e 9,99");
                    }
                }
                else
                {
                    MessageBox.Show("Os pesos dos requisitos precisam ser números!");
                }
            }
            else
            {
                MessageBox.Show("Todos os campos são obrigatórios!");
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void cbIdEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void txtPesoRequisito1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}

       /*      
       private void btnEncontrarIdComCnpj_Click(object sender, EventArgs e)
       {
           EmpresaModel empresa = new EmpresaModel();
           empresa.Cnpj = txtCnpjEmpresa.Text;
           VagaestagioDAO vaga = new VagaestagioDAO();
           cbIdEmpresa.DataSource = vaga.RecuperarIdEmpresa(empresa);
           cbIdEmpresa.DisplayMember = "ID";
       }
       */
