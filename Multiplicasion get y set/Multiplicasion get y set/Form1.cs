using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiplicasion_get_y_set
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            multiplicaclass mul = new multiplicaclass();
            mul.N11=int.Parse(textBox1.Text);
            mul.N21=int.Parse(textBox2.Text);
            textBox3.Text = mul.multiplica().ToString();
        }
    }
}
