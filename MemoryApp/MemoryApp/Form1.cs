/* Autore: Francesco Di Lena
 * Classe: 4 F
 * Consegna: creare un videogioco, Memory, attraverso l'uso del framework Windows Forms e il linguaggio di programmazione C#.
 * Form iniziale in cui vengono inseriti i dati dei giocatori.
 */

using System;
using System.Windows.Forms;

namespace MemoryApp
{
    public partial class FormIniziale : Form //Classe che contiene tutti gli oggetti del form FormIniziale.
    {

        //Inizializzazione e dichiarazione variabili.

        string[,] DatiGiocatori = new string[2, 2] { { "G1", "0" }, { "G2", "0" } }; //Vettore necessario per contenere i nomi e i punteggi dei due giocatori.
        int codiceSetTessere = 0; //Necessario per distinguere un caso di utilizzo del gioco normale, oppure nella modalità "segreta" ITIS Viola.
        
        public FormIniziale() //Metodo costruttore della classe FormIniziale.
        {
            InitializeComponent();
        }

        //Metodi relativi all'oggetto FormIniziale (Form).

        private void FormIniziale_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.H) //Se si preme la combinazione di tasti ALT + H, allora vengono eseguite le seguenti istruzioni.
            {
                var conferma = MessageBox.Show("Hai attivato la modalità ITIS Ferruccio Viola: ora ogni tessera verrà associata all'immagine di un professore della scuola. Vuoi proseguire con questa configurazione (Sì) oppure con le tessere normali (No)? \nNota: il programmatore nega ogni responsabilità per l'utilizzo incorretto di questa funzionalità di programma.", "Modalità segreta", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (conferma == DialogResult.Yes)
                {
                    MessageBox.Show("Bene, hai configurato la modalità ITIS Ferruccio Viola. Ora inserisci i dati dei giocatori e premi il pulsante Gioca!", "Operazione eseguita con successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    codiceSetTessere = 2;
                }
            }
        } //Permette di rilevare la combinazione di inserimento da tastiera di ALT+H e di eseguire le operazioni associate.

        //Metodi relativi agli oggetti unoGiocatoreRtn e dueGiocatoriRBtn (entrambi RadioButton).

        private void unoGiocatoreRBtn_CheckedChanged(object sender, EventArgs e) //Se viene selezionato un solo giocatore, disattiva la casella del nome di G2.
        {
            nomeG2TBox.Enabled = false;
            nomeG2TBox.Text = "G2";
            DatiGiocatori[1, 0] = nomeG2TBox.Text;
            erroreInserimentoG2EProvider.Clear();
        }

        private void dueGiocatoriRBtn_CheckedChanged(object sender, EventArgs e) //Se viene selezionato un solo giocatore, attiva la casella del nome di G2.
        {
            nomeG2TBox.Enabled = true;
            nomeG2TBox.Text = "Nome G2";
            erroreInserimentoG2EProvider.Clear();
        }

        //Metodi relativi agli oggetti nomeG1TBox e nomeG2TBox (entrambi TextBox)

        private void nomeG1TBox_Click(object sender, EventArgs e) //Al click di nomeG1TBox seleziona tutto il testo inserito nella casella di testo.
        {
            nomeG1TBox.SelectionStart = 0;
            nomeG1TBox.SelectionLength = nomeG1TBox.Text.Length;
        }

        private void nomeG1TBox_TextChanged(object sender, EventArgs e) //In questo metodo si effettua, ogni volta che il testo cambia, l'inserimento del nome di G1 in una variabile a partire da ciò che l'utente inserisce in nomeG1TBox.
        {
            DatiGiocatori[0, 0] = nomeG1TBox.Text;
            VerificaErroriInserimentoTextBox();
        }

        private void nomeG2TBox_Click(object sender, EventArgs e) //Al click di nomeG2TBox seleziona tutto il testo inserito nella casella di testo.
        {
            nomeG2TBox.SelectionStart = 0;
            nomeG2TBox.SelectionLength = nomeG2TBox.Text.Length;
        }

        private void nomeG2TBox_TextChanged(object sender, EventArgs e) //In questo metodo si effettua, ogni volta che il testo cambia, l'inserimento del nome di G2 in una variabile a partire da ciò che l'utente inserisce in nomeG2TBox.
        {
            DatiGiocatori[1, 0] = nomeG2TBox.Text;
            VerificaErroriInserimentoTextBox();
        }

        private void VerificaErroriInserimentoTextBox() //Metodo che consente di individuare errori di inserimento all'interno delle TextBox e di visualizzare all'utente l'errore commesso
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

        //Metodi relativi all' oggetto giocaBtn (Button)

        private void giocaBtn_Click(object sender, EventArgs e) //Permette di chiudere questo form e di passare al successivo.
        {
            FormGioco FormGioco = new FormGioco(DatiGiocatori, codiceSetTessere); 
            this.Hide();
            FormGioco.Show();
        }
    }
}
