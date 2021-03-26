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
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void btnError(object sender, EventArgs e)
        {
            if(txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Este campo no puede estar vacio", "ERROR");               
            }
            else if (lbxNombres.Items.Contains(txtNombre.Text.Trim()))
            {
                MessageBox.Show("Duplicado", "ERROR");
            }

            else
            {
                lbxNombres.Items.Add(txtNombre.Text.Trim());          
            }
            
            txtNombre.Text = "";
        }

        private void txtSoloLetras(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }
    }
}
