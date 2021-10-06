/* Autore: Francesco Di Lena
 * Classe: 4 F
 * Consegna: creare un videogioco, Memory, attraverso l'uso del framework Windows Forms e il linguaggio di programmazione C#.
 * Form gioco.
 */

using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryApp
{
    public partial class FormGioco : Form
    {
        Button[] TessereGioco;
        int GiocatoreTurno = 0;
        string[,] datiGiocatori = new string[2, 2];
        Random NumeroCasuale = new Random();
        Button primaTessera = null, secondaTessera = null;
        Image SfondoTesseraNascosta = Properties.Resources.punto_domanda_blu;
        int uno = 0, due = 0, numeroTurno = 1;
        Gioco OperazioniTessere = new Gioco();
        public FormGioco(string [,] datiGiocatori)
        {
            InitializeComponent();
            this.datiGiocatori = datiGiocatori;
            TessereGioco = new Button[] { tessera0Btn, tessera1Btn, tessera2Btn, tessera3Btn, tessera4Btn, tessera5Btn, tessera6Btn, tessera7Btn, tessera8Btn, tessera9Btn, tessera10Btn, tessera11Btn, tessera12Btn, tessera13Btn, tessera14Btn, tessera15Btn };
        }

        private void FormGioco_Load(object sender, EventArgs e)
        {
            OperazioniTessere.GeneraTessereCasuali(0);
            Attendi();
        }

        public async void Attendi()
        {
            await Task.Delay(3000);
            int n = NumeroCasuale.Next(0, 2);
            switch (n)
            {
                case (0):
                    GiocatoreTurno = 0;
                    break;
                case (1):
                    GiocatoreTurno = 1;
                    break;
            }
            for (int i = 0; i < TessereGioco.Length; i++)
            {
                TessereGioco[i].Enabled = true;
            }
            indicatoreTurniLabel.Text = $"Il primo a giocare è { datiGiocatori[GiocatoreTurno, 0]}.";
            indicatoreAbbinamentiLabel.Text = $"Numero turno: {numeroTurno}\n\nAbbinamenti corretti:\n {datiGiocatori[0,0] }: 0\n {datiGiocatori[1, 0]}: 0 ";
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
            bluToolStripMenuItem.Checked = false;
            arancioToolStripMenuItem.Checked = false;
            gialloToolStripMenuItem.Checked = false;
            verdeToolStripMenuItem.Checked = false;
            for (int i = 0; i < TessereGioco.Length; i++)
            {
                if(TessereGioco[i].Enabled==true)
                switch (n)
                {
                    case 0:
                            TessereGioco[i].BackgroundImage = Properties.Resources.punto_domanda_blu;
                            SfondoTesseraNascosta = Properties.Resources.punto_domanda_blu;
                            logoLabel.BackColor = Color.AliceBlue;
                            indicatoreTurniLabel.BackColor = Color.AliceBlue;
                            indicatoreAbbinamentiLabel.BackColor = Color.AliceBlue;
                            rimescolaTesserePanel.BackColor= Color.AliceBlue;
                            break;
                    case 1:
                            TessereGioco[i].BackgroundImage = Properties.Resources.punto_domanda_arancio;
                            SfondoTesseraNascosta = Properties.Resources.punto_domanda_arancio;
                            logoLabel.BackColor = Color.SeaShell;
                            indicatoreTurniLabel.BackColor = Color.SeaShell;
                            indicatoreAbbinamentiLabel.BackColor = Color.SeaShell;
                            rimescolaTesserePanel.BackColor = Color.SeaShell;
                            break;
                    case 2:
                            TessereGioco[i].BackgroundImage = Properties.Resources.punto_domanda_giallo;
                            SfondoTesseraNascosta = Properties.Resources.punto_domanda_giallo;
                            logoLabel.BackColor = Color.Cornsilk;
                            indicatoreTurniLabel.BackColor = Color.Cornsilk;
                            indicatoreAbbinamentiLabel.BackColor = Color.Cornsilk;
                            rimescolaTesserePanel.BackColor = Color.Cornsilk;
                            break;
                    case 3:
                            TessereGioco[i].BackgroundImage = Properties.Resources.punto_domanda_verde;
                            SfondoTesseraNascosta = Properties.Resources.punto_domanda_verde;
                            logoLabel.BackColor = Color.Honeydew;
                            indicatoreTurniLabel.BackColor = Color.Honeydew;
                            indicatoreAbbinamentiLabel.BackColor = Color.Honeydew;
                            rimescolaTesserePanel.BackColor = Color.Honeydew;
                            break;
                }
            }
        }
        private void tessera0Btn_Click(object sender, EventArgs e)
        {
            MostraImmagineTessera(0, tessera0Btn);
        }

        private void tessera1Btn_Click(object sender, EventArgs e)
        {
            MostraImmagineTessera(1, tessera1Btn);
        }

        private void tessera2Btn_Click(object sender, EventArgs e)
        {
            MostraImmagineTessera(2, tessera2Btn);
        }

        private void tessera3Btn_Click(object sender, EventArgs e)
        {
            MostraImmagineTessera(3, tessera3Btn);
        }

        private void tessera4Btn_Click(object sender, EventArgs e)
        {
            MostraImmagineTessera(4, tessera4Btn);
        }

        private void tessera5Btn_Click(object sender, EventArgs e)
        {
            MostraImmagineTessera(5, tessera5Btn);
        }

        private void tessera6Btn_Click(object sender, EventArgs e)
        {
            MostraImmagineTessera(6, tessera6Btn);
        }

        private void tessera7Btn_Click(object sender, EventArgs e)
        {
            MostraImmagineTessera(7, tessera7Btn);
        }

        private void tessera8Btn_Click(object sender, EventArgs e)
        {
            MostraImmagineTessera(8, tessera8Btn);
        }

        private void tessera9Btn_Click(object sender, EventArgs e)
        {
            MostraImmagineTessera(9, tessera9Btn);
        }

        private void tessera10Btn_Click(object sender, EventArgs e)
        {
            MostraImmagineTessera(10, tessera10Btn);
        }

        private void tessera11Btn_Click(object sender, EventArgs e)
        {
            MostraImmagineTessera(11, tessera11Btn);
        }

        private void tessera12Btn_Click(object sender, EventArgs e)
        {
            MostraImmagineTessera(12, tessera12Btn);
        }

        private void tessera13Btn_Click(object sender, EventArgs e)
        {
            MostraImmagineTessera(13, tessera13Btn);
        }

        private void tessera14Btn_Click(object sender, EventArgs e)
        {
            MostraImmagineTessera(14, tessera14Btn);
        }

        private void tessera15Btn_Click(object sender, EventArgs e)
        {
            MostraImmagineTessera(15, tessera15Btn);
        }

        public void MostraImmagineTessera(int numeroTessera, Button tessera)
        {
            tessera.BackgroundImage = OperazioniTessere.TessereGirate[numeroTessera];
            tessera.Enabled = false;
            if (primaTessera == null)
            {
                primaTessera = tessera;
                uno = numeroTessera;
            }
            else
            {
                secondaTessera = tessera;
                due = numeroTessera;
                ConfermaAbbinamento();
            }
        }

        public void ConfermaAbbinamento()
        {
            if (OperazioniTessere.idCarte[uno] == OperazioniTessere.idCarte[due]) 
            {
                Thread.Sleep(750);
                primaTessera.Visible = false;
                secondaTessera.Visible = false;
                int n = Convert.ToInt32(datiGiocatori[GiocatoreTurno, 1]);
                n++;
                datiGiocatori[GiocatoreTurno, 1] = Convert.ToString(n);
                indicatoreAbbinamentiLabel.Text = $"Numero turno: {numeroTurno}\n\nAbbinamenti corretti:\n {datiGiocatori[0, 0]}: {datiGiocatori[0, 1]}\n {datiGiocatori[1, 0]}: {datiGiocatori[1, 1]} ";

            }
            else
            {
                Thread.Sleep(750);
                primaTessera.BackgroundImage = SfondoTesseraNascosta;
                secondaTessera.BackgroundImage = SfondoTesseraNascosta;
                primaTessera.Enabled = true;
                secondaTessera.Enabled = true;
                switch(GiocatoreTurno)
                {
                    case (0):
                        GiocatoreTurno = 1;
                        break;
                    case (1):
                        GiocatoreTurno = 0;
                        break;
                }
                indicatoreTurniLabel.Text = $"{datiGiocatori[GiocatoreTurno, 0]}, è il tuo turno!";
            }
            if (Convert.ToInt32(datiGiocatori[0, 1]) + Convert.ToInt32(datiGiocatori[1, 1]) == (numeroTurno * 8)) 
            {
                ProclamazioneVincitore();
            }
            primaTessera = null;
            secondaTessera = null;
        }

        public void ProclamazioneVincitore()
        {
            if (Convert.ToInt32(datiGiocatori[0, 1]) > Convert.ToInt32(datiGiocatori[1, 1]))
            {
                MessageBox.Show($"Evviva! Il turno è finito e lo ha vinto {datiGiocatori[0, 0]}\ncon {datiGiocatori[0, 1]} abbinamenti corretti.");
            }
            else if(Convert.ToInt32(datiGiocatori[0, 1]) < Convert.ToInt32(datiGiocatori[1, 1]))
            {
                MessageBox.Show($"Evviva! Il turno è finito e lo ha vinto {datiGiocatori[1, 0]}\ncon {datiGiocatori[1, 1]} abbinamenti corretti.");
            }
            else
            {
                MessageBox.Show($"Il turno è finito, ma non c'è nessun vincitore: entrambi voi giocatori avete ottenuto {datiGiocatori[0, 1]} abbinamenti corretti.");
            }
            rimescolaTesserePanel.Visible = true;
            rimescolaTessereBtn.Visible = true;

        }

        private void FormGioco_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void informazioniSulGiocoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Il gioco del Memory.\n\nVersione di test.\nVersione .NET Framework 4.7.2 \nTutti i diritti riservati a Rasvenburger.", "Informazioni sul gioco...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tornaAlMenuInizialeToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

        private void fioriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fioriToolStripMenuItem.Checked == false)
            {
                fioriToolStripMenuItem.Checked = true;
                animaliToolStripMenuItem.Checked = false;
                AvvisoCambioSetCarte();
            }
        }

        private void rimescolaTessereBtn_Click(object sender, EventArgs e)
        {
            numeroTurno++;
            rimescolaTesserePanel.Visible = false;
            rimescolaTessereBtn.Visible = false;
            if (fioriToolStripMenuItem.Checked == true)
            {
                OperazioniTessere.GeneraTessereCasuali(0);
            }
            else
            {
                OperazioniTessere.GeneraTessereCasuali(1);
            }
            for (int i = 0; i < TessereGioco.Length; i++)
            {
                TessereGioco[i].BackgroundImage = SfondoTesseraNascosta;
                TessereGioco[i].Enabled = true;
                TessereGioco[i].Visible = true;
            }
        }

        private void animaliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (animaliToolStripMenuItem.Checked == false)
            {
                fioriToolStripMenuItem.Checked = false;
                animaliToolStripMenuItem.Checked = true;
                AvvisoCambioSetCarte();
            }
        }

        public void AvvisoCambioSetCarte()
        {
            MessageBox.Show("Le modifiche verranno applicate al prossimo turno di gioco.", "Cambio set carte", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

    }
    public class Gioco
    {
        public int[] idCarte = new int[16];
        public Image[] TessereGirate = new Image[16];
        Random NumeroCasuale = new Random();
        public void GeneraTessereCasuali(int codiceSetTessere)
        {
            int[] ContatoreCollisioni = new int[8];
            for (int i = 0; i < TessereGirate.Length; i++)
            {
                int numeroGenerato = NumeroCasuale.Next(0, 8);
                switch (numeroGenerato)
                {
                    case (0):
                        if (ContatoreCollisioni[0] < 2) 
                        {
                            if (codiceSetTessere == 0)
                            {
                                TessereGirate[i] = Properties.Resources.calla;
                            }
                            else
                            {
                                TessereGirate[i] = Properties.Resources.cavallo;
                            }
                            idCarte[i] = 0;
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
                            if (codiceSetTessere == 0)
                            {
                                TessereGirate[i] = Properties.Resources.campanelle;
                            }
                            else
                            {
                                TessereGirate[i] = Properties.Resources.gallina;
                            }
                            idCarte[i] = 1;
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
                            if (codiceSetTessere == 0)
                            {
                                TessereGirate[i] = Properties.Resources.girasole;
                            }
                            else
                            {
                                TessereGirate[i] = Properties.Resources.leone;
                            }
                            idCarte[i] = 2;
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
                            if (codiceSetTessere == 0)
                            {
                                TessereGirate[i] = Properties.Resources.lavanda;
                            }
                            else
                            {
                                TessereGirate[i] = Properties.Resources.maiale;
                            }
                            idCarte[i] = 3;
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
                            if (codiceSetTessere == 0)
                            {
                                TessereGirate[i] = Properties.Resources.margherita;
                            }
                            else
                            {
                                TessereGirate[i] = Properties.Resources.mucca;
                            }
                            idCarte[i] = 4;
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
                            if (codiceSetTessere == 0)
                            {
                                TessereGirate[i] = Properties.Resources.rosa;
                            }
                            else
                            {
                                TessereGirate[i] = Properties.Resources.panda;
                            }
                            idCarte[i] = 5;
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
                            if (codiceSetTessere == 0)
                            {
                                TessereGirate[i] = Properties.Resources.stella_alpina;
                            }
                            else
                            {
                                TessereGirate[i] = Properties.Resources.pulcino;
                            }
                            idCarte[i] = 6;
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
                            if (codiceSetTessere == 0)
                            {
                                TessereGirate[i] = Properties.Resources.tulipano;
                            }
                            else
                            {
                                TessereGirate[i] = Properties.Resources.scimpanzè;
                            }
                            idCarte[i] = 7;
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
