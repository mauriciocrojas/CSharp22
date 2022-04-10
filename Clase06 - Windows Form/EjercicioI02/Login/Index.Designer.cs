namespace Login
{
    partial class Index
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpbUsuario = new System.Windows.Forms.GroupBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.NumericUpDown();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.grpbGenero = new System.Windows.Forms.GroupBox();
            this.rdbNoBinario = new System.Windows.Forms.RadioButton();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.grpbCursos = new System.Windows.Forms.GroupBox();
            this.chkbJavaScript = new System.Windows.Forms.CheckBox();
            this.chkbCMas = new System.Windows.Forms.CheckBox();
            this.chkbCSharp = new System.Windows.Forms.CheckBox();
            this.lstbPais = new System.Windows.Forms.ListBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.grpbUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdad)).BeginInit();
            this.grpbGenero.SuspendLayout();
            this.grpbCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbUsuario
            // 
            this.grpbUsuario.Controls.Add(this.lblEdad);
            this.grpbUsuario.Controls.Add(this.lblDireccion);
            this.grpbUsuario.Controls.Add(this.lblNombre);
            this.grpbUsuario.Controls.Add(this.txtEdad);
            this.grpbUsuario.Controls.Add(this.txtDireccion);
            this.grpbUsuario.Controls.Add(this.txtNombre);
            this.grpbUsuario.Location = new System.Drawing.Point(22, 21);
            this.grpbUsuario.Name = "grpbUsuario";
            this.grpbUsuario.Size = new System.Drawing.Size(230, 167);
            this.grpbUsuario.TabIndex = 0;
            this.grpbUsuario.TabStop = false;
            this.grpbUsuario.Text = "Detalles del usuario";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(36, 127);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(36, 15);
            this.lblEdad.TabIndex = 5;
            this.lblEdad.Text = "Edad:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(18, 71);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(60, 15);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(18, 42);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 15);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(95, 119);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(97, 23);
            this.txtEdad.TabIndex = 2;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(95, 63);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 23);
            this.txtDireccion.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(95, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 0;
            // 
            // grpbGenero
            // 
            this.grpbGenero.Controls.Add(this.rdbNoBinario);
            this.grpbGenero.Controls.Add(this.rdbFemenino);
            this.grpbGenero.Controls.Add(this.rdbMasculino);
            this.grpbGenero.Location = new System.Drawing.Point(288, 21);
            this.grpbGenero.Name = "grpbGenero";
            this.grpbGenero.Size = new System.Drawing.Size(200, 100);
            this.grpbGenero.TabIndex = 1;
            this.grpbGenero.TabStop = false;
            this.grpbGenero.Text = "Género";
            // 
            // rdbNoBinario
            // 
            this.rdbNoBinario.AutoSize = true;
            this.rdbNoBinario.Location = new System.Drawing.Point(18, 75);
            this.rdbNoBinario.Name = "rdbNoBinario";
            this.rdbNoBinario.Size = new System.Drawing.Size(81, 19);
            this.rdbNoBinario.TabIndex = 2;
            this.rdbNoBinario.Text = "No Binario";
            this.rdbNoBinario.UseVisualStyleBackColor = true;
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Location = new System.Drawing.Point(18, 51);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(78, 19);
            this.rdbFemenino.TabIndex = 1;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Checked = true;
            this.rdbMasculino.Location = new System.Drawing.Point(18, 26);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(80, 19);
            this.rdbMasculino.TabIndex = 0;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // grpbCursos
            // 
            this.grpbCursos.Controls.Add(this.chkbJavaScript);
            this.grpbCursos.Controls.Add(this.chkbCMas);
            this.grpbCursos.Controls.Add(this.chkbCSharp);
            this.grpbCursos.Location = new System.Drawing.Point(288, 134);
            this.grpbCursos.Name = "grpbCursos";
            this.grpbCursos.Size = new System.Drawing.Size(200, 100);
            this.grpbCursos.TabIndex = 2;
            this.grpbCursos.TabStop = false;
            this.grpbCursos.Text = "Cursos";
            // 
            // chkbJavaScript
            // 
            this.chkbJavaScript.AutoSize = true;
            this.chkbJavaScript.Location = new System.Drawing.Point(16, 75);
            this.chkbJavaScript.Name = "chkbJavaScript";
            this.chkbJavaScript.Size = new System.Drawing.Size(78, 19);
            this.chkbJavaScript.TabIndex = 2;
            this.chkbJavaScript.Text = "JavaScript";
            this.chkbJavaScript.UseVisualStyleBackColor = true;
            // 
            // chkbCMas
            // 
            this.chkbCMas.AutoSize = true;
            this.chkbCMas.Location = new System.Drawing.Point(16, 50);
            this.chkbCMas.Name = "chkbCMas";
            this.chkbCMas.Size = new System.Drawing.Size(50, 19);
            this.chkbCMas.TabIndex = 1;
            this.chkbCMas.Text = "C++";
            this.chkbCMas.UseVisualStyleBackColor = true;
            // 
            // chkbCSharp
            // 
            this.chkbCSharp.AutoSize = true;
            this.chkbCSharp.Location = new System.Drawing.Point(16, 29);
            this.chkbCSharp.Name = "chkbCSharp";
            this.chkbCSharp.Size = new System.Drawing.Size(41, 19);
            this.chkbCSharp.TabIndex = 0;
            this.chkbCSharp.Text = "C#";
            this.chkbCSharp.UseVisualStyleBackColor = true;
            // 
            // lstbPais
            // 
            this.lstbPais.FormattingEnabled = true;
            this.lstbPais.ItemHeight = 15;
            this.lstbPais.Location = new System.Drawing.Point(22, 225);
            this.lstbPais.Name = "lstbPais";
            this.lstbPais.Size = new System.Drawing.Size(236, 64);
            this.lstbPais.TabIndex = 3;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(22, 207);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(31, 15);
            this.lblPais.TabIndex = 4;
            this.lblPais.Text = "País:";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(288, 253);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(200, 36);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 333);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lstbPais);
            this.Controls.Add(this.grpbCursos);
            this.Controls.Add(this.grpbGenero);
            this.Controls.Add(this.grpbUsuario);
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpbUsuario.ResumeLayout(false);
            this.grpbUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdad)).EndInit();
            this.grpbGenero.ResumeLayout(false);
            this.grpbGenero.PerformLayout();
            this.grpbCursos.ResumeLayout(false);
            this.grpbCursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbUsuario;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.NumericUpDown txtEdad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox grpbGenero;
        private System.Windows.Forms.RadioButton rdbNoBinario;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.GroupBox grpbCursos;
        private System.Windows.Forms.CheckBox chkbJavaScript;
        private System.Windows.Forms.CheckBox chkbCMas;
        private System.Windows.Forms.CheckBox chkbCSharp;
        private System.Windows.Forms.ListBox lstbPais;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Button btnIngresar;
    }
}
