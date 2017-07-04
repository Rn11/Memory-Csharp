namespace Memory
{
    partial class FormCredits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCredits));
            this.lblVerTxt = new System.Windows.Forms.Label();
            this.lblVerValue = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblVerTxt
            // 
            this.lblVerTxt.AutoSize = true;
            this.lblVerTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerTxt.Location = new System.Drawing.Point(12, 9);
            this.lblVerTxt.Name = "lblVerTxt";
            this.lblVerTxt.Size = new System.Drawing.Size(57, 16);
            this.lblVerTxt.TabIndex = 2;
            this.lblVerTxt.Text = "Version:";
            // 
            // lblVerValue
            // 
            this.lblVerValue.ActiveLinkColor = System.Drawing.Color.LightGreen;
            this.lblVerValue.AutoSize = true;
            this.lblVerValue.LinkColor = System.Drawing.Color.SteelBlue;
            this.lblVerValue.Location = new System.Drawing.Point(12, 25);
            this.lblVerValue.Name = "lblVerValue";
            this.lblVerValue.Size = new System.Drawing.Size(23, 13);
            this.lblVerValue.TabIndex = 3;
            this.lblVerValue.TabStop = true;
            this.lblVerValue.Text = "null";
            this.lblVerValue.VisitedLinkColor = System.Drawing.Color.Tomato;
            this.lblVerValue.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblVerValue_LinkClicked);
            // 
            // FormCredits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 62);
            this.Controls.Add(this.lblVerValue);
            this.Controls.Add(this.lblVerTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCredits";
            this.Text = "Version";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVerTxt;
        private System.Windows.Forms.LinkLabel lblVerValue;
    }
}
