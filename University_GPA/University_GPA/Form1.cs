using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_GPA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calc_btn_Click(object sender, EventArgs e)
        {
            double first, second, average;
            first = Convert.ToDouble(textBox1.Text);
            second = Convert.ToDouble(textBox2.Text);
            average = (first * 0.40 + second * 0.60);

            if(average <= 100 && average >= 90)
            {
                avg_lbl.Text = average.ToString() + " >> AA";
            }
            else if(average <= 89 && average >= 80)
            {
                avg_lbl.Text = average.ToString() + " >> BA";
            }
            else if(average <= 79 && average >=70)
            {
                avg_lbl.Text = average.ToString() + " >> BB";
            }
            else if (average <= 69 && average >= 60)
            {
                avg_lbl.Text = average.ToString() + " >> CB";
            }
            else if (average <= 59 && average >= 50)
            {
                avg_lbl.Text = average.ToString() + " >> CC";
            }
            else
            {
                avg_lbl.Text = average.ToString() + " >> FF";
            }
            avg_lbl.Visible = true;
        }
    }
}
