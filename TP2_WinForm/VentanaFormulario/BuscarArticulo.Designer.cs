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
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Buscar = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btnMostrartodo = new System.Windows.Forms.Button();
            this.panelbusqueda = new System.Windows.Forms.Panel();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnvolverArticulo = new System.Windows.Forms.Button();
            this.AgregariconoPc = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panelbusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgregariconoPc)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_BuscarArticulo
            // 
            this.lbl_BuscarArticulo.AutoSize = true;
            this.lbl_BuscarArticulo.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BuscarArticulo.ForeColor = System.Drawing.Color.White;
            this.lbl_BuscarArticulo.Location = new System.Drawing.Point(406, 9);
            this.lbl_BuscarArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_BuscarArticulo.Name = "lbl_BuscarArticulo";
            this.lbl_BuscarArticulo.Size = new System.Drawing.Size(516, 48);
            this.lbl_BuscarArticulo.TabIndex = 0;
            this.lbl_BuscarArticulo.Text = "BUSQUEDA DE ARTICULOS";
            this.lbl_BuscarArticulo.Click += new System.EventHandler(this.lbl_BuscarArticulo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnMostrartodo);
            this.panel1.Controls.Add(this.lbl_BuscarArticulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1326, 154);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.lbl_Buscar);
            this.panel4.Controls.Add(this.menuStrip1);
            this.panel4.Controls.Add(this.txt_buscar);
            this.panel4.Location = new System.Drawing.Point(4, 63);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1096, 86);
            this.panel4.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Buscar
            // 
            this.lbl_Buscar.AutoSize = true;
            this.lbl_Buscar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Buscar.ForeColor = System.Drawing.Color.White;
            this.lbl_Buscar.Location = new System.Drawing.Point(195, 22);
            this.lbl_Buscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Buscar.Name = "lbl_Buscar";
            this.lbl_Buscar.Size = new System.Drawing.Size(214, 31);
            this.lbl_Buscar.TabIndex = 2;
            this.lbl_Buscar.Text = "Buscar articulo...";
            this.lbl_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Buscar.Click += new System.EventHandler(this.lbl_Buscar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(140, 20);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(51, 48);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(40, 44);
            // 
            // txt_buscar
            // 
            this.txt_buscar.BackColor = System.Drawing.Color.MediumPurple;
            this.txt_buscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_buscar.ForeColor = System.Drawing.Color.White;
            this.txt_buscar.Location = new System.Drawing.Point(422, 20);
            this.txt_buscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_buscar.Multiline = true;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(399, 32);
            this.txt_buscar.TabIndex = 1;
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            // 
            // btnMostrartodo
            // 
            this.btnMostrartodo.FlatAppearance.BorderSize = 0;
            this.btnMostrartodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrartodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrartodo.ForeColor = System.Drawing.Color.Black;
            this.btnMostrartodo.Location = new System.Drawing.Point(1110, 74);
            this.btnMostrartodo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMostrartodo.Name = "btnMostrartodo";
            this.btnMostrartodo.Size = new System.Drawing.Size(212, 54);
            this.btnMostrartodo.TabIndex = 13;
            this.btnMostrartodo.Text = "Mostrar todos";
            this.btnMostrartodo.UseVisualStyleBackColor = true;
            // 
            // panelbusqueda
            // 
            this.panelbusqueda.Controls.Add(this.dgvArticulos);
            this.panelbusqueda.Location = new System.Drawing.Point(18, 163);
            this.panelbusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelbusqueda.Name = "panelbusqueda";
            this.panelbusqueda.Size = new System.Drawing.Size(807, 338);
            this.panelbusqueda.TabIndex = 2;
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.AllowUserToDeleteRows = false;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArticulos.Location = new System.Drawing.Point(0, 0);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 62;
            this.dgvArticulos.Size = new System.Drawing.Size(807, 338);
            this.dgvArticulos.TabIndex = 0;
            // 
            // btnvolverArticulo
            // 
            this.btnvolverArticulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnvolverArticulo.BackgroundImage")));
            this.btnvolverArticulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnvolverArticulo.FlatAppearance.BorderSize = 0;
            this.btnvolverArticulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnvolverArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnvolverArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvolverArticulo.Location = new System.Drawing.Point(1002, 511);
            this.btnvolverArticulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnvolverArticulo.Name = "btnvolverArticulo";
            this.btnvolverArticulo.Size = new System.Drawing.Size(218, 89);
            this.btnvolverArticulo.TabIndex = 13;
            this.btnvolverArticulo.UseVisualStyleBackColor = true;
            this.btnvolverArticulo.Click += new System.EventHandler(this.btnvolverArticulo_Click);
            // 
            // AgregariconoPc
            // 
            this.AgregariconoPc.Image = ((System.Drawing.Image)(resources.GetObject("AgregariconoPc.Image")));
            this.AgregariconoPc.Location = new System.Drawing.Point(915, 163);
            this.AgregariconoPc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AgregariconoPc.Name = "AgregariconoPc";
            this.AgregariconoPc.Size = new System.Drawing.Size(393, 338);
            this.AgregariconoPc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AgregariconoPc.TabIndex = 12;
            this.AgregariconoPc.TabStop = false;
            // 
            // BuscarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1326, 643);
            this.Controls.Add(this.btnvolverArticulo);
            this.Controls.Add(this.AgregariconoPc);
            this.Controls.Add(this.panelbusqueda);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "BuscarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar artículo";
            this.Load += new System.EventHandler(this.BuscarArticulo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelbusqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgregariconoPc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_BuscarArticulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnvolverArticulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelbusqueda;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox AgregariconoPc;
        private System.Windows.Forms.Button btnMostrartodo;
    }
}