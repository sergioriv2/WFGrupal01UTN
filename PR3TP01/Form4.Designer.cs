
namespace PR3TP01
{
    partial class Ejercicio3
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
			this.gbEstadocivil = new System.Windows.Forms.GroupBox();
			this.rbSoltero = new System.Windows.Forms.RadioButton();
			this.rbCasado = new System.Windows.Forms.RadioButton();
			this.gbSexo = new System.Windows.Forms.GroupBox();
			this.rbMasculino = new System.Windows.Forms.RadioButton();
			this.rbFemenino = new System.Windows.Forms.RadioButton();
			this.clbOpciones = new System.Windows.Forms.CheckedListBox();
			this.btnMostrar = new System.Windows.Forms.Button();
			this.lblElegidos = new System.Windows.Forms.Label();
			this.lblElementos = new System.Windows.Forms.Label();
			this.gbEstadocivil.SuspendLayout();
			this.gbSexo.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbEstadocivil
			// 
			this.gbEstadocivil.Controls.Add(this.rbSoltero);
			this.gbEstadocivil.Controls.Add(this.rbCasado);
			this.gbEstadocivil.Location = new System.Drawing.Point(258, 33);
			this.gbEstadocivil.Name = "gbEstadocivil";
			this.gbEstadocivil.Size = new System.Drawing.Size(171, 83);
			this.gbEstadocivil.TabIndex = 0;
			this.gbEstadocivil.TabStop = false;
			this.gbEstadocivil.Text = "Estado civil";
			this.gbEstadocivil.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// rbSoltero
			// 
			this.rbSoltero.AutoSize = true;
			this.rbSoltero.Location = new System.Drawing.Point(51, 44);
			this.rbSoltero.Name = "rbSoltero";
			this.rbSoltero.Size = new System.Drawing.Size(58, 17);
			this.rbSoltero.TabIndex = 2;
			this.rbSoltero.Text = "Soltero";
			this.rbSoltero.UseVisualStyleBackColor = true;
			// 
			// rbCasado
			// 
			this.rbCasado.AutoSize = true;
			this.rbCasado.Checked = true;
			this.rbCasado.Location = new System.Drawing.Point(51, 21);
			this.rbCasado.Name = "rbCasado";
			this.rbCasado.Size = new System.Drawing.Size(61, 17);
			this.rbCasado.TabIndex = 0;
			this.rbCasado.TabStop = true;
			this.rbCasado.Text = "Casado";
			this.rbCasado.UseVisualStyleBackColor = true;
			// 
			// gbSexo
			// 
			this.gbSexo.Controls.Add(this.rbMasculino);
			this.gbSexo.Controls.Add(this.rbFemenino);
			this.gbSexo.Location = new System.Drawing.Point(33, 33);
			this.gbSexo.Name = "gbSexo";
			this.gbSexo.Size = new System.Drawing.Size(169, 83);
			this.gbSexo.TabIndex = 1;
			this.gbSexo.TabStop = false;
			this.gbSexo.Text = "Sexo";
			// 
			// rbMasculino
			// 
			this.rbMasculino.AutoSize = true;
			this.rbMasculino.Location = new System.Drawing.Point(45, 44);
			this.rbMasculino.Name = "rbMasculino";
			this.rbMasculino.Size = new System.Drawing.Size(73, 17);
			this.rbMasculino.TabIndex = 1;
			this.rbMasculino.Text = "Masculino";
			this.rbMasculino.UseVisualStyleBackColor = true;
			// 
			// rbFemenino
			// 
			this.rbFemenino.AutoSize = true;
			this.rbFemenino.Checked = true;
			this.rbFemenino.Location = new System.Drawing.Point(45, 21);
			this.rbFemenino.Name = "rbFemenino";
			this.rbFemenino.Size = new System.Drawing.Size(71, 17);
			this.rbFemenino.TabIndex = 0;
			this.rbFemenino.TabStop = true;
			this.rbFemenino.Text = "Femenino";
			this.rbFemenino.UseVisualStyleBackColor = true;
			// 
			// clbOpciones
			// 
			this.clbOpciones.FormattingEnabled = true;
			this.clbOpciones.Items.AddRange(new object[] {
            "Data entry",
            "Operador de PC",
            "Programador",
            "Reparador ",
            "Reparador de PC",
            "Tester"});
			this.clbOpciones.Location = new System.Drawing.Point(128, 143);
			this.clbOpciones.Name = "clbOpciones";
			this.clbOpciones.Size = new System.Drawing.Size(197, 124);
			this.clbOpciones.TabIndex = 2;
			// 
			// btnMostrar
			// 
			this.btnMostrar.Location = new System.Drawing.Point(128, 290);
			this.btnMostrar.Name = "btnMostrar";
			this.btnMostrar.Size = new System.Drawing.Size(197, 28);
			this.btnMostrar.TabIndex = 3;
			this.btnMostrar.Text = "Mostrar lo que se selecciono";
			this.btnMostrar.UseVisualStyleBackColor = true;
			this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
			// 
			// lblElegidos
			// 
			this.lblElegidos.AutoSize = true;
			this.lblElegidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblElegidos.Location = new System.Drawing.Point(12, 342);
			this.lblElegidos.Name = "lblElegidos";
			this.lblElegidos.Size = new System.Drawing.Size(355, 20);
			this.lblElegidos.TabIndex = 4;
			this.lblElegidos.Text = "Usted selecciono los siguientes elementos:";
			// 
			// lblElementos
			// 
			this.lblElementos.AutoSize = true;
			this.lblElementos.Location = new System.Drawing.Point(125, 372);
			this.lblElementos.Name = "lblElementos";
			this.lblElementos.Size = new System.Drawing.Size(0, 13);
			this.lblElementos.TabIndex = 5;
			// 
			// Ejercicio3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(466, 475);
			this.Controls.Add(this.lblElementos);
			this.Controls.Add(this.lblElegidos);
			this.Controls.Add(this.btnMostrar);
			this.Controls.Add(this.clbOpciones);
			this.Controls.Add(this.gbSexo);
			this.Controls.Add(this.gbEstadocivil);
			this.Name = "Ejercicio3";
			this.Text = "EjerciciosParaParcial3cs";
			this.Load += new System.EventHandler(this.Form4_Load);
			this.gbEstadocivil.ResumeLayout(false);
			this.gbEstadocivil.PerformLayout();
			this.gbSexo.ResumeLayout(false);
			this.gbSexo.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEstadocivil;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.RadioButton rbSoltero;
        private System.Windows.Forms.RadioButton rbCasado;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.CheckedListBox clbOpciones;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblElegidos;
		private System.Windows.Forms.Label lblElementos;
	}
}