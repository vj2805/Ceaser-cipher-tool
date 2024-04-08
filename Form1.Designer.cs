
namespace CeaserCipher
{
    partial class CeaserCipherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CeaserCipherForm));
            this.messageLabel = new System.Windows.Forms.Label();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.decryptButton = new System.Windows.Forms.Button();
            this.shiftLabel = new System.Windows.Forms.Label();
            this.decryptedMessageTextBox = new System.Windows.Forms.TextBox();
            this.decryptedMessageLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.encryptButton = new System.Windows.Forms.Button();
            this.encryptedMessageTextBox = new System.Windows.Forms.TextBox();
            this.encryptedMessageLabel = new System.Windows.Forms.Label();
            this.shiftSpinBox = new System.Windows.Forms.NumericUpDown();
            this.BackGround = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.shiftSpinBox)).BeginInit();
            this.BackGround.SuspendLayout();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.messageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.messageLabel.Location = new System.Drawing.Point(138, 66);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(58, 15);
            this.messageLabel.TabIndex = 0;
            this.messageLabel.Text = "Message :";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(212, 63);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(278, 20);
            this.messageTextBox.TabIndex = 1;
            this.messageTextBox.TextChanged += new System.EventHandler(this.messageTextBox_TextChanged);
            // 
            // decryptButton
            // 
            this.decryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptButton.Location = new System.Drawing.Point(292, 120);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(75, 31);
            this.decryptButton.TabIndex = 2;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.DecryptButtonClicked);
            // 
            // shiftLabel
            // 
            this.shiftLabel.AutoSize = true;
            this.shiftLabel.BackColor = System.Drawing.Color.White;
            this.shiftLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.shiftLabel.Location = new System.Drawing.Point(160, 92);
            this.shiftLabel.Name = "shiftLabel";
            this.shiftLabel.Size = new System.Drawing.Size(36, 15);
            this.shiftLabel.TabIndex = 3;
            this.shiftLabel.Text = "Shift :";
            // 
            // decryptedMessageTextBox
            // 
            this.decryptedMessageTextBox.Location = new System.Drawing.Point(211, 193);
            this.decryptedMessageTextBox.Name = "decryptedMessageTextBox";
            this.decryptedMessageTextBox.ReadOnly = true;
            this.decryptedMessageTextBox.Size = new System.Drawing.Size(278, 20);
            this.decryptedMessageTextBox.TabIndex = 6;
            this.decryptedMessageTextBox.TextChanged += new System.EventHandler(this.decryptedMessageTextBox_TextChanged);
            // 
            // decryptedMessageLabel
            // 
            this.decryptedMessageLabel.AutoSize = true;
            this.decryptedMessageLabel.BackColor = System.Drawing.Color.White;
            this.decryptedMessageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.decryptedMessageLabel.Location = new System.Drawing.Point(86, 196);
            this.decryptedMessageLabel.Name = "decryptedMessageLabel";
            this.decryptedMessageLabel.Size = new System.Drawing.Size(110, 15);
            this.decryptedMessageLabel.TabIndex = 5;
            this.decryptedMessageLabel.Text = "Decrypted Message :";
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(373, 120);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 31);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButtonClicked);
            // 
            // encryptButton
            // 
            this.encryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptButton.Image = ((System.Drawing.Image)(resources.GetObject("encryptButton.Image")));
            this.encryptButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.encryptButton.Location = new System.Drawing.Point(211, 120);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(75, 31);
            this.encryptButton.TabIndex = 9;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.EncryptButtonClicked);
            // 
            // encryptedMessageTextBox
            // 
            this.encryptedMessageTextBox.Location = new System.Drawing.Point(211, 167);
            this.encryptedMessageTextBox.Name = "encryptedMessageTextBox";
            this.encryptedMessageTextBox.ReadOnly = true;
            this.encryptedMessageTextBox.Size = new System.Drawing.Size(278, 20);
            this.encryptedMessageTextBox.TabIndex = 11;
            this.encryptedMessageTextBox.TextChanged += new System.EventHandler(this.encryptedMessageTextBox_TextChanged);
            // 
            // encryptedMessageLabel
            // 
            this.encryptedMessageLabel.AutoSize = true;
            this.encryptedMessageLabel.BackColor = System.Drawing.Color.White;
            this.encryptedMessageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.encryptedMessageLabel.Location = new System.Drawing.Point(87, 170);
            this.encryptedMessageLabel.Name = "encryptedMessageLabel";
            this.encryptedMessageLabel.Size = new System.Drawing.Size(109, 15);
            this.encryptedMessageLabel.TabIndex = 10;
            this.encryptedMessageLabel.Text = "Encrypted Message :";
            // 
            // shiftSpinBox
            // 
            this.shiftSpinBox.Location = new System.Drawing.Point(211, 90);
            this.shiftSpinBox.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.shiftSpinBox.Name = "shiftSpinBox";
            this.shiftSpinBox.Size = new System.Drawing.Size(120, 20);
            this.shiftSpinBox.TabIndex = 12;
            this.shiftSpinBox.ValueChanged += new System.EventHandler(this.shiftSpinBox_ValueChanged);
            // 
            // BackGround
            // 
            this.BackGround.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackGround.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackGround.BackgroundImage")));
            this.BackGround.Controls.Add(this.shiftSpinBox);
            this.BackGround.Controls.Add(this.messageLabel);
            this.BackGround.Controls.Add(this.encryptedMessageTextBox);
            this.BackGround.Controls.Add(this.messageTextBox);
            this.BackGround.Controls.Add(this.encryptedMessageLabel);
            this.BackGround.Controls.Add(this.decryptButton);
            this.BackGround.Controls.Add(this.encryptButton);
            this.BackGround.Controls.Add(this.shiftLabel);
            this.BackGround.Controls.Add(this.clearButton);
            this.BackGround.Controls.Add(this.decryptedMessageLabel);
            this.BackGround.Controls.Add(this.decryptedMessageTextBox);
            this.BackGround.Location = new System.Drawing.Point(-4, -2);
            this.BackGround.MaximumSize = new System.Drawing.Size(595, 338);
            this.BackGround.Name = "BackGround";
            this.BackGround.Size = new System.Drawing.Size(595, 310);
            this.BackGround.TabIndex = 13;
            // 
            // CeaserCipherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(579, 299);
            this.Controls.Add(this.BackGround);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CeaserCipherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caesar Cipher";
            ((System.ComponentModel.ISupportInitialize)(this.shiftSpinBox)).EndInit();
            this.BackGround.ResumeLayout(false);
            this.BackGround.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Label shiftLabel;
        private System.Windows.Forms.TextBox decryptedMessageTextBox;
        private System.Windows.Forms.Label decryptedMessageLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.TextBox encryptedMessageTextBox;
        private System.Windows.Forms.Label encryptedMessageLabel;
        private System.Windows.Forms.NumericUpDown shiftSpinBox;
        private System.Windows.Forms.Panel BackGround;
    }
}

