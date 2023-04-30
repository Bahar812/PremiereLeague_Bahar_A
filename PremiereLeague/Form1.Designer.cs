namespace PremiereLeague
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.playerDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMatchDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.panelPopulateData = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPlayer = new System.Windows.Forms.ComboBox();
            this.comboBoxTeam = new System.Windows.Forms.ComboBox();
            this.panelMatch = new System.Windows.Forms.Panel();
            this.panelDetailMatch = new System.Windows.Forms.Panel();
            this.dgvPlayerAway = new System.Windows.Forms.DataGridView();
            this.dgvPlayerHome = new System.Windows.Forms.DataGridView();
            this.dgvMatch = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTeamMatch = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.panelPlayer.SuspendLayout();
            this.panelMatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerAway)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatch)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerDataToolStripMenuItem,
            this.showMatchDetailsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(802, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // playerDataToolStripMenuItem
            // 
            this.playerDataToolStripMenuItem.Name = "playerDataToolStripMenuItem";
            this.playerDataToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.playerDataToolStripMenuItem.Text = "Player Data";
            this.playerDataToolStripMenuItem.Click += new System.EventHandler(this.playerDataToolStripMenuItem_Click);
            // 
            // showMatchDetailsToolStripMenuItem
            // 
            this.showMatchDetailsToolStripMenuItem.Name = "showMatchDetailsToolStripMenuItem";
            this.showMatchDetailsToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.showMatchDetailsToolStripMenuItem.Text = "Show Match Details";
            this.showMatchDetailsToolStripMenuItem.Click += new System.EventHandler(this.showMatchDetailsToolStripMenuItem_Click);
            // 
            // panelPlayer
            // 
            this.panelPlayer.Controls.Add(this.panelPopulateData);
            this.panelPlayer.Controls.Add(this.label1);
            this.panelPlayer.Controls.Add(this.comboBoxPlayer);
            this.panelPlayer.Controls.Add(this.comboBoxTeam);
            this.panelPlayer.Location = new System.Drawing.Point(3, 24);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(800, 401);
            this.panelPlayer.TabIndex = 1;
            // 
            // panelPopulateData
            // 
            this.panelPopulateData.Location = new System.Drawing.Point(32, 103);
            this.panelPopulateData.Name = "panelPopulateData";
            this.panelPopulateData.Size = new System.Drawing.Size(413, 279);
            this.panelPopulateData.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Panel Player";
            // 
            // comboBoxPlayer
            // 
            this.comboBoxPlayer.FormattingEnabled = true;
            this.comboBoxPlayer.Location = new System.Drawing.Point(212, 51);
            this.comboBoxPlayer.Name = "comboBoxPlayer";
            this.comboBoxPlayer.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPlayer.TabIndex = 1;
            this.comboBoxPlayer.SelectedIndexChanged += new System.EventHandler(this.comboBoxPlayer_SelectedIndexChanged);
            this.comboBoxPlayer.SelectionChangeCommitted += new System.EventHandler(this.comboBoxPlayer_SelectionChangeCommitted);
            // 
            // comboBoxTeam
            // 
            this.comboBoxTeam.FormattingEnabled = true;
            this.comboBoxTeam.Location = new System.Drawing.Point(33, 51);
            this.comboBoxTeam.Name = "comboBoxTeam";
            this.comboBoxTeam.Size = new System.Drawing.Size(173, 21);
            this.comboBoxTeam.TabIndex = 0;
            this.comboBoxTeam.SelectedIndexChanged += new System.EventHandler(this.comboBoxTeam_SelectedIndexChanged);
            this.comboBoxTeam.SelectionChangeCommitted += new System.EventHandler(this.comboBoxTeam_SelectionChangeCommitted);
            // 
            // panelMatch
            // 
            this.panelMatch.Controls.Add(this.panelDetailMatch);
            this.panelMatch.Controls.Add(this.dgvPlayerAway);
            this.panelMatch.Controls.Add(this.dgvPlayerHome);
            this.panelMatch.Controls.Add(this.dgvMatch);
            this.panelMatch.Controls.Add(this.label2);
            this.panelMatch.Controls.Add(this.comboBoxTeamMatch);
            this.panelMatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMatch.Location = new System.Drawing.Point(0, 24);
            this.panelMatch.Name = "panelMatch";
            this.panelMatch.Size = new System.Drawing.Size(802, 426);
            this.panelMatch.TabIndex = 3;
            // 
            // panelDetailMatch
            // 
            this.panelDetailMatch.Location = new System.Drawing.Point(316, 207);
            this.panelDetailMatch.Name = "panelDetailMatch";
            this.panelDetailMatch.Size = new System.Drawing.Size(461, 156);
            this.panelDetailMatch.TabIndex = 5;
            // 
            // dgvPlayerAway
            // 
            this.dgvPlayerAway.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayerAway.Location = new System.Drawing.Point(550, 51);
            this.dgvPlayerAway.Name = "dgvPlayerAway";
            this.dgvPlayerAway.Size = new System.Drawing.Size(228, 135);
            this.dgvPlayerAway.TabIndex = 4;
            // 
            // dgvPlayerHome
            // 
            this.dgvPlayerHome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayerHome.Location = new System.Drawing.Point(317, 51);
            this.dgvPlayerHome.Name = "dgvPlayerHome";
            this.dgvPlayerHome.Size = new System.Drawing.Size(207, 135);
            this.dgvPlayerHome.TabIndex = 3;
            // 
            // dgvMatch
            // 
            this.dgvMatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatch.Location = new System.Drawing.Point(32, 106);
            this.dgvMatch.Name = "dgvMatch";
            this.dgvMatch.Size = new System.Drawing.Size(240, 258);
            this.dgvMatch.TabIndex = 2;
            this.dgvMatch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatch_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Panel Match";
            // 
            // comboBoxTeamMatch
            // 
            this.comboBoxTeamMatch.FormattingEnabled = true;
            this.comboBoxTeamMatch.Location = new System.Drawing.Point(33, 51);
            this.comboBoxTeamMatch.Name = "comboBoxTeamMatch";
            this.comboBoxTeamMatch.Size = new System.Drawing.Size(247, 21);
            this.comboBoxTeamMatch.TabIndex = 0;
            this.comboBoxTeamMatch.SelectionChangeCommitted += new System.EventHandler(this.comboBoxTeamMatch_SelectionChangeCommitted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.panelMatch);
            this.Controls.Add(this.panelPlayer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelPlayer.ResumeLayout(false);
            this.panelPlayer.PerformLayout();
            this.panelMatch.ResumeLayout(false);
            this.panelMatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerAway)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem playerDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMatchDetailsToolStripMenuItem;
        private System.Windows.Forms.Panel panelPlayer;
        private System.Windows.Forms.Panel panelMatch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTeamMatch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPlayer;
        private System.Windows.Forms.ComboBox comboBoxTeam;
        private System.Windows.Forms.Panel panelPopulateData;
        private System.Windows.Forms.DataGridView dgvMatch;
        private System.Windows.Forms.DataGridView dgvPlayerAway;
        private System.Windows.Forms.DataGridView dgvPlayerHome;
        private System.Windows.Forms.Panel panelDetailMatch;
    }
}

