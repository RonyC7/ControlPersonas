using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace ControlPersonas
{
    class Persona
    {
        string dpi;
        string nombre;
        string apellido;
        DateTime fechaNacimiento;

        public String Dpi { get => dpi; set => dpi = value; }
        public String Nombre { get => nombre; set => nombre = value; }
        public String Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }

        public Persona()
        {
            dpi = "";
            nombre = "";
            apellido = "";
            fechaNacimiento = DateTime.Now;
        }

        public void PrimeraMayuscula()
        {
            nombre = CapitalizarCadaPalabra(nombre);
            apellido = CapitalizarCadaPalabra(apellido);
        }

        private string CapitalizarCadaPalabra(string input)
        {
            return Regex.Replace(input, @"\b\w", match => match.Value.ToUpper());
        }

        public int CalcularEdad()
        {
            DateTime fechaActual = DateTime.Now;
            int edad = fechaActual.Year - fechaNacimiento.Year;

            if (fechaNacimiento.Date > fechaActual.AddYears(-edad))
            {
                edad--;
            }

            return edad;
        }

        public void LimpiarNombre()
        {
            nombre = Regex.Replace(nombre, @"[^a-zA-Z ]+", "");

            nombre = CapitalizarCadaPalabra(nombre.Trim());
        }
    }
}
