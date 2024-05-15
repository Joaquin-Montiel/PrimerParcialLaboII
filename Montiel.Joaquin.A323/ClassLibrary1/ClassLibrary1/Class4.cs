using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Consultas
    {
        private DateTime fecha;
        private string paciente;

        public Consultas(DateTime fecha, string paciente)
        {
            this.fecha = fecha;
            this.paciente = paciente;
        }

        public DateTime GetFecha()
        {
            return fecha;
        }
        public string GetPaciente()
        {
            return paciente;
        }

        public override string ToString()
        {
            return $"{fecha} se ha atendido a {paciente}";
        }



    }
}

