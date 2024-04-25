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
            this.datalistadoArticulos = new System.Windows.Forms.DataGridView();
            this.panelBtnguardarpersonal = new System.Windows.Forms.FlowLayoutPanel();
            this.btnguardarpersonal = new System.Windows.Forms.Button();
            this.btnguardarcambiospersonal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistadoArticulos)).BeginInit();
            this.panelBtnguardarpersonal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 66);
            this.panel1.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "ELIMINAR ARTÍCULO";
            // 
            // datalistadoArticulos
            // 
            this.datalistadoArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistadoArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datalistadoArticulos.Location = new System.Drawing.Point(12, 72);
            this.datalistadoArticulos.Name = "datalistadoArticulos";
            this.datalistadoArticulos.RowHeadersWidth = 51;
            this.datalistadoArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistadoArticulos.Size = new System.Drawing.Size(755, 273);
            this.datalistadoArticulos.TabIndex = 40;
            // 
            // panelBtnguardarpersonal
            // 
            this.panelBtnguardarpersonal.Controls.Add(this.btnguardarpersonal);
            this.panelBtnguardarpersonal.Controls.Add(this.btnguardarcambiospersonal);
            this.panelBtnguardarpersonal.Location = new System.Drawing.Point(260, 351);
            this.panelBtnguardarpersonal.Name = "panelBtnguardarpersonal";
            this.panelBtnguardarpersonal.Size = new System.Drawing.Size(261, 71);
            this.panelBtnguardarpersonal.TabIndex = 41;
            // 
            // btnguardarpersonal
            // 
            this.btnguardarpersonal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnguardarpersonal.BackgroundImage")));
            this.btnguardarpersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnguardarpersonal.FlatAppearance.BorderSize = 0;
            this.btnguardarpersonal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnguardarpersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnguardarpersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardarpersonal.Location = new System.Drawing.Point(3, 3);
            this.btnguardarpersonal.Name = "btnguardarpersonal";
            this.btnguardarpersonal.Size = new System.Drawing.Size(121, 52);
            this.btnguardarpersonal.TabIndex = 0;
            this.btnguardarpersonal.UseVisualStyleBackColor = true;
            // 
            // btnguardarcambiospersonal
            // 
            this.btnguardarcambiospersonal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnguardarcambiospersonal.BackgroundImage")));
            this.btnguardarcambiospersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnguardarcambiospersonal.FlatAppearance.BorderSize = 0;
            this.btnguardarcambiospersonal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnguardarcambiospersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnguardarcambiospersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardarcambiospersonal.Location = new System.Drawing.Point(130, 3);
            this.btnguardarcambiospersonal.Name = "btnguardarcambiospersonal";
            this.btnguardarcambiospersonal.Size = new System.Drawing.Size(118, 52);
            this.btnguardarcambiospersonal.TabIndex = 1;
            this.btnguardarcambiospersonal.UseVisualStyleBackColor = true;
            // 
            // Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 432);
            this.Controls.Add(this.panelBtnguardarpersonal);
            this.Controls.Add(this.datalistadoArticulos);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Eliminar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar";
            this.Load += new System.EventHandler(this.Eliminar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistadoArticulos)).EndInit();
            this.panelBtnguardarpersonal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datalistadoArticulos;
        private System.Windows.Forms.FlowLayoutPanel panelBtnguardarpersonal;
        private System.Windows.Forms.Button btnguardarpersonal;
        private System.Windows.Forms.Button btnguardarcambiospersonal;
    }
}