using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _0H04037_正田陸_uiux01
{
    public partial class Appli : Form
    {
        public Appli()
        {
            InitializeComponent();
        }

        private void Appli_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            label6.Left = this.Width;

            string info;
            int sep;
            int i;

            StreamReader rw = new StreamReader("user_data.txt", Encoding.GetEncoding("Shift_JIS"));
            for (i = 0; i < login.loginnum; i++)
            {
                rw.ReadLine();
            }

            info = rw.ReadLine();
            rw.Close();

            sep = info.IndexOf(':');
            label4.Text = info.Substring(0, sep);
            label5.Text = info.Substring(sep + 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("本当にログアウトしますか？", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Title sc1 = new Title();
                sc1.ShowDialog();
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int month;

            if (int.TryParse(textBox1.Text, out month) && month >= 1 && month <= 12) 
            {
                switch (month)
                {
                    case 1:
                        label6.Text = "1月は新年の始まりです。";
                        break;
                    case 2:
                        label6.Text = "2月はバレンタインデーがあります。";
                        break;
                    case 3:
                        label6.Text = "3月は春の訪れを感じます。";
                        break;
                    case 4:
                        label6.Text = "4月は桜が満開になります。";
                        break;
                    case 5:
                        label6.Text = "5月はゴールデンウィークがあります。";
                        break;
                    case 6:
                        label6.Text = "6月は梅雨の季節です。";
                        break;
                    case 7:
                        label6.Text = "7月は夏の始まりです。";
                        break;
                    case 8:
                        label6.Text = "8月はお盆の時期です。";
                        break;
                    case 9:
                        label6.Text = "9月は秋の始まりを感じます。";
                        break;
                    case 10:
                        label6.Text = "10月はハロウィンがあります。";
                        break;
                    case 11:
                        label6.Text = "11月は紅葉が美しい季節です。";
                        break;
                    case 12:
                        label6.Text = "12月はクリスマスがあります。";
                        break;
                }
                timer1.Enabled = true;
            }
            else
            {
                MessageBox.Show("月を正しく入力してください");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Left = label6.Left - 30;

            if (label6.Left < -label6.Width)
            {
                label6.Left = this.Width;
            }
        }
    }
}
