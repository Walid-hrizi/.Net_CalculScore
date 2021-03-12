using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcul_de_score
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            date.Text = DateTime.Now.ToShortDateString();
            heure.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
                
            if(cinText.Text==""||telText.Text == ""|| prenText.Text == "")
            {
                MessageBox.Show("il faut saisir toutes les in formation");
                return;
            }
            int lang = int.Parse(textBox6.Text);
            int tech= int.Parse(textBox5.Text);
            int sex=1 ;
            int chance = int.Parse(chanceText.Text);
            int bonus = 0;
            if (experCheck.Checked)
            {
                bonus++;
            }
            if (motivCheck.Checked)
            {
                bonus++;
            }
            if (diplomCheck.Checked)
            {
                bonus++;
            }
            int age;
            int score; 
            if (femRadio.Checked)
            {
                sex = 0;
            }
            switch (ageComboBox.SelectedIndex)
            {
                case 0: age = 20; break;
                case 1: age = 30; break;
                case 2: age = 40; break;
                default: age = 0; break;
            }
            score = lang + tech + sex + age + bonus + chance;
            scoreText.Text = score.ToString();
            button4.Enabled = true;



        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_Validating(object sender, CancelEventArgs e)
        {
            if (textBox6.Text == "")
            {
                MessageBox.Show("Il faut saisir une note");
                e.Cancel = true;
            }
            else
            {
                if (int.Parse(textBox6.Text) > 20)
                {
                    MessageBox.Show("La note doit être entre 0 et 20");
                    textBox5.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            if (textBox5.Text == "")
            {
                MessageBox.Show("Il faut saisir une note");
                e.Cancel = true;
            }
            else
            {
                if (int.Parse(textBox5.Text) > 20)
                {
                    MessageBox.Show("La note doit être entre 0 et 20");
                    textBox5.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x;
            Random rand = new Random();
            x = rand.Next(0, 16);
            chanceText.Text = x.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cinText.Text = "";
            telText.Text = "";
            prenText.Text = "";
            nomText.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            scoreText.Text = "";
            
            chanceText.Text = "";
            motivCheck.Checked = false;
            experCheck.Checked = false;
            diplomCheck.Checked = false;
            


        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(cinText.Text);
            listBox2.Items.Add(nomText.Text);
            listBox3.Items.Add(prenText.Text);
            listBox4.Items.Add(scoreText.Text);
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cinText_TextChanged(object sender, EventArgs e)
        {

        }

        private void telText_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
