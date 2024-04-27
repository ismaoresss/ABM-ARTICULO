namespace TP2_WinForm.VentanaFormulario
{
    partial class DetalleArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleArticulo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AgregariconoPc = new System.Windows.Forms.PictureBox();
            this.datalistadoDetalle = new System.Windows.Forms.DataGridView();
            this.datalistadoDetalletotal = new System.Windows.Forms.DataGridView();
            this.btnDetallar = new System.Windows.Forms.Button();
            this.btnguardarcambiospersonal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgregariconoPc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datalistadoDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datalistadoDetalletotal)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 66);
            this.panel1.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Underline);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(196, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "DETALLE DEL ARTICULO";
            // 
            // AgregariconoPc
            // 
            this.AgregariconoPc.Image = ((System.Drawing.Image)(resources.GetObject("AgregariconoPc.Image")));
            this.AgregariconoPc.Location = new System.Drawing.Point(356, 84);
            this.AgregariconoPc.Name = "AgregariconoPc";
            this.AgregariconoPc.Size = new System.Drawing.Size(268, 258);
            this.AgregariconoPc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AgregariconoPc.TabIndex = 52;
            this.AgregariconoPc.TabStop = false;
            // 
            // datalistadoDetalle
            // 
            this.datalistadoDetalle.AllowUserToAddRows = false;
            this.datalistadoDetalle.AllowUserToDeleteRows = false;
            this.datalistadoDetalle.BackgroundColor = System.Drawing.Color.White;
            this.datalistadoDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistadoDetalle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datalistadoDetalle.Location = new System.Drawing.Point(12, 84);
            this.datalistadoDetalle.Name = "datalistadoDetalle";
            this.datalistadoDetalle.ReadOnly = true;
            this.datalistadoDetalle.RowHeadersWidth = 51;
            this.datalistadoDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistadoDetalle.Size = new System.Drawing.Size(276, 258);
            this.datalistadoDetalle.TabIndex = 53;
            // 
            // datalistadoDetalletotal
            // 
            this.datalistadoDetalletotal.BackgroundColor = System.Drawing.Color.White;
            this.datalistadoDetalletotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistadoDetalletotal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datalistadoDetalletotal.Location = new System.Drawing.Point(12, 448);
            this.datalistadoDetalletotal.Name = "datalistadoDetalletotal";
            this.datalistadoDetalletotal.RowHeadersWidth = 51;
            this.datalistadoDetalletotal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistadoDetalletotal.Size = new System.Drawing.Size(688, 69);
            this.datalistadoDetalletotal.TabIndex = 54;
            // 
            // btnDetallar
            // 
            this.btnDetallar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDetallar.BackgroundImage")));
            this.btnDetallar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDetallar.FlatAppearance.BorderSize = 0;
            this.btnDetallar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDetallar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDetallar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetallar.Location = new System.Drawing.Point(0, 360);
            this.btnDetallar.Name = "btnDetallar";
            this.btnDetallar.Size = new System.Drawing.Size(164, 73);
            this.btnDetallar.TabIndex = 55;
            this.btnDetallar.UseVisualStyleBackColor = true;
            this.btnDetallar.Click += new System.EventHandler(this.btnDetallar_Click);
            // 
            // btnguardarcambiospersonal
            // 
            this.btnguardarcambiospersonal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnguardarcambiospersonal.BackgroundImage")));
            this.btnguardarcambiospersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnguardarcambiospersonal.FlatAppearance.BorderSize = 0;
            this.btnguardarcambiospersonal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnguardarcambiospersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnguardarcambiospersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardarcambiospersonal.Location = new System.Drawing.Point(153, 360);
            this.btnguardarcambiospersonal.Name = "btnguardarcambiospersonal";
            this.btnguardarcambiospersonal.Size = new System.Drawing.Size(135, 73);
            this.btnguardarcambiospersonal.TabIndex = 56;
            this.btnguardarcambiospersonal.UseVisualStyleBackColor = true;
            this.btnguardarcambiospersonal.Click += new System.EventHandler(this.btnguardarcambiospersonal_Click);
            // 
            // DetalleArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(706, 558);
            this.Controls.Add(this.btnguardarcambiospersonal);
            this.Controls.Add(this.btnDetallar);
            this.Controls.Add(this.datalistadoDetalletotal);
            this.Controls.Add(this.datalistadoDetalle);
            this.Controls.Add(this.AgregariconoPc);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DetalleArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle articulo";
            this.Load += new System.EventHandler(this.DetalleArticulo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgregariconoPc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datalistadoDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datalistadoDetalletotal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox AgregariconoPc;
        private System.Windows.Forms.DataGridView datalistadoDetalle;
        private System.Windows.Forms.DataGridView datalistadoDetalletotal;
        private System.Windows.Forms.Button btnDetallar;
        private System.Windows.Forms.Button btnguardarcambiospersonal;
    }
}