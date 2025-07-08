using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0H04037_正田陸_uiux01
{
    public partial class application : Form
    {
        public application()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void application_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Text = "";
        }
    }
}
