using System.ComponentModel;

namespace bp1_chatapp
{
    partial class ClientScreen
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
            this.messagesInput = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.connectGroupBox = new System.Windows.Forms.GroupBox();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.bufferSizeLabel = new System.Windows.Forms.Label();
            this.bufferSizeInput = new System.Windows.Forms.TextBox();
            this.portInput = new System.Windows.Forms.TextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.ipInput = new System.Windows.Forms.TextBox();
            this.ipLabel = new System.Windows.Forms.Label();
            this.connectGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // chatBox
            // 
            this.chatBox.FormattingEnabled = true;
            this.chatBox.ItemHeight = 16;
            this.chatBox.Location = new System.Drawing.Point(12, 12);
            this.chatBox.Name = "chatBox";
            this.chatBox.Size = new System.Drawing.Size(568, 388);
            this.chatBox.TabIndex = 0;
            // 
            // messagesInput
            // 
            this.messagesInput.Location = new System.Drawing.Point(12, 416);
            this.messagesInput.Name = "messagesInput";
            this.messagesInput.Size = new System.Drawing.Size(492, 22);
            this.messagesInput.TabIndex = 1;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(510, 415);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(70, 25);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // connectGroupBox
            // 
            this.connectGroupBox.Controls.Add(this.disconnectButton);
            this.connectGroupBox.Controls.Add(this.bufferSizeLabel);
            this.connectGroupBox.Controls.Add(this.bufferSizeInput);
            this.connectGroupBox.Controls.Add(this.portInput);
            this.connectGroupBox.Controls.Add(this.portLabel);
            this.connectGroupBox.Controls.Add(this.usernameInput);
            this.connectGroupBox.Controls.Add(this.usernameLabel);
            this.connectGroupBox.Controls.Add(this.connectButton);
            this.connectGroupBox.Controls.Add(this.ipInput);
            this.connectGroupBox.Controls.Add(this.ipLabel);
            this.connectGroupBox.Location = new System.Drawing.Point(593, 12);
            this.connectGroupBox.Name = "connectGroupBox";
            this.connectGroupBox.Size = new System.Drawing.Size(195, 265);
            this.connectGroupBox.TabIndex = 3;
            this.connectGroupBox.TabStop = false;
            this.connectGroupBox.Text = "Connect";
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(6, 218);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(179, 33);
            this.disconnectButton.TabIndex = 4;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            // 
            // bufferSizeLabel
            // 
            this.bufferSizeLabel.Location = new System.Drawing.Point(6, 163);
            this.bufferSizeLabel.Name = "bufferSizeLabel";
            this.bufferSizeLabel.Size = new System.Drawing.Size(100, 15);
            this.bufferSizeLabel.TabIndex = 9;
            this.bufferSizeLabel.Text = "Buffer size";
            // 
            // bufferSizeInput
            // 
            this.bufferSizeInput.Location = new System.Drawing.Point(6, 181);
            this.bufferSizeInput.Name = "bufferSizeInput";
            this.bufferSizeInput.Size = new System.Drawing.Size(179, 22);
            this.bufferSizeInput.TabIndex = 3;
            // 
            // portInput
            // 
            this.portInput.Location = new System.Drawing.Point(6, 134);
            this.portInput.Name = "portInput";
            this.portInput.Size = new System.Drawing.Size(179, 22);
            this.portInput.TabIndex = 2;
            // 
            // portLabel
            // 
            this.portLabel.Location = new System.Drawing.Point(6, 112);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(83, 19);
            this.portLabel.TabIndex = 5;
            this.portLabel.Text = "Port";
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(6, 40);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(179, 22);
            this.usernameInput.TabIndex = 0;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Location = new System.Drawing.Point(6, 18);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(83, 19);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "Username";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(6, 218);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(179, 33);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "Connect to server";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // ipInput
            // 
            this.ipInput.Location = new System.Drawing.Point(6, 87);
            this.ipInput.Name = "ipInput";
            this.ipInput.Size = new System.Drawing.Size(179, 22);
            this.ipInput.TabIndex = 1;
            // 
            // ipLabel
            // 
            this.ipLabel.Location = new System.Drawing.Point(6, 65);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(83, 19);
            this.ipLabel.TabIndex = 0;
            this.ipLabel.Text = "IP address";
            // 
            // ClientScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.connectGroupBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.messagesInput);
            this.Controls.Add(this.chatBox);
            this.Name = "ClientScreen";
            this.Text = "Rchat client";
            this.connectGroupBox.ResumeLayout(false);
            this.connectGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button disconnectButton;

        private System.Windows.Forms.Label bufferSizeLabel;

        private System.Windows.Forms.TextBox bufferSizeInput;

        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox portInput;
        private System.Windows.Forms.Label portLabel;

        private System.Windows.Forms.GroupBox connectGroupBox;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.TextBox ipInput;
        private System.Windows.Forms.Button connectButton;

        private System.Windows.Forms.TextBox messagesInput;
        private System.Windows.Forms.Button sendButton;

        private System.Windows.Forms.ListBox chatBox;

        #endregion
    }
}