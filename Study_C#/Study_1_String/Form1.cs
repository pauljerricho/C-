using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Contain_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = lblText.Text;
            lbl_Contain.Text = txt.Contains("Test").ToString();
            lbl_Equals.Text = txt.Equals("Test").ToString();
            lbl_Length.Text = txt.Length.ToString();
            lbl_Replace.Text = txt.Replace("Test", "I Can");

            string[] strSplit = txt.Split(',');
            lbl_Split.Text = strSplit[0].Trim();
            lbl_Split_2.Text = strSplit[1].Trim();
            lbl_Split_3.Text = strSplit[2].Trim();

            lbl_Substring.Text = txt.Substring(3,5).ToString();
            lbl_ToLower.Text = txt.ToLower().ToString();
            lbl_ToUpper.Text = txt.ToUpper().ToString();
            lbl_Trim.Text = txt.Trim().ToString();



        }
    }
}
