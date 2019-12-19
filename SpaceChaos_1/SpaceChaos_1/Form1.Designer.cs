namespace SpaceChaos_1
{
    partial class frmSpaceChaos
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
            this.components = new System.ComponentModel.Container();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.picMeteor1 = new System.Windows.Forms.PictureBox();
            this.picMeteor2 = new System.Windows.Forms.PictureBox();
            this.picMeteor3 = new System.Windows.Forms.PictureBox();
            this.picMeteor4 = new System.Windows.Forms.PictureBox();
            this.picMeteor5 = new System.Windows.Forms.PictureBox();
            this.picSpaceShip = new System.Windows.Forms.PictureBox();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.lblPlayAgain = new System.Windows.Forms.Label();
            this.mnuFile = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRules = new System.Windows.Forms.ToolStripMenuItem();
            this.lblGameScore = new System.Windows.Forms.Label();
            this.lblFinalScore = new System.Windows.Forms.Label();
            this.picPowerUp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMeteor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMeteor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMeteor3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMeteor4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMeteor5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpaceShip)).BeginInit();
            this.mnuFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPowerUp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(-4, 448);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(41, 13);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score: ";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(581, 173);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(33, 13);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.Text = "Timer";
            // 
            // tmrGame
            // 
            this.tmrGame.Enabled = true;
            this.tmrGame.Interval = 20;
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick);
            // 
            // picMeteor1
            // 
            this.picMeteor1.BackgroundImage = global::SpaceChaos_1.Textures.meteor1;
            this.picMeteor1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMeteor1.Location = new System.Drawing.Point(0, 27);
            this.picMeteor1.Name = "picMeteor1";
            this.picMeteor1.Size = new System.Drawing.Size(50, 50);
            this.picMeteor1.TabIndex = 14;
            this.picMeteor1.TabStop = false;
            this.picMeteor1.Tag = "Obstacle";
            this.picMeteor1.Click += new System.EventHandler(this.picMeteor1_Click);
            // 
            // picMeteor2
            // 
            this.picMeteor2.BackgroundImage = global::SpaceChaos_1.Textures.meteor1;
            this.picMeteor2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMeteor2.Location = new System.Drawing.Point(150, 27);
            this.picMeteor2.Name = "picMeteor2";
            this.picMeteor2.Size = new System.Drawing.Size(50, 50);
            this.picMeteor2.TabIndex = 13;
            this.picMeteor2.TabStop = false;
            this.picMeteor2.Tag = "Obstacle";
            // 
            // picMeteor3
            // 
            this.picMeteor3.BackgroundImage = global::SpaceChaos_1.Textures.meteor1;
            this.picMeteor3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMeteor3.Location = new System.Drawing.Point(250, 27);
            this.picMeteor3.Name = "picMeteor3";
            this.picMeteor3.Size = new System.Drawing.Size(50, 50);
            this.picMeteor3.TabIndex = 12;
            this.picMeteor3.TabStop = false;
            this.picMeteor3.Tag = "Obstacle";
            // 
            // picMeteor4
            // 
            this.picMeteor4.BackgroundImage = global::SpaceChaos_1.Textures.meteor1;
            this.picMeteor4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMeteor4.Location = new System.Drawing.Point(398, 27);
            this.picMeteor4.Name = "picMeteor4";
            this.picMeteor4.Size = new System.Drawing.Size(50, 50);
            this.picMeteor4.TabIndex = 10;
            this.picMeteor4.TabStop = false;
            this.picMeteor4.Tag = "Obstacle";
            this.picMeteor4.Click += new System.EventHandler(this.picMeteor4_Click);
            // 
            // picMeteor5
            // 
            this.picMeteor5.BackgroundImage = global::SpaceChaos_1.Textures.meteor1;
            this.picMeteor5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMeteor5.Location = new System.Drawing.Point(594, 27);
            this.picMeteor5.Name = "picMeteor5";
            this.picMeteor5.Size = new System.Drawing.Size(50, 50);
            this.picMeteor5.TabIndex = 9;
            this.picMeteor5.TabStop = false;
            this.picMeteor5.Tag = "Obstacle";
            // 
            // picSpaceShip
            // 
            this.picSpaceShip.BackgroundImage = global::SpaceChaos_1.Textures.SpaceShip;
            this.picSpaceShip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSpaceShip.Location = new System.Drawing.Point(261, 400);
            this.picSpaceShip.Name = "picSpaceShip";
            this.picSpaceShip.Size = new System.Drawing.Size(50, 50);
            this.picSpaceShip.TabIndex = 1;
            this.picSpaceShip.TabStop = false;
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.White;
            this.lblGameOver.Location = new System.Drawing.Point(31, 132);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(624, 119);
            this.lblGameOver.TabIndex = 15;
            this.lblGameOver.Text = "Game Over!";
            this.lblGameOver.Visible = false;
            // 
            // lblPlayAgain
            // 
            this.lblPlayAgain.AutoSize = true;
            this.lblPlayAgain.BackColor = System.Drawing.Color.Maroon;
            this.lblPlayAgain.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayAgain.ForeColor = System.Drawing.Color.White;
            this.lblPlayAgain.Location = new System.Drawing.Point(144, 289);
            this.lblPlayAgain.Name = "lblPlayAgain";
            this.lblPlayAgain.Size = new System.Drawing.Size(416, 36);
            this.lblPlayAgain.TabIndex = 16;
            this.lblPlayAgain.Text = "Press Enter to Play Again";
            this.lblPlayAgain.Visible = false;
            // 
            // mnuFile
            // 
            this.mnuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mnuHelp});
            this.mnuFile.Location = new System.Drawing.Point(0, 0);
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(684, 24);
            this.mnuFile.TabIndex = 17;
            this.mnuFile.Text = "menuStrip1";
            this.mnuFile.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuFile_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileRestart,
            this.mnuFileExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuFileRestart
            // 
            this.mnuFileRestart.Name = "mnuFileRestart";
            this.mnuFileRestart.Size = new System.Drawing.Size(110, 22);
            this.mnuFileRestart.Text = "Restart";
            this.mnuFileRestart.Click += new System.EventHandler(this.mnuFileRestart_Click);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(110, 22);
            this.mnuFileExit.Text = "Exit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRules});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "Help";
            // 
            // mnuRules
            // 
            this.mnuRules.Name = "mnuRules";
            this.mnuRules.Size = new System.Drawing.Size(102, 22);
            this.mnuRules.Text = "Rules";
            this.mnuRules.Click += new System.EventHandler(this.mnuRules_Click);
            // 
            // lblGameScore
            // 
            this.lblGameScore.AutoSize = true;
            this.lblGameScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameScore.ForeColor = System.Drawing.Color.White;
            this.lblGameScore.Location = new System.Drawing.Point(2, 435);
            this.lblGameScore.Name = "lblGameScore";
            this.lblGameScore.Size = new System.Drawing.Size(66, 24);
            this.lblGameScore.TabIndex = 18;
            this.lblGameScore.Text = "label1";
            this.lblGameScore.Click += new System.EventHandler(this.lblGameScore_Click);
            // 
            // lblFinalScore
            // 
            this.lblFinalScore.AutoSize = true;
            this.lblFinalScore.BackColor = System.Drawing.Color.Transparent;
            this.lblFinalScore.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalScore.ForeColor = System.Drawing.Color.Maroon;
            this.lblFinalScore.Location = new System.Drawing.Point(144, 244);
            this.lblFinalScore.Name = "lblFinalScore";
            this.lblFinalScore.Size = new System.Drawing.Size(0, 36);
            this.lblFinalScore.TabIndex = 19;
            this.lblFinalScore.Visible = false;
            // 
            // picPowerUp
            // 
            this.picPowerUp.BackgroundImage = global::SpaceChaos_1.Textures.picPowerUp;
            this.picPowerUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPowerUp.Location = new System.Drawing.Point(330, 27);
            this.picPowerUp.Name = "picPowerUp";
            this.picPowerUp.Size = new System.Drawing.Size(36, 30);
            this.picPowerUp.TabIndex = 20;
            this.picPowerUp.TabStop = false;
            this.picPowerUp.Tag = "PowerUp";
            this.picPowerUp.Visible = false;
            // 
            // frmSpaceChaos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.lblFinalScore);
            this.Controls.Add(this.lblGameScore);
            this.Controls.Add(this.lblPlayAgain);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.picMeteor1);
            this.Controls.Add(this.picMeteor2);
            this.Controls.Add(this.picMeteor3);
            this.Controls.Add(this.picMeteor4);
            this.Controls.Add(this.picMeteor5);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.picSpaceShip);
            this.Controls.Add(this.mnuFile);
            this.Controls.Add(this.picPowerUp);
            this.MainMenuStrip = this.mnuFile;
            this.Name = "frmSpaceChaos";
            this.Text = "Space Chaos";
            this.Load += new System.EventHandler(this.frmSpaceChaos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyisDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyisUp);
            ((System.ComponentModel.ISupportInitialize)(this.picMeteor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMeteor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMeteor3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMeteor4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMeteor5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpaceShip)).EndInit();
            this.mnuFile.ResumeLayout(false);
            this.mnuFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPowerUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSpaceShip;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.PictureBox picMeteor5;
        private System.Windows.Forms.PictureBox picMeteor4;
        private System.Windows.Forms.PictureBox picMeteor3;
        private System.Windows.Forms.PictureBox picMeteor2;
        private System.Windows.Forms.PictureBox picMeteor1;
        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblPlayAgain;
        private System.Windows.Forms.MenuStrip mnuFile;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFileRestart;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuRules;
        private System.Windows.Forms.Label lblGameScore;
        private System.Windows.Forms.Label lblFinalScore;
        private System.Windows.Forms.PictureBox picPowerUp;
    }
}

