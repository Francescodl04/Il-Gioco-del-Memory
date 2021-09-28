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
    public partial class FormGioco : Form
    {
        Tessere OperazioniTessere = new Tessere();
        public FormGioco()
        {
            InitializeComponent();
        }

        private void FormGioco_Load(object sender, EventArgs e)
        {
            OperazioniTessere.GeneraTessereCasuali();
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
            tessera1Btn.BackgroundImage = OperazioniTessere.TessereFloreali[0];
        }

        private void tessera2Btn_Click(object sender, EventArgs e)
        {
            tessera2Btn.BackgroundImage = OperazioniTessere.TessereFloreali[1];
        }

        private void tessera3Btn_Click(object sender, EventArgs e)
        {
            tessera3Btn.BackgroundImage = OperazioniTessere.TessereFloreali[2];
        }

        private void tessera4Btn_Click(object sender, EventArgs e)
        {
            tessera4Btn.BackgroundImage = OperazioniTessere.TessereFloreali[3];
        }

        private void tessera5Btn_Click(object sender, EventArgs e)
        {
            tessera5Btn.BackgroundImage = OperazioniTessere.TessereFloreali[4];
        }

        private void tessera6Btn_Click(object sender, EventArgs e)
        {
            tessera6Btn.BackgroundImage = OperazioniTessere.TessereFloreali[5];
        }

        private void tessera7Btn_Click(object sender, EventArgs e)
        {
            tessera7Btn.BackgroundImage = OperazioniTessere.TessereFloreali[6];
        }

        private void tessera8Btn_Click(object sender, EventArgs e)
        {
            tessera8Btn.BackgroundImage = OperazioniTessere.TessereFloreali[7];
        }

        private void tessera9Btn_Click(object sender, EventArgs e)
        {
            tessera9Btn.BackgroundImage = OperazioniTessere.TessereFloreali[8];
        }

        private void tessera10Btn_Click(object sender, EventArgs e)
        {
            tessera10Btn.BackgroundImage = OperazioniTessere.TessereFloreali[9];
        }

        private void tessera11Btn_Click(object sender, EventArgs e)
        {
            tessera11Btn.BackgroundImage = OperazioniTessere.TessereFloreali[10];
        }

        private void tessera12Btn_Click(object sender, EventArgs e)
        {
            tessera12Btn.BackgroundImage = OperazioniTessere.TessereFloreali[11];
        }

        private void tessera13Btn_Click(object sender, EventArgs e)
        {
            tessera13Btn.BackgroundImage = OperazioniTessere.TessereFloreali[12];
        }

        private void tessera14Btn_Click(object sender, EventArgs e)
        {
            tessera14Btn.BackgroundImage = OperazioniTessere.TessereFloreali[13];
        }

        private void tessera15Btn_Click(object sender, EventArgs e)
        {
            tessera15Btn.BackgroundImage = OperazioniTessere.TessereFloreali[14];
        }

        private void tessera16Btn_Click(object sender, EventArgs e)
        {
            tessera16Btn.BackgroundImage = OperazioniTessere.TessereFloreali[15];
        }

        private void FormGioco_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void informazioniSulGiocoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Il gioco del Memory.\n\nVersione di test 0.1 .\nVersione .NET Framework 4.7.2 \nTutti i diritti riservati a Rasvenburger.", "Informazioni sul gioco...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    public class Tessere
    {
        public Image[] TessereFloreali = new Image[16];
        public void GeneraTessereCasuali()
        {
            Random NumeroCasuale = new Random();
            int[] ContatoreCollisioni = new int[8];
            for (int i = 0; i < TessereFloreali.Length; i++)
            {
                int numeroGenerato = NumeroCasuale.Next(0, 8);
                switch (numeroGenerato)
                {
                    case (0):
                        if (ContatoreCollisioni[0] < 2) 
                        {
                            TessereFloreali[i] = Properties.Resources.calla;
                            ContatoreCollisioni[0]++;
                        }
                        else
                        {
                            i--;
                        }
                        break;
                    case (1):
                        if (ContatoreCollisioni[1] < 2)
                        {
                            TessereFloreali[i] = Properties.Resources.campanelle;
                            ContatoreCollisioni[1]++;
                        }
                        else
                        {
                            i--;
                        }
                        break;
                    case (2):
                        if (ContatoreCollisioni[2] < 2)
                        {
                            TessereFloreali[i] = Properties.Resources.girasole;
                            ContatoreCollisioni[2]++;
                        }
                        else
                        {
                            i--;
                        }
                        break;
                    case (3):
                        if (ContatoreCollisioni[3] < 2)
                        {
                            TessereFloreali[i] = Properties.Resources.lavanda;
                            ContatoreCollisioni[3]++;
                        }
                        else
                        {
                            i--;
                        }
                        break;
                    case (4):
                        if (ContatoreCollisioni[4] < 2)
                        {
                            TessereFloreali[i] = Properties.Resources.margherita;
                            ContatoreCollisioni[4]++;
                        }
                        else
                        {
                            i--;
                        }
                        break;
                    case (5):
                        if (ContatoreCollisioni[5] < 2)
                        {
                            TessereFloreali[i] = Properties.Resources.rosa;
                            ContatoreCollisioni[5]++;
                        }
                        else
                        {
                            i--;
                        }
                        break;
                    case (6):
                        if (ContatoreCollisioni[6] < 2)
                        {
                            TessereFloreali[i] = Properties.Resources.stella_alpina;
                            ContatoreCollisioni[6]++;
                        }
                        else
                        {
                            i--;
                        }
                        break;
                    case (7):
                        if (ContatoreCollisioni[7] < 2)
                        {
                            TessereFloreali[i] = Properties.Resources.tulipano;
                            ContatoreCollisioni[7]++;
                        }
                        else
                        {
                            i--;
                        }
                        break;
                }
            }
        }
    }
}
