namespace quersumme
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
            this.zahl = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labErgebniss = new System.Windows.Forms.Label();
            this.QS = new System.Windows.Forms.RadioButton();
            this.einfacheQS = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.zahl)).BeginInit();
            this.SuspendLayout();
            // 
            // zahl
            // 
            this.zahl.Location = new System.Drawing.Point(67, 74);
            this.zahl.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.zahl.Name = "zahl";
            this.zahl.Size = new System.Drawing.Size(120, 20);
            this.zahl.TabIndex = 0;
            this.zahl.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gib bitte eine Zahl ein.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labErgebniss
            // 
            this.labErgebniss.AutoSize = true;
            this.labErgebniss.Location = new System.Drawing.Point(111, 222);
            this.labErgebniss.Name = "labErgebniss";
            this.labErgebniss.Size = new System.Drawing.Size(56, 13);
            this.labErgebniss.TabIndex = 3;
            this.labErgebniss.Text = "Ergebniss:";
            // 
            // QS
            // 
            this.QS.AutoSize = true;
            this.QS.Location = new System.Drawing.Point(67, 117);
            this.QS.Name = "QS";
            this.QS.Size = new System.Drawing.Size(121, 17);
            this.QS.TabIndex = 4;
            this.QS.TabStop = true;
            this.QS.Text = "normale Quersumme";
            this.QS.UseVisualStyleBackColor = true;
            // 
            // einfacheQS
            // 
            this.einfacheQS.AutoSize = true;
            this.einfacheQS.Location = new System.Drawing.Point(67, 158);
            this.einfacheQS.Name = "einfacheQS";
            this.einfacheQS.Size = new System.Drawing.Size(125, 17);
            this.einfacheQS.TabIndex = 5;
            this.einfacheQS.TabStop = true;
            this.einfacheQS.Text = "einfache Quersumme";
            this.einfacheQS.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 368);
            this.Controls.Add(this.einfacheQS);
            this.Controls.Add(this.QS);
            this.Controls.Add(this.labErgebniss);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zahl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.zahl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown zahl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labErgebniss;
        private System.Windows.Forms.RadioButton QS;
        private System.Windows.Forms.RadioButton einfacheQS;
    }
}

