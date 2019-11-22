using BL.NotasEscolares;
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
    public partial class FormDatosEstudiantes : Form
    {
        DatosEstudiantesBL _estudiantes;
        GradosBL _gradosBL;

        public FormDatosEstudiantes()
        {
            InitializeComponent();

            _estudiantes = new DatosEstudiantesBL();
            listaEstudiantesBindingSource.DataSource = _estudiantes.ObtenerEstudiantes();

            _gradosBL = new GradosBL();
            listaGradosBindingSource.DataSource = _gradosBL.ObtenerGrados();
           
          
        }

        private void listaEstudiantesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listaEstudiantesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaEstudiantesBindingSource.EndEdit();
            var estudiante = (Estudiante)listaEstudiantesBindingSource.Current;

            var resultado = _estudiantes.GuardarEstudiante(estudiante);

            if (resultado.Exitoso ==true )
            {
                listaEstudiantesBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Datos Guardados");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void fechaNacimientoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _estudiantes.AgregarEstudiante();
            listaEstudiantesBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }

        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtonCancelar.Visible = !valor;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
           

            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("Desea Eliminar Datos del Estudiante?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                } 
            }
        }

        private void Eliminar(int id)
        {
           
            var resultado = _estudiantes.EliminarEstudiante(id);

            if (resultado == true)
            {
                listaEstudiantesBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar datos del estudiante");
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarBotones(true);
            Eliminar(0);
        }

        private void FormDatosEstudiantes_Load(object sender, EventArgs e)
        {

        }
    }
}
