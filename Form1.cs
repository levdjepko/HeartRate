using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeartRateApp
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HeartRateCalculator calculateMaxRate = new HeartRateCalculator(textBox1.Text, Convert.ToInt32(textBox2.Text), 2019);
            calculateMaxRate.CalculateMaxRate(calculateMaxRate.Age);
            label4.Text = $"{calculateMaxRate.Name}, your max heart rate is:";
            label5.Text = calculateMaxRate.MaxRate.ToString();
            label6.Text = calculateMaxRate.LowRange.ToString();
            label7.Text = calculateMaxRate.HighRange.ToString();
        }
    }
}
