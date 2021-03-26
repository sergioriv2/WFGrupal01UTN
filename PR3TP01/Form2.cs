using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

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
                MessageBox.Show("No se permiten valores repetidos", "ERROR");
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
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnError(sender, (EventArgs)e);
            }
        }

        private void lbxNombres_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPasarNombre_Click(object sender, EventArgs e)
        {
            ArrayList tmpArr = new ArrayList();

            foreach (String aux in lbxNombres.SelectedItems)    // Pasaje del primer listbox al segundo, ademas de agregar los nombres
                                                                // a un array temp para borrarlos
            {
                lbxNombres2.Items.Add(aux);
                tmpArr.Add(aux);
            }

            foreach (object obj in tmpArr.ToArray())    // Eliminar nombres de el listBox mediante el temp Array
            {
                lbxNombres.Items.Remove(obj);
            }
        }

        private void btnPasarTodos_Click(object sender, EventArgs e)
        {
            lbxNombres2.Items.AddRange(lbxNombres.Items);
            lbxNombres.Items.Clear();
        }
    }
}
