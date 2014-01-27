using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Web_Browser
{
    public partial class source : Form
    {
        public source()
        {
            InitializeComponent();

        }

        public void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        // Property to access the control inside the form 
        public string srccode
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }








       
    }
}
