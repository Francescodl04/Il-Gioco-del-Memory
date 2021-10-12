/* Autore: Francesco Di Lena
 * Classe: 4 F
 * Consegna: creare un videogioco, Memory, attraverso l'uso del framework Windows Forms e il linguaggio di programmazione C#.
 * Form iniziale in cui vengono inseriti i dati dei giocatori.
 */

using System;
using System.Windows.Forms;

namespace MemoryApp
{
    public partial class FormIniziale : Form
    {
        string[,] DatiGiocatori = new string[2, 2] { { "G1", "0" }, { "G2", "0" } };
        public FormIniziale()
        {
            InitializeComponent();
        }

        private void giocaBtn_Click(object sender, EventArgs e)
        {
            Form FormGioco = new FormGioco(DatiGiocatori);
            this.Hide();
            FormGioco.Show();
        }
        private void unoGiocatoreRBtn_CheckedChanged(object sender, EventArgs e)
        {
            nomeG2TBox.Enabled = false;
            nomeG2TBox.Text = "G2";
            DatiGiocatori[1, 0] = nomeG2TBox.Text;
            erroreInserimentoG2EProvider.Clear();
        }

        private void dueGiocatoriRBtn_CheckedChanged(object sender, EventArgs e)
        {
            nomeG2TBox.Enabled = true;
            nomeG2TBox.Text = "Nome G2";
            erroreInserimentoG2EProvider.Clear();
        }
        private void nomeG1TBox_Click(object sender, EventArgs e)
        {
            nomeG1TBox.SelectionStart = 0;
            nomeG1TBox.SelectionLength = nomeG1TBox.Text.Length;
        }

        private void nomeG1TBox_TextChanged(object sender, EventArgs e)
        {
            DatiGiocatori[0, 0] = nomeG1TBox.Text;
            VerificaErroriInserimentoTextBox();
        }

        private void nomeG2TBox_Click(object sender, EventArgs e)
        {
            nomeG2TBox.SelectionStart = 0;
            nomeG2TBox.SelectionLength = nomeG2TBox.Text.Length;
        }

        private void nomeG2TBox_TextChanged(object sender, EventArgs e)
        {
            DatiGiocatori[1, 0] = nomeG2TBox.Text;
            VerificaErroriInserimentoTextBox();
        }

        private void VerificaErroriInserimentoTextBox()
        {
            int indice;
            if (dueGiocatoriRBtn.Checked == false)
            {
                indice = 1;
            }
            else
            {
                indice = 2;
            }
            for (int i = 0; i < indice; i++)
            {
                if (DatiGiocatori[i, 0] == "" || DatiGiocatori[i, 0] == "G1" || DatiGiocatori[i, 0] == "G2" || DatiGiocatori[i, 0].Contains(" ") || DatiGiocatori[0, 0] == DatiGiocatori[1, 0])
                {
                    giocaBtn.Enabled = false;
                    if (i == 0)
                    {
                        erroreInserimentoG1EProvider.SetError(nomeG1TBox, "Non puoi inserire un nome con gli spazi, oppure un nome uguale a G1.");
                    }
                    else
                    {
                        erroreInserimentoG2EProvider.SetError(nomeG2TBox, "Non puoi inserire un nome vuoto, con spazi, oppure un nome uguale a G2.");
                    }
                }
                else
                {
                    if (i == 0)
                    {
                        erroreInserimentoG1EProvider.Clear();
                        giocaBtn.Enabled = true;
                    }
                    else
                    {
                        erroreInserimentoG2EProvider.Clear();
                    }
                }
            }
        }
    }
}
