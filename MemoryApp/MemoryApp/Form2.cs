/* Autore: Francesco Di Lena
 * Classe: 4 F
 * Consegna: creare un videogioco, Memory, attraverso l'uso del framework Windows Forms e il linguaggio di programmazione C#.
 * Form gioco.
 */

using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryApp
{
    public partial class FormGioco : Form //Classe che contiene tutti gli oggetti del form FormGioco.
    {
        //Inizializzazione e dichiarazione variabili.

        static Button[] TessereGioco;
        static ToolStripMenuItem[] SceltaSetColori, SceltaSetCarte;
        static Label[] EtichetteGioco;
        int giocatoreTurno = 0, codiceSetCarte = 0, codiceSetColore = 0, numeroTurno = 1;
        string[,] DatiGiocatori;
        Random NumeroCasuale = new Random();
        Image sfondoTesseraNascosta = Properties.Resources.punto_domanda_blu;
        Button[] TessereCliccate = new Button[2];
        int[] PosizioneTessereCliccate = new int[2], IDCarte;
        bool verifica, chiusuraGioco = true;
        OperazioniTessere OperazioniTessere;

        public FormGioco(string [,] DatiGiocatori, int codiceSetCarte) //Metodo costruttore della classe FormGioco.
        {
            InitializeComponent();
            this.DatiGiocatori = DatiGiocatori;
            this.codiceSetCarte = codiceSetCarte;
            TessereGioco = new Button[] { tessera0Btn, tessera1Btn, tessera2Btn, tessera3Btn, tessera4Btn, tessera5Btn, tessera6Btn, tessera7Btn, tessera8Btn, tessera9Btn, tessera10Btn, tessera11Btn, tessera12Btn, tessera13Btn, tessera14Btn, tessera15Btn };
            SceltaSetColori = new ToolStripMenuItem[] { bluToolStripMenuItem, arancioToolStripMenuItem, gialloToolStripMenuItem, verdeToolStripMenuItem, iISViolaMarchesiniToolStripMenuItem };
            SceltaSetCarte = new ToolStripMenuItem[] { fioriToolStripMenuItem, animaliToolStripMenuItem, professoriToolStripMenuItem };
            EtichetteGioco = new Label[] { logoLabel, indicatoreTurniLabel, indicatoreAbbinamentiLabel };
            OperazioniTessere = new OperazioniTessere(SceltaSetColori, SceltaSetCarte, TessereGioco, EtichetteGioco, rimescolaTesserePanel, sfondoTesseraNascosta);
        }

        //Metodi relativi all'oggetto FormGioco (Form).

        private void FormGioco_Load(object sender, EventArgs e) //Operazioni eseguite al caricamento del form: viene generato casualmente il primo che deve giocare ed altre operazioni iniziali.
        {
            OperazioniTessere.AttivaDisattivaTessere(false);
            IDCarte = OperazioniTessere.GeneraTessereCasuali(codiceSetCarte);
            if (codiceSetCarte == 2)
            {
                codiceSetColore = 4;
                sfondoTesseraNascosta = OperazioniTessere.CambioSetColori(codiceSetColore, true);
                OperazioniTessere.ModalitàSegreta();
            }
            AggiornaEtichette();
        } 

        private void FormGioco_FormClosing(object sender, FormClosingEventArgs e) //Mentre il form si sta chiudendo, visualizza il messaggio che chiede all'utente se è sicuro di uscire oppure no. 
        {
            if (chiusuraGioco == true)
            {
                var conferma = MessageBox.Show("Sei sicuro di voler uscire dal gioco?\nOgni progresso non salvato andrà perso.", "Chiusura gioco...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (conferma == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void FormGioco_FormClosed(object sender, FormClosedEventArgs e) //Quando il form è chiuso, esce del tutto dall'applicazione. 
        {
            Application.Exit();
        }

        private async void AggiornaEtichette() //Metodo che consente di aggiornare il testo degli oggetti Label contenuti nel form. 
        {
            EtichetteGioco[1].Text = "👋 Benvenuti nel gioco!";
            EtichetteGioco[2].Text = "⌚ Un attimo e sarà il caso a decidere chi comincerà per primo!";
            await Task.Delay(3000);
            EtichetteGioco[2].Text = $"Numero turno: {numeroTurno}\n\nAbbinamenti corretti:\n {DatiGiocatori[0, 0]}: {DatiGiocatori[0, 1]}\n {DatiGiocatori[1, 0]}: {DatiGiocatori[1, 1]} ";
            int n = NumeroCasuale.Next(0, 2);
            switch (n)
            {
                case (0):
                    giocatoreTurno = 0;
                    break;
                case (1):
                    giocatoreTurno = 1;
                    break;
            }
            if (G2() == -1) 
            {
                OperazioniTessere.AttivaDisattivaTessere(true);
                EtichetteGioco[1].Text = $"Il primo a giocare è { DatiGiocatori[giocatoreTurno, 0]}.";
            }
        }

        //Metodi relativi agli oggetti tornaAlMenuInizialeToolStripMenuItem e chiudiIlGiocoToolStripMenuItem (entrambi ToolStripMenuItem), che si trovano all'interno del menu Partita.

        private void tornaAlMenuInizialeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chiusuraGioco = false;
            var conferma = MessageBox.Show("Sei sicuro di voler ritornare al menu principale?\nOgni progresso non salvato verrà perso.", "Torna al menu principale", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (conferma == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void chiudiIlGiocoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Metodi relativi agli oggetti fioriToolStripMenuItem, animaliToolStripMenuItem e professoriToolStripMenuItem (tutti ToolStripMenuItem), che si trovano all'interno del menu Visualizzazione e consentono la scelta del set di tessere.

        private void fioriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fioriToolStripMenuItem.Checked == false)
            {
                codiceSetCarte = 0;
                fioriToolStripMenuItem.Checked = true;
                animaliToolStripMenuItem.Checked = false;
                professoriToolStripMenuItem.Checked = false;
                AvvisoCambioSetCarte();
            }
        }

        private void animaliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (animaliToolStripMenuItem.Checked == false)
            {
                codiceSetCarte = 1;
                fioriToolStripMenuItem.Checked = false;
                animaliToolStripMenuItem.Checked = true;
                professoriToolStripMenuItem.Checked = false;
                AvvisoCambioSetCarte();
            }
        }

        private void professoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (professoriToolStripMenuItem.Checked == false)
            {
                codiceSetCarte = 2;
                fioriToolStripMenuItem.Checked = false;
                animaliToolStripMenuItem.Checked = false;
                professoriToolStripMenuItem.Checked = true;
                AvvisoCambioSetCarte();
            }
        }

        private void AvvisoCambioSetCarte()
        {
            MessageBox.Show("Le modifiche verranno applicate al prossimo turno di gioco.", "Cambio set carte", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        // Metodi relativi agli oggetti bluToolStripMenuItem, arancioToolStripMenuItem, gialloToolStripMenuItem, verdeToolStripMenuItem, iISViolaMarchesiniToolStripMenuItem (tutti ToolStripMenuItem), che si trovano all'interno del menu Visualizzazione e consentono la scelta di set di colori.

        private void bluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codiceSetColore = 0;
            sfondoTesseraNascosta = OperazioniTessere.CambioSetColori(codiceSetColore, false);
            bluToolStripMenuItem.Checked = true;
        }

        private void arancioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codiceSetColore = 1;
            sfondoTesseraNascosta = OperazioniTessere.CambioSetColori(codiceSetColore, false);
            arancioToolStripMenuItem.Checked = true;
        }

        private void gialloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codiceSetColore = 2;
            sfondoTesseraNascosta = OperazioniTessere.CambioSetColori(codiceSetColore, false);
            gialloToolStripMenuItem.Checked = true;
        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codiceSetColore = 3;
            sfondoTesseraNascosta = OperazioniTessere.CambioSetColori(codiceSetColore, false);
            verdeToolStripMenuItem.Checked = true;
        }

        private void iISViolaMarchesiniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codiceSetColore = 4;
            sfondoTesseraNascosta = OperazioniTessere.CambioSetColori(codiceSetColore, false);
            iISViolaMarchesiniToolStripMenuItem.Checked = true;
        }

        //Metodi relativi agli oggetti informazioniSulGiocoToolStripMenuItem e regoleDelGiocoToolStripMenuItem (entrambi ToolStripMenuItem), che si trovano all'interno del menu Aiuto (?).

        private void informazioniSulGiocoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Il gioco del Memory.\n\nVersione di test.\nVersione .NET Framework 4.7.2 \nTutti i diritti riservati a Rasvenburger.", "Informazioni sul gioco...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void regoleDelGiocoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vengono disposte tutte le tessere coperte sul tabellone." + "\nA turno ciascun giocatore gira due tessere facendole vedere anche agli avversari." +
                "\nLo scopo è quello di abbinare un’ immagine con la frazione corrispondente: se le due tessere girate costituiscono una buona coppia il giocatore le prende e " +
                "tocca ancora a lui finché non sbaglia; se le due tessere non rappresentano la stessa frazione deve rigirarle e tocca al giocatore successivo." +
                "\nIl gioco termina quando non ci sono più tessere sul tavolo: vince chi ne ha raccolte di più.", "Regole del gioco", MessageBoxButtons.OK);
        }


        //Metodi relativi agli oggetti da tessera0Btn a tessera15Btn (tutti Button).

        private void tessera0Btn_Click(object sender, EventArgs e)
        {
            MostraImmagineTessera(0, tessera0Btn);
            G2();
        }

        private void tessera1Btn_Click(object sender, EventArgs e)
        {
            MostraImmagineTessera(1, tessera1Btn);
            G2();
        }

        private void tessera2Btn_Click(object sender, EventArgs e)
        {
            MostraImmagineTessera(2, tessera2Btn);
            G2();
        }

        private void tessera3Btn_Click(object sender, EventArgs e)
        {
            MostraImmagineTessera(3, tessera3Btn);
            G2();
        }

        private void tessera4Btn_Click(object sender, EventArgs e)
        {
            MostraImmagineTessera(4, tessera4Btn);
            G2();
        }

        private void tessera5Btn_Click(object sender, EventArgs e)
        {
            MostraImmagineTessera(5, tessera5Btn);
            G2();
        }

        private void tessera6Btn_Click(object sender, EventArgs e)
        {
            MostraImmagineTessera(6, tessera6Btn);
            G2();
        }

        private void tessera7Btn_Click(object sender, EventArgs e)
        {
            MostraImmagineTessera(7, tessera7Btn);
            G2();
        }

        private void tessera8Btn_Click(object sender, EventArgs e)
        {
            MostraImmagineTessera(8, tessera8Btn);
            G2();
        }

        private void tessera9Btn_Click(object sender, EventArgs e)
        {
            MostraImmagineTessera(9, tessera9Btn);
            G2();
        }

        private void tessera10Btn_Click(object sender, EventArgs e)
        {
            MostraImmagineTessera(10, tessera10Btn);
            G2();
        }

        private void tessera11Btn_Click(object sender, EventArgs e)
        {
            MostraImmagineTessera(11, tessera11Btn);
            G2();
        }

        private void tessera12Btn_Click(object sender, EventArgs e)
        {
           MostraImmagineTessera(12, tessera12Btn);
            G2();
        }

        private void tessera13Btn_Click(object sender, EventArgs e)
        {
            MostraImmagineTessera(13, tessera13Btn);
            G2();
        }

        private void tessera14Btn_Click(object sender, EventArgs e)
        {
            MostraImmagineTessera(14, tessera14Btn);
            G2();
        }

        private void tessera15Btn_Click(object sender, EventArgs e)
        {
            MostraImmagineTessera(15, tessera15Btn);
            G2();
            
        }

        //Metodi che permettono lo svolgimento del gioco.

        public int G2()
        {
            int n = -1;
            if (DatiGiocatori[giocatoreTurno, 0] == "G2")
            {
                do
                {
                    int[] NumeriTessere = OperazioniTessere.OperazioniG2();
                    for (int i = 0; i < NumeriTessere.Length; i++)
                    {
                        MostraImmagineTessera(NumeriTessere[i], TessereGioco[NumeriTessere[i]]);
                        Task.Delay(500).Wait();
                    }
                }
                while (verifica == false);
                n = 0;
            }
            return n;
        } //Metodo che contiene le operazioni da eseguire nel caso in cui si abbia un giocatore controllato dal computer.

        public void MostraImmagineTessera(int numeroTessera, Button tessera)
        {
            tessera.BackgroundImage = OperazioniTessere.ImmaginiTessereGirate[numeroTessera];
            tessera.Enabled = false;
            if (TessereCliccate[0] == null)
            {
                TessereCliccate[0] = tessera;
                PosizioneTessereCliccate[0] = numeroTessera;
            }
            else
            {
                TessereCliccate[1] = tessera;
                PosizioneTessereCliccate[1] = numeroTessera;
                ConfermaAbbinamento();
            }
        } //Metodo che visualizza la parte nascosta delle tessere.

        private void ConfermaAbbinamento()
        {
            if (OperazioniTessere.IDCarte[PosizioneTessereCliccate[0]] == OperazioniTessere.IDCarte[PosizioneTessereCliccate[1]])
            {
                Task.Delay(750).Wait();
                for (int i = 0; i < TessereCliccate.Length; i++)
                {
                    TessereCliccate[i].Visible = false;
                }
                DatiGiocatori[giocatoreTurno, 1] = Convert.ToString(Convert.ToInt32(DatiGiocatori[giocatoreTurno, 1]) + 1);
                EtichetteGioco[2].Text = $"Numero turno: {numeroTurno}\n\nAbbinamenti corretti:\n {DatiGiocatori[0, 0]}: {DatiGiocatori[0, 1]}\n {DatiGiocatori[1, 0]}: {DatiGiocatori[1, 1]} ";
                verifica = false;
            }
            else
            {
                Task.Delay(750).Wait();
                OperazioniTessere.AttivaDisattivaTessere(true);
                OperazioniTessere.CambioImmagineTessereNascoste(codiceSetColore, false);
                switch (giocatoreTurno)
                {
                    case (0):
                        giocatoreTurno = 1;
                        break;
                    case (1):
                        giocatoreTurno = 0;
                        break;
                }
                if (DatiGiocatori[giocatoreTurno, 0] != "G2")
                {
                    EtichetteGioco[1].Text = $"{DatiGiocatori[giocatoreTurno, 0]}, è il tuo turno!";
                }
                verifica = true;
            }
            if (Convert.ToInt32(DatiGiocatori[0, 1]) + Convert.ToInt32(DatiGiocatori[1, 1]) == (numeroTurno * 8))
            {
                ProclamazioneVincitore();
            }
            for (int i = 0; i < TessereCliccate.Length; i++)
            {
                TessereCliccate[i] = null;
            }
        } //Metodo che verifica se gli abbinamenti effettuati dai giocatori sono corretti o meno.

        public void ProclamazioneVincitore()
        {
            if (Convert.ToInt32(DatiGiocatori[0, 1]) > Convert.ToInt32(DatiGiocatori[1, 1]))
            {
                MessageBox.Show($"Evviva! Il turno è finito e lo ha vinto {DatiGiocatori[0, 0]}\ncon {DatiGiocatori[0, 1]} abbinamenti corretti.", "Fine turno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Convert.ToInt32(DatiGiocatori[0, 1]) < Convert.ToInt32(DatiGiocatori[1, 1]))
            {
                MessageBox.Show($"Evviva! Il turno è finito e lo ha vinto {DatiGiocatori[1, 0]}\ncon {DatiGiocatori[1, 1]} abbinamenti corretti.", "Fine turno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Il turno è finito, ma non c'è nessun vincitore: entrambi voi giocatori avete ottenuto {DatiGiocatori[0, 1]} abbinamenti corretti.", "Fine turno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            indicatoreTurniLabel.Text = "😀\nIl turno è terminato...";
            indicatoreAbbinamentiLabel.Text = "⬅\nScegli cosa fare premendo uno dei bottoni a sinistra...";
            rimescolaTesserePanel.Visible = true;
            rimescolaTessereBtn.Visible = true;
            esciBtn.Visible = true;
            verifica = true;

        } //Metodo richiamato nel caso in cui le tessere siano esaurite e ci sia bisogno di indicare il vincitore del turno.

        //Metodi relativi agli oggetti rimescolaTessereBtn e esciBtn (entrambi Button), che vengono visualizzati solamente alla fine di un turno e permettono di continuare la partita, oppure di uscire.

        private void rimescolaTessereBtn_Click(object sender, EventArgs e)
        {
            numeroTurno++;
            rimescolaTesserePanel.Visible = false;
            rimescolaTessereBtn.Visible = false;
            esciBtn.Visible = false;
            OperazioniTessere.CambioImmagineTessereNascoste(codiceSetColore, true);
            OperazioniTessere.VisibilitàTessere(true);
            OperazioniTessere.GeneraTessereCasuali(codiceSetCarte);
            AggiornaEtichette();
        }

        private void esciBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }

    public class OperazioniTessere //Classe che permette di eseguire la maggior parte delle operazioni sulle tessere.
    {
        //Dichiarazione e assegnazione delle variabili.

        ToolStripMenuItem[] SceltaSetColori, SceltaSetCarte;
        Button[] TessereGioco;
        Label[] EtichetteGioco;
        Panel rimescolaTesserePanel;
        public Image[] ImmaginiTessereGirate = new Image[16];
        public Image sfondoTesseraNascosta;
        public Button primaTessera, secondaTessera;
        public int uno, due, numeroTurno;
        public int[] IDCarte = new int[16];

        //Metodi costruttori

        private Random NumeroCasuale = new Random(); //Metodo costruttore della classe NumeroCasuale che permette di usare i metodi che generano numeri casuali.

        public OperazioniTessere(ToolStripMenuItem[] SceltaSetColori, ToolStripMenuItem[] SceltaSetCarte, Button[] TessereGioco, Label[] EtichetteGioco, Panel rimescolaTesserePanel, Image sfondoTesseraNascosta) //Metodo costruttore della classe OperazioniTessere.
        {
            this.SceltaSetColori = SceltaSetColori;
            this.SceltaSetCarte = SceltaSetCarte;
            this.TessereGioco = TessereGioco;
            this.EtichetteGioco = EtichetteGioco;
            this.rimescolaTesserePanel = rimescolaTesserePanel;
            this.sfondoTesseraNascosta = sfondoTesseraNascosta;
        }
        
        public int[] OperazioniG2() //Metodo che permette di eseguire in automatico le operazioni di G2. 
        {
            EtichetteGioco[1].Text = "G2 sta giocando il suo turno...";
            int[] NumeriTessere = new int[2];
            for (int i = 0; i < TessereGioco.Length; i++)
            {
                TessereGioco[i].Enabled = false;
            }
            Task.Delay(1000).Wait();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < TessereGioco.Length; j++)
                {
                    do
                    {
                        NumeriTessere[i] = NumeroCasuale.Next(0, 16);
                    }
                    while (TessereGioco[NumeriTessere[i]].Visible == false || (NumeriTessere[0] == NumeriTessere[1] && i != 0));
                }
            }
            return NumeriTessere;
            
        } 
        
        public Image CambioSetColori(int n, bool verifica) //Metodo che permette di cambiare il set di colori del gioco in base a quanto stabilito dall'utente.
        {
            for (int i = 0; i < SceltaSetColori.Length; i++)
            {
                SceltaSetColori[i].Checked = false;
            }
            switch (n)
            {
                case 0:
                    CambioImmagineTessereNascoste(n, verifica);
                    for (int j = 0; j < EtichetteGioco.Length; j++)
                    {
                        EtichetteGioco[j].BackColor = Color.AliceBlue;
                    }
                    rimescolaTesserePanel.BackColor = Color.AliceBlue;
                    break;
                case 1:
                    CambioImmagineTessereNascoste(n, verifica);
                    for (int j = 0; j < EtichetteGioco.Length; j++)
                    {
                        EtichetteGioco[j].BackColor = Color.SeaShell;
                    }
                    rimescolaTesserePanel.BackColor = Color.SeaShell;
                    break;
                case 2:
                    CambioImmagineTessereNascoste(n, verifica);
                    for (int j = 0; j < EtichetteGioco.Length; j++)
                    {
                        EtichetteGioco[j].BackColor = Color.Cornsilk;
                    }
                    rimescolaTesserePanel.BackColor = Color.Cornsilk;
                    break;
                case 3:
                    CambioImmagineTessereNascoste(n, verifica);
                    for (int j = 0; j < EtichetteGioco.Length; j++)
                    {
                        EtichetteGioco[j].BackColor = Color.Honeydew;
                    }
                    rimescolaTesserePanel.BackColor = Color.Honeydew;
                    break;
                case 4:
                    CambioImmagineTessereNascoste(n, verifica);
                    for (int j = 0; j < EtichetteGioco.Length; j++)
                    {
                        EtichetteGioco[j].BackColor = Color.Azure;
                    }
                    rimescolaTesserePanel.BackColor = Color.Azure;
                    break;
            }
            return sfondoTesseraNascosta;
        } 
        
        public Image CambioImmagineTessereNascoste(int n, bool verifica) //Metodo che permette di cambiare il set di immagini, che rappresentano la tessera nascosta del gioco, in base a quanto stabilito dall'utente.
        {
            for (int i = 0; i < TessereGioco.Length; i++)
            {
                if (TessereGioco[i].Enabled == true || verifica == true) 
                {
                    switch (n)
                    {
                        case (0):
                            TessereGioco[i].BackgroundImage = Properties.Resources.punto_domanda_blu;
                            sfondoTesseraNascosta = Properties.Resources.punto_domanda_blu;
                            break;
                        case (1):
                            TessereGioco[i].BackgroundImage = Properties.Resources.punto_domanda_arancio;
                            sfondoTesseraNascosta = Properties.Resources.punto_domanda_arancio;
                            break;
                        case (2):
                            TessereGioco[i].BackgroundImage = Properties.Resources.punto_domanda_giallo;
                            sfondoTesseraNascosta = Properties.Resources.punto_domanda_giallo;
                            break;
                        case (3):
                            TessereGioco[i].BackgroundImage = Properties.Resources.punto_domanda_verde;
                            sfondoTesseraNascosta = Properties.Resources.punto_domanda_verde;
                            break;
                        case (4):
                            TessereGioco[i].BackgroundImage = Properties.Resources.tessera_nascosta_itis;
                            sfondoTesseraNascosta = Properties.Resources.tessera_nascosta_itis;
                            break;
                    }
                }
                if (i == TessereGioco.Length - 1)
                {
                    verifica = false;
                }
            }
            return sfondoTesseraNascosta;
        } 
        
        public int [] GeneraTessereCasuali(int codiceSetCarte) //Metodo che permette di generare casualmente le tessere che dovranno essere visualizzate al click di una tessera del tabellone.
        {
            int[] ContatoreCollisioni = new int[8];
            for (int i = 0; i < ImmaginiTessereGirate.Length; i++)
            {
                int numeroGenerato = NumeroCasuale.Next(0, 8);
                switch (numeroGenerato)
                {
                    case (0):
                        if (ContatoreCollisioni[0] < 2) 
                        {
                            switch(codiceSetCarte)
                            {
                                case (0):
                                    ImmaginiTessereGirate[i] = Properties.Resources.calla;
                                    break;
                                case (1):
                                    ImmaginiTessereGirate[i] = Properties.Resources.cavallo;
                                    break;
                                case (2):
                                    ImmaginiTessereGirate[i] = Properties.Resources.bagatin;
                                    break;
                            }
                            IDCarte[i] = 0;
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
                            switch (codiceSetCarte)
                            {
                                case (0):
                                    ImmaginiTessereGirate[i] = Properties.Resources.campanelle;
                                    break;
                                case (1):
                                    ImmaginiTessereGirate[i] = Properties.Resources.gallina;
                                    break;
                                case (2):
                                    ImmaginiTessereGirate[i] = Properties.Resources.bononi;
                                    break;
                            }
                            IDCarte[i] = 1;
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
                            switch (codiceSetCarte)
                            {
                                case (0):
                                    ImmaginiTessereGirate[i] = Properties.Resources.girasole;
                                    break;
                                case (1):
                                    ImmaginiTessereGirate[i] = Properties.Resources.leone;
                                    break;
                                case (2):
                                    ImmaginiTessereGirate[i] = Properties.Resources.dall_ara;
                                    break;
                            }
                            IDCarte[i] = 2;
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
                            switch (codiceSetCarte)
                            {
                                case (0):
                                    ImmaginiTessereGirate[i] = Properties.Resources.lavanda;
                                    break;
                                case (1):
                                    ImmaginiTessereGirate[i] = Properties.Resources.maiale;
                                    break;
                                case (2):
                                    ImmaginiTessereGirate[i] = Properties.Resources.gregnanin;
                                    break;
                            }
                            IDCarte[i] = 3;
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
                            switch (codiceSetCarte)
                            {
                                case (0):
                                    ImmaginiTessereGirate[i] = Properties.Resources.margherita;
                                    break;
                                case (1):
                                    ImmaginiTessereGirate[i] = Properties.Resources.mucca;
                                    break;
                                case (2):
                                    ImmaginiTessereGirate[i] = Properties.Resources.melon;
                                    break;
                            }
                            IDCarte[i] = 4;
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
                            switch (codiceSetCarte)
                            {
                                case (0):
                                    ImmaginiTessereGirate[i] = Properties.Resources.rosa;
                                    break;
                                case (1):
                                    ImmaginiTessereGirate[i] = Properties.Resources.panda;
                                    break;
                                case (2):
                                    ImmaginiTessereGirate[i] = Properties.Resources.Nino;
                                    break;
                            }
                            IDCarte[i] = 5;
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
                            switch (codiceSetCarte)
                            {
                                case (0):
                                    ImmaginiTessereGirate[i] = Properties.Resources.stella_alpina;
                                    break;
                                case (1):
                                    ImmaginiTessereGirate[i] = Properties.Resources.pulcino;
                                    break;
                                case (2):
                                    ImmaginiTessereGirate[i] = Properties.Resources.padovani;
                                    break;
                            }
                            IDCarte[i] = 6;
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
                            switch (codiceSetCarte)
                            {
                                case (0):
                                    ImmaginiTessereGirate[i] = Properties.Resources.tulipano;
                                    break;
                                case (1):
                                    ImmaginiTessereGirate[i] = Properties.Resources.scimpanzè;
                                    break;
                                case (2):
                                    ImmaginiTessereGirate[i] = Properties.Resources.raspa;
                                    break;
                            }
                            IDCarte[i] = 7;
                            ContatoreCollisioni[7]++;
                        }
                        else
                        {
                            i--;
                        }
                        break;
                }
            }
            return IDCarte;
        } 

        public void AttivaDisattivaTessere(bool attivoNonAttivo) //Metodo che permette di attivare o disattivare le tessere del tabellone in base al valore che gli viene passato.
        {
            for (int i = 0; i < TessereGioco.Length; i++)
            {
                TessereGioco[i].Enabled = attivoNonAttivo;
            }
        } 

        public void VisibilitàTessere(bool visibiliNonVisibili) //Metodo che permette di rendere visibili o invisibili le tessere del tabellone in base al valore che gli viene passato.
        {
            for (int i = 0; i < TessereGioco.Length; i++)
            {
                TessereGioco[i].Visible = visibiliNonVisibili;
            }
        } 

        public void ModalitàSegreta() //Metodo speciale eseguito solo quando viene attivata la modalita "segreta" ITIS Viola.
        {
            EtichetteGioco[0].Text = "Memory del Viola";
            SceltaSetColori[0].Checked = false;
            SceltaSetCarte[0].Checked = false;
            SceltaSetCarte[2].Visible = true;
            SceltaSetCarte[2].Checked = true;
            SceltaSetColori[4].Visible = true;
            SceltaSetColori[4].Checked = true;
        } 
    }
}
