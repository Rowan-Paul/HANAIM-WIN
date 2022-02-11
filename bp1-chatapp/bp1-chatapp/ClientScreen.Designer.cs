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
            this.connectButton = new System.Windows.Forms.Button();
            this.ipInput = new System.Windows.Forms.TextBox();
            this.ipLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            // 
            // connectGroupBox
            // 
            this.connectGroupBox.Controls.Add(this.textBox2);
            this.connectGroupBox.Controls.Add(this.label2);
            this.connectGroupBox.Controls.Add(this.textBox1);
            this.connectGroupBox.Controls.Add(this.label1);
            this.connectGroupBox.Controls.Add(this.connectButton);
            this.connectGroupBox.Controls.Add(this.ipInput);
            this.connectGroupBox.Controls.Add(this.ipLabel);
            this.connectGroupBox.Location = new System.Drawing.Point(593, 12);
            this.connectGroupBox.Name = "connectGroupBox";
            this.connectGroupBox.Size = new System.Drawing.Size(195, 206);
            this.connectGroupBox.TabIndex = 3;
            this.connectGroupBox.TabStop = false;
            this.connectGroupBox.Text = "Connect";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(6, 162);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(179, 33);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connect to server";
            this.connectButton.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 22);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 22);
            this.textBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port";
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

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;

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