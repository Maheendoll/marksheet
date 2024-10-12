using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marksheet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num_1 = int.Parse(textBox1.Text);
            int num_2 = int.Parse(textBox2.Text);
            float percentage = ((float)num_2 / num_1) * 100;
            char grade;
            if(percentage >= 90)
            {
                grade = 'A';
            }
            else if(percentage >= 80)
            {
                grade = 'B';
            }
            else if (percentage >= 70)
            {
                grade = 'C';
            }
            else if (percentage >= 60)
            {
                grade = 'D';
            }
            else
            {
                grade = 'F';
            }
            MessageBox.Show($"Your Grade is:{grade}. Your Percenatage is {percentage}");
        }
    }
}
