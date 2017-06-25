namespace Memory
{
    partial class FormHauptmenue
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
            this.btnEinzelspieler = new System.Windows.Forms.Button();
            this.btnOptionen = new System.Windows.Forms.Button();
            this.btnMehrspieler = new System.Windows.Forms.Button();
            this.btnCredits = new System.Windows.Forms.Button();
            this.btnVerlassen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEinzelspieler
            // 
            this.btnEinzelspieler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEinzelspieler.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEinzelspieler.Location = new System.Drawing.Point(30, 12);
            this.btnEinzelspieler.Name = "btnEinzelspieler";
            this.btnEinzelspieler.Size = new System.Drawing.Size(198, 36);
            this.btnEinzelspieler.TabIndex = 0;
            this.btnEinzelspieler.Text = "Einzelspieler";
            this.btnEinzelspieler.UseVisualStyleBackColor = true;
            this.btnEinzelspieler.Click += new System.EventHandler(this.btnEinzelspieler_Click);
            // 
            // btnOptionen
            // 
            this.btnOptionen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOptionen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOptionen.Location = new System.Drawing.Point(30, 96);
            this.btnOptionen.Name = "btnOptionen";
            this.btnOptionen.Size = new System.Drawing.Size(198, 36);
            this.btnOptionen.TabIndex = 1;
            this.btnOptionen.Text = "Optionen";
            this.btnOptionen.UseVisualStyleBackColor = true;
            this.btnOptionen.Click += new System.EventHandler(this.btnOptionen_Click);
            // 
            // btnMehrspieler
            // 
            this.btnMehrspieler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMehrspieler.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMehrspieler.Enabled = false;
            this.btnMehrspieler.Location = new System.Drawing.Point(30, 54);
            this.btnMehrspieler.Name = "btnMehrspieler";
            this.btnMehrspieler.Size = new System.Drawing.Size(198, 36);
            this.btnMehrspieler.TabIndex = 2;
            this.btnMehrspieler.Text = "Mehrspieler";
            this.btnMehrspieler.UseVisualStyleBackColor = true;
            this.btnMehrspieler.Click += new System.EventHandler(this.btnMehrspieler_Click);
            // 
            // btnCredits
            // 
            this.btnCredits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCredits.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCredits.Location = new System.Drawing.Point(30, 138);
            this.btnCredits.Name = "btnCredits";
            this.btnCredits.Size = new System.Drawing.Size(198, 36);
            this.btnCredits.TabIndex = 3;
            this.btnCredits.Text = "Credits";
            this.btnCredits.UseVisualStyleBackColor = true;
            this.btnCredits.Click += new System.EventHandler(this.btnCredits_Click);
            // 
            // btnVerlassen
            // 
            this.btnVerlassen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerlassen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVerlassen.Location = new System.Drawing.Point(30, 180);
            this.btnVerlassen.Name = "btnVerlassen";
            this.btnVerlassen.Size = new System.Drawing.Size(198, 36);
            this.btnVerlassen.TabIndex = 4;
            this.btnVerlassen.Text = "Verlassen";
            this.btnVerlassen.UseVisualStyleBackColor = true;
            this.btnVerlassen.Click += new System.EventHandler(this.btnVerlassen_Click);
            // 
            // FormHauptmenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 235);
            this.Controls.Add(this.btnVerlassen);
            this.Controls.Add(this.btnCredits);
            this.Controls.Add(this.btnMehrspieler);
            this.Controls.Add(this.btnOptionen);
            this.Controls.Add(this.btnEinzelspieler);
            this.Name = "FormHauptmenue";
            this.Text = "Hauptmenü";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEinzelspieler;
        private System.Windows.Forms.Button btnOptionen;
        private System.Windows.Forms.Button btnMehrspieler;
        private System.Windows.Forms.Button btnCredits;
        private System.Windows.Forms.Button btnVerlassen;
    }
}

