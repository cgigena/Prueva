using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iniciaciando_a_git
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
            


        }

        private void Button2_Click(object sender, EventArgs e)
        {
          
            panel2.BringToFront();
        }

        private void BtnComoEstas_Click(object sender, EventArgs e)
        {
            panel3.BringToFront();
        }
    }
}
