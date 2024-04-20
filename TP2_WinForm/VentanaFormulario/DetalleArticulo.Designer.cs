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
            this.datalistadoArticulo = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAcancelar = new System.Windows.Forms.Button();
            this.btnguardarcambiospersonal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgregariconoPc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datalistadoArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 66);
            this.panel1.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "DETALLE DEL ARTICULO";
            // 
            // AgregariconoPc
            // 
            this.AgregariconoPc.Image = ((System.Drawing.Image)(resources.GetObject("AgregariconoPc.Image")));
            this.AgregariconoPc.Location = new System.Drawing.Point(389, 84);
            this.AgregariconoPc.Name = "AgregariconoPc";
            this.AgregariconoPc.Size = new System.Drawing.Size(267, 239);
            this.AgregariconoPc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AgregariconoPc.TabIndex = 52;
            this.AgregariconoPc.TabStop = false;
            // 
            // datalistadoArticulo
            // 
            this.datalistadoArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistadoArticulo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datalistadoArticulo.Location = new System.Drawing.Point(12, 84);
            this.datalistadoArticulo.Name = "datalistadoArticulo";
            this.datalistadoArticulo.RowHeadersWidth = 51;
            this.datalistadoArticulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistadoArticulo.Size = new System.Drawing.Size(276, 239);
            this.datalistadoArticulo.TabIndex = 53;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 448);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(688, 93);
            this.dataGridView1.TabIndex = 54;
            // 
            // btnAcancelar
            // 
            this.btnAcancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAcancelar.BackgroundImage")));
            this.btnAcancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAcancelar.FlatAppearance.BorderSize = 0;
            this.btnAcancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcancelar.Location = new System.Drawing.Point(12, 329);
            this.btnAcancelar.Name = "btnAcancelar";
            this.btnAcancelar.Size = new System.Drawing.Size(164, 73);
            this.btnAcancelar.TabIndex = 55;
            this.btnAcancelar.UseVisualStyleBackColor = true;
            // 
            // btnguardarcambiospersonal
            // 
            this.btnguardarcambiospersonal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnguardarcambiospersonal.BackgroundImage")));
            this.btnguardarcambiospersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnguardarcambiospersonal.FlatAppearance.BorderSize = 0;
            this.btnguardarcambiospersonal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnguardarcambiospersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnguardarcambiospersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardarcambiospersonal.Location = new System.Drawing.Point(153, 329);
            this.btnguardarcambiospersonal.Name = "btnguardarcambiospersonal";
            this.btnguardarcambiospersonal.Size = new System.Drawing.Size(135, 73);
            this.btnguardarcambiospersonal.TabIndex = 56;
            this.btnguardarcambiospersonal.UseVisualStyleBackColor = true;
            // 
            // DetalleArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(755, 612);
            this.Controls.Add(this.btnguardarcambiospersonal);
            this.Controls.Add(this.btnAcancelar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.datalistadoArticulo);
            this.Controls.Add(this.AgregariconoPc);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DetalleArticulo";
            this.Text = "DetalleArticulo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgregariconoPc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datalistadoArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox AgregariconoPc;
        private System.Windows.Forms.DataGridView datalistadoArticulo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAcancelar;
        private System.Windows.Forms.Button btnguardarcambiospersonal;
    }
}