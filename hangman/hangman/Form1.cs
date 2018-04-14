using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace hangman
{
    public partial class form1 : Form
    {   
        private Bitmap[] Images = { hangman.Properties.Resources._0, hangman.Properties.Resources._1 ,
                                    hangman.Properties.Resources._2, hangman.Properties.Resources._3 , 
                                    hangman.Properties.Resources._4, hangman.Properties.Resources._5 ,
                                    hangman.Properties.Resources._6};
        int ta;
        int counter1;
        public form1()
        {
            InitializeComponent();
            counter1 = Start.counter;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            readfile();
            random();
            showing(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
        
        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }
        

        private string[] used = new string[31];
        private string[] one  = new string[31];
        private string[] two  = new string[31];

        char[] c = { ' ', '\t' }; 

       private void readfile() 
        {
            string[] easy = File.ReadAllLines("easyhangman.txt");
            string[] medium = File.ReadAllLines("mediumhangaman.txt");
            string[] hard = File.ReadAllLines("Hardhangman.txt");

            if (counter1 == 1)
            {
                for (int i = 0; i < 31; i++)
                {
                    used[i] = easy[i];
                }
            }

            else if (counter1 == 2)
            {
                for (int i = 0; i < 31; i++)
                {
                    used[i] = medium[i];
                }
            }

            else if (counter1 == 3)
            {
                for (int i = 0; i < 31; i++)
                {
                    used[i] = hard[i];
                }
            }
            int index = 0;
            while (index < used.Length )
            {
                string[] s = used[index].Split(c);
                one[index] = s[0];
                two[index] = s[1];
                index++;
            }

        }
         int j ;
         private string copy = "";

        private void random()
        {
            Random rand = new Random();
            j = rand.Next(0, one.Length);
            label3.Text = two[j];
            label3.Refresh();

            ta = one[j].Length;
            for (int i = 0; i < ta; i++)
            {
                copy += "_";

            }
            showing();
        }
        private int Wrongs=0;

        private void guess(object sender, EventArgs e)
        {
            Button trying = sender as Button;
            trying.Enabled = false;

            char[] arr = copy.ToCharArray();
            char x = trying.Text.ElementAt(0);

            bool a = false;
            for (int i = 0; i < one[j].Length; i++)
            {
                if (one[j][i] == x)
                {
                    a = true;
                    arr[i] = x;
                }
            }

            if (a == false)
                Wrongs++;

            copy = new string(arr);
            showing();

            if (copy == one[j])
            {
                MessageBox.Show("AWESOME, YOU WON!!!", "WOOOW");

            }
            else if (Wrongs < 6)
                pictureBox1.Image = Images[Wrongs];
            else
            {
                pictureBox1.Image = Images[Wrongs];
                MessageBox.Show("GAME OVER DUDE!!!", "YOU LOST.");
                return;
            }
        }
        private void showing()
        {

            label5.Text = copy;

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e) // reset
        {

            Wrongs = 0;
            pictureBox1.Image = Images[Wrongs];
            form1 NewForm = new form1();
            NewForm.Show();
            this.Dispose(false);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Start d = new Start();
            d.Show();
            this.Hide();
        }

       
    }
}
