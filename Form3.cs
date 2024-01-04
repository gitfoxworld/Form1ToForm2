using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Form1ToForm2
{
    public partial class Form3 : Form
    {
        public static Form3 instance;
        public DataGridView DGV1;
        public Form3()
        {
            
            InitializeComponent();
            instance = this;
            DGV1= dataGridView1;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
           frm.ShowDialog(this);

          

        }
    }
}
