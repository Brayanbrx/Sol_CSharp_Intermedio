namespace Presentacion
{
    partial class frmEncuesta
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
            this.cbVFP = new System.Windows.Forms.CheckBox();
            this.cbCSharp = new System.Windows.Forms.CheckBox();
            this.cbNet = new System.Windows.Forms.CheckBox();
            this.lbCursosDisponibles = new System.Windows.Forms.Label();
            this.cbJava = new System.Windows.Forms.CheckBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lbResultado = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.rbtnPresencial = new System.Windows.Forms.RadioButton();
            this.rbtnVirtual = new System.Windows.Forms.RadioButton();
            this.lbModalidadAprendizaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbVFP
            // 
            this.cbVFP.AutoSize = true;
            this.cbVFP.Location = new System.Drawing.Point(109, 97);
            this.cbVFP.Name = "cbVFP";
            this.cbVFP.Size = new System.Drawing.Size(90, 17);
            this.cbVFP.TabIndex = 0;
            this.cbVFP.Text = "Visual FoxPro";
            this.cbVFP.UseVisualStyleBackColor = true;
            // 
            // cbCSharp
            // 
            this.cbCSharp.AutoSize = true;
            this.cbCSharp.Location = new System.Drawing.Point(109, 142);
            this.cbCSharp.Name = "cbCSharp";
            this.cbCSharp.Size = new System.Drawing.Size(81, 17);
            this.cbCSharp.TabIndex = 1;
            this.cbCSharp.Text = "C Sharp C#";
            this.cbCSharp.UseVisualStyleBackColor = true;
            // 
            // cbNet
            // 
            this.cbNet.AutoSize = true;
            this.cbNet.Location = new System.Drawing.Point(109, 184);
            this.cbNet.Name = "cbNet";
            this.cbNet.Size = new System.Drawing.Size(65, 17);
            this.cbNet.TabIndex = 2;
            this.cbNet.Text = "VB.NET";
            this.cbNet.UseVisualStyleBackColor = true;
            // 
            // lbCursosDisponibles
            // 
            this.lbCursosDisponibles.AutoSize = true;
            this.lbCursosDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCursosDisponibles.ForeColor = System.Drawing.Color.Brown;
            this.lbCursosDisponibles.Location = new System.Drawing.Point(93, 55);
            this.lbCursosDisponibles.Name = "lbCursosDisponibles";
            this.lbCursosDisponibles.Size = new System.Drawing.Size(272, 18);
            this.lbCursosDisponibles.TabIndex = 3;
            this.lbCursosDisponibles.Text = "Cursos Disponibles en Promoción:";
            // 
            // cbJava
            // 
            this.cbJava.AutoSize = true;
            this.cbJava.Location = new System.Drawing.Point(109, 226);
            this.cbJava.Name = "cbJava";
            this.cbJava.Size = new System.Drawing.Size(49, 17);
            this.cbJava.TabIndex = 4;
            this.cbJava.Text = "Java";
            this.cbJava.UseVisualStyleBackColor = true;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(371, 327);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(434, 142);
            this.txtResultado.TabIndex = 5;
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.Location = new System.Drawing.Point(368, 297);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(311, 18);
            this.lbResultado.TabIndex = 6;
            this.lbResultado.Text = "Resultado de los cursos seleccionados:";
            // 
            // btnProcesar
            // 
            this.btnProcesar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProcesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.Location = new System.Drawing.Point(72, 327);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(178, 96);
            this.btnProcesar.TabIndex = 7;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = false;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // rbtnPresencial
            // 
            this.rbtnPresencial.AutoSize = true;
            this.rbtnPresencial.Location = new System.Drawing.Point(401, 186);
            this.rbtnPresencial.Name = "rbtnPresencial";
            this.rbtnPresencial.Size = new System.Drawing.Size(74, 17);
            this.rbtnPresencial.TabIndex = 8;
            this.rbtnPresencial.TabStop = true;
            this.rbtnPresencial.Text = "Presencial";
            this.rbtnPresencial.UseVisualStyleBackColor = true;
            // 
            // rbtnVirtual
            // 
            this.rbtnVirtual.AutoSize = true;
            this.rbtnVirtual.Location = new System.Drawing.Point(538, 184);
            this.rbtnVirtual.Name = "rbtnVirtual";
            this.rbtnVirtual.Size = new System.Drawing.Size(54, 17);
            this.rbtnVirtual.TabIndex = 9;
            this.rbtnVirtual.TabStop = true;
            this.rbtnVirtual.Text = "Virtual";
            this.rbtnVirtual.UseVisualStyleBackColor = true;
            // 
            // lbModalidadAprendizaje
            // 
            this.lbModalidadAprendizaje.AutoSize = true;
            this.lbModalidadAprendizaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModalidadAprendizaje.Location = new System.Drawing.Point(382, 139);
            this.lbModalidadAprendizaje.Name = "lbModalidadAprendizaje";
            this.lbModalidadAprendizaje.Size = new System.Drawing.Size(349, 18);
            this.lbModalidadAprendizaje.TabIndex = 10;
            this.lbModalidadAprendizaje.Text = "En que modalidad de aprendizaje te gustaria?";
            // 
            // frmEncuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 490);
            this.Controls.Add(this.lbModalidadAprendizaje);
            this.Controls.Add(this.rbtnVirtual);
            this.Controls.Add(this.rbtnPresencial);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.cbJava);
            this.Controls.Add(this.lbCursosDisponibles);
            this.Controls.Add(this.cbNet);
            this.Controls.Add(this.cbCSharp);
            this.Controls.Add(this.cbVFP);
            this.Name = "frmEncuesta";
            this.Text = "ENCUESTA DE CURSOS DISPONIBLES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbVFP;
        private System.Windows.Forms.CheckBox cbCSharp;
        private System.Windows.Forms.CheckBox cbNet;
        private System.Windows.Forms.Label lbCursosDisponibles;
        private System.Windows.Forms.CheckBox cbJava;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.RadioButton rbtnPresencial;
        private System.Windows.Forms.RadioButton rbtnVirtual;
        private System.Windows.Forms.Label lbModalidadAprendizaje;
    }
}