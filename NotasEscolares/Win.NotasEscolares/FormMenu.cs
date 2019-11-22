using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.NotasEscolares
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void ingresoDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormDatosEstudiantes = new FormDatosEstudiantes();
            FormDatosEstudiantes.MdiParent = this;
            FormDatosEstudiantes.Show();
        }

        private void ingresoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormIngresarNotas = new FormIngresarNotas();
            FormIngresarNotas.MdiParent = this;
            FormIngresarNotas.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            Login();
        }
    }
}
