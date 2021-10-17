
namespace MemoryApp
{
    partial class FormIniziale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIniziale));
            this.logoLabel = new System.Windows.Forms.Label();
            this.tesseraGialloPBox = new System.Windows.Forms.PictureBox();
            this.tesseraArancioPBox = new System.Windows.Forms.PictureBox();
            this.tesseraVerdePBox = new System.Windows.Forms.PictureBox();
            this.tesseraBluPBox = new System.Windows.Forms.PictureBox();
            this.indicazioniLabel = new System.Windows.Forms.Label();
            this.unoGiocatoreRBtn = new System.Windows.Forms.RadioButton();
            this.dueGiocatoriRBtn = new System.Windows.Forms.RadioButton();
            this.opzioniPanel = new System.Windows.Forms.Panel();
            this.nomeG2TBox = new System.Windows.Forms.TextBox();
            this.nomeG1TBox = new System.Windows.Forms.TextBox();
            this.giocaBtn = new System.Windows.Forms.Button();
            this.indicazioniGiocoTTip = new System.Windows.Forms.ToolTip(this.components);
            this.erroreInserimentoG1EProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.erroreInserimentoG2EProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tesseraGialloPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesseraArancioPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesseraVerdePBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesseraBluPBox)).BeginInit();
            this.opzioniPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroreInserimentoG1EProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroreInserimentoG2EProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // logoLabel
            // 
            this.logoLabel.BackColor = System.Drawing.Color.Transparent;
            this.logoLabel.Font = new System.Drawing.Font("Harlow Solid Italic", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoLabel.Location = new System.Drawing.Point(12, 9);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(244, 175);
            this.logoLabel.TabIndex = 41;
            this.logoLabel.Text = "Il Gioco del Memory";
            this.logoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tesseraGialloPBox
            // 
            this.tesseraGialloPBox.Image = global::MemoryApp.Properties.Resources.punto_domanda_giallo;
            this.tesseraGialloPBox.Location = new System.Drawing.Point(14, 132);
            this.tesseraGialloPBox.Name = "tesseraGialloPBox";
            this.tesseraGialloPBox.Size = new System.Drawing.Size(50, 49);
            this.tesseraGialloPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tesseraGialloPBox.TabIndex = 45;
            this.tesseraGialloPBox.TabStop = false;
            // 
            // tesseraArancioPBox
            // 
            this.tesseraArancioPBox.Image = global::MemoryApp.Properties.Resources.punto_domanda_arancio;
            this.tesseraArancioPBox.Location = new System.Drawing.Point(204, 9);
            this.tesseraArancioPBox.Name = "tesseraArancioPBox";
            this.tesseraArancioPBox.Size = new System.Drawing.Size(50, 49);
            this.tesseraArancioPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tesseraArancioPBox.TabIndex = 44;
            this.tesseraArancioPBox.TabStop = false;
            // 
            // tesseraVerdePBox
            // 
            this.tesseraVerdePBox.Image = global::MemoryApp.Properties.Resources.punto_domanda_verde;
            this.tesseraVerdePBox.Location = new System.Drawing.Point(204, 133);
            this.tesseraVerdePBox.Name = "tesseraVerdePBox";
            this.tesseraVerdePBox.Size = new System.Drawing.Size(50, 49);
            this.tesseraVerdePBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tesseraVerdePBox.TabIndex = 43;
            this.tesseraVerdePBox.TabStop = false;
            // 
            // tesseraBluPBox
            // 
            this.tesseraBluPBox.Image = global::MemoryApp.Properties.Resources.punto_domanda_blu;
            this.tesseraBluPBox.Location = new System.Drawing.Point(13, 10);
            this.tesseraBluPBox.Name = "tesseraBluPBox";
            this.tesseraBluPBox.Size = new System.Drawing.Size(50, 49);
            this.tesseraBluPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tesseraBluPBox.TabIndex = 42;
            this.tesseraBluPBox.TabStop = false;
            // 
            // indicazioniLabel
            // 
            this.indicazioniLabel.BackColor = System.Drawing.Color.Transparent;
            this.indicazioniLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.indicazioniLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indicazioniLabel.Location = new System.Drawing.Point(274, 10);
            this.indicazioniLabel.Name = "indicazioniLabel";
            this.indicazioniLabel.Size = new System.Drawing.Size(366, 28);
            this.indicazioniLabel.TabIndex = 46;
            this.indicazioniLabel.Text = "Benvenuto in Memory! Scegli il numero di giocatori...";
            this.indicazioniLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unoGiocatoreRBtn
            // 
            this.unoGiocatoreRBtn.AutoSize = true;
            this.unoGiocatoreRBtn.Checked = true;
            this.unoGiocatoreRBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unoGiocatoreRBtn.Location = new System.Drawing.Point(16, 14);
            this.unoGiocatoreRBtn.Name = "unoGiocatoreRBtn";
            this.unoGiocatoreRBtn.Size = new System.Drawing.Size(92, 17);
            this.unoGiocatoreRBtn.TabIndex = 47;
            this.unoGiocatoreRBtn.TabStop = true;
            this.unoGiocatoreRBtn.Text = "Un giocatore";
            this.indicazioniGiocoTTip.SetToolTip(this.unoGiocatoreRBtn, "Se scegli un giocatore, sfiderai il computer.");
            this.unoGiocatoreRBtn.UseVisualStyleBackColor = true;
            this.unoGiocatoreRBtn.CheckedChanged += new System.EventHandler(this.unoGiocatoreRBtn_CheckedChanged);
            // 
            // dueGiocatoriRBtn
            // 
            this.dueGiocatoriRBtn.AutoSize = true;
            this.dueGiocatoriRBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueGiocatoriRBtn.Location = new System.Drawing.Point(202, 14);
            this.dueGiocatoriRBtn.Name = "dueGiocatoriRBtn";
            this.dueGiocatoriRBtn.Size = new System.Drawing.Size(95, 17);
            this.dueGiocatoriRBtn.TabIndex = 48;
            this.dueGiocatoriRBtn.Text = "Due giocatori";
            this.indicazioniGiocoTTip.SetToolTip(this.dueGiocatoriRBtn, "Scegli due giocatori per sfidare un tuo amico.");
            this.dueGiocatoriRBtn.UseVisualStyleBackColor = true;
            this.dueGiocatoriRBtn.CheckedChanged += new System.EventHandler(this.dueGiocatoriRBtn_CheckedChanged);
            // 
            // opzioniPanel
            // 
            this.opzioniPanel.BackColor = System.Drawing.Color.Transparent;
            this.opzioniPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.opzioniPanel.Controls.Add(this.nomeG2TBox);
            this.opzioniPanel.Controls.Add(this.nomeG1TBox);
            this.opzioniPanel.Controls.Add(this.unoGiocatoreRBtn);
            this.opzioniPanel.Controls.Add(this.dueGiocatoriRBtn);
            this.opzioniPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opzioniPanel.Location = new System.Drawing.Point(277, 51);
            this.opzioniPanel.Name = "opzioniPanel";
            this.opzioniPanel.Size = new System.Drawing.Size(363, 81);
            this.opzioniPanel.TabIndex = 49;
            // 
            // nomeG2TBox
            // 
            this.nomeG2TBox.Enabled = false;
            this.nomeG2TBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeG2TBox.Location = new System.Drawing.Point(202, 45);
            this.nomeG2TBox.MaxLength = 10;
            this.nomeG2TBox.Name = "nomeG2TBox";
            this.nomeG2TBox.Size = new System.Drawing.Size(143, 22);
            this.nomeG2TBox.TabIndex = 50;
            this.nomeG2TBox.Text = "G2";
            this.indicazioniGiocoTTip.SetToolTip(this.nomeG2TBox, "Inserisci qui il tuo nome, giocatore 2. Non lasciare lo spazio vuoto oppure inser" +
        "ire G2.");
            this.nomeG2TBox.Click += new System.EventHandler(this.nomeG2TBox_Click);
            this.nomeG2TBox.TextChanged += new System.EventHandler(this.nomeG2TBox_TextChanged);
            // 
            // nomeG1TBox
            // 
            this.nomeG1TBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeG1TBox.Location = new System.Drawing.Point(16, 45);
            this.nomeG1TBox.MaxLength = 10;
            this.nomeG1TBox.Name = "nomeG1TBox";
            this.nomeG1TBox.Size = new System.Drawing.Size(143, 22);
            this.nomeG1TBox.TabIndex = 49;
            this.nomeG1TBox.Text = "Nome G1";
            this.indicazioniGiocoTTip.SetToolTip(this.nomeG1TBox, "Inserisci qui il tuo nome, giocatore 1. lasciare lo spazio vuoto oppure inserire " +
        "G1.");
            this.nomeG1TBox.Click += new System.EventHandler(this.nomeG1TBox_Click);
            this.nomeG1TBox.TextChanged += new System.EventHandler(this.nomeG1TBox_TextChanged);
            // 
            // giocaBtn
            // 
            this.giocaBtn.Enabled = false;
            this.giocaBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giocaBtn.Location = new System.Drawing.Point(277, 151);
            this.giocaBtn.Name = "giocaBtn";
            this.giocaBtn.Size = new System.Drawing.Size(363, 33);
            this.giocaBtn.TabIndex = 50;
            this.giocaBtn.Text = "Gioca!";
            this.giocaBtn.UseVisualStyleBackColor = true;
            this.giocaBtn.Click += new System.EventHandler(this.giocaBtn_Click);
            // 
            // indicazioniGiocoTTip
            // 
            this.indicazioniGiocoTTip.AutoPopDelay = 5000;
            this.indicazioniGiocoTTip.InitialDelay = 100;
            this.indicazioniGiocoTTip.ReshowDelay = 100;
            // 
            // erroreInserimentoG1EProvider
            // 
            this.erroreInserimentoG1EProvider.BlinkRate = 500;
            this.erroreInserimentoG1EProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.erroreInserimentoG1EProvider.ContainerControl = this;
            // 
            // erroreInserimentoG2EProvider
            // 
            this.erroreInserimentoG2EProvider.BlinkRate = 500;
            this.erroreInserimentoG2EProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.erroreInserimentoG2EProvider.ContainerControl = this;
            // 
            // FormIniziale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MemoryApp.Properties.Resources.sfondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(661, 211);
            this.Controls.Add(this.giocaBtn);
            this.Controls.Add(this.opzioniPanel);
            this.Controls.Add(this.indicazioniLabel);
            this.Controls.Add(this.tesseraGialloPBox);
            this.Controls.Add(this.tesseraArancioPBox);
            this.Controls.Add(this.tesseraVerdePBox);
            this.Controls.Add(this.tesseraBluPBox);
            this.Controls.Add(this.logoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormIniziale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Benvenuto!";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormIniziale_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.tesseraGialloPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesseraArancioPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesseraVerdePBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesseraBluPBox)).EndInit();
            this.opzioniPanel.ResumeLayout(false);
            this.opzioniPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroreInserimentoG1EProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroreInserimentoG2EProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox tesseraGialloPBox;
        private System.Windows.Forms.PictureBox tesseraArancioPBox;
        private System.Windows.Forms.PictureBox tesseraVerdePBox;
        private System.Windows.Forms.PictureBox tesseraBluPBox;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.Label indicazioniLabel;
        private System.Windows.Forms.RadioButton unoGiocatoreRBtn;
        private System.Windows.Forms.RadioButton dueGiocatoriRBtn;
        private System.Windows.Forms.Panel opzioniPanel;
        private System.Windows.Forms.Button giocaBtn;
        private System.Windows.Forms.TextBox nomeG2TBox;
        private System.Windows.Forms.TextBox nomeG1TBox;
        private System.Windows.Forms.ToolTip indicazioniGiocoTTip;
        private System.Windows.Forms.ErrorProvider erroreInserimentoG1EProvider;
        private System.Windows.Forms.ErrorProvider erroreInserimentoG2EProvider;
    }
}