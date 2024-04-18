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
            this.lbl_Buscar = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelbusqueda = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnvolverArticulo = new System.Windows.Forms.Button();
            this.AgregariconoPc = new System.Windows.Forms.PictureBox();
            this.btnMostrartodo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelbusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgregariconoPc)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_BuscarArticulo
            // 
            this.lbl_BuscarArticulo.AutoSize = true;
            this.lbl_BuscarArticulo.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BuscarArticulo.ForeColor = System.Drawing.Color.White;
            this.lbl_BuscarArticulo.Location = new System.Drawing.Point(326, 6);
            this.lbl_BuscarArticulo.Name = "lbl_BuscarArticulo";
            this.lbl_BuscarArticulo.Size = new System.Drawing.Size(343, 32);
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 100);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.lbl_Buscar);
            this.panel4.Controls.Add(this.menuStrip1);
            this.panel4.Controls.Add(this.txt_buscar);
            this.panel4.Location = new System.Drawing.Point(3, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(731, 56);
            this.panel4.TabIndex = 4;
            // 
            // lbl_Buscar
            // 
            this.lbl_Buscar.AutoSize = true;
            this.lbl_Buscar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Buscar.ForeColor = System.Drawing.Color.White;
            this.lbl_Buscar.Location = new System.Drawing.Point(130, 13);
            this.lbl_Buscar.Name = "lbl_Buscar";
            this.lbl_Buscar.Size = new System.Drawing.Size(145, 22);
            this.lbl_Buscar.TabIndex = 2;
            this.lbl_Buscar.Text = "Buscar articulo...";
            this.lbl_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(93, 13);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(34, 31);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(28, 27);
            // 
            // txt_buscar
            // 
            this.txt_buscar.BackColor = System.Drawing.Color.SlateBlue;
            this.txt_buscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_buscar.ForeColor = System.Drawing.Color.White;
            this.txt_buscar.Location = new System.Drawing.Point(281, 13);
            this.txt_buscar.Multiline = true;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(437, 21);
            this.txt_buscar.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panelbusqueda
            // 
            this.panelbusqueda.Controls.Add(this.dataGridView1);
            this.panelbusqueda.Location = new System.Drawing.Point(12, 106);
            this.panelbusqueda.Name = "panelbusqueda";
            this.panelbusqueda.Size = new System.Drawing.Size(538, 220);
            this.panelbusqueda.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(538, 220);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnvolverArticulo
            // 
            this.btnvolverArticulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnvolverArticulo.BackgroundImage")));
            this.btnvolverArticulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnvolverArticulo.FlatAppearance.BorderSize = 0;
            this.btnvolverArticulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnvolverArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnvolverArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvolverArticulo.Location = new System.Drawing.Point(667, 314);
            this.btnvolverArticulo.Name = "btnvolverArticulo";
            this.btnvolverArticulo.Size = new System.Drawing.Size(145, 58);
            this.btnvolverArticulo.TabIndex = 13;
            this.btnvolverArticulo.UseVisualStyleBackColor = true;
            // 
            // AgregariconoPc
            // 
            this.AgregariconoPc.Image = ((System.Drawing.Image)(resources.GetObject("AgregariconoPc.Image")));
            this.AgregariconoPc.Location = new System.Drawing.Point(610, 115);
            this.AgregariconoPc.Name = "AgregariconoPc";
            this.AgregariconoPc.Size = new System.Drawing.Size(262, 193);
            this.AgregariconoPc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AgregariconoPc.TabIndex = 12;
            this.AgregariconoPc.TabStop = false;
            // 
            // btnMostrartodo
            // 
            this.btnMostrartodo.FlatAppearance.BorderSize = 0;
            this.btnMostrartodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrartodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrartodo.ForeColor = System.Drawing.Color.Black;
            this.btnMostrartodo.Location = new System.Drawing.Point(740, 48);
            this.btnMostrartodo.Name = "btnMostrartodo";
            this.btnMostrartodo.Size = new System.Drawing.Size(141, 35);
            this.btnMostrartodo.TabIndex = 13;
            this.btnMostrartodo.Text = "Mostrar todos";
            this.btnMostrartodo.UseVisualStyleBackColor = true;
            // 
            // BuscarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(884, 749);
            this.Controls.Add(this.btnvolverArticulo);
            this.Controls.Add(this.AgregariconoPc);
            this.Controls.Add(this.panelbusqueda);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BuscarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarArticulo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelbusqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox AgregariconoPc;
        private System.Windows.Forms.Button btnMostrartodo;
    }
}