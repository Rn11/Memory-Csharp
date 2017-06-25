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
            this.lblVerValue = new System.Windows.Forms.Label();
            this.lblVerText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblVerValue
            // 
            this.lblVerValue.AutoSize = true;
            this.lblVerValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerValue.Location = new System.Drawing.Point(80, 20);
            this.lblVerValue.Name = "lblVerValue";
            this.lblVerValue.Size = new System.Drawing.Size(81, 16);
            this.lblVerValue.TabIndex = 0;
            this.lblVerValue.Text = "lorem ipsum";
            // 
            // lblVerText
            // 
            this.lblVerText.AutoSize = true;
            this.lblVerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerText.Location = new System.Drawing.Point(17, 20);
            this.lblVerText.Name = "lblVerText";
            this.lblVerText.Size = new System.Drawing.Size(11, 16);
            this.lblVerText.TabIndex = 1;
            this.lblVerText.Text = " ";
            // 
            // FormCredits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 99);
            this.Controls.Add(this.lblVerText);
            this.Controls.Add(this.lblVerValue);
            this.Name = "FormCredits";
            this.Text = "Version";
            this.Load += new System.EventHandler(this.FormCredits_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVerValue;
        private System.Windows.Forms.Label lblVerText;
    }
}