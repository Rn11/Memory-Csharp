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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHauptmenue));
            this.btnEinzelspieler = new System.Windows.Forms.Button();
            this.btnOptionen = new System.Windows.Forms.Button();
            this.btnMehrspieler = new System.Windows.Forms.Button();
            this.btnCredits = new System.Windows.Forms.Button();
            this.btnVerlassen = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEinzelspieler
            // 
            this.btnEinzelspieler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEinzelspieler.Location = new System.Drawing.Point(10, 10);
            this.btnEinzelspieler.Margin = new System.Windows.Forms.Padding(10);
            this.btnEinzelspieler.Name = "btnEinzelspieler";
            this.btnEinzelspieler.Size = new System.Drawing.Size(216, 35);
            this.btnEinzelspieler.TabIndex = 0;
            this.btnEinzelspieler.Text = "Einzelspieler";
            this.btnEinzelspieler.UseVisualStyleBackColor = true;
            this.btnEinzelspieler.Click += new System.EventHandler(this.btnEinzelspieler_Click);
            // 
            // btnOptionen
            // 
            this.btnOptionen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOptionen.Location = new System.Drawing.Point(10, 120);
            this.btnOptionen.Margin = new System.Windows.Forms.Padding(10);
            this.btnOptionen.Name = "btnOptionen";
            this.btnOptionen.Size = new System.Drawing.Size(216, 35);
            this.btnOptionen.TabIndex = 1;
            this.btnOptionen.Text = "Optionen";
            this.btnOptionen.UseVisualStyleBackColor = true;
            this.btnOptionen.Click += new System.EventHandler(this.btnOptionen_Click);
            // 
            // btnMehrspieler
            // 
            this.btnMehrspieler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMehrspieler.Enabled = false;
            this.btnMehrspieler.Location = new System.Drawing.Point(10, 65);
            this.btnMehrspieler.Margin = new System.Windows.Forms.Padding(10);
            this.btnMehrspieler.Name = "btnMehrspieler";
            this.btnMehrspieler.Size = new System.Drawing.Size(216, 35);
            this.btnMehrspieler.TabIndex = 2;
            this.btnMehrspieler.Text = "Mehrspieler";
            this.btnMehrspieler.UseVisualStyleBackColor = true;
            this.btnMehrspieler.Click += new System.EventHandler(this.btnMehrspieler_Click);
            // 
            // btnCredits
            // 
            this.btnCredits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCredits.Location = new System.Drawing.Point(10, 175);
            this.btnCredits.Margin = new System.Windows.Forms.Padding(10);
            this.btnCredits.Name = "btnCredits";
            this.btnCredits.Size = new System.Drawing.Size(216, 35);
            this.btnCredits.TabIndex = 3;
            this.btnCredits.Text = "Credits";
            this.btnCredits.UseVisualStyleBackColor = true;
            this.btnCredits.Click += new System.EventHandler(this.btnCredits_Click);
            // 
            // btnVerlassen
            // 
            this.btnVerlassen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVerlassen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVerlassen.Location = new System.Drawing.Point(10, 230);
            this.btnVerlassen.Margin = new System.Windows.Forms.Padding(10);
            this.btnVerlassen.Name = "btnVerlassen";
            this.btnVerlassen.Size = new System.Drawing.Size(216, 39);
            this.btnVerlassen.TabIndex = 4;
            this.btnVerlassen.Text = "Verlassen";
            this.btnVerlassen.UseVisualStyleBackColor = true;
            this.btnVerlassen.Click += new System.EventHandler(this.btnVerlassen_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnEinzelspieler, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMehrspieler, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCredits, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnOptionen, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnVerlassen, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(236, 279);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // FormHauptmenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 303);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(276, 342);
            this.Name = "FormHauptmenue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hauptmenü";
            this.Load += new System.EventHandler(this.FormHauptmenue_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEinzelspieler;
        private System.Windows.Forms.Button btnOptionen;
        private System.Windows.Forms.Button btnMehrspieler;
        private System.Windows.Forms.Button btnCredits;
        private System.Windows.Forms.Button btnVerlassen;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

