namespace buttonverschieben150121
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
            this.Läufer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Läufer
            // 
            this.Läufer.ForeColor = System.Drawing.Color.Brown;
            this.Läufer.Location = new System.Drawing.Point(250, 250);
            this.Läufer.Name = "Läufer";
            this.Läufer.Size = new System.Drawing.Size(346, 90);
            this.Läufer.TabIndex = 0;
            this.Läufer.Text = "Bewegung";
            this.Läufer.UseVisualStyleBackColor = true;
            this.Läufer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Läufer_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 508);
            this.Controls.Add(this.Läufer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Läufer;
    }
}

