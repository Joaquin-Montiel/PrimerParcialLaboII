using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Paciente : Persona
    {
        public string diagnostico;

        public Paciente(string apellido, string barrioRecidencia, DateTime nacimiento, string nombre, string diagnostico) 
            : base(apellido, barrioRecidencia, nacimiento, nombre)
        {
            this.diagnostico = diagnostico;
        }

        public string GetDiagnostico()
        {
            return diagnostico;
        }

        public string SetDiagnostico(string value)
        {
            this.diagnostico = value;
            return diagnostico;
        }

        internal override string FichaExtra()
        {
            return $"Recide en: {barrioRecidencia}\n Diagnostico: {diagnostico}";
        }

        
   
    }
}
