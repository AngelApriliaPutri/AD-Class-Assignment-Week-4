using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA_W4_ANGEL_L
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Gender;
        string text = "";
        int nol = 0;
        int satu = 0;
        int dua = 0;
        bool validsemua = true;
        private void button_submit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox_name.Text.Length; i++)
            {
                if (Char.IsDigit(textBox_name.Text[i]))
                {
                    nol++;
                }
            }
            for (int i = 0; i < textBox_age.Text.Length; i++)
            {
                if (Char.IsDigit(textBox_age.Text[i]))
                {
                    satu++;
                }
                else
                {
                    satu = 0;
                    break;
                }

            }
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (Char.IsDigit(textBox1.Text[i]))
                {
                    dua++;
                }
            }
            if (radioButton_male.Checked)
            {
                Gender = "Male";
            }
            else
            {
                Gender = "Female";
            }
            if (radioButton_blue.Checked)
            {
                BackColor = Color.LightBlue;
            }
            else if (radioButton_yellow.Checked)
            {
                BackColor = Color.LightYellow;
            }
            else if (radioButton_pink.Checked)
            {
                BackColor = Color.Pink;
            }

            if (checkBox_reading.Checked)
            {
                text += checkBox_reading.Text;
            }
            if (checkBox_watchtv.Checked)
            {
                if (text != "")
                {
                    text += ", ";
                }
                text += checkBox_watchtv.Text;
            }
            if (checkBox_sports.Checked)
            {
                if (text != "")
                {
                    text += ", ";
                }
                text += checkBox_sports.Text;
            }
            if (checkBox_lain.Checked)
            {
                if (text != "")
                {
                    text += ", ";
                }
                text += textBox1.Text;
            }
            if (nol > 0 || satu == 0 || dua > 0)
            {
                MessageBox.Show("Name must not contain number, Age must be numbers, Hobby must not contain number");
                validsemua = false;
            }
            if (validsemua == true)
            {
                MessageBox.Show($"Name : {textBox_name.Text} \nAge : {textBox_age.Text} \nGender : {Gender} \nHobbies : {text}");
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_name.Clear();
            textBox_age.Clear();
            radioButton_male.Checked = false;
            radioButton_female.Checked = false;
            radioButton_blue.Checked = false;
            radioButton_pink.Checked = false;
            radioButton_yellow.Checked = false;
            checkBox_reading.Checked = false;
            checkBox_sports.Checked = false;
            checkBox_watchtv.Checked = false;
            checkBox_lain.Checked = false;
            textBox1.Clear();
        }
    }
}
