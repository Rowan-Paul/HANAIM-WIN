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
            this.startServerButton = new System.Windows.Forms.Button();
            this.bufferInput = new System.Windows.Forms.TextBox();
            this.bufferLabel = new System.Windows.Forms.Label();
            this.portInput = new System.Windows.Forms.TextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.ipInput = new System.Windows.Forms.TextBox();
            this.ipLabel = new System.Windows.Forms.Label();
            this.createServerGroupBox.SuspendLayout();
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
            // groupBox1
            // 
            this.createServerGroupBox.Controls.Add(this.ipInput);
            this.createServerGroupBox.Controls.Add(this.ipLabel);
            this.createServerGroupBox.Controls.Add(this.portInput);
            this.createServerGroupBox.Controls.Add(this.portLabel);
            this.createServerGroupBox.Controls.Add(this.startServerButton);
            this.createServerGroupBox.Controls.Add(this.bufferInput);
            this.createServerGroupBox.Controls.Add(this.bufferLabel);
            this.createServerGroupBox.Location = new System.Drawing.Point(593, 12);
            this.createServerGroupBox.Name = "createServerGroupBox";
            this.createServerGroupBox.Size = new System.Drawing.Size(195, 213);
            this.createServerGroupBox.TabIndex = 1;
            this.createServerGroupBox.TabStop = false;
            this.createServerGroupBox.Text = "Start server";
            // 
            // button1
            // 
            this.startServerButton.Location = new System.Drawing.Point(12, 167);
            this.startServerButton.Name = "startServerButton";
            this.startServerButton.Size = new System.Drawing.Size(177, 33);
            this.startServerButton.TabIndex = 6;
            this.startServerButton.Text = "Start server";
            this.startServerButton.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.bufferInput.Location = new System.Drawing.Point(12, 139);
            this.bufferInput.Name = "bufferInput";
            this.bufferInput.Size = new System.Drawing.Size(177, 22);
            this.bufferInput.TabIndex = 3;
            // 
            // label2
            // 
            this.bufferLabel.Location = new System.Drawing.Point(12, 122);
            this.bufferLabel.Name = "bufferLabel";
            this.bufferLabel.Size = new System.Drawing.Size(100, 23);
            this.bufferLabel.TabIndex = 2;
            this.bufferLabel.Text = "Buffer size";
            // 
            // textBox1
            // 
            this.portInput.Location = new System.Drawing.Point(12, 94);
            this.portInput.Name = "portInput";
            this.portInput.Size = new System.Drawing.Size(177, 22);
            this.portInput.TabIndex = 8;
            // 
            // label1
            // 
            this.portLabel.Location = new System.Drawing.Point(12, 77);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(100, 23);
            this.portLabel.TabIndex = 7;
            this.portLabel.Text = "Port";
            // 
            // textBox3
            // 
            this.ipInput.Location = new System.Drawing.Point(12, 49);
            this.ipInput.Name = "ipInput";
            this.ipInput.Size = new System.Drawing.Size(177, 22);
            this.ipInput.TabIndex = 10;
            // 
            // label3
            // 
            this.ipLabel.Location = new System.Drawing.Point(12, 32);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(100, 23);
            this.ipLabel.TabIndex = 9;
            this.ipLabel.Text = "IP address";
            // 
            // ServerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createServerGroupBox);
            this.Controls.Add(this.chatBox);
            this.Name = "ServerScreen";
            this.Text = "ServerScreen";
            this.createServerGroupBox.ResumeLayout(false);
            this.createServerGroupBox.PerformLayout();
            this.ResumeLayout(false);
        }

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