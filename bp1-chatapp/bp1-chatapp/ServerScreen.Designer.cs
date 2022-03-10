using System.ComponentModel;

namespace bp1_chatapp
{
    partial class ServerScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.chatBox = new System.Windows.Forms.ListBox();
            this.createServerGroupBox = new System.Windows.Forms.GroupBox();
            this.stopServerButton = new System.Windows.Forms.Button();
            this.ipInput = new System.Windows.Forms.TextBox();
            this.ipLabel = new System.Windows.Forms.Label();
            this.portInput = new System.Windows.Forms.TextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.startServerButton = new System.Windows.Forms.Button();
            this.bufferInput = new System.Windows.Forms.TextBox();
            this.bufferLabel = new System.Windows.Forms.Label();
            this.createServerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // chatBox
            // 
            this.chatBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chatBox.FormattingEnabled = true;
            this.chatBox.Location = new System.Drawing.Point(9, 10);
            this.chatBox.Margin = new System.Windows.Forms.Padding(2);
            this.chatBox.Name = "chatBox";
            this.chatBox.Size = new System.Drawing.Size(427, 316);
            this.chatBox.TabIndex = 0;
            // 
            // createServerGroupBox
            // 
            this.createServerGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createServerGroupBox.Controls.Add(this.stopServerButton);
            this.createServerGroupBox.Controls.Add(this.ipInput);
            this.createServerGroupBox.Controls.Add(this.ipLabel);
            this.createServerGroupBox.Controls.Add(this.portInput);
            this.createServerGroupBox.Controls.Add(this.portLabel);
            this.createServerGroupBox.Controls.Add(this.startServerButton);
            this.createServerGroupBox.Controls.Add(this.bufferInput);
            this.createServerGroupBox.Controls.Add(this.bufferLabel);
            this.createServerGroupBox.Location = new System.Drawing.Point(445, 10);
            this.createServerGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.createServerGroupBox.Name = "createServerGroupBox";
            this.createServerGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.createServerGroupBox.Size = new System.Drawing.Size(146, 173);
            this.createServerGroupBox.TabIndex = 1;
            this.createServerGroupBox.TabStop = false;
            this.createServerGroupBox.Text = "Start server";
            // 
            // stopServerButton
            // 
            this.stopServerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stopServerButton.Location = new System.Drawing.Point(9, 136);
            this.stopServerButton.Margin = new System.Windows.Forms.Padding(2);
            this.stopServerButton.Name = "stopServerButton";
            this.stopServerButton.Size = new System.Drawing.Size(133, 27);
            this.stopServerButton.TabIndex = 0;
            this.stopServerButton.Text = "Stop server";
            this.stopServerButton.Click += new System.EventHandler(this.stopServerButton_Click);
            // 
            // ipInput
            // 
            this.ipInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ipInput.Location = new System.Drawing.Point(9, 40);
            this.ipInput.Margin = new System.Windows.Forms.Padding(2);
            this.ipInput.Name = "ipInput";
            this.ipInput.Size = new System.Drawing.Size(134, 20);
            this.ipInput.TabIndex = 0;
            // 
            // ipLabel
            // 
            this.ipLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ipLabel.Location = new System.Drawing.Point(9, 26);
            this.ipLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(75, 19);
            this.ipLabel.TabIndex = 9;
            this.ipLabel.Text = "IP address";
            // 
            // portInput
            // 
            this.portInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.portInput.Location = new System.Drawing.Point(9, 76);
            this.portInput.Margin = new System.Windows.Forms.Padding(2);
            this.portInput.Name = "portInput";
            this.portInput.Size = new System.Drawing.Size(134, 20);
            this.portInput.TabIndex = 1;
            // 
            // portLabel
            // 
            this.portLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.portLabel.Location = new System.Drawing.Point(9, 63);
            this.portLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(75, 19);
            this.portLabel.TabIndex = 7;
            this.portLabel.Text = "Port";
            // 
            // startServerButton
            // 
            this.startServerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startServerButton.Location = new System.Drawing.Point(9, 136);
            this.startServerButton.Margin = new System.Windows.Forms.Padding(2);
            this.startServerButton.Name = "startServerButton";
            this.startServerButton.Size = new System.Drawing.Size(133, 27);
            this.startServerButton.TabIndex = 6;
            this.startServerButton.Text = "Start server";
            this.startServerButton.UseVisualStyleBackColor = true;
            this.startServerButton.Click += new System.EventHandler(this.startServerButton_Click);
            // 
            // bufferInput
            // 
            this.bufferInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bufferInput.Location = new System.Drawing.Point(9, 113);
            this.bufferInput.Margin = new System.Windows.Forms.Padding(2);
            this.bufferInput.Name = "bufferInput";
            this.bufferInput.Size = new System.Drawing.Size(134, 20);
            this.bufferInput.TabIndex = 2;
            // 
            // bufferLabel
            // 
            this.bufferLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bufferLabel.Location = new System.Drawing.Point(9, 99);
            this.bufferLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bufferLabel.Name = "bufferLabel";
            this.bufferLabel.Size = new System.Drawing.Size(75, 19);
            this.bufferLabel.TabIndex = 2;
            this.bufferLabel.Text = "Buffer size";
            // 
            // ServerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.createServerGroupBox);
            this.Controls.Add(this.chatBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ServerScreen";
            this.Text = "Rchat server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerScreen_FormClosing);
            this.createServerGroupBox.ResumeLayout(false);
            this.createServerGroupBox.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button stopServerButton;

        private System.Windows.Forms.TextBox portInput;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.TextBox ipInput;
        private System.Windows.Forms.Label ipLabel;

        private System.Windows.Forms.Button startServerButton;

        private System.Windows.Forms.TextBox bufferInput;

        private System.Windows.Forms.Label bufferLabel;

        private System.Windows.Forms.GroupBox createServerGroupBox;

        private System.Windows.Forms.ListBox chatBox;

        #endregion
    }
}