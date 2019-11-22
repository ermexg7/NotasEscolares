using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.NotasEscolares
{
    public class DatosEstudiantesBL
    {
        Contexto _contexto;
        public BindingList<Estudiante> ListaEstudiantes { get; set; }

        public DatosEstudiantesBL()
        {
            _contexto = new Contexto();
            ListaEstudiantes = new BindingList<Estudiante>();

           
        }

        public BindingList<Estudiante> ObtenerEstudiantes()
        {
            _contexto.Estudiantes.Load();
            ListaEstudiantes = _contexto.Estudiantes.Local.ToBindingList();

            return ListaEstudiantes;
        }

        public Resultado GuardarEstudiante(Estudiante estudiante)
        {
            var resultado = Validar(estudiante);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();
                
            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarEstudiante()
        {
            var nuevoEstudiante = new Estudiante();
            ListaEstudiantes.Add(nuevoEstudiante);
        }

      public bool EliminarEstudiante(int id)
        {
            foreach (var estudiante in ListaEstudiantes)
            {
                if (estudiante.Id == id)
                {
                    ListaEstudiantes.Remove(estudiante);
                    _contexto.SaveChanges();
                    return true;
                }

            }
            return false;
        }

        private Resultado Validar(Estudiante estudiante)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty(estudiante.Nombres) == true)
            {
                resultado.Mensaje = "Ingrese los nombres";
                resultado.Exitoso = false;
            }
                 
            return resultado;
        }
    }
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Identidad { get; set; }
        public string Direccion { get; set; }
        public int GradoId { get; set; }
        public Grado Grado { get; set; }
        public string Seccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
       

        public string NombreEncargado { get; set; }
        public string TelefonoEncargado { get; set; }
        public string CorreoElectronico { get; set; }
    }

    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}
