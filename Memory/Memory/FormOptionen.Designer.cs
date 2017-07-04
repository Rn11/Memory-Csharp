namespace Memory
{
    partial class FormOptionen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOptionen));
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.lblVolumeText = new System.Windows.Forms.Label();
            this.lblVolumeValue = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbVolume
            // 
            this.tbVolume.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbVolume.Location = new System.Drawing.Point(6, 47);
            this.tbVolume.Margin = new System.Windows.Forms.Padding(6);
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(523, 29);
            this.tbVolume.TabIndex = 0;
            this.tbVolume.Value = 2;
            this.tbVolume.Scroll += new System.EventHandler(this.tbVolume_Scroll);
            // 
            // lblVolumeText
            // 
            this.lblVolumeText.AutoSize = true;
            this.lblVolumeText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblVolumeText.Location = new System.Drawing.Point(6, 12);
            this.lblVolumeText.Margin = new System.Windows.Forms.Padding(6, 3, 6, 16);
            this.lblVolumeText.Name = "lblVolumeText";
            this.lblVolumeText.Size = new System.Drawing.Size(523, 13);
            this.lblVolumeText.TabIndex = 1;
            this.lblVolumeText.Text = "Lautstärke:";
            // 
            // lblVolumeValue
            // 
            this.lblVolumeValue.AutoSize = true;
            this.lblVolumeValue.Location = new System.Drawing.Point(79, 13);
            this.lblVolumeValue.Name = "lblVolumeValue";
            this.lblVolumeValue.Size = new System.Drawing.Size(0, 13);
            this.lblVolumeValue.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tbVolume, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblVolumeText, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(535, 82);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // FormOptionen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 82);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblVolumeValue);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1400, 121);
            this.MinimumSize = new System.Drawing.Size(295, 121);
            this.Name = "FormOptionen";
            this.Text = "Optionen";
            this.Load += new System.EventHandler(this.FormOptionen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbVolume;
        private System.Windows.Forms.Label lblVolumeText;
        private System.Windows.Forms.Label lblVolumeValue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}