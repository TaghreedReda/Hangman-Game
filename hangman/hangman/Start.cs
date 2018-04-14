using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hangman
{
   
   

    public partial class Start : Form
    {
        public static int counter;
        public Start()
        {
            InitializeComponent();
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            counter = 1;
            form1 d = new form1();
            d.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            counter = 3;
            form1 m = new form1();
            m.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            counter = 2;
            form1 s = new form1();
            s.Show();
            this.Hide();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form2 s = new Form2();
            s.Show();
            this.Hide();
        }

       

    }
}
