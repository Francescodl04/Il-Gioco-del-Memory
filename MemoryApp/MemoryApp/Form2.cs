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
        static Button[] TessereGioco;
        static ToolStripMenuItem[] SceltaSetColori;
        static Label[] EtichetteGioco;
        int GiocatoreTurno = 0;
        string[,] datiGiocatori = new string[2, 2];
        Random NumeroCasuale = new Random();
        Image sfondoTesseraNascosta = Properties.Resources.punto_domanda_blu;
        int numeroTurno = 1;
        Button[] TessereCliccate = new Button[2];
        int[] PosizioneTessereCliccate = new int[2];
        int[] IDCarte;
        OperazioniTessere OperazioniTessere;
        public FormGioco(string [,] datiGiocatori)
        {
            InitializeComponent();
            this.datiGiocatori = datiGiocatori;
            TessereGioco = new Button[] { tessera0Btn, tessera1Btn, tessera2Btn, tessera3Btn, tessera4Btn, tessera5Btn, tessera6Btn, tessera7Btn, tessera8Btn, tessera9Btn, tessera10Btn, tessera11Btn, tessera12Btn, tessera13Btn, tessera14Btn, tessera15Btn };
            SceltaSetColori = new ToolStripMenuItem[] { bluToolStripMenuItem, arancioToolStripMenuItem, gialloToolStripMenuItem, verdeToolStripMenuItem };
            EtichetteGioco = new Label[] { logoLabel, indicatoreTurniLabel, indicatoreAbbinamentiLabel };
            OperazioniTessere = new OperazioniTessere(SceltaSetColori, TessereGioco, EtichetteGioco, rimescolaTesserePanel, sfondoTesseraNascosta);
        }

        private void FormGioco_Load(object sender, EventArgs e)
        {
            IDCarte = OperazioniTessere.GeneraTessereCasuali(0);
            Attendi();
        }

        private async void Attendi()
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
            if (G2() == -1) 
            {
                for (int i = 0; i < TessereGioco.Length; i++)
                {
                    TessereGioco[i].Enabled = true;
                }
                indicatoreTurniLabel.Text = $"Il primo a giocare è { datiGiocatori[GiocatoreTurno, 0]}.";
            }
            indicatoreAbbinamentiLabel.Text = $"Numero turno: {numeroTurno}\n\nAbbinamenti corretti:\n {datiGiocatori[0,0] }: 0\n {datiGiocatori[1, 0]}: 0 ";
        }

        private void bluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfondoTesseraNascosta = OperazioniTessere.DisattivaSelezione(0);
            bluToolStripMenuItem.Checked = true;
        }

        private void arancioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfondoTesseraNascosta = OperazioniTessere.DisattivaSelezione(1);
            arancioToolStripMenuItem.Checked = true;
        }

        private void gialloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfondoTesseraNascosta = OperazioniTessere.DisattivaSelezione(2);
            gialloToolStripMenuItem.Checked = true;
        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfondoTesseraNascosta = OperazioniTessere.DisattivaSelezione(3);
            verdeToolStripMenuItem.Checked = true;
        }

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
        public int G2()
        {
            int n = -1;
            if (datiGiocatori[GiocatoreTurno, 0] == "G2")
            {
                int[] NumeriTessere = OperazioniTessere.OperazioniG2();
                for (int i = 0; i < NumeriTessere.Length; i++)
                {
                    MostraImmagineTessera(NumeriTessere[i], TessereGioco[NumeriTessere[i]]);
                }
                n = 0;
            }
            return n;
        }
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
        }

        private void ConfermaAbbinamento()
        {
            if (OperazioniTessere.IDCarte[PosizioneTessereCliccate[0]] == OperazioniTessere.IDCarte[PosizioneTessereCliccate[1]]) 
            {
                Thread.Sleep(750);
                for (int i = 0; i < TessereCliccate.Length; i++)
                {
                    TessereCliccate[i].Visible = false;
                }
                int n = Convert.ToInt32(datiGiocatori[GiocatoreTurno, 1]);
                n++;
                datiGiocatori[GiocatoreTurno, 1] = Convert.ToString(n);
                EtichetteGioco[2].Text = $"Numero turno: {numeroTurno}\n\nAbbinamenti corretti:\n {datiGiocatori[0, 0]}: {datiGiocatori[0, 1]}\n {datiGiocatori[1, 0]}: {datiGiocatori[1, 1]} ";
            }
            else
            {
                Thread.Sleep(750);
                for (int i = 0; i < TessereGioco.Length; i++)
                {
                    TessereGioco[i].BackgroundImage = sfondoTesseraNascosta;
                    TessereGioco[i].Enabled = true;
                }
                switch (GiocatoreTurno)
                {
                    case (0):
                        GiocatoreTurno = 1;
                        break;
                    case (1):
                        GiocatoreTurno = 0;
                        break;
                }
                if (datiGiocatori[GiocatoreTurno, 0] != "G2")
                {
                    EtichetteGioco[1].Text = $"{datiGiocatori[GiocatoreTurno, 0]}, è il tuo turno!";
                }
            }
            if (Convert.ToInt32(datiGiocatori[0, 1]) + Convert.ToInt32(datiGiocatori[1, 1]) == (numeroTurno * 8))
            {
                ProclamazioneVincitore();
            }
            for (int i = 0; i < TessereCliccate.Length; i++)
            {
                TessereCliccate[i] = null;
            }
        }

        public void ProclamazioneVincitore()
        {
            if (Convert.ToInt32(datiGiocatori[0, 1]) > Convert.ToInt32(datiGiocatori[1, 1]))
            {
                MessageBox.Show($"Evviva! Il turno è finito e lo ha vinto {datiGiocatori[0, 0]}\ncon {datiGiocatori[0, 1]} abbinamenti corretti.");
            }
            else if (Convert.ToInt32(datiGiocatori[0, 1]) < Convert.ToInt32(datiGiocatori[1, 1]))
            {
                MessageBox.Show($"Evviva! Il turno è finito e lo ha vinto {datiGiocatori[1, 0]}\ncon {datiGiocatori[1, 1]} abbinamenti corretti.");
            }
            else
            {
                MessageBox.Show($"Il turno è finito, ma non c'è nessun vincitore: entrambi voi giocatori avete ottenuto {datiGiocatori[0, 1]} abbinamenti corretti.");
            }
            rimescolaTesserePanel.Visible = true;
            rimescolaTessereBtn.Visible = true;
            esciBtn.Visible = true;

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
            esciBtn.Visible = false;
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
                TessereGioco[i].BackgroundImage = sfondoTesseraNascosta;
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

        private void AvvisoCambioSetCarte()
        {
            MessageBox.Show("Le modifiche verranno applicate al prossimo turno di gioco.", "Cambio set carte", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void esciBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    public class OperazioniTessere
    {
        public int[] IDCarte = new int[16];
        public Button primaTessera, secondaTessera;
        public int uno , due, numeroTurno;
        public Image[] ImmaginiTessereGirate = new Image[16];
        public Image sfondoTesseraNascosta;
        Random NumeroCasuale = new Random();
        ToolStripMenuItem [] SceltaSetColori;
        Button[] TessereGioco;
        Label[] EtichetteGioco;
        Panel rimescolaTesserePanel;
        public OperazioniTessere(ToolStripMenuItem[] SceltaSetColori, Button[] TessereGioco, Label[] EtichetteGioco, Panel rimescolaTesserePanel, Image sfondoTesseraNascosta)
        {
            this.SceltaSetColori = SceltaSetColori;
            this.TessereGioco = TessereGioco;
            this.EtichetteGioco = EtichetteGioco;
            this.rimescolaTesserePanel = rimescolaTesserePanel;
            this.sfondoTesseraNascosta = sfondoTesseraNascosta;
        }
        public int[] OperazioniG2()
        {
            Attendi();
            int[] NumeriTessere = new int[2];
            for (int i = 0; i < TessereGioco.Length; i++)
            {
                TessereGioco[i].Enabled = false;
            }
            for (int i = 0; i < 2; i++)
            {
                do
                {
                    NumeriTessere[i] = NumeroCasuale.Next(0, 16);
                }
                while (TessereGioco[NumeriTessere[i]].Visible == false);
            }
            return NumeriTessere;
            
        }
        public async void Attendi()
        {
            await Task.Delay(2000);
            EtichetteGioco[1].Text = "G2 sta giocando il suo turno...";

        }
        public Image DisattivaSelezione(int n)
        {
            for (int i = 0; i < SceltaSetColori.Length; i++)
            {
                SceltaSetColori[i].Checked = false;
            }
            for (int i = 0; i < TessereGioco.Length; i++)
            {
                if (TessereGioco[i].Enabled == true)
                    switch (n)
                    {
                        case 0:
                            TessereGioco[i].BackgroundImage = Properties.Resources.punto_domanda_blu;
                            sfondoTesseraNascosta = Properties.Resources.punto_domanda_blu;
                            for (int j = 0; j < EtichetteGioco.Length; j++)
                            {
                                EtichetteGioco[j].BackColor = Color.AliceBlue;
                            }
                            rimescolaTesserePanel.BackColor = Color.AliceBlue;
                            break;
                        case 1:
                            TessereGioco[i].BackgroundImage = Properties.Resources.punto_domanda_arancio;
                            sfondoTesseraNascosta = Properties.Resources.punto_domanda_arancio;
                            for (int j = 0; j < EtichetteGioco.Length; j++)
                            {
                                EtichetteGioco[j].BackColor = Color.SeaShell;
                            }
                            rimescolaTesserePanel.BackColor = Color.SeaShell;
                            break;
                        case 2:
                            TessereGioco[i].BackgroundImage = Properties.Resources.punto_domanda_giallo;
                            sfondoTesseraNascosta = Properties.Resources.punto_domanda_giallo;
                            for (int j = 0; j < EtichetteGioco.Length; j++)
                            {
                                EtichetteGioco[j].BackColor = Color.Cornsilk;
                            }
                            rimescolaTesserePanel.BackColor = Color.Cornsilk;
                            break;
                        case 3:
                            TessereGioco[i].BackgroundImage = Properties.Resources.punto_domanda_verde;
                            sfondoTesseraNascosta = Properties.Resources.punto_domanda_verde;
                            for (int j = 0; j < EtichetteGioco.Length; j++)
                            {
                                EtichetteGioco[j].BackColor = Color.Honeydew;
                            }
                            rimescolaTesserePanel.BackColor = Color.Honeydew;
                            break;
                    }
            }
            return sfondoTesseraNascosta;
        }
        public int [] GeneraTessereCasuali(int codiceSetTessere)
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
                            if (codiceSetTessere == 0)
                            {
                                ImmaginiTessereGirate[i] = Properties.Resources.calla;
                            }
                            else
                            {
                                ImmaginiTessereGirate[i] = Properties.Resources.cavallo;
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
                            if (codiceSetTessere == 0)
                            {
                                ImmaginiTessereGirate[i] = Properties.Resources.campanelle;
                            }
                            else
                            {
                                ImmaginiTessereGirate[i] = Properties.Resources.gallina;
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
                            if (codiceSetTessere == 0)
                            {
                                ImmaginiTessereGirate[i] = Properties.Resources.girasole;
                            }
                            else
                            {
                                ImmaginiTessereGirate[i] = Properties.Resources.leone;
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
                            if (codiceSetTessere == 0)
                            {
                                ImmaginiTessereGirate[i] = Properties.Resources.lavanda;
                            }
                            else
                            {
                                ImmaginiTessereGirate[i] = Properties.Resources.maiale;
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
                            if (codiceSetTessere == 0)
                            {
                                ImmaginiTessereGirate[i] = Properties.Resources.margherita;
                            }
                            else
                            {
                                ImmaginiTessereGirate[i] = Properties.Resources.mucca;
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
                            if (codiceSetTessere == 0)
                            {
                                ImmaginiTessereGirate[i] = Properties.Resources.rosa;
                            }
                            else
                            {
                                ImmaginiTessereGirate[i] = Properties.Resources.panda;
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
                            if (codiceSetTessere == 0)
                            {
                                ImmaginiTessereGirate[i] = Properties.Resources.stella_alpina;
                            }
                            else
                            {
                                ImmaginiTessereGirate[i] = Properties.Resources.pulcino;
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
                            if (codiceSetTessere == 0)
                            {
                                ImmaginiTessereGirate[i] = Properties.Resources.tulipano;
                            }
                            else
                            {
                                ImmaginiTessereGirate[i] = Properties.Resources.scimpanzè;
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

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
