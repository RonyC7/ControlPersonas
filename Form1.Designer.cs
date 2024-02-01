namespace ControlPersonas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxDpi = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.buttonIngreso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.labelDpi = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.buttonPrimeraMayuscula = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelEdad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxDpi
            // 
            this.textBoxDpi.Location = new System.Drawing.Point(186, 36);
            this.textBoxDpi.Name = "textBoxDpi";
            this.textBoxDpi.Size = new System.Drawing.Size(239, 22);
            this.textBoxDpi.TabIndex = 0;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(186, 84);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(239, 22);
            this.textBoxNombre.TabIndex = 1;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(186, 126);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(239, 22);
            this.textBoxApellido.TabIndex = 2;
            // 
            // buttonIngreso
            // 
            this.buttonIngreso.Location = new System.Drawing.Point(21, 36);
            this.buttonIngreso.Name = "buttonIngreso";
            this.buttonIngreso.Size = new System.Drawing.Size(129, 57);
            this.buttonIngreso.TabIndex = 3;
            this.buttonIngreso.Text = "Ingresar Persona";
            this.buttonIngreso.UseVisualStyleBackColor = true;
            this.buttonIngreso.Click += new System.EventHandler(this.buttonIngreso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "DPI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellido";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(186, 166);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(239, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // labelDpi
            // 
            this.labelDpi.AutoSize = true;
            this.labelDpi.Location = new System.Drawing.Point(662, 36);
            this.labelDpi.Name = "labelDpi";
            this.labelDpi.Size = new System.Drawing.Size(44, 16);
            this.labelDpi.TabIndex = 9;
            this.labelDpi.Text = "label5";
            this.labelDpi.Visible = false;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(662, 84);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 16);
            this.labelNombre.TabIndex = 10;
            this.labelNombre.Text = "label6";
            this.labelNombre.Visible = false;
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(662, 126);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(44, 16);
            this.labelApellido.TabIndex = 11;
            this.labelApellido.Text = "label7";
            this.labelApellido.Visible = false;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(662, 166);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(44, 16);
            this.labelFecha.TabIndex = 12;
            this.labelFecha.Text = "label8";
            this.labelFecha.Visible = false;
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.Location = new System.Drawing.Point(21, 132);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(129, 56);
            this.buttonMostrar.TabIndex = 13;
            this.buttonMostrar.Text = "Mostrar Persona";
            this.buttonMostrar.UseVisualStyleBackColor = true;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // buttonPrimeraMayuscula
            // 
            this.buttonPrimeraMayuscula.Location = new System.Drawing.Point(21, 225);
            this.buttonPrimeraMayuscula.Name = "buttonPrimeraMayuscula";
            this.buttonPrimeraMayuscula.Size = new System.Drawing.Size(129, 43);
            this.buttonPrimeraMayuscula.TabIndex = 14;
            this.buttonPrimeraMayuscula.Text = "Primera Mayuscula";
            this.buttonPrimeraMayuscula.UseVisualStyleBackColor = true;
            this.buttonPrimeraMayuscula.Click += new System.EventHandler(this.buttonPrimeraMayuscula_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(456, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Edad";
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Location = new System.Drawing.Point(665, 207);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(44, 16);
            this.labelEdad.TabIndex = 16;
            this.labelEdad.Text = "label6";
            this.labelEdad.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 280);
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonPrimeraMayuscula);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelDpi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonIngreso);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxDpi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Formulario de persona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDpi;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Button buttonIngreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDpi;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.Button buttonPrimeraMayuscula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelEdad;
    }
}

