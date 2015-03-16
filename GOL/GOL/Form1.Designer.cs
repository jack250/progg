namespace GOL
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
            this.GOTT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GOTT
            // 
            this.GOTT.Location = new System.Drawing.Point(748, 127);
            this.GOTT.Name = "GOTT";
            this.GOTT.Size = new System.Drawing.Size(84, 63);
            this.GOTT.TabIndex = 0;
            this.GOTT.Text = "GOTT";
            this.GOTT.UseVisualStyleBackColor = true;
            this.GOTT.Click += new System.EventHandler(this.GOTT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
         
            this.ClientSize = new System.Drawing.Size(889, 540);
            this.Controls.Add(this.GOTT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GOTT;

    }
}

