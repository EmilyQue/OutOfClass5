//Emily Quevedo
//CST 117
//April 16, 2018
//This is my own work, with the help of https://stackoverflow.com/questions/9387267/transparent-control-over-picturebox
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutOfClass5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 nutrition = new Form2(); 
            if (radio_md.Checked)
            {
                if (comboBox1.Text == "Big Mac")
                {
                    nutrition.label_calories.Text = "540";
                }
                else if (comboBox1.Text == "Large Fries")
                {
                    nutrition.label_calories.Text = "510";
                }
                else
                    nutrition.label_calories.Text = "380";
            }

            else if (radio_wendy.Checked)
            {
                if (comboBox1.Text == "Baconator")
                {
                    nutrition.label_calories.Text = "670";
                }
                else if (comboBox1.Text == "Large Fries")
                {
                    nutrition.label_calories.Text = "460";
                }
                else
                    nutrition.label_calories.Text = "450";
            }
            else if (radio_carl.Checked)
            {
                if (comboBox1.Text == "Famous Star with Cheese")
                {
                    nutrition.label_calories.Text = "670";
                }
                else if (comboBox1.Text == "Large Fries")
                {
                    nutrition.label_calories.Text = "460";
                }
                else
                    nutrition.label_calories.Text = "330";
            }
                nutrition.ShowDialog();
            comboBox1.Text = "";
        }

        private void radio_md_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_md.Checked)
            {
                comboBox1.Items.Add("Big Mac");
                comboBox1.Items.Add("Large Fries");
                comboBox1.Items.Add("Hot Caramel Sundae");
            }
            else
            {
                comboBox1.Items.Remove("Big Mac");
                comboBox1.Items.Remove("Large Fries");
                comboBox1.Items.Remove("Hot Caramel Sundae");
            }
        }

        private void radio_wendy_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_wendy.Checked)
            {
                comboBox1.Items.Add("Baconator");
                comboBox1.Items.Add("Large Fries");
                comboBox1.Items.Add("Medium Vanilla Frosty");
            }
            else
            {
                comboBox1.Items.Remove("Baconator");
                comboBox1.Items.Remove("Large Fries");
                comboBox1.Items.Remove("Medium Vanilla Frosty");
            }
        }

        private void radio_carl_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_carl.Checked)
            {
                comboBox1.Items.Add("Famous Star with Cheese");
                comboBox1.Items.Add("Large Fries");
                comboBox1.Items.Add("Chocolate Chip Cookie");
            }
            else
            {
                comboBox1.Items.Remove("Famous Star with Cheese");
                comboBox1.Items.Remove("Large Fries");
                comboBox1.Items.Remove("Chocolate Chip Cookie");
            }
        }
    }
}
