using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SortComparison
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "asldkmakmclaknlasklaksdn\nalskdmlaksdlakslkaf\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain newForm = new frmMain(this);
            this.Hide();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }


    }
}
