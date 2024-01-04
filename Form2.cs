using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1ToForm2
{
    public partial class Form2 : Form
    {
        public static Form2 instance;

        public Form2()
        {
            InitializeComponent();
         instance = this;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.instance.tb1.Text = "This is from Form2";
            Form1.instance.tb2.Text = "Hello World"; 
            Form1.instance.tb3.Text = "Hello my country";
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }
    }
}
