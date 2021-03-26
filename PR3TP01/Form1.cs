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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Ej1_Click(object sender, EventArgs e)
        {
            Ejercicio1 Ejer1 = new Ejercicio1();
            Ejer1.Show();

        }

        private void btn_Ej2_Click(object sender, EventArgs e)
        {
            Ejercicio2 Ejer2 = new Ejercicio2();
            Ejer2.Show();
        }

        private void btn_Ej3_Click(object sender, EventArgs e)
        {
            Ejercicio3 Ejer3 = new Ejercicio3();
            Ejer3.Show();
        }
    }
}
