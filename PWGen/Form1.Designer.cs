namespace PWGen
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbZahlen = new System.Windows.Forms.CheckBox();
            this.cbKleinbuchstaben = new System.Windows.Forms.CheckBox();
            this.cbGrosbuchstaben = new System.Windows.Forms.CheckBox();
            this.cbSonderzeichen = new System.Windows.Forms.CheckBox();
            this.tbAusgabe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bStart = new System.Windows.Forms.Button();
            this.bCopy = new System.Windows.Forms.Button();
            this.nudAnzahl = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnzahl)).BeginInit();
            this.SuspendLayout();
            // 
            // cbZahlen
            // 
            this.cbZahlen.AutoSize = true;
            this.cbZahlen.Checked = true;
            this.cbZahlen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbZahlen.Location = new System.Drawing.Point(12, 64);
            this.cbZahlen.Name = "cbZahlen";
            this.cbZahlen.Size = new System.Drawing.Size(76, 17);
            this.cbZahlen.TabIndex = 1;
            this.cbZahlen.Text = "Numerisch";
            this.cbZahlen.UseVisualStyleBackColor = true;
            // 
            // cbKleinbuchstaben
            // 
            this.cbKleinbuchstaben.AutoSize = true;
            this.cbKleinbuchstaben.Checked = true;
            this.cbKleinbuchstaben.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbKleinbuchstaben.Location = new System.Drawing.Point(12, 87);
            this.cbKleinbuchstaben.Name = "cbKleinbuchstaben";
            this.cbKleinbuchstaben.Size = new System.Drawing.Size(105, 17);
            this.cbKleinbuchstaben.TabIndex = 2;
            this.cbKleinbuchstaben.Text = "Kleinbuchstaben";
            this.cbKleinbuchstaben.UseVisualStyleBackColor = true;
            // 
            // cbGrosbuchstaben
            // 
            this.cbGrosbuchstaben.AutoSize = true;
            this.cbGrosbuchstaben.Checked = true;
            this.cbGrosbuchstaben.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGrosbuchstaben.Location = new System.Drawing.Point(12, 110);
            this.cbGrosbuchstaben.Name = "cbGrosbuchstaben";
            this.cbGrosbuchstaben.Size = new System.Drawing.Size(105, 17);
            this.cbGrosbuchstaben.TabIndex = 3;
            this.cbGrosbuchstaben.Text = "Großbuchstaben";
            this.cbGrosbuchstaben.UseVisualStyleBackColor = true;
            // 
            // cbSonderzeichen
            // 
            this.cbSonderzeichen.AutoSize = true;
            this.cbSonderzeichen.Checked = true;
            this.cbSonderzeichen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSonderzeichen.Location = new System.Drawing.Point(12, 133);
            this.cbSonderzeichen.Name = "cbSonderzeichen";
            this.cbSonderzeichen.Size = new System.Drawing.Size(97, 17);
            this.cbSonderzeichen.TabIndex = 4;
            this.cbSonderzeichen.Text = "Sonderzeichen";
            this.cbSonderzeichen.UseVisualStyleBackColor = true;
            // 
            // tbAusgabe
            // 
            this.tbAusgabe.Location = new System.Drawing.Point(12, 12);
            this.tbAusgabe.Name = "tbAusgabe";
            this.tbAusgabe.Size = new System.Drawing.Size(211, 20);
            this.tbAusgabe.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(147, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Passwortlänge";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(147, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "(~!@#$%^&*...)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(147, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "(A..Z)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(147, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "(a..z)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(147, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "(0..9)";
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(12, 156);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(292, 23);
            this.bStart.TabIndex = 5;
            this.bStart.Text = "Passwort generieren";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bCopy
            // 
            this.bCopy.Location = new System.Drawing.Point(229, 10);
            this.bCopy.Name = "bCopy";
            this.bCopy.Size = new System.Drawing.Size(75, 23);
            this.bCopy.TabIndex = 6;
            this.bCopy.Text = "Kopieren";
            this.bCopy.UseVisualStyleBackColor = true;
            this.bCopy.Click += new System.EventHandler(this.bCopy_Click);
            // 
            // nudAnzahl
            // 
            this.nudAnzahl.Location = new System.Drawing.Point(12, 38);
            this.nudAnzahl.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.nudAnzahl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAnzahl.Name = "nudAnzahl";
            this.nudAnzahl.Size = new System.Drawing.Size(76, 20);
            this.nudAnzahl.TabIndex = 0;
            this.nudAnzahl.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudAnzahl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudAnzahl_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 190);
            this.Controls.Add(this.nudAnzahl);
            this.Controls.Add(this.bCopy);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAusgabe);
            this.Controls.Add(this.cbSonderzeichen);
            this.Controls.Add(this.cbGrosbuchstaben);
            this.Controls.Add(this.cbKleinbuchstaben);
            this.Controls.Add(this.cbZahlen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Passwort Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAnzahl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbZahlen;
        private System.Windows.Forms.CheckBox cbKleinbuchstaben;
        private System.Windows.Forms.CheckBox cbGrosbuchstaben;
        private System.Windows.Forms.CheckBox cbSonderzeichen;
        private System.Windows.Forms.TextBox tbAusgabe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bCopy;
        private System.Windows.Forms.NumericUpDown nudAnzahl;
    }
}

