using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryApp
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

        private void arancioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(bluToolStripMenuItem.Checked==true)
            {
                bluToolStripMenuItem.Checked = false;
            }
            else if (gialloToolStripMenuItem.Checked == true)
            {
                gialloToolStripMenuItem.Checked = false;
            }
            else if (verdeToolStripMenuItem.Checked == true)
            {
                verdeToolStripMenuItem.Checked = false;
            }
            tessera1Btn.BackgroundImage = Properties.Resources.punto_domanda_arancio;
            tessera2Btn.BackgroundImage = Properties.Resources.punto_domanda_arancio;
        }
    }
}
