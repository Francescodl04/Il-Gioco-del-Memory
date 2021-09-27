/* Autore: Francesco Di Lena
 * Classe: 4 F
 * Consegna: creare un videogioco, Memory, attraverso l'uso del framework Windows Forms e il linguaggio di programmazione C#.
 * Form iniziale.
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
    public partial class FormIniziale : Form
    {
        public FormIniziale()
        {
            InitializeComponent();
        }

        private void giocaBtn_Click(object sender, EventArgs e)
        {
            Form FormGioco = new FormGioco();
            this.Hide();
            FormGioco.Show();
        }
        private void unoGiocatoreRBtn_CheckedChanged(object sender, EventArgs e)
        {
            nomeG2TBox.Enabled = false;
            nomeG2TBox.Text = "G2";
        }

        private void dueGiocatoriRBtn_CheckedChanged(object sender, EventArgs e)
        {
            nomeG2TBox.Enabled = true;
            nomeG2TBox.Text = "Nome G2";
        }

    }
}
