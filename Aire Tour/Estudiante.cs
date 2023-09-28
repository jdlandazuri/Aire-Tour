using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aire_Tour
{
    public partial class Estudiante : Form
    {
        public Estudiante()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textidEs.Text.ToString() == "")
            {
                MessageBox.Show("Ingrese número de Identificación");

            }else if (textNombreEs.Text == "")
            {
                MessageBox.Show("Ingrese su nombre completo");
            }else if (textApellidoEs.Text == "")
            {
                MessageBox.Show("Ingrese su apellido completo");
            }else if (textClave.Text == "")
            {
                MessageBox.Show("Ingrese clave de ingreso");
                textClave.Focus();
            }

            else
            {
                DatosEstudiante datosEstudiante = new DatosEstudiante();
                datosEstudiante.IdentificacionEs = Convert.ToDouble(textidEs.Text);
                datosEstudiante.NombreEs = Convert.ToString(textNombreEs.Text);
                datosEstudiante.ApellidoEs = Convert.ToString((string)textApellidoEs.Text);
                datosEstudiante.clave = Convert.ToInt32((string)textClave.Text);

                if ( datosEstudiante.clave == 123 )
                {
                    MessageBox.Show("Correcto");
                    this.Hide();
                    Aire_Tour aireTour = new Aire_Tour();
                    aireTour.Show();

                }
                else
                {
                    MessageBox.Show("Controseña incorrecta ");
                    textClave.Text = " ";
                    textClave.Focus();
                }
            }
        }

        private void textNombreEs_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
