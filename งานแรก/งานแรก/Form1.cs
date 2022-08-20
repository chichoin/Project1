using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace งานแรก
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)

        {

            int total = 0;
            if (
                (string.IsNullOrEmpty(textBox1.Text)) ||
                (string.IsNullOrEmpty(textBox2.Text)) ||
                (string.IsNullOrEmpty(textBox3.Text)) ||
                (string.IsNullOrEmpty(textBox4.Text)) ||
                (string.IsNullOrEmpty(textBox5.Text)) ||
                (string.IsNullOrEmpty(textBox6.Text))

               )
            {   //เชคกรณีว่าง
                MessageBox.Show("กรุณาใส่ตัวเลขให้ครบทุกช่องโดย");
            }
            else
            {
                if (textBox1.Text != " ")
                {
                    total += Convert.ToInt32(textBox1.Text) * 30;
                }
                if (textBox2.Text != " ")
                {
                    total += Convert.ToInt32(textBox2.Text) * 9000;
                }
                if (textBox3.Text != " ")
                {
                    total += Convert.ToInt32(textBox3.Text) * 10;
                }
                if (textBox4.Text != " ")

                {
                    total += Convert.ToInt32(textBox4.Text) * 20;
                }
                if (textBox5.Text != " ")

                {
                    total += Convert.ToInt32(textBox5.Text) * 50;
                }
                if (textBox6.Text != " ")
                {
                    total += Convert.ToInt32(textBox6.Text) * 30;
                }
                lbpay.Text = total.ToString();
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("กรอกตัวเลขในทุกช่องด้วยเลข(0-99)และกดปุ่มคำนวนราคาเพื่อคำนวนข้อมูล" +
                "ส่วนClear คือปุ่ม รีเซ็ตข้อมูล ส่วนปุ่มExit คือปุ่ม จบการทำงาน");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            lbpay.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show(
                  "คุณต้องการออกจากโปรแกรม ?",
                  "ออกจากโปรแกรม",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question
                  );
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
            }

        }
        private void btok_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}