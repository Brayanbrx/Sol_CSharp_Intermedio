namespace Presentacion
{
    partial class frmNumericUpDown
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
            this.numDia = new System.Windows.Forms.NumericUpDown();
            this.lbDiaDeSemana = new System.Windows.Forms.Label();
            this.btnMostrarDia = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numDia)).BeginInit();
            this.SuspendLayout();
            // 
            // numDia
            // 
            this.numDia.Location = new System.Drawing.Point(36, 52);
            this.numDia.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numDia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDia.Name = "numDia";
            this.numDia.ReadOnly = true;
            this.numDia.Size = new System.Drawing.Size(119, 20);
            this.numDia.TabIndex = 0;
            this.numDia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbDiaDeSemana
            // 
            this.lbDiaDeSemana.AutoSize = true;
            this.lbDiaDeSemana.Location = new System.Drawing.Point(54, 24);
            this.lbDiaDeSemana.Name = "lbDiaDeSemana";
            this.lbDiaDeSemana.Size = new System.Drawing.Size(92, 13);
            this.lbDiaDeSemana.TabIndex = 1;
            this.lbDiaDeSemana.Text = "Dia de la semana:";
            this.lbDiaDeSemana.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnMostrarDia
            // 
            this.btnMostrarDia.Location = new System.Drawing.Point(36, 88);
            this.btnMostrarDia.Name = "btnMostrarDia";
            this.btnMostrarDia.Size = new System.Drawing.Size(119, 23);
            this.btnMostrarDia.TabIndex = 2;
            this.btnMostrarDia.Text = "Mostrar dia en Texto";
            this.btnMostrarDia.UseVisualStyleBackColor = true;
            this.btnMostrarDia.Click += new System.EventHandler(this.btnMostrarDia_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(193, 71);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(162, 20);
            this.txtResultado.TabIndex = 3;
            // 
            // frmNumericUpDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 265);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnMostrarDia);
            this.Controls.Add(this.lbDiaDeSemana);
            this.Controls.Add(this.numDia);
            this.Name = "frmNumericUpDown";
            this.Text = "frmNumericUpDown";
            ((System.ComponentModel.ISupportInitialize)(this.numDia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numDia;
        private System.Windows.Forms.Label lbDiaDeSemana;
        private System.Windows.Forms.Button btnMostrarDia;
        private System.Windows.Forms.TextBox txtResultado;
    }
}