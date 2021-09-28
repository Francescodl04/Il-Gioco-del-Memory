
namespace MemoryApp
{
    partial class FormGioco
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGioco));
            this.barraStrumentiTStrip = new System.Windows.Forms.ToolStrip();
            this.partitaTSDDButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.chiudiIlGiocoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizzazioneTSDDButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.setCarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.florealeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setColoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bluToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arancioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gialloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aiutoTSDDButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.manualeDiUsoDelGiocoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.informazioniSulGiocoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tessera1Btn = new System.Windows.Forms.Button();
            this.tessera3Btn = new System.Windows.Forms.Button();
            this.tessera9Btn = new System.Windows.Forms.Button();
            this.tessera4Btn = new System.Windows.Forms.Button();
            this.tessera10Btn = new System.Windows.Forms.Button();
            this.tessera5Btn = new System.Windows.Forms.Button();
            this.tessera11Btn = new System.Windows.Forms.Button();
            this.tessera6Btn = new System.Windows.Forms.Button();
            this.tessera12Btn = new System.Windows.Forms.Button();
            this.tessera7Btn = new System.Windows.Forms.Button();
            this.tessera13Btn = new System.Windows.Forms.Button();
            this.tessera8Btn = new System.Windows.Forms.Button();
            this.tessera14Btn = new System.Windows.Forms.Button();
            this.tessera16Btn = new System.Windows.Forms.Button();
            this.tessera15Btn = new System.Windows.Forms.Button();
            this.tesseraGialloPBox = new System.Windows.Forms.PictureBox();
            this.tesseraArancioPBox = new System.Windows.Forms.PictureBox();
            this.tesseraVerdePBox = new System.Windows.Forms.PictureBox();
            this.tesseraBluPBox = new System.Windows.Forms.PictureBox();
            this.indicatoreAbbinamentiLabel = new System.Windows.Forms.Label();
            this.logoLabel = new System.Windows.Forms.Label();
            this.rimescolaTessereBtn = new System.Windows.Forms.Button();
            this.rimescolaTessereLabel = new System.Windows.Forms.Label();
            this.tessera2Btn = new System.Windows.Forms.Button();
            this.barraStrumentiTStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tesseraGialloPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesseraArancioPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesseraVerdePBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesseraBluPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // barraStrumentiTStrip
            // 
            this.barraStrumentiTStrip.BackColor = System.Drawing.Color.White;
            this.barraStrumentiTStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.barraStrumentiTStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.partitaTSDDButton,
            this.visualizzazioneTSDDButton,
            this.aiutoTSDDButton});
            this.barraStrumentiTStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.barraStrumentiTStrip.Location = new System.Drawing.Point(0, 0);
            this.barraStrumentiTStrip.Name = "barraStrumentiTStrip";
            this.barraStrumentiTStrip.Size = new System.Drawing.Size(842, 22);
            this.barraStrumentiTStrip.TabIndex = 0;
            this.barraStrumentiTStrip.Text = "toolStrip1";
            // 
            // partitaTSDDButton
            // 
            this.partitaTSDDButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.partitaTSDDButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chiudiIlGiocoToolStripMenuItem});
            this.partitaTSDDButton.Image = ((System.Drawing.Image)(resources.GetObject("partitaTSDDButton.Image")));
            this.partitaTSDDButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.partitaTSDDButton.Name = "partitaTSDDButton";
            this.partitaTSDDButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.partitaTSDDButton.ShowDropDownArrow = false;
            this.partitaTSDDButton.Size = new System.Drawing.Size(45, 19);
            this.partitaTSDDButton.Text = "Partita";
            this.partitaTSDDButton.ToolTipText = "Permette di cambiare le impostazioni della partita";
            // 
            // chiudiIlGiocoToolStripMenuItem
            // 
            this.chiudiIlGiocoToolStripMenuItem.Name = "chiudiIlGiocoToolStripMenuItem";
            this.chiudiIlGiocoToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.chiudiIlGiocoToolStripMenuItem.Text = "Chiudi il gioco";
            // 
            // visualizzazioneTSDDButton
            // 
            this.visualizzazioneTSDDButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.visualizzazioneTSDDButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setCarteToolStripMenuItem,
            this.setColoriToolStripMenuItem});
            this.visualizzazioneTSDDButton.Image = ((System.Drawing.Image)(resources.GetObject("visualizzazioneTSDDButton.Image")));
            this.visualizzazioneTSDDButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.visualizzazioneTSDDButton.Name = "visualizzazioneTSDDButton";
            this.visualizzazioneTSDDButton.ShowDropDownArrow = false;
            this.visualizzazioneTSDDButton.Size = new System.Drawing.Size(89, 19);
            this.visualizzazioneTSDDButton.Text = "Visualizzazione";
            this.visualizzazioneTSDDButton.ToolTipText = "Permette di cambiare le impostazioni di visulizzazione (colori, tipo tessere)";
            // 
            // setCarteToolStripMenuItem
            // 
            this.setCarteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.florealeToolStripMenuItem});
            this.setCarteToolStripMenuItem.Name = "setCarteToolStripMenuItem";
            this.setCarteToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.setCarteToolStripMenuItem.Text = "Set carte";
            // 
            // florealeToolStripMenuItem
            // 
            this.florealeToolStripMenuItem.Checked = true;
            this.florealeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.florealeToolStripMenuItem.Name = "florealeToolStripMenuItem";
            this.florealeToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.florealeToolStripMenuItem.Text = "Floreale";
            // 
            // setColoriToolStripMenuItem
            // 
            this.setColoriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bluToolStripMenuItem,
            this.arancioToolStripMenuItem,
            this.gialloToolStripMenuItem,
            this.verdeToolStripMenuItem});
            this.setColoriToolStripMenuItem.Name = "setColoriToolStripMenuItem";
            this.setColoriToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.setColoriToolStripMenuItem.Text = "Set colori";
            // 
            // bluToolStripMenuItem
            // 
            this.bluToolStripMenuItem.Checked = true;
            this.bluToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bluToolStripMenuItem.Name = "bluToolStripMenuItem";
            this.bluToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.bluToolStripMenuItem.Text = "Blu";
            this.bluToolStripMenuItem.Click += new System.EventHandler(this.bluToolStripMenuItem_Click);
            // 
            // arancioToolStripMenuItem
            // 
            this.arancioToolStripMenuItem.Name = "arancioToolStripMenuItem";
            this.arancioToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.arancioToolStripMenuItem.Text = "Arancio";
            this.arancioToolStripMenuItem.Click += new System.EventHandler(this.arancioToolStripMenuItem_Click);
            // 
            // gialloToolStripMenuItem
            // 
            this.gialloToolStripMenuItem.Name = "gialloToolStripMenuItem";
            this.gialloToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.gialloToolStripMenuItem.Text = "Giallo";
            this.gialloToolStripMenuItem.Click += new System.EventHandler(this.gialloToolStripMenuItem_Click);
            // 
            // verdeToolStripMenuItem
            // 
            this.verdeToolStripMenuItem.Name = "verdeToolStripMenuItem";
            this.verdeToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.verdeToolStripMenuItem.Text = "Verde";
            this.verdeToolStripMenuItem.Click += new System.EventHandler(this.verdeToolStripMenuItem_Click);
            // 
            // aiutoTSDDButton
            // 
            this.aiutoTSDDButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aiutoTSDDButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualeDiUsoDelGiocoToolStripMenuItem,
            this.toolStripSeparator2,
            this.informazioniSulGiocoToolStripMenuItem});
            this.aiutoTSDDButton.Image = ((System.Drawing.Image)(resources.GetObject("aiutoTSDDButton.Image")));
            this.aiutoTSDDButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aiutoTSDDButton.Name = "aiutoTSDDButton";
            this.aiutoTSDDButton.ShowDropDownArrow = false;
            this.aiutoTSDDButton.Size = new System.Drawing.Size(16, 19);
            this.aiutoTSDDButton.Text = "?";
            this.aiutoTSDDButton.ToolTipText = "Qui trovi il manuale d\'uso e le informazioni sul gioco";
            // 
            // manualeDiUsoDelGiocoToolStripMenuItem
            // 
            this.manualeDiUsoDelGiocoToolStripMenuItem.Name = "manualeDiUsoDelGiocoToolStripMenuItem";
            this.manualeDiUsoDelGiocoToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.manualeDiUsoDelGiocoToolStripMenuItem.Text = "Manuale di uso del gioco";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(204, 6);
            // 
            // informazioniSulGiocoToolStripMenuItem
            // 
            this.informazioniSulGiocoToolStripMenuItem.Name = "informazioniSulGiocoToolStripMenuItem";
            this.informazioniSulGiocoToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.informazioniSulGiocoToolStripMenuItem.Text = "Informazioni sul gioco...";
            this.informazioniSulGiocoToolStripMenuItem.Click += new System.EventHandler(this.informazioniSulGiocoToolStripMenuItem_Click);
            // 
            // tessera1Btn
            // 
            this.tessera1Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tessera1Btn.BackgroundImage")));
            this.tessera1Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tessera1Btn.Location = new System.Drawing.Point(35, 63);
            this.tessera1Btn.Name = "tessera1Btn";
            this.tessera1Btn.Size = new System.Drawing.Size(125, 125);
            this.tessera1Btn.TabIndex = 1;
            this.tessera1Btn.UseVisualStyleBackColor = true;
            this.tessera1Btn.Click += new System.EventHandler(this.tessera1Btn_Click);
            // 
            // tessera3Btn
            // 
            this.tessera3Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tessera3Btn.BackgroundImage")));
            this.tessera3Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tessera3Btn.Location = new System.Drawing.Point(300, 63);
            this.tessera3Btn.Name = "tessera3Btn";
            this.tessera3Btn.Size = new System.Drawing.Size(125, 125);
            this.tessera3Btn.TabIndex = 3;
            this.tessera3Btn.UseVisualStyleBackColor = true;
            this.tessera3Btn.Click += new System.EventHandler(this.tessera3Btn_Click);
            // 
            // tessera9Btn
            // 
            this.tessera9Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tessera9Btn.BackgroundImage")));
            this.tessera9Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tessera9Btn.Location = new System.Drawing.Point(35, 325);
            this.tessera9Btn.Name = "tessera9Btn";
            this.tessera9Btn.Size = new System.Drawing.Size(125, 125);
            this.tessera9Btn.TabIndex = 9;
            this.tessera9Btn.UseVisualStyleBackColor = true;
            this.tessera9Btn.Click += new System.EventHandler(this.tessera9Btn_Click);
            // 
            // tessera4Btn
            // 
            this.tessera4Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tessera4Btn.BackgroundImage")));
            this.tessera4Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tessera4Btn.Location = new System.Drawing.Point(431, 63);
            this.tessera4Btn.Name = "tessera4Btn";
            this.tessera4Btn.Size = new System.Drawing.Size(125, 125);
            this.tessera4Btn.TabIndex = 4;
            this.tessera4Btn.UseVisualStyleBackColor = true;
            this.tessera4Btn.Click += new System.EventHandler(this.tessera4Btn_Click);
            // 
            // tessera10Btn
            // 
            this.tessera10Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tessera10Btn.BackgroundImage")));
            this.tessera10Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tessera10Btn.Location = new System.Drawing.Point(166, 325);
            this.tessera10Btn.Name = "tessera10Btn";
            this.tessera10Btn.Size = new System.Drawing.Size(125, 125);
            this.tessera10Btn.TabIndex = 10;
            this.tessera10Btn.UseVisualStyleBackColor = true;
            this.tessera10Btn.Click += new System.EventHandler(this.tessera10Btn_Click);
            // 
            // tessera5Btn
            // 
            this.tessera5Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tessera5Btn.BackgroundImage")));
            this.tessera5Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tessera5Btn.Location = new System.Drawing.Point(35, 194);
            this.tessera5Btn.Name = "tessera5Btn";
            this.tessera5Btn.Size = new System.Drawing.Size(125, 125);
            this.tessera5Btn.TabIndex = 5;
            this.tessera5Btn.UseVisualStyleBackColor = true;
            this.tessera5Btn.Click += new System.EventHandler(this.tessera5Btn_Click);
            // 
            // tessera11Btn
            // 
            this.tessera11Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tessera11Btn.BackgroundImage")));
            this.tessera11Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tessera11Btn.Location = new System.Drawing.Point(300, 325);
            this.tessera11Btn.Name = "tessera11Btn";
            this.tessera11Btn.Size = new System.Drawing.Size(125, 125);
            this.tessera11Btn.TabIndex = 11;
            this.tessera11Btn.UseVisualStyleBackColor = true;
            this.tessera11Btn.Click += new System.EventHandler(this.tessera11Btn_Click);
            // 
            // tessera6Btn
            // 
            this.tessera6Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tessera6Btn.BackgroundImage")));
            this.tessera6Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tessera6Btn.Location = new System.Drawing.Point(169, 194);
            this.tessera6Btn.Name = "tessera6Btn";
            this.tessera6Btn.Size = new System.Drawing.Size(125, 125);
            this.tessera6Btn.TabIndex = 6;
            this.tessera6Btn.UseVisualStyleBackColor = true;
            this.tessera6Btn.Click += new System.EventHandler(this.tessera6Btn_Click);
            // 
            // tessera12Btn
            // 
            this.tessera12Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tessera12Btn.BackgroundImage")));
            this.tessera12Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tessera12Btn.Location = new System.Drawing.Point(431, 325);
            this.tessera12Btn.Name = "tessera12Btn";
            this.tessera12Btn.Size = new System.Drawing.Size(125, 125);
            this.tessera12Btn.TabIndex = 12;
            this.tessera12Btn.UseVisualStyleBackColor = true;
            this.tessera12Btn.Click += new System.EventHandler(this.tessera12Btn_Click);
            // 
            // tessera7Btn
            // 
            this.tessera7Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tessera7Btn.BackgroundImage")));
            this.tessera7Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tessera7Btn.Location = new System.Drawing.Point(300, 194);
            this.tessera7Btn.Name = "tessera7Btn";
            this.tessera7Btn.Size = new System.Drawing.Size(125, 125);
            this.tessera7Btn.TabIndex = 7;
            this.tessera7Btn.UseVisualStyleBackColor = true;
            this.tessera7Btn.Click += new System.EventHandler(this.tessera7Btn_Click);
            // 
            // tessera13Btn
            // 
            this.tessera13Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tessera13Btn.BackgroundImage")));
            this.tessera13Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tessera13Btn.Location = new System.Drawing.Point(35, 456);
            this.tessera13Btn.Name = "tessera13Btn";
            this.tessera13Btn.Size = new System.Drawing.Size(125, 125);
            this.tessera13Btn.TabIndex = 13;
            this.tessera13Btn.UseVisualStyleBackColor = true;
            this.tessera13Btn.Click += new System.EventHandler(this.tessera13Btn_Click);
            // 
            // tessera8Btn
            // 
            this.tessera8Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tessera8Btn.BackgroundImage")));
            this.tessera8Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tessera8Btn.Location = new System.Drawing.Point(431, 194);
            this.tessera8Btn.Name = "tessera8Btn";
            this.tessera8Btn.Size = new System.Drawing.Size(125, 125);
            this.tessera8Btn.TabIndex = 8;
            this.tessera8Btn.UseVisualStyleBackColor = true;
            this.tessera8Btn.Click += new System.EventHandler(this.tessera8Btn_Click);
            // 
            // tessera14Btn
            // 
            this.tessera14Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tessera14Btn.BackgroundImage")));
            this.tessera14Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tessera14Btn.Location = new System.Drawing.Point(169, 456);
            this.tessera14Btn.Name = "tessera14Btn";
            this.tessera14Btn.Size = new System.Drawing.Size(125, 125);
            this.tessera14Btn.TabIndex = 14;
            this.tessera14Btn.UseVisualStyleBackColor = true;
            this.tessera14Btn.Click += new System.EventHandler(this.tessera14Btn_Click);
            // 
            // tessera16Btn
            // 
            this.tessera16Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tessera16Btn.BackgroundImage")));
            this.tessera16Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tessera16Btn.Location = new System.Drawing.Point(431, 456);
            this.tessera16Btn.Name = "tessera16Btn";
            this.tessera16Btn.Size = new System.Drawing.Size(125, 125);
            this.tessera16Btn.TabIndex = 16;
            this.tessera16Btn.UseVisualStyleBackColor = true;
            this.tessera16Btn.Click += new System.EventHandler(this.tessera16Btn_Click);
            // 
            // tessera15Btn
            // 
            this.tessera15Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tessera15Btn.BackgroundImage")));
            this.tessera15Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tessera15Btn.Location = new System.Drawing.Point(300, 456);
            this.tessera15Btn.Name = "tessera15Btn";
            this.tessera15Btn.Size = new System.Drawing.Size(125, 125);
            this.tessera15Btn.TabIndex = 15;
            this.tessera15Btn.UseVisualStyleBackColor = true;
            this.tessera15Btn.Click += new System.EventHandler(this.tessera15Btn_Click);
            // 
            // tesseraGialloPBox
            // 
            this.tesseraGialloPBox.Image = global::MemoryApp.Properties.Resources.punto_domanda_giallo;
            this.tesseraGialloPBox.Location = new System.Drawing.Point(588, 186);
            this.tesseraGialloPBox.Name = "tesseraGialloPBox";
            this.tesseraGialloPBox.Size = new System.Drawing.Size(50, 49);
            this.tesseraGialloPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tesseraGialloPBox.TabIndex = 40;
            this.tesseraGialloPBox.TabStop = false;
            // 
            // tesseraArancioPBox
            // 
            this.tesseraArancioPBox.Image = global::MemoryApp.Properties.Resources.punto_domanda_arancio;
            this.tesseraArancioPBox.Location = new System.Drawing.Point(778, 63);
            this.tesseraArancioPBox.Name = "tesseraArancioPBox";
            this.tesseraArancioPBox.Size = new System.Drawing.Size(50, 49);
            this.tesseraArancioPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tesseraArancioPBox.TabIndex = 39;
            this.tesseraArancioPBox.TabStop = false;
            // 
            // tesseraVerdePBox
            // 
            this.tesseraVerdePBox.Image = global::MemoryApp.Properties.Resources.punto_domanda_verde;
            this.tesseraVerdePBox.Location = new System.Drawing.Point(778, 187);
            this.tesseraVerdePBox.Name = "tesseraVerdePBox";
            this.tesseraVerdePBox.Size = new System.Drawing.Size(50, 49);
            this.tesseraVerdePBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tesseraVerdePBox.TabIndex = 38;
            this.tesseraVerdePBox.TabStop = false;
            // 
            // tesseraBluPBox
            // 
            this.tesseraBluPBox.Image = global::MemoryApp.Properties.Resources.punto_domanda_blu;
            this.tesseraBluPBox.Location = new System.Drawing.Point(587, 64);
            this.tesseraBluPBox.Name = "tesseraBluPBox";
            this.tesseraBluPBox.Size = new System.Drawing.Size(50, 49);
            this.tesseraBluPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tesseraBluPBox.TabIndex = 37;
            this.tesseraBluPBox.TabStop = false;
            // 
            // indicatoreAbbinamentiLabel
            // 
            this.indicatoreAbbinamentiLabel.BackColor = System.Drawing.Color.AliceBlue;
            this.indicatoreAbbinamentiLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.indicatoreAbbinamentiLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.indicatoreAbbinamentiLabel.Location = new System.Drawing.Point(589, 249);
            this.indicatoreAbbinamentiLabel.Name = "indicatoreAbbinamentiLabel";
            this.indicatoreAbbinamentiLabel.Size = new System.Drawing.Size(241, 219);
            this.indicatoreAbbinamentiLabel.TabIndex = 36;
            this.indicatoreAbbinamentiLabel.Text = "Tessere abbinate correttamente\r\n\r\nG1: 0 \r\nG2:  0 ";
            this.indicatoreAbbinamentiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoLabel
            // 
            this.logoLabel.BackColor = System.Drawing.Color.AliceBlue;
            this.logoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoLabel.Font = new System.Drawing.Font("Harlow Solid Italic", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoLabel.Location = new System.Drawing.Point(586, 63);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(244, 175);
            this.logoLabel.TabIndex = 35;
            this.logoLabel.Text = "Il Gioco del Memory";
            this.logoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rimescolaTessereBtn
            // 
            this.rimescolaTessereBtn.Enabled = false;
            this.rimescolaTessereBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.rimescolaTessereBtn.Location = new System.Drawing.Point(623, 510);
            this.rimescolaTessereBtn.Name = "rimescolaTessereBtn";
            this.rimescolaTessereBtn.Size = new System.Drawing.Size(175, 43);
            this.rimescolaTessereBtn.TabIndex = 34;
            this.rimescolaTessereBtn.Text = "Rimescola le tessere";
            this.rimescolaTessereBtn.UseVisualStyleBackColor = true;
            // 
            // rimescolaTessereLabel
            // 
            this.rimescolaTessereLabel.BackColor = System.Drawing.Color.AliceBlue;
            this.rimescolaTessereLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rimescolaTessereLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rimescolaTessereLabel.Location = new System.Drawing.Point(589, 481);
            this.rimescolaTessereLabel.Name = "rimescolaTessereLabel";
            this.rimescolaTessereLabel.Size = new System.Drawing.Size(241, 100);
            this.rimescolaTessereLabel.TabIndex = 41;
            this.rimescolaTessereLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tessera2Btn
            // 
            this.tessera2Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tessera2Btn.BackgroundImage")));
            this.tessera2Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tessera2Btn.Location = new System.Drawing.Point(166, 63);
            this.tessera2Btn.Name = "tessera2Btn";
            this.tessera2Btn.Size = new System.Drawing.Size(125, 125);
            this.tessera2Btn.TabIndex = 2;
            this.tessera2Btn.UseVisualStyleBackColor = true;
            this.tessera2Btn.Click += new System.EventHandler(this.tessera2Btn_Click);
            // 
            // FormGioco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MemoryApp.Properties.Resources.sfondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(842, 618);
            this.Controls.Add(this.tesseraGialloPBox);
            this.Controls.Add(this.tesseraArancioPBox);
            this.Controls.Add(this.tesseraVerdePBox);
            this.Controls.Add(this.tesseraBluPBox);
            this.Controls.Add(this.indicatoreAbbinamentiLabel);
            this.Controls.Add(this.logoLabel);
            this.Controls.Add(this.rimescolaTessereBtn);
            this.Controls.Add(this.rimescolaTessereLabel);
            this.Controls.Add(this.tessera1Btn);
            this.Controls.Add(this.tessera2Btn);
            this.Controls.Add(this.tessera3Btn);
            this.Controls.Add(this.barraStrumentiTStrip);
            this.Controls.Add(this.tessera9Btn);
            this.Controls.Add(this.tessera15Btn);
            this.Controls.Add(this.tessera4Btn);
            this.Controls.Add(this.tessera16Btn);
            this.Controls.Add(this.tessera10Btn);
            this.Controls.Add(this.tessera14Btn);
            this.Controls.Add(this.tessera5Btn);
            this.Controls.Add(this.tessera8Btn);
            this.Controls.Add(this.tessera11Btn);
            this.Controls.Add(this.tessera13Btn);
            this.Controls.Add(this.tessera6Btn);
            this.Controls.Add(this.tessera7Btn);
            this.Controls.Add(this.tessera12Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormGioco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGioco_FormClosed);
            this.Load += new System.EventHandler(this.FormGioco_Load);
            this.barraStrumentiTStrip.ResumeLayout(false);
            this.barraStrumentiTStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tesseraGialloPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesseraArancioPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesseraVerdePBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesseraBluPBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip barraStrumentiTStrip;
        private System.Windows.Forms.ToolStripDropDownButton visualizzazioneTSDDButton;
        private System.Windows.Forms.ToolStripMenuItem setCarteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem florealeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setColoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bluToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arancioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gialloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verdeToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton aiutoTSDDButton;
        private System.Windows.Forms.ToolStripMenuItem manualeDiUsoDelGiocoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem informazioniSulGiocoToolStripMenuItem;
        private System.Windows.Forms.Button tessera1Btn;
        private System.Windows.Forms.Button tessera3Btn;
        private System.Windows.Forms.Button tessera9Btn;
        private System.Windows.Forms.Button tessera4Btn;
        private System.Windows.Forms.Button tessera10Btn;
        private System.Windows.Forms.Button tessera5Btn;
        private System.Windows.Forms.Button tessera11Btn;
        private System.Windows.Forms.Button tessera6Btn;
        private System.Windows.Forms.Button tessera12Btn;
        private System.Windows.Forms.Button tessera7Btn;
        private System.Windows.Forms.Button tessera13Btn;
        private System.Windows.Forms.Button tessera8Btn;
        private System.Windows.Forms.Button tessera14Btn;
        private System.Windows.Forms.Button tessera16Btn;
        private System.Windows.Forms.Button tessera15Btn;
        private System.Windows.Forms.PictureBox tesseraGialloPBox;
        private System.Windows.Forms.PictureBox tesseraArancioPBox;
        private System.Windows.Forms.PictureBox tesseraVerdePBox;
        private System.Windows.Forms.PictureBox tesseraBluPBox;
        private System.Windows.Forms.Label indicatoreAbbinamentiLabel;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.Button rimescolaTessereBtn;
        private System.Windows.Forms.Label rimescolaTessereLabel;
        private System.Windows.Forms.ToolStripDropDownButton partitaTSDDButton;
        private System.Windows.Forms.ToolStripMenuItem chiudiIlGiocoToolStripMenuItem;
        private System.Windows.Forms.Button tessera2Btn;
    }
}

