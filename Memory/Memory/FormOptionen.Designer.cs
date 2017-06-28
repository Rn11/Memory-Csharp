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
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // tbVolume
            // 
            this.tbVolume.Location = new System.Drawing.Point(12, 49);
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(260, 45);
            this.tbVolume.TabIndex = 0;
            this.tbVolume.Value = 2;
            this.tbVolume.Scroll += new System.EventHandler(this.tbVolume_Scroll);
            // 
            // lblVolumeText
            // 
            this.lblVolumeText.AutoSize = true;
            this.lblVolumeText.Location = new System.Drawing.Point(13, 13);
            this.lblVolumeText.Name = "lblVolumeText";
            this.lblVolumeText.Size = new System.Drawing.Size(60, 13);
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
            // FormOptionen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 104);
            this.Controls.Add(this.lblVolumeValue);
            this.Controls.Add(this.lblVolumeText);
            this.Controls.Add(this.tbVolume);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOptionen";
            this.Text = "Optionen";
            this.Load += new System.EventHandler(this.FormOptionen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbVolume;
        private System.Windows.Forms.Label lblVolumeText;
        private System.Windows.Forms.Label lblVolumeValue;
    }
}