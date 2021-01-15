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
using Estagiado.Views;

namespace Estagiado
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void btnAreaEmpresa_Click(object sender, EventArgs e)
        {
            FormMainEmpresa form = new FormMainEmpresa();
            form.Show();
        }

        private void btnAreaEstudante_Click(object sender, EventArgs e)
        {
            FormMainEstudante form = new FormMainEstudante();
            form.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
