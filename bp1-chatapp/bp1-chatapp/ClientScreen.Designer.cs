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
            this.ipLabel = new System.Windows.Forms.Label();
            this.ipInput = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.connectGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.chatBox.FormattingEnabled = true;
            this.chatBox.ItemHeight = 16;
            this.chatBox.Location = new System.Drawing.Point(12, 12);
            this.chatBox.Name = "chatBox";
            this.chatBox.Size = new System.Drawing.Size(568, 388);
            this.chatBox.TabIndex = 0;
            // 
            // textBox1
            // 
            this.messagesInput.Location = new System.Drawing.Point(12, 416);
            this.messagesInput.Name = "messagesInput";
            this.messagesInput.Size = new System.Drawing.Size(492, 22);
            this.messagesInput.TabIndex = 1;
            // 
            // button1
            // 
            this.sendButton.Location = new System.Drawing.Point(510, 415);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(70, 25);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.connectGroupBox.Controls.Add(this.connectButton);
            this.connectGroupBox.Controls.Add(this.ipInput);
            this.connectGroupBox.Controls.Add(this.ipLabel);
            this.connectGroupBox.Location = new System.Drawing.Point(593, 12);
            this.connectGroupBox.Name = "connectGroupBox";
            this.connectGroupBox.Size = new System.Drawing.Size(195, 122);
            this.connectGroupBox.TabIndex = 3;
            this.connectGroupBox.TabStop = false;
            this.connectGroupBox.Text = "Connect";
            // 
            // label1
            // 
            this.ipLabel.Location = new System.Drawing.Point(8, 22);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(83, 19);
            this.ipLabel.TabIndex = 0;
            this.ipLabel.Text = "IP address";
            // 
            // textBox2
            // 
            this.ipInput.Location = new System.Drawing.Point(8, 44);
            this.ipInput.Name = "ipInput";
            this.ipInput.Size = new System.Drawing.Size(179, 22);
            this.ipInput.TabIndex = 1;
            // 
            // button2
            // 
            this.connectButton.Location = new System.Drawing.Point(8, 77);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(179, 33);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connect to server";
            this.connectButton.UseVisualStyleBackColor = true;
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
            this.Text = "Rchat";
            this.connectGroupBox.ResumeLayout(false);
            this.connectGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

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