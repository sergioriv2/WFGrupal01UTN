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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            string Elemento;
            Elemento = txtbox_Nombre.Text.Trim() + " " + txtbox_Apellido.Text.Trim();

            txtbox_Nombre.Focus();
            if (txtbox_Apellido.Text.Trim() != "" && txtbox_Nombre.Text.Trim() != "")
            {    
                if (!lbx_Elementos.Items.Contains(Elemento))
                {
                    lbx_Elementos.Items.Add(Elemento); //Agrego a la listbox el nombre (espacio) apellido
                }
                else
                {
                    MessageBox.Show("No se aceptan Nombres y Apellidos repetidos");
                    txtbox_Nombre.Focus();
                }
                txtbox_Apellido.Text = "";
                txtbox_Nombre.Text = "";
            }
            else {
                if (txtbox_Nombre.Text.Trim() == "")
                {
                    MessageBox.Show("No se aceptan nombres en blanco", "ERROR");
                    txtbox_Nombre.Text = "";
                    txtbox_Nombre.Focus();
                }
                if (txtbox_Apellido.Text.Trim() == "")
                {
                    MessageBox.Show("No se aceptan apellidos en blanco", "ERROR");
                    txtbox_Apellido.Text = "";
                    txtbox_Apellido.Focus();
                }
            }

        }

        private void btn_Borrar_Click(object sender, EventArgs e)
        {

            if (lbx_Elementos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecciona al menos un elemento", "ERROR");
            }
            else
            {
                ArrayList tmpArr = new ArrayList();

                foreach (String aux in lbx_Elementos.SelectedItems)    // Pasaje del primer listbox al segundo, ademas de agregar los nombres
                                                                       // a un array temp para borrarlos
                {
                    tmpArr.Add(aux);
                }

                foreach (object obj in tmpArr.ToArray())    // Eliminar nombres de el listBox mediante el temp Array
                {
                    lbx_Elementos.Items.Remove(obj);
                }
            }
        }

   

        private void txtbox_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btn_Agregar_Click(sender, (EventArgs)e);
            }

        }

        private void txtbox_Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btn_Agregar_Click(sender, (EventArgs)e);
                //txtbox_Nombre.Focus();
            }
        }
	}
}
