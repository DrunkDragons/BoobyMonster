using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoobyTrap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LL_Click(object sender, EventArgs e)
        {
            LooseLeaf frm = new LooseLeaf();
            frm.Show();
        }

        private void L_Click(object sender, EventArgs e)
        {
            List frm = new List();
            frm.Show();
        }

        private void C_Click(object sender, EventArgs e)
        {
            Calculator frm = new Calculator();
            frm.Show();
        }
    }
}