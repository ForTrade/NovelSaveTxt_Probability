using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Probability
{
    public partial class Form1 : Form
    {
        public double capital, winrate, tradeTimes, useCapitalRatio, profitRatio, lossRatio;
        public Form1()
        {
            InitializeComponent();
            capital = Convert.ToDouble(textBox1.Text);
            winrate = Convert.ToDouble(textBox2.Text);
            tradeTimes = Convert.ToDouble(textBox3.Text);
            useCapitalRatio = Convert.ToDouble(textBox4.Text);
            profitRatio = Convert.ToDouble(textBox5.Text);
            lossRatio = Convert.ToDouble(textBox6.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = string.Empty;
            capital = Convert.ToDouble(textBox1.Text);
            winrate = Convert.ToDouble(textBox2.Text);
            tradeTimes = Convert.ToDouble(textBox3.Text);
            useCapitalRatio = Convert.ToDouble(textBox4.Text);
            profitRatio = Convert.ToDouble(textBox5.Text);
            lossRatio = Convert.ToDouble(textBox6.Text);
            //MessageBox.Show(Convert.ToInt32(this.textBox6.Text).ToString());
            Computing();
        }



        private void Computing()
        {
            Random ran = new Random();
            for (int i = 0; i < tradeTimes; i++)
            {
                int  randomNum = ran.Next(0, 100);
                if (capital >= 10000000000 || capital<=1) break;
                if(randomNum<winrate)
                {
                    capital += capital*(useCapitalRatio/100) * (profitRatio / 100);
                    textBox7.AppendText((i+1).ToString() + "__profit__\t" + Convert.ToInt64(capital).ToString()+"\r\n");
                }else
                {
                    capital -= capital * (useCapitalRatio/100) * (lossRatio/ 100);
                    textBox7.AppendText((i + 1).ToString() + "___loss___\t" + Convert.ToInt64(capital).ToString() +"\r\n");
                }
                
            }
        }
    }
}
