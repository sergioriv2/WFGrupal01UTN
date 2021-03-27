
namespace PR3TP01
{
    partial class Ejercicio2
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
            this.panel_Ingresodatos = new System.Windows.Forms.Panel();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.txtbox_Apellido = new System.Windows.Forms.TextBox();
            this.txtbox_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_titulo1 = new System.Windows.Forms.Label();
            this.panel_Elementos = new System.Windows.Forms.Panel();
            this.lbx_Elementos = new System.Windows.Forms.ListBox();
            this.btn_Borrar = new System.Windows.Forms.Button();
            this.lbl_titulo2 = new System.Windows.Forms.Label();
            this.panel_Ingresodatos.SuspendLayout();
            this.panel_Elementos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Ingresodatos
            // 
            this.panel_Ingresodatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Ingresodatos.Controls.Add(this.btn_Agregar);
            this.panel_Ingresodatos.Controls.Add(this.txtbox_Apellido);
            this.panel_Ingresodatos.Controls.Add(this.txtbox_Nombre);
            this.panel_Ingresodatos.Controls.Add(this.lbl_apellido);
            this.panel_Ingresodatos.Controls.Add(this.lbl_nombre);
            this.panel_Ingresodatos.Controls.Add(this.lbl_titulo1);
            this.panel_Ingresodatos.Location = new System.Drawing.Point(12, 28);
            this.panel_Ingresodatos.Name = "panel_Ingresodatos";
            this.panel_Ingresodatos.Size = new System.Drawing.Size(345, 410);
            this.panel_Ingresodatos.TabIndex = 0;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(117, 210);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(110, 45);
            this.btn_Agregar.TabIndex = 5;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // txtbox_Apellido
            // 
            this.txtbox_Apellido.Location = new System.Drawing.Point(104, 170);
            this.txtbox_Apellido.Name = "txtbox_Apellido";
            this.txtbox_Apellido.Size = new System.Drawing.Size(138, 20);
            this.txtbox_Apellido.TabIndex = 4;
            this.txtbox_Apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_Apellido_KeyPress);
            // 
            // txtbox_Nombre
            // 
            this.txtbox_Nombre.Location = new System.Drawing.Point(104, 141);
            this.txtbox_Nombre.Name = "txtbox_Nombre";
            this.txtbox_Nombre.Size = new System.Drawing.Size(138, 20);
            this.txtbox_Nombre.TabIndex = 3;
            this.txtbox_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_Nombre_KeyPress);
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido.Location = new System.Drawing.Point(14, 169);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(77, 19);
            this.lbl_apellido.TabIndex = 2;
            this.lbl_apellido.Text = "Apellido:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(14, 140);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(76, 19);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // lbl_titulo1
            // 
            this.lbl_titulo1.AutoSize = true;
            this.lbl_titulo1.Location = new System.Drawing.Point(-2, 0);
            this.lbl_titulo1.Name = "lbl_titulo1";
            this.lbl_titulo1.Size = new System.Drawing.Size(86, 13);
            this.lbl_titulo1.TabIndex = 0;
            this.lbl_titulo1.Text = "Ingreso de datos";
            // 
            // panel_Elementos
            // 
            this.panel_Elementos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Elementos.Controls.Add(this.lbx_Elementos);
            this.panel_Elementos.Controls.Add(this.btn_Borrar);
            this.panel_Elementos.Controls.Add(this.lbl_titulo2);
            this.panel_Elementos.Location = new System.Drawing.Point(401, 28);
            this.panel_Elementos.Name = "panel_Elementos";
            this.panel_Elementos.Size = new System.Drawing.Size(375, 410);
            this.panel_Elementos.TabIndex = 1;
            // 
            // lbx_Elementos
            // 
            this.lbx_Elementos.FormattingEnabled = true;
            this.lbx_Elementos.Location = new System.Drawing.Point(33, 36);
            this.lbx_Elementos.Name = "lbx_Elementos";
            this.lbx_Elementos.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbx_Elementos.Size = new System.Drawing.Size(325, 290);
            this.lbx_Elementos.TabIndex = 7;
            // 
            // btn_Borrar
            // 
            this.btn_Borrar.Location = new System.Drawing.Point(139, 336);
            this.btn_Borrar.Name = "btn_Borrar";
            this.btn_Borrar.Size = new System.Drawing.Size(110, 35);
            this.btn_Borrar.TabIndex = 6;
            this.btn_Borrar.Text = "Borrar";
            this.btn_Borrar.UseVisualStyleBackColor = true;
            this.btn_Borrar.Click += new System.EventHandler(this.btn_Borrar_Click);
            // 
            // lbl_titulo2
            // 
            this.lbl_titulo2.AutoSize = true;
            this.lbl_titulo2.Location = new System.Drawing.Point(3, 0);
            this.lbl_titulo2.Name = "lbl_titulo2";
            this.lbl_titulo2.Size = new System.Drawing.Size(56, 13);
            this.lbl_titulo2.TabIndex = 1;
            this.lbl_titulo2.Text = "Elementos";
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_Elementos);
            this.Controls.Add(this.panel_Ingresodatos);
            this.Name = "Ejercicio2";
            this.Text = "EjerciciosParcial2";
            this.Load += new System.EventHandler(this.Ejercicio2_Load);
            this.panel_Ingresodatos.ResumeLayout(false);
            this.panel_Ingresodatos.PerformLayout();
            this.panel_Elementos.ResumeLayout(false);
            this.panel_Elementos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Ingresodatos;
        private System.Windows.Forms.Label lbl_titulo1;
        private System.Windows.Forms.Panel panel_Elementos;
        private System.Windows.Forms.Label lbl_titulo2;
        private System.Windows.Forms.TextBox txtbox_Apellido;
        private System.Windows.Forms.TextBox txtbox_Nombre;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.ListBox lbx_Elementos;
        private System.Windows.Forms.Button btn_Borrar;
    }
}