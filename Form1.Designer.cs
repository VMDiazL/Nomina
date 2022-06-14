namespace Nomina
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
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtPrecioHora = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtHorasTrabajadas = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.AccessibleName = "txtNombreEmpleado";
            this.txtNombreEmpleado.Location = new System.Drawing.Point(100, 107);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(254, 20);
            this.txtNombreEmpleado.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(100, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Nombre del Empleado:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(100, 155);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(89, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "Precio por hora:";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtPrecioHora
            // 
            this.txtPrecioHora.AccessibleName = "txtPrecioHora";
            this.txtPrecioHora.Location = new System.Drawing.Point(100, 186);
            this.txtPrecioHora.Name = "txtPrecioHora";
            this.txtPrecioHora.Size = new System.Drawing.Size(89, 20);
            this.txtPrecioHora.TabIndex = 2;
            this.txtPrecioHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrecioHora.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(100, 230);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(149, 20);
            this.textBox5.TabIndex = 5;
            this.textBox5.Text = "Cantidad de horas trabajadas:";
            // 
            // txtHorasTrabajadas
            // 
            this.txtHorasTrabajadas.AccessibleName = "txtHorasTrabajadas";
            this.txtHorasTrabajadas.Location = new System.Drawing.Point(100, 261);
            this.txtHorasTrabajadas.Name = "txtHorasTrabajadas";
            this.txtHorasTrabajadas.Size = new System.Drawing.Size(149, 20);
            this.txtHorasTrabajadas.TabIndex = 4;
            this.txtHorasTrabajadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalcular
            // 
            this.btnCalcular.AccessibleName = "btnCalcular";
            this.btnCalcular.Location = new System.Drawing.Point(256, 362);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(96, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular Salario";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(229, 34);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(154, 20);
            this.textBox8.TabIndex = 8;
            this.textBox8.Text = "CALCULO DE SALARIO";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // txtResultado
            // 
            this.txtResultado.AccessibleName = "txtSalario";
            this.txtResultado.Location = new System.Drawing.Point(229, 336);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(155, 20);
            this.txtResultado.TabIndex = 6;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(162, 310);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(306, 20);
            this.txtNombre.TabIndex = 9;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 450);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtHorasTrabajadas);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtPrecioHora);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtPrecioHora;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtHorasTrabajadas;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtNombre;
    }
}

