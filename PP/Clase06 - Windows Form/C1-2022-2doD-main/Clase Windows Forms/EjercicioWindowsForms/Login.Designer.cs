namespace EjercicioWindowsForms
{
    partial class Login
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
            this.button1 = new System.Windows.Forms.Button();
            this.txb_ingresoDatos = new System.Windows.Forms.TextBox();
            this.tbx_pass = new System.Windows.Forms.TextBox();
            this.btn_rellenar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(329, 247);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 85);
            this.button1.TabIndex = 0;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txb_ingresoDatos
            // 
            this.txb_ingresoDatos.Location = new System.Drawing.Point(105, 115);
            this.txb_ingresoDatos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_ingresoDatos.Name = "txb_ingresoDatos";
            this.txb_ingresoDatos.PlaceholderText = "Ingrese un mensaje";
            this.txb_ingresoDatos.Size = new System.Drawing.Size(659, 27);
            this.txb_ingresoDatos.TabIndex = 2;
            // 
            // tbx_pass
            // 
            this.tbx_pass.Location = new System.Drawing.Point(105, 191);
            this.tbx_pass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_pass.Name = "tbx_pass";
            this.tbx_pass.Size = new System.Drawing.Size(659, 27);
            this.tbx_pass.TabIndex = 3;
            // 
            // btn_rellenar
            // 
            this.btn_rellenar.Location = new System.Drawing.Point(655, 269);
            this.btn_rellenar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_rellenar.Name = "btn_rellenar";
            this.btn_rellenar.Size = new System.Drawing.Size(86, 31);
            this.btn_rellenar.TabIndex = 4;
            this.btn_rellenar.Text = "Rellenar";
            this.btn_rellenar.UseVisualStyleBackColor = true;
            this.btn_rellenar.Click += new System.EventHandler(this.btn_rellenar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 415);
            this.Controls.Add(this.btn_rellenar);
            this.Controls.Add(this.tbx_pass);
            this.Controls.Add(this.txb_ingresoDatos);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txb_ingresoDatos;
        private System.Windows.Forms.TextBox tbx_pass;
        private System.Windows.Forms.Button btn_rellenar;
    }
}
