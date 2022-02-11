namespace bp1_chatapp
{
    partial class LandingScreen
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
            this.clientButton = new System.Windows.Forms.Button();
            this.serverButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clientButton
            // 
            this.clientButton.Location = new System.Drawing.Point(12, 60);
            this.clientButton.Name = "clientButton";
            this.clientButton.Size = new System.Drawing.Size(150, 75);
            this.clientButton.TabIndex = 0;
            this.clientButton.Text = "Open client";
            this.clientButton.UseVisualStyleBackColor = true;
            this.clientButton.Click += new System.EventHandler(this.clientButton_Click);
            // 
            // serverButton
            // 
            this.serverButton.Location = new System.Drawing.Point(188, 60);
            this.serverButton.Name = "serverButton";
            this.serverButton.Size = new System.Drawing.Size(150, 75);
            this.serverButton.TabIndex = 1;
            this.serverButton.Text = "Open server";
            this.serverButton.UseVisualStyleBackColor = true;
            // 
            // LandingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.serverButton);
            this.Controls.Add(this.clientButton);
            this.Name = "LandingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rchat";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button serverButton;

        private System.Windows.Forms.Button clientButton;

        #endregion
    }
}