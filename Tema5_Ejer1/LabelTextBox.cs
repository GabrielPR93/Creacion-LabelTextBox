using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema5_Ejer1
{
    public partial class LabelTextBox : UserControl
    {
        private int separacion = 0;

        public LabelTextBox()
        {
            InitializeComponent();
            TextLbl = Name;
            TextTxt = "";
            recolocar();

        }
        private void recolocar()
        {
            switch (posicion)
            {
                case ePosicion.DERECHA:
                    //Establecemos posición del componente txt
                    txt.Location = new Point(0, 0);
                    //Establecemos ancho del Textbox (la label tiene ancho fijo)
                    txt.Width = this.Width - lbl.Width - Separacion;
                    //Establecemos posición del componente lbl
                    lbl.Location = new Point(txt.Width + Separacion, 0);
                    //Establecemos altura del componente
                    this.Height = Math.Max(txt.Height, lbl.Height);
                    break;
                case ePosicion.IZQUIERDA:
                    lbl.Location = new Point(0, 0);
                    txt.Location = new Point(lbl.Width + Separacion, 0);
                    txt.Width = this.Width - lbl.Width - Separacion;
                    this.Height = Math.Max(txt.Height, lbl.Height);
                    break;
            }

        }
        public enum ePosicion
        {
            IZQUIERDA, DERECHA
        }

        private ePosicion posicion = ePosicion.IZQUIERDA;
        [Category("Appearance")]
        [Description("Indica si la Label se sitúa a la IZQUIERDA o DERECHA del Textbox")]
        public ePosicion Posicion
        {
            set
            {
                if (Enum.IsDefined(typeof(ePosicion), value))
                {
                    posicion = value;
                    recolocar();
                    if (CambiaPosicion != null)
                    {
                        CambiaPosicion(this, new EventArgs());
                    }
                }
                else
                {
                    throw new InvalidEnumArgumentException();
                }
            }
            get
            {
                return posicion;
            }
        }

        [Category("Design")]
        [Description("Píxels de separación entre Label y Textbox")]
        public int Separacion
        {
            set
            {
                if (value >= 0)
                {
                    separacion = value;
                    recolocar();
                    if (CambiaSeparacion!=null)
                    {
                        CambiaSeparacion(this,new EventArgs());
                    }
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            get
            {
                return separacion;
            }
        }

        [Category("Appearance")]
        [Description("Texto asociado a la Label del control")]
        public string TextLbl
        {
            set
            {
                lbl.Text = value;
                recolocar();
            }
            get
            {
                return lbl.Text;
            }
        }
        [Category("Appearance")]
        [Description("Texto asociado al TextBox del control")]
        public string TextTxt
        {
            set
            {
                txt.Text = value;
            
            }
            get
            {
                return txt.Text;
            }
        }


        // Esta función has de enlazarla con el evento SizeChanged.
        private void LabelTextBox_SizeChanged(object sender, EventArgs e)
        {

            Console.WriteLine("Cambio");
            //recolocar();
        }
        //---------------
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            recolocar();
        }

        //Creacion del Evento CambiaPosicion
        [Category("La propiedad cambió")]
        [Description("Se lanza cuando la propiedad Posición cambia")]
        public event System.EventHandler CambiaPosicion;

        //Creacion Evento CambiaSeparacion
        [Category("la separacion cambio")]
        [Description("Se lanza cuando la separacion cambia")]
        public event System.EventHandler CambiaSeparacion;

        //metodo asociado a keyUp del labelTextbox
        private void txt_KeyUp(object sender,KeyEventArgs e)
        {
            this.OnKeyUp(e);
        }

        //Creacion Evento TxtChanged
        [Category("La propiedad cambió")]
        [Description("Se lanza cuando se produce el evento TextChanged")]
        public event System.EventHandler TxtChanged;

        private void txt_TextChanged(object sender, EventArgs e)
        {
            this.OnTextChanged(e);
        }

        //Creacion propiedad PswChr
        [Category("Appearance")]
        [Description("propiedad que enlaza con la propiedad PasswordChar")]

        public char PswChr
        {
            set
            {
                txt.PasswordChar = value;
            }
            get
            {
                return txt.PasswordChar;
            }
        }
    }

}
