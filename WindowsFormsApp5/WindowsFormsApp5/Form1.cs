using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        int score1 = 0;
        int score2 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int num = random.Next(1, 100);
            textBox1.Text = num.ToString();
            int playerone = 0;
            int.TryParse(textBox2.Text, out playerone);
            int playertwo = 0;
            int.TryParse(textBox3.Text, out playertwo);
            if (Math.Abs(num - playerone) < Math.Abs(num - playertwo))
            {
                score1 = score1 + 1;
                label1.Text = score1.ToString();
            }
            if (Math.Abs(num - playertwo) < Math.Abs(num - playerone))
            {
                score2 = score2 + 1;
                label2.Text = score2.ToString();

            }
        }
    }
}
