using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.NotasEscolares
{
    public class DatosdeInicio: CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            var grado1 = new Grado();
            grado1.Descripcion = "Grado 1°";
            contexto.Grados.Add(grado1);

            var grado2 = new Grado();
            grado2.Descripcion = "Grado 2°";
            contexto.Grados.Add(grado2);

            var grado3 = new Grado();
            grado3.Descripcion = "Grado 3°";
            contexto.Grados.Add(grado3);

            var grado4 = new Grado();
            grado4.Descripcion = "Grado 4°";
            contexto.Grados.Add(grado4);

            var grado5 = new Grado();
            grado5.Descripcion = "Grado 5°";
            contexto.Grados.Add(grado5);

            var grado6 = new Grado();
            grado6.Descripcion = "Grado 6°";
            contexto.Grados.Add(grado6);

            base.Seed(contexto);
        }
    }
}
