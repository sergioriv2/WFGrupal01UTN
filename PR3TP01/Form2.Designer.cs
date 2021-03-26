
namespace PR3TP01
{
    partial class Ejercicio1
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbxNombres = new System.Windows.Forms.ListBox();
            this.lbxNombres2 = new System.Windows.Forms.ListBox();
            this.btnPasarNombre = new System.Windows.Forms.Button();
            this.btnPasarTodos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(24, 28);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(149, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Ingrese un nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(179, 27);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(262, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoloLetras);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(479, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnError);
            // 
            // lbxNombres
            // 
            this.lbxNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxNombres.FormattingEnabled = true;
            this.lbxNombres.Location = new System.Drawing.Point(27, 82);
            this.lbxNombres.Name = "lbxNombres";
            this.lbxNombres.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxNombres.Size = new System.Drawing.Size(167, 212);
            this.lbxNombres.TabIndex = 3;
            this.lbxNombres.Click += new System.EventHandler(this.lbxNombres_Click);
            // 
            // lbxNombres2
            // 
            this.lbxNombres2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxNombres2.FormattingEnabled = true;
            this.lbxNombres2.Location = new System.Drawing.Point(356, 82);
            this.lbxNombres2.Name = "lbxNombres2";
            this.lbxNombres2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxNombres2.Size = new System.Drawing.Size(190, 212);
            this.lbxNombres2.TabIndex = 4;
            // 
            // btnPasarNombre
            // 
            this.btnPasarNombre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPasarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasarNombre.Location = new System.Drawing.Point(233, 115);
            this.btnPasarNombre.Name = "btnPasarNombre";
            this.btnPasarNombre.Size = new System.Drawing.Size(75, 47);
            this.btnPasarNombre.TabIndex = 5;
            this.btnPasarNombre.Text = ">";
            this.btnPasarNombre.UseVisualStyleBackColor = true;
            this.btnPasarNombre.Click += new System.EventHandler(this.btnPasarNombre_Click);
            // 
            // btnPasarTodos
            // 
            this.btnPasarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPasarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasarTodos.Location = new System.Drawing.Point(233, 184);
            this.btnPasarTodos.Name = "btnPasarTodos";
            this.btnPasarTodos.Size = new System.Drawing.Size(75, 47);
            this.btnPasarTodos.TabIndex = 6;
            this.btnPasarTodos.Text = ">>";
            this.btnPasarTodos.UseVisualStyleBackColor = true;
            this.btnPasarTodos.Click += new System.EventHandler(this.btnPasarTodos_Click);
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.btnPasarTodos);
            this.Controls.Add(this.btnPasarNombre);
            this.Controls.Add(this.lbxNombres2);
            this.Controls.Add(this.lbxNombres);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "Ejercicio1";
            this.Text = "frmNombres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbxNombres;
        private System.Windows.Forms.ListBox lbxNombres2;
        private System.Windows.Forms.Button btnPasarNombre;
        private System.Windows.Forms.Button btnPasarTodos;
    }
}