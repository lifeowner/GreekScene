using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GreekScene_API_V2;

namespace example_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GreekScene_API_V2.sign_in_form RequiredSignIn = new GreekScene_API_V2.sign_in_form();
            RequiredSignIn.ShowDialog();
        }
    }
}
