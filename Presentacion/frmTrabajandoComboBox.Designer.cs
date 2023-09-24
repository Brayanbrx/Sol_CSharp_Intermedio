namespace Presentacion
{
    partial class frmTrabajandoComboBox
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
            this.lbCursosDisponibles = new System.Windows.Forms.Label();
            this.cboCursosDisponibles = new System.Windows.Forms.ComboBox();
            this.lbCursoSeleccionado = new System.Windows.Forms.Label();
            this.lbCursoNuevo = new System.Windows.Forms.Label();
            this.txtCursoNuevo = new System.Windows.Forms.TextBox();
            this.txtCursoSeleccionado = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCursosDisponibles
            // 
            this.lbCursosDisponibles.AutoSize = true;
            this.lbCursosDisponibles.Location = new System.Drawing.Point(413, 84);
            this.lbCursosDisponibles.Name = "lbCursosDisponibles";
            this.lbCursosDisponibles.Size = new System.Drawing.Size(99, 13);
            this.lbCursosDisponibles.TabIndex = 0;
            this.lbCursosDisponibles.Text = "Cursos Disponibles:";
            // 
            // cboCursosDisponibles
            // 
            this.cboCursosDisponibles.FormattingEnabled = true;
            this.cboCursosDisponibles.Items.AddRange(new object[] {
            "VISUAL FOXPRO",
            "C SHARP",
            "VB.NET"});
            this.cboCursosDisponibles.Location = new System.Drawing.Point(518, 81);
            this.cboCursosDisponibles.Name = "cboCursosDisponibles";
            this.cboCursosDisponibles.Size = new System.Drawing.Size(226, 21);
            this.cboCursosDisponibles.TabIndex = 1;
            this.cboCursosDisponibles.Text = "Seleccione un curso";
            this.cboCursosDisponibles.SelectedIndexChanged += new System.EventHandler(this.cboCursosDisponibles_SelectedIndexChanged);
            // 
            // lbCursoSeleccionado
            // 
            this.lbCursoSeleccionado.AutoSize = true;
            this.lbCursoSeleccionado.Location = new System.Drawing.Point(461, 136);
            this.lbCursoSeleccionado.Name = "lbCursoSeleccionado";
            this.lbCursoSeleccionado.Size = new System.Drawing.Size(105, 13);
            this.lbCursoSeleccionado.TabIndex = 2;
            this.lbCursoSeleccionado.Text = "Curso Seleccionado:";
            // 
            // lbCursoNuevo
            // 
            this.lbCursoNuevo.AutoSize = true;
            this.lbCursoNuevo.Location = new System.Drawing.Point(47, 89);
            this.lbCursoNuevo.Name = "lbCursoNuevo";
            this.lbCursoNuevo.Size = new System.Drawing.Size(77, 13);
            this.lbCursoNuevo.TabIndex = 3;
            this.lbCursoNuevo.Text = "Cursos Nuevo:";
            // 
            // txtCursoNuevo
            // 
            this.txtCursoNuevo.Location = new System.Drawing.Point(130, 86);
            this.txtCursoNuevo.Name = "txtCursoNuevo";
            this.txtCursoNuevo.Size = new System.Drawing.Size(151, 20);
            this.txtCursoNuevo.TabIndex = 4;
            // 
            // txtCursoSeleccionado
            // 
            this.txtCursoSeleccionado.Location = new System.Drawing.Point(464, 152);
            this.txtCursoSeleccionado.Multiline = true;
            this.txtCursoSeleccionado.Name = "txtCursoSeleccionado";
            this.txtCursoSeleccionado.ReadOnly = true;
            this.txtCursoSeleccionado.Size = new System.Drawing.Size(280, 96);
            this.txtCursoSeleccionado.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(130, 126);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(151, 23);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // frmTrabajandoComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtCursoSeleccionado);
            this.Controls.Add(this.txtCursoNuevo);
            this.Controls.Add(this.lbCursoNuevo);
            this.Controls.Add(this.lbCursoSeleccionado);
            this.Controls.Add(this.cboCursosDisponibles);
            this.Controls.Add(this.lbCursosDisponibles);
            this.Name = "frmTrabajandoComboBox";
            this.Text = "frmTrabajandoComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCursosDisponibles;
        private System.Windows.Forms.ComboBox cboCursosDisponibles;
        private System.Windows.Forms.Label lbCursoSeleccionado;
        private System.Windows.Forms.Label lbCursoNuevo;
        private System.Windows.Forms.TextBox txtCursoNuevo;
        private System.Windows.Forms.TextBox txtCursoSeleccionado;
        private System.Windows.Forms.Button btnRegistrar;
    }
}