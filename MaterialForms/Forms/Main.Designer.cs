namespace MaterialForms.Forms
{
    partial class Main
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
            this.tabcVisualize = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabc_Manage = new System.Windows.Forms.TabPage();
            this.lbRecords = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btRemove = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.RecordID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Game = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Platform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Video = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tabcVisualize.SuspendLayout();
            this.tabc_Manage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabcVisualize
            // 
            this.tabcVisualize.Controls.Add(this.tabPage1);
            this.tabcVisualize.Controls.Add(this.tabc_Manage);
            this.tabcVisualize.Location = new System.Drawing.Point(8, 8);
            this.tabcVisualize.Margin = new System.Windows.Forms.Padding(2);
            this.tabcVisualize.Name = "tabcVisualize";
            this.tabcVisualize.SelectedIndex = 0;
            this.tabcVisualize.Size = new System.Drawing.Size(605, 422);
            this.tabcVisualize.TabIndex = 1;
            this.tabcVisualize.Click += new System.EventHandler(this.LoadTabVisualize);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(597, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vizualize";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabc_Manage
            // 
            this.tabc_Manage.Controls.Add(this.lbRecords);
            this.tabc_Manage.Controls.Add(this.dataGridView1);
            this.tabc_Manage.Controls.Add(this.btRemove);
            this.tabc_Manage.Controls.Add(this.btAdd);
            this.tabc_Manage.Location = new System.Drawing.Point(4, 22);
            this.tabc_Manage.Margin = new System.Windows.Forms.Padding(2);
            this.tabc_Manage.Name = "tabc_Manage";
            this.tabc_Manage.Padding = new System.Windows.Forms.Padding(2);
            this.tabc_Manage.Size = new System.Drawing.Size(597, 396);
            this.tabc_Manage.TabIndex = 1;
            this.tabc_Manage.Text = "Manage";
            this.tabc_Manage.UseVisualStyleBackColor = true;
            // 
            // lbRecords
            // 
            this.lbRecords.AutoSize = true;
            this.lbRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbRecords.Location = new System.Drawing.Point(262, 14);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(64, 13);
            this.lbRecords.TabIndex = 3;
            this.lbRecords.Text = "My Records";
            this.lbRecords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RecordID,
            this.Game,
            this.Stage,
            this.Platform,
            this.Video});
            this.dataGridView1.Location = new System.Drawing.Point(5, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(587, 244);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(401, 118);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(191, 23);
            this.btRemove.TabIndex = 1;
            this.btRemove.Text = "Remove Record";
            this.btRemove.UseVisualStyleBackColor = true;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(204, 118);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(191, 23);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Add Record";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // RecordID
            // 
            this.RecordID.HeaderText = "RecordID";
            this.RecordID.Name = "RecordID";
            this.RecordID.ReadOnly = true;
            // 
            // Game
            // 
            this.Game.HeaderText = "Game";
            this.Game.Name = "Game";
            this.Game.ReadOnly = true;
            // 
            // Stage
            // 
            this.Stage.HeaderText = "Stage";
            this.Stage.Name = "Stage";
            this.Stage.ReadOnly = true;
            // 
            // Platform
            // 
            this.Platform.HeaderText = "Platform";
            this.Platform.Name = "Platform";
            this.Platform.ReadOnly = true;
            // 
            // Video
            // 
            this.Video.HeaderText = "Video";
            this.Video.Name = "Video";
            this.Video.ReadOnly = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tabcVisualize);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 480);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Main";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bandicoot Records";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabcVisualize.ResumeLayout(false);
            this.tabc_Manage.ResumeLayout(false);
            this.tabc_Manage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcVisualize;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabc_Manage;
        private System.Windows.Forms.Label lbRecords;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Game;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Platform;
        private System.Windows.Forms.DataGridViewLinkColumn Video;
    }
}