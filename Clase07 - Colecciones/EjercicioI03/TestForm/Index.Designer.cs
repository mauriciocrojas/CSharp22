namespace TestForm
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
            this.rchPalabras = new System.Windows.Forms.RichTextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnMostrarPalabras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchPalabras
            // 
            this.rchPalabras.Location = new System.Drawing.Point(21, 12);
            this.rchPalabras.Name = "rchPalabras";
            this.rchPalabras.Size = new System.Drawing.Size(284, 347);
            this.rchPalabras.TabIndex = 0;
            this.rchPalabras.Text = "";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(318, 12);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(110, 50);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnMostrarPalabras
            // 
            this.btnMostrarPalabras.Location = new System.Drawing.Point(318, 79);
            this.btnMostrarPalabras.Name = "btnMostrarPalabras";
            this.btnMostrarPalabras.Size = new System.Drawing.Size(110, 49);
            this.btnMostrarPalabras.TabIndex = 2;
            this.btnMostrarPalabras.Text = "Mostrar Palabras";
            this.btnMostrarPalabras.UseVisualStyleBackColor = true;
            this.btnMostrarPalabras.Click += new System.EventHandler(this.btnMostrarPalabras_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 370);
            this.Controls.Add(this.btnMostrarPalabras);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.rchPalabras);
            this.Name = "Index";
            this.Text = "Contador Palabras";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchPalabras;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnMostrarPalabras;
    }
}
