namespace EjercicioWindowsForms
{
    partial class AltaAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.tb_apellido = new System.Windows.Forms.TextBox();
            this.tb_dni = new System.Windows.Forms.TextBox();
            this.tb_telefono = new System.Windows.Forms.TextBox();
            this.tb_direccion = new System.Windows.Forms.TextBox();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(86, 48);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.PlaceholderText = "Nombre";
            this.tb_nombre.Size = new System.Drawing.Size(443, 23);
            this.tb_nombre.TabIndex = 0;
            // 
            // tb_apellido
            // 
            this.tb_apellido.Location = new System.Drawing.Point(86, 101);
            this.tb_apellido.Name = "tb_apellido";
            this.tb_apellido.PlaceholderText = "Apellido";
            this.tb_apellido.Size = new System.Drawing.Size(443, 23);
            this.tb_apellido.TabIndex = 1;
            // 
            // tb_dni
            // 
            this.tb_dni.Location = new System.Drawing.Point(86, 149);
            this.tb_dni.Name = "tb_dni";
            this.tb_dni.PlaceholderText = "Dni";
            this.tb_dni.Size = new System.Drawing.Size(443, 23);
            this.tb_dni.TabIndex = 2;
            // 
            // tb_telefono
            // 
            this.tb_telefono.Location = new System.Drawing.Point(86, 197);
            this.tb_telefono.Name = "tb_telefono";
            this.tb_telefono.PlaceholderText = "Telefono";
            this.tb_telefono.Size = new System.Drawing.Size(443, 23);
            this.tb_telefono.TabIndex = 3;
            // 
            // tb_direccion
            // 
            this.tb_direccion.Location = new System.Drawing.Point(86, 246);
            this.tb_direccion.Name = "tb_direccion";
            this.tb_direccion.PlaceholderText = "Direccion";
            this.tb_direccion.Size = new System.Drawing.Size(443, 23);
            this.tb_direccion.TabIndex = 4;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(88, 321);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(183, 58);
            this.btn_Aceptar.TabIndex = 5;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(357, 321);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(147, 58);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // AltaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.tb_direccion);
            this.Controls.Add(this.tb_telefono);
            this.Controls.Add(this.tb_dni);
            this.Controls.Add(this.tb_apellido);
            this.Controls.Add(this.tb_nombre);
            this.Name = "AltaAlumno";
            this.Text = "AltaAlumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.TextBox tb_apellido;
        private System.Windows.Forms.TextBox tb_dni;
        private System.Windows.Forms.TextBox tb_telefono;
        private System.Windows.Forms.TextBox tb_direccion;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}