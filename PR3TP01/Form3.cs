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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (txtbox_Nombre.Text == "")
            {
                MessageBox.Show("No se aceptan nombres en blanco", "ERROR");
            }
            else if(txtbox_Apellido.Text == "")
            {
                MessageBox.Show("No se aceptan apellidos en blanco", "ERROR");
            }
            else
            {
                lbx_Elementos.Items.Add(txtbox_Nombre.Text.Trim() + " " + txtbox_Apellido.Text.Trim()); //Agrego a la listbox el nombre (espacio) apellido
                txtbox_Apellido.Text = "";
                txtbox_Nombre.Text = "";
            }
            
        }

        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            lbx_Elementos.Items.Clear();
        }
    }
}
