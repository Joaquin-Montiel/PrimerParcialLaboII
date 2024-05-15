using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class PersonalMedico : Persona
    {
        private List<Consultas> consultas;
        private bool esRecidente;

        public PersonalMedico(string apellido, DateTime nacimiento, string nombre, bool esRecidente)
            : base(apellido, nacimiento, nombre)
        {
            this.esRecidente = esRecidente;
        }

        internal override string FichaExtra()
        {
            return $"Finalizo la recidencia {esRecidente} \n ATENCIONES";
        }
    }
}
