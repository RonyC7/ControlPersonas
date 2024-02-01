using System;
using System.Windows.Forms;

namespace ControlPersonas
{
    public partial class Form1 : Form
    {
        Persona persona = new Persona();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonIngreso_Click(object sender, EventArgs e)
        {
            string nombreSinEspacios = textBoxNombre.Text.Trim();
            persona.Dpi = textBoxDpi.Text;
            persona.Nombre = nombreSinEspacios;
            persona.Apellido = textBoxApellido.Text;
            persona.FechaNacimiento = dateTimePicker1.Value;
            persona.Nombre = LimpiarNombre(nombreSinEspacios);
            textBoxNombre.Text = nombreSinEspacios;
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            labelDpi.Text = persona.Dpi;
            labelNombre.Text = persona.Nombre;
            labelApellido.Text = persona.Apellido;
            labelFecha.Text = persona.FechaNacimiento.ToShortDateString();

            int edad = persona.CalcularEdad();
            labelEdad.Text = $"Edad: {edad} años";

            labelDpi.Visible = true;
            labelNombre.Visible = true;
            labelApellido.Visible = true;
            labelFecha.Visible = true;
            labelEdad.Visible = true;
        }

        private void buttonPrimeraMayuscula_Click(object sender, EventArgs e)
        {
            persona.PrimeraMayuscula();
            labelNombre.Text = persona.Nombre;
            labelApellido.Text = persona.Apellido;
        }

        private string LimpiarNombre(string nombre)
        {
            return System.Text.RegularExpressions.Regex.Replace(nombre, "[^a-zA-Z]+", "");
        }
    }
}
