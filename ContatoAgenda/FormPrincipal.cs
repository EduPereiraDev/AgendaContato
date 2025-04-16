using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ContatoAgenda
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroContato telaCadastro = new CadastroContato();
            telaCadastro.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ConsultaContato consultaForm = new ConsultaContato();
            consultaForm.ShowDialog();
        }
    }
}
