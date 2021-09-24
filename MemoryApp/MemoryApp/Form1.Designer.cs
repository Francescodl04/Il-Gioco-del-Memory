
namespace MemoryApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.setCarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.florealeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.chiudiGiocoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualeDiUsoDelGiocoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.informazioniSulGiocoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSplitButton1,
            this.toolStripSplitButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(744, 43);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 96);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Harlow Solid Italic", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(277, 40);
            this.toolStripLabel1.Text = "Il gioco del Memory";
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualeDiUsoDelGiocoToolStripMenuItem,
            this.toolStripSeparator2,
            this.informazioniSulGiocoToolStripMenuItem});
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(28, 40);
            this.toolStripSplitButton2.Text = "?";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(239, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 96);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(350, 89);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 96);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setCarteToolStripMenuItem,
            this.toolStripSeparator1,
            this.chiudiGiocoToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(54, 40);
            this.toolStripSplitButton1.Text = "Partita";
            // 
            // setCarteToolStripMenuItem
            // 
            this.setCarteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.florealeToolStripMenuItem});
            this.setCarteToolStripMenuItem.Name = "setCarteToolStripMenuItem";
            this.setCarteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setCarteToolStripMenuItem.Text = "Set carte";
            // 
            // florealeToolStripMenuItem
            // 
            this.florealeToolStripMenuItem.Name = "florealeToolStripMenuItem";
            this.florealeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.florealeToolStripMenuItem.Text = "Floreale";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // chiudiGiocoToolStripMenuItem
            // 
            this.chiudiGiocoToolStripMenuItem.Name = "chiudiGiocoToolStripMenuItem";
            this.chiudiGiocoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.chiudiGiocoToolStripMenuItem.Text = "Chiudi gioco";
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 413);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Memory";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem setCarteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem florealeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem chiudiGiocoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualeDiUsoDelGiocoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem informazioniSulGiocoToolStripMenuItem;
    }
}

