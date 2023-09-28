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
    public partial class Aire_Tour : Form
    {
        public Aire_Tour()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboEstrato_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IngresarDatos_Click(object sender, EventArgs e)
        {
            if (textid.Text == "")
            {
                MessageBox.Show("Falta Identificación");
                textid.Focus();
            } else if (textNombre.Text == " ")
            {
                MessageBox.Show("Falta Nombre");
                textNombre.Focus();
            } else if (textApellido.Text == " ")
            {
                MessageBox.Show("Falta Apellido");
                textApellido.Focus();
            } else if (comboGenero.Items.ToString() == " ")
            {
                MessageBox.Show("Seleccione genero");
            } else if (comboEstrato.Items.ToString() == "")
            {
                MessageBox.Show("Seleccione estrato");
            } else if (comboDestino.Items.ToString() == " ")
            {
                MessageBox.Show("Seleccione destino");
            } else if (comboClase.Items.ToString() == "")
            {
                MessageBox.Show("Seleccione Clase");
            } else if (comboDia.Items.ToString() == "")
            {
                MessageBox.Show("Seleccione día que desea viajar");
            }

            else
            {
                Destinos destinos = new Destinos();
                destinos.Id = Convert.ToInt32(textid);
                destinos.Nombre = textNombre.Text;
                destinos.Apellido = textApellido.Text;
                destinos.Estrato = Convert.ToChar(comboEstrato.Text);
                destinos.Genero = Convert.ToString(comboGenero.Text);
                destinos.CiudadOrigen = Convert.ToString(comboDestino.Text);
                destinos.Destino = Convert.ToString(comboDestino.Text);
                destinos.Clase = Convert.ToChar(comboClase.Text);
                destinos.Dia = Convert.ToString(comboDia.Text);

                if (destinos.Destino == "Bogotá" && destinos.Clase == 'A')
                {
                    MessageBox.Show (" Valor de viaje es: " + "$ " + destinos.DestinoBogotaClaseA());
                }
                else if (destinos.Destino == "Bogotá" && destinos.Clase == 'B')
                {
                    MessageBox.Show("Valor de viaje es: " + "$ " + destinos.DestinoBogotaClaseB());
                }
                else if (destinos.Destino == "Bogotá" && destinos.Clase == 'C')
                {
                    MessageBox.Show(" Valor de viaje es: " + "$ " + destinos.DestinoBogotaClaseC());
                }
                else if (destinos.Destino == "Medellín" && destinos.Clase == 'A')
                {
                    MessageBox.Show(" Valor de viaje es: " + "$ " + destinos.DestinoMedellinClaseA());
                }
                else if (destinos.Destino == "Medellín" && destinos.Clase == 'B')
                {
                    MessageBox.Show(" Valor de viaje es: " + "$ " + destinos.DestinoMedellinClaseB());
                }
                else if (destinos.Destino == "Medellín" && destinos.Clase == 'C')
                {
                    MessageBox.Show(" Valor de viaje es: " + "$ " + destinos.DestinoMedellinClaseC());
                }
                else if (destinos.Destino == "Florencia" && destinos.Clase == 'A')
                {
                    MessageBox.Show(" Valor de viaje es: " + "$ " + destinos.DestinoFlorenciaClaseA());
                }
                else if (destinos.Destino == "Florenica" && destinos.Clase == 'B')
                {
                    MessageBox.Show(" Valor de viaje es: " + "$ " + destinos.DestinoFlorenciaClaseB());
                }
                else if (destinos.Destino == "Florencia" && destinos.Clase == 'C')
                {
                    MessageBox.Show(" Valor de viaje es: " + "$ " + destinos.DestinoFlorenciaClaseC());
                }
                else if (destinos.Destino == "Pitalito" && destinos.Clase == 'A')
                {
                    MessageBox.Show(" Valor de viaje es: " + "$ " + destinos.DestinoPitalitoClaseA());
                }
                else if (destinos.Destino == "Pitalito" && destinos.Clase == 'B')
                {
                    MessageBox.Show(" Valor de viaje es: " + "$ " + destinos.DestinoPitalitoClaseB());
                }
                else if (destinos.Destino == "Pitalito" && destinos.Clase == 'C')
                {
                    MessageBox.Show(" Valor de viaje es: " + "$ " + destinos.DestinoPitalitoClaseC());
                }

                Reporte reporte = new Reporte();
                
            }
        }

        private void LimpiarDatos_Click(object sender, EventArgs e)
        {
            foreach (var c in this.Controls) 
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
                if (c is ComboBox)
                {
                    ((ComboBox)c).Text = "";
                }
            }
        }
    }
}
