namespace MaterialForms.Forms
{
    partial class popupAddRecord
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
            this.lbVideoLink = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbStage = new System.Windows.Forms.ComboBox();
            this.lbStage = new System.Windows.Forms.Label();
            this.cbGame = new System.Windows.Forms.ComboBox();
            this.lbGame = new System.Windows.Forms.Label();
            this.cbPlatform = new System.Windows.Forms.ComboBox();
            this.lbPlatform = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbVideoLink
            // 
            this.lbVideoLink.AutoSize = true;
            this.lbVideoLink.Location = new System.Drawing.Point(25, 184);
            this.lbVideoLink.Name = "lbVideoLink";
            this.lbVideoLink.Size = new System.Drawing.Size(94, 13);
            this.lbVideoLink.TabIndex = 0;
            this.lbVideoLink.Text = "Youtube Video ID:";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(245, 217);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(25, 143);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(33, 13);
            this.lbTime.TabIndex = 4;
            this.lbTime.Text = "Time:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.cbStage);
            this.groupBox1.Controls.Add(this.lbStage);
            this.groupBox1.Controls.Add(this.cbGame);
            this.groupBox1.Controls.Add(this.lbGame);
            this.groupBox1.Controls.Add(this.cbPlatform);
            this.groupBox1.Controls.Add(this.lbPlatform);
            this.groupBox1.Controls.Add(this.maskedTextBox2);
            this.groupBox1.Controls.Add(this.btSave);
            this.groupBox1.Controls.Add(this.lbTime);
            this.groupBox1.Controls.Add(this.btCancel);
            this.groupBox1.Controls.Add(this.lbVideoLink);
            this.groupBox1.Location = new System.Drawing.Point(41, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 246);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(181, 178);
            this.textBox1.MaxLength = 20;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbStage
            // 
            this.cbStage.Enabled = false;
            this.cbStage.FormattingEnabled = true;
            this.cbStage.Location = new System.Drawing.Point(82, 99);
            this.cbStage.Name = "cbStage";
            this.cbStage.Size = new System.Drawing.Size(238, 21);
            this.cbStage.TabIndex = 3;
            // 
            // lbStage
            // 
            this.lbStage.AutoSize = true;
            this.lbStage.Location = new System.Drawing.Point(25, 102);
            this.lbStage.Name = "lbStage";
            this.lbStage.Size = new System.Drawing.Size(41, 13);
            this.lbStage.TabIndex = 10;
            this.lbStage.Text = "Stage: ";
            // 
            // cbGame
            // 
            this.cbGame.Enabled = false;
            this.cbGame.FormattingEnabled = true;
            this.cbGame.Location = new System.Drawing.Point(82, 58);
            this.cbGame.Name = "cbGame";
            this.cbGame.Size = new System.Drawing.Size(238, 21);
            this.cbGame.TabIndex = 2;
            // 
            // lbGame
            // 
            this.lbGame.AutoSize = true;
            this.lbGame.Location = new System.Drawing.Point(25, 61);
            this.lbGame.Name = "lbGame";
            this.lbGame.Size = new System.Drawing.Size(41, 13);
            this.lbGame.TabIndex = 8;
            this.lbGame.Text = "Game: ";
            // 
            // cbPlatform
            // 
            this.cbPlatform.FormattingEnabled = true;
            this.cbPlatform.Location = new System.Drawing.Point(82, 17);
            this.cbPlatform.Name = "cbPlatform";
            this.cbPlatform.Size = new System.Drawing.Size(238, 21);
            this.cbPlatform.TabIndex = 1;
            // 
            // lbPlatform
            // 
            this.lbPlatform.AutoSize = true;
            this.lbPlatform.Location = new System.Drawing.Point(25, 20);
            this.lbPlatform.Name = "lbPlatform";
            this.lbPlatform.Size = new System.Drawing.Size(51, 13);
            this.lbPlatform.TabIndex = 6;
            this.lbPlatform.Text = "Platform: ";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox2.Location = new System.Drawing.Point(181, 137);
            this.maskedTextBox2.Mask = "00:00:00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedTextBox2.Size = new System.Drawing.Size(139, 20);
            this.maskedTextBox2.TabIndex = 4;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(6, 217);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // popupAddRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 316);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "popupAddRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Record";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbVideoLink;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbStage;
        private System.Windows.Forms.ComboBox cbGame;
        private System.Windows.Forms.Label lbGame;
        private System.Windows.Forms.ComboBox cbPlatform;
        private System.Windows.Forms.Label lbPlatform;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbStage;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Button btCancel;
    }
}