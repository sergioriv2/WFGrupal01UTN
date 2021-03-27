using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR3TP01
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

		private void btnMostrar_Click(object sender, EventArgs e)
		{
            lblElementos.Text = "";
            clbOpciones.CheckOnClick = false;
            lblElementos.Text += 
                "Sexo: " + gbSexo.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text + "    "+
                "Estado civil: " + gbEstadocivil.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text+
                "\r\n";
            foreach (string a in clbOpciones.CheckedItems) {
                
                lblElementos.Text += "               -" + (a) + "\r\n"; 
            }
        }
	}
}
