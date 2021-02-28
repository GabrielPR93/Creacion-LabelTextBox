namespace Prueba
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.lblSeparacion = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblKeyUp = new System.Windows.Forms.Label();
            this.labelTextBox1 = new Tema5_Ejer1.LabelTextBox();
            this.lblChanged = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Der/Izq";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSeparacion
            // 
            this.lblSeparacion.AutoSize = true;
            this.lblSeparacion.Location = new System.Drawing.Point(119, 76);
            this.lblSeparacion.Name = "lblSeparacion";
            this.lblSeparacion.Size = new System.Drawing.Size(61, 13);
            this.lblSeparacion.TabIndex = 2;
            this.lblSeparacion.Text = "Separacion";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Separacion";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblKeyUp
            // 
            this.lblKeyUp.AutoSize = true;
            this.lblKeyUp.Location = new System.Drawing.Point(13, 118);
            this.lblKeyUp.Name = "lblKeyUp";
            this.lblKeyUp.Size = new System.Drawing.Size(76, 13);
            this.lblKeyUp.TabIndex = 4;
            this.lblKeyUp.Text = "Prueba KeyUp";
            // 
            // labelTextBox1
            // 
            this.labelTextBox1.Location = new System.Drawing.Point(12, 12);
            this.labelTextBox1.Name = "labelTextBox1";
            this.labelTextBox1.Posicion = Tema5_Ejer1.LabelTextBox.ePosicion.DERECHA;
            this.labelTextBox1.Separacion = 55;
            this.labelTextBox1.Size = new System.Drawing.Size(294, 20);
            this.labelTextBox1.TabIndex = 0;
            this.labelTextBox1.TextLbl = "LabelTextBox";
            this.labelTextBox1.TextTxt = "";
            this.labelTextBox1.CambiaPosicion += new System.EventHandler(this.labelTextBox1_CambiaPosicion);
            this.labelTextBox1.CambiaSeparacion += new System.EventHandler(this.labelTextBox1_CambiaSeparacion);
            this.labelTextBox1.TxtChanged += new System.EventHandler(this.labelTextBox1_TxtChanged);
            this.labelTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.labelTextBox1_KeyUp);
            // 
            // lblChanged
            // 
            this.lblChanged.AutoSize = true;
            this.lblChanged.Location = new System.Drawing.Point(16, 144);
            this.lblChanged.Name = "lblChanged";
            this.lblChanged.Size = new System.Drawing.Size(108, 13);
            this.lblChanged.TabIndex = 5;
            this.lblChanged.Text = "Prueba TextChanged";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 216);
            this.Controls.Add(this.lblChanged);
            this.Controls.Add(this.lblKeyUp);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblSeparacion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tema5_Ejer1.LabelTextBox labelTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSeparacion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblKeyUp;
        private System.Windows.Forms.Label lblChanged;
    }
}

