using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tema5_Ejer1;

namespace Prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void labelTextBox1_CambiaPosicion(object sender, EventArgs e)
        {
            Text = labelTextBox1.Posicion.ToString();
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelTextBox1.Posicion =
                 labelTextBox1.Posicion == LabelTextBox.ePosicion.DERECHA ?
                 LabelTextBox.ePosicion.IZQUIERDA : LabelTextBox.ePosicion.DERECHA;  
        }

        private void labelTextBox1_CambiaSeparacion(object sender, EventArgs e)
        {
            lblSeparacion.Text = "La separacion Cambió: "+labelTextBox1.Separacion;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelTextBox1.Separacion = 5;
        }

        private void labelTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            lblKeyUp.Text = "Letra: " + e.KeyCode;
            
        }

        private void labelTextBox1_TxtChanged(object sender, EventArgs e)
        {
            lblChanged.Text = "Evento TxtChanged lanzado";
        }
    }
}
