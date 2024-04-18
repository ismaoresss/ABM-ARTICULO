namespace TP2_WinForm.VentanaFormulario
{
    partial class BuscarArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarArticulo));
            this.lbl_BuscarArticulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboBusquedaArticulos = new System.Windows.Forms.ComboBox();
            this.lbl_buscarPor = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_BuscarArticulo
            // 
            this.lbl_BuscarArticulo.AutoSize = true;
            this.lbl_BuscarArticulo.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BuscarArticulo.ForeColor = System.Drawing.Color.White;
            this.lbl_BuscarArticulo.Location = new System.Drawing.Point(229, 34);
            this.lbl_BuscarArticulo.Name = "lbl_BuscarArticulo";
            this.lbl_BuscarArticulo.Size = new System.Drawing.Size(342, 32);
            this.lbl_BuscarArticulo.TabIndex = 0;
            this.lbl_BuscarArticulo.Text = "BUSQUEDA DE ARTICULOS";
            this.lbl_BuscarArticulo.Click += new System.EventHandler(this.lbl_BuscarArticulo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.lbl_BuscarArticulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 1;
            // 
            // cboBusquedaArticulos
            // 
            this.cboBusquedaArticulos.FormattingEnabled = true;
            this.cboBusquedaArticulos.Location = new System.Drawing.Point(132, 158);
            this.cboBusquedaArticulos.Name = "cboBusquedaArticulos";
            this.cboBusquedaArticulos.Size = new System.Drawing.Size(250, 21);
            this.cboBusquedaArticulos.TabIndex = 2;
            // 
            // lbl_buscarPor
            // 
            this.lbl_buscarPor.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscarPor.Location = new System.Drawing.Point(12, 155);
            this.lbl_buscarPor.Name = "lbl_buscarPor";
            this.lbl_buscarPor.Size = new System.Drawing.Size(114, 28);
            this.lbl_buscarPor.TabIndex = 3;
            this.lbl_buscarPor.Text = "BUSCAR POR:";
            this.lbl_buscarPor.Click += new System.EventHandler(this.lbl_buscarPor_Click);
            // 
            // BuscarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_buscarPor);
            this.Controls.Add(this.cboBusquedaArticulos);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuscarArticulo";
            this.Text = "BuscarArticulo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_BuscarArticulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboBusquedaArticulos;
        private System.Windows.Forms.Label lbl_buscarPor;
    }
}