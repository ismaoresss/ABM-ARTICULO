namespace TP2_WinForm.VentanaFormulario
{
    partial class ListadoArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoArticulos));
            this.lbl_ListadoArticulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_CodArticulo = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_ListadoArticulo
            // 
            this.lbl_ListadoArticulo.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ListadoArticulo.ForeColor = System.Drawing.Color.White;
            this.lbl_ListadoArticulo.Location = new System.Drawing.Point(280, 25);
            this.lbl_ListadoArticulo.Name = "lbl_ListadoArticulo";
            this.lbl_ListadoArticulo.Size = new System.Drawing.Size(376, 38);
            this.lbl_ListadoArticulo.TabIndex = 0;
            this.lbl_ListadoArticulo.Text = "LISTADO DE ARTICULOS";
            this.lbl_ListadoArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.lbl_ListadoArticulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 88);
            this.panel1.TabIndex = 1;
            // 
            // lbl_CodArticulo
            // 
            this.lbl_CodArticulo.AutoSize = true;
            this.lbl_CodArticulo.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CodArticulo.ForeColor = System.Drawing.Color.White;
            this.lbl_CodArticulo.Location = new System.Drawing.Point(12, 149);
            this.lbl_CodArticulo.Name = "lbl_CodArticulo";
            this.lbl_CodArticulo.Size = new System.Drawing.Size(161, 28);
            this.lbl_CodArticulo.TabIndex = 2;
            this.lbl_CodArticulo.Text = "Codigo Articulo:";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_Nombre.Location = new System.Drawing.Point(75, 255);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(98, 28);
            this.lbl_Nombre.TabIndex = 3;
            this.lbl_Nombre.Text = "Nombre:";
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descripcion.ForeColor = System.Drawing.Color.White;
            this.lbl_Descripcion.Location = new System.Drawing.Point(44, 350);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(129, 28);
            this.lbl_Descripcion.TabIndex = 4;
            this.lbl_Descripcion.Text = "Descripción:";
            // 
            // ListadoArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(937, 523);
            this.Controls.Add(this.lbl_Descripcion);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.lbl_CodArticulo);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListadoArticulos";
            this.Text = "ListadoArticulos";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ListadoArticulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_CodArticulo;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Descripcion;
    }
}