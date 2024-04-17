namespace TP2_WinForm.VentanaFormulario
{
    partial class MenuPrincipal
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
            this.ListadoArt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListadoArt
            // 
            this.ListadoArt.Location = new System.Drawing.Point(48, 47);
            this.ListadoArt.Name = "ListadoArt";
            this.ListadoArt.Size = new System.Drawing.Size(178, 23);
            this.ListadoArt.TabIndex = 0;
            this.ListadoArt.Text = "LISTAR ARTICULOS";
            this.ListadoArt.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListadoArt);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ListadoArt;
    }
}