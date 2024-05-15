using Microsoft.VisualBasic;

namespace Biblioteca
{
    public abstract class Persona
    {
        protected string apellido;
        protected string barrioRecidencia;
        protected DateTime nacimiento;
        protected string nombre;

        public Persona(string apellido, DateTime nacimiento, string nombre)
        {
            this.apellido = apellido;
            this.nacimiento = nacimiento;
            this.nombre = nombre;
        }

        public Persona(string apellido, string barrioRecidencia, DateTime nacimiento, string nombre) 
            :this(apellido, nacimiento, nombre)
        {
            this.apellido = apellido;
            this.barrioRecidencia = barrioRecidencia;
            this.nacimiento = nacimiento;
            this.nombre = nombre;
        }

        public string NombreCompleto => $"{apellido}, {nombre}";

        public int Edad
        {
            get
            {
                DateTime hoy = DateTime.Today;
                int edad = hoy.Year - nacimiento.Year;
                if (nacimiento > hoy.AddYears(-edad))
                {
                    edad--;
                }
                return edad;
            }
        }

        public string GetNombreCompleto()
        {
            return NombreCompleto;
        }

        public string ToString()
        {
            return GetNombreCompleto();
        }

        public virtual string FichaPersonal()
        {
            return $"{ToString}\n Edad: {Edad}\n {FichaExtra}";
        }

        internal abstract string FichaExtra();

    }
}
