namespace TP2_WinForm.VentanaFormulario
{
    partial class Eliminar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eliminar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.datalistadoArticulosEliminar = new System.Windows.Forms.DataGridView();
            this.panelBtnguardarpersonal = new System.Windows.Forms.FlowLayoutPanel();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnguardarcambiospersonal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistadoArticulosEliminar)).BeginInit();
            this.panelBtnguardarpersonal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 102);
            this.panel1.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Underline);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(381, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "ELIMINAR ARTÍCULO";
            // 
            // datalistadoArticulosEliminar
            // 
            this.datalistadoArticulosEliminar.AllowUserToAddRows = false;
            this.datalistadoArticulosEliminar.AllowUserToDeleteRows = false;
            this.datalistadoArticulosEliminar.BackgroundColor = System.Drawing.Color.White;
            this.datalistadoArticulosEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistadoArticulosEliminar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datalistadoArticulosEliminar.Location = new System.Drawing.Point(18, 115);
            this.datalistadoArticulosEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datalistadoArticulosEliminar.Name = "datalistadoArticulosEliminar";
            this.datalistadoArticulosEliminar.ReadOnly = true;
            this.datalistadoArticulosEliminar.RowHeadersWidth = 51;
            this.datalistadoArticulosEliminar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistadoArticulosEliminar.Size = new System.Drawing.Size(1132, 420);
            this.datalistadoArticulosEliminar.TabIndex = 40;
            // 
            // panelBtnguardarpersonal
            // 
            this.panelBtnguardarpersonal.Controls.Add(this.btneliminar);
            this.panelBtnguardarpersonal.Controls.Add(this.btnguardarcambiospersonal);
            this.panelBtnguardarpersonal.Location = new System.Drawing.Point(390, 540);
            this.panelBtnguardarpersonal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelBtnguardarpersonal.Name = "panelBtnguardarpersonal";
            this.panelBtnguardarpersonal.Size = new System.Drawing.Size(392, 109);
            this.panelBtnguardarpersonal.TabIndex = 41;
            // 
            // btneliminar
            // 
            this.btneliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btneliminar.BackgroundImage")));
            this.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btneliminar.FlatAppearance.BorderSize = 0;
            this.btneliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btneliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Location = new System.Drawing.Point(4, 5);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(182, 80);
            this.btneliminar.TabIndex = 0;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnguardarcambiospersonal
            // 
            this.btnguardarcambiospersonal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnguardarcambiospersonal.BackgroundImage")));
            this.btnguardarcambiospersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnguardarcambiospersonal.FlatAppearance.BorderSize = 0;
            this.btnguardarcambiospersonal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnguardarcambiospersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnguardarcambiospersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardarcambiospersonal.Location = new System.Drawing.Point(194, 5);
            this.btnguardarcambiospersonal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnguardarcambiospersonal.Name = "btnguardarcambiospersonal";
            this.btnguardarcambiospersonal.Size = new System.Drawing.Size(177, 80);
            this.btnguardarcambiospersonal.TabIndex = 1;
            this.btnguardarcambiospersonal.UseVisualStyleBackColor = true;
            this.btnguardarcambiospersonal.Click += new System.EventHandler(this.btnguardarcambiospersonal_Click);
            // 
            // Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1168, 677);
            this.Controls.Add(this.panelBtnguardarpersonal);
            this.Controls.Add(this.datalistadoArticulosEliminar);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Eliminar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar artículo";
            this.Load += new System.EventHandler(this.Eliminar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistadoArticulosEliminar)).EndInit();
            this.panelBtnguardarpersonal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datalistadoArticulosEliminar;
        private System.Windows.Forms.FlowLayoutPanel panelBtnguardarpersonal;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnguardarcambiospersonal;
    }
}