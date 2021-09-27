/* Autore: Francesco Di Lena
 * Classe: 4 F
 * Consegna: creare un videogioco, Memory, attraverso l'uso del framework Windows Forms e il linguaggio di programmazione C#.
 * Form gioco.
 */

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
    public partial class FormGioco : System.Windows.Forms.Form
    {
        public FormGioco()
        {
            InitializeComponent();
        }

        private void FormGioco_Load(object sender, EventArgs e)
        {
            Random tessere = new Random();
        }

        private void bluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisattivaSelezione(0);
            bluToolStripMenuItem.Checked = true;
        }

        private void arancioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisattivaSelezione(1);
            arancioToolStripMenuItem.Checked = true;
        }

        private void gialloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisattivaSelezione(2);
            gialloToolStripMenuItem.Checked = true;
        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisattivaSelezione(3);
            verdeToolStripMenuItem.Checked = true;
        }

        public void DisattivaSelezione(int n)
        {
            Button[] tessere = new Button[] { tessera1Btn, tessera2Btn, tessera3Btn, tessera4Btn, tessera5Btn, tessera6Btn, tessera7Btn, tessera8Btn, tessera9Btn, tessera10Btn, tessera11Btn, tessera12Btn, tessera13Btn, tessera14Btn, tessera15Btn, tessera16Btn };
            bluToolStripMenuItem.Checked = false;
            arancioToolStripMenuItem.Checked = false;
            gialloToolStripMenuItem.Checked = false;
            verdeToolStripMenuItem.Checked = false;
            for (int i = 0; i < tessere.Length; i++)
            {
                if(tessere[i].Enabled==true)
                switch (n)
                {
                    case 0:
                            tessere[i].BackgroundImage = Properties.Resources.punto_domanda_blu;
                            logoLabel.BackColor = Color.AliceBlue;
                            indicatoreAbbinamentiLabel.BackColor = Color.AliceBlue;
                            rimescolaTessereLabel.BackColor= Color.AliceBlue;
                            break;
                    case 1:
                            tessere[i].BackgroundImage = Properties.Resources.punto_domanda_arancio;
                            logoLabel.BackColor = Color.SeaShell;
                            indicatoreAbbinamentiLabel.BackColor = Color.SeaShell;
                            rimescolaTessereLabel.BackColor = Color.SeaShell;
                            break;
                    case 2:
                            tessere[i].BackgroundImage = Properties.Resources.punto_domanda_giallo;
                            logoLabel.BackColor = Color.Cornsilk;
                            indicatoreAbbinamentiLabel.BackColor = Color.Cornsilk;
                            rimescolaTessereLabel.BackColor = Color.Cornsilk;
                            break;
                    case 3:
                            tessere[i].BackgroundImage = Properties.Resources.punto_domanda_verde;
                            logoLabel.BackColor = Color.Honeydew;
                            indicatoreAbbinamentiLabel.BackColor = Color.Honeydew;
                            rimescolaTessereLabel.BackColor = Color.Honeydew;
                            break;
                }
            }
        }

        private void tessera1Btn_Click(object sender, EventArgs e)
        {

        }

        private void tessera2Btn_Click(object sender, EventArgs e)
        {

        }

        private void tessera3Btn_Click(object sender, EventArgs e)
        {

        }

        private void tessera4Btn_Click(object sender, EventArgs e)
        {

        }

        private void tessera5Btn_Click(object sender, EventArgs e)
        {

        }

        private void tessera6Btn_Click(object sender, EventArgs e)
        {

        }

        private void tessera7Btn_Click(object sender, EventArgs e)
        {

        }

        private void tessera8Btn_Click(object sender, EventArgs e)
        {

        }

        private void tessera9Btn_Click(object sender, EventArgs e)
        {

        }

        private void tessera10Btn_Click(object sender, EventArgs e)
        {

        }

        private void tessera11Btn_Click(object sender, EventArgs e)
        {

        }

        private void tessera12Btn_Click(object sender, EventArgs e)
        {

        }

        private void tessera13Btn_Click(object sender, EventArgs e)
        {

        }

        private void tessera14Btn_Click(object sender, EventArgs e)
        {

        }

        private void tessera15Btn_Click(object sender, EventArgs e)
        {

        }

        private void tessera16Btn_Click(object sender, EventArgs e)
        {

        }

        private void FormGioco_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
