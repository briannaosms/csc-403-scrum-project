using System.Diagnostics;
using TDRPGCode;

namespace TowerDefense_TheRPG {
    partial class FrmMain {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
            components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.lblStoryLine = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.waveCounter = new System.Windows.Forms.Label();
            this.waveInstruction = new System.Windows.Forms.Label();
            this.tmrTextCrawl = new System.Windows.Forms.Timer(this.components);
            this.tmrSpawnEnemies = new System.Windows.Forms.Timer(this.components);
            this.tmrMoveEnemies = new System.Windows.Forms.Timer(this.components);
            this.btnStoryLine = new System.Windows.Forms.Button();
            this.tmrMoveArrows = new System.Windows.Forms.Timer(this.components);
            this.tmrSpawnArrows = new System.Windows.Forms.Timer(this.components);
            this.tmrLootSpawned = new System.Windows.Forms.Timer(this.components);
            this.OptionsBtn = new System.Windows.Forms.Button();
            this.VolumeUpBtn = new System.Windows.Forms.Button();
            this.VolumeDownBtn = new System.Windows.Forms.Button();
            this.Vol1 = new System.Windows.Forms.PictureBox();
            this.Vol2 = new System.Windows.Forms.PictureBox();
            this.Vol3 = new System.Windows.Forms.PictureBox();
            this.Vol4 = new System.Windows.Forms.PictureBox();
            this.Vol5 = new System.Windows.Forms.PictureBox();
            this.VolName = new System.Windows.Forms.TextBox();
            this.FullScreen = new System.Windows.Forms.Button();
            this.WindowedBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Vol1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vol2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vol3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vol4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vol5)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStoryLine
            // 
            this.lblStoryLine.BackColor = System.Drawing.Color.Transparent;
            this.lblStoryLine.Font = new System.Drawing.Font("Segoe UI Emoji", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStoryLine.ForeColor = System.Drawing.Color.White;
            this.lblStoryLine.Location = new System.Drawing.Point(9, 11);
            this.lblStoryLine.Name = "lblStoryLine";
            this.lblStoryLine.Size = new System.Drawing.Size(1289, 821);
            this.lblStoryLine.TabIndex = 0;
            this.lblStoryLine.Click += new System.EventHandler(this.lblStoryLine_Click);
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = true;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(457, 827);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(251, 93);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Play";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // waveCounter
            // 
            this.waveCounter.BackColor = System.Drawing.Color.Transparent;
            this.waveCounter.Font = new System.Drawing.Font("Segoe UI Emoji", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.waveCounter.ForeColor = System.Drawing.Color.White;
            this.waveCounter.Location = new System.Drawing.Point(17, 20);
            this.waveCounter.Name = "waveCounter";
            this.waveCounter.Size = new System.Drawing.Size(160, 40);
            this.waveCounter.TabIndex = 4;
            this.waveCounter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // waveInstruction
            // 
            this.waveInstruction.BackColor = System.Drawing.Color.Transparent;
            this.waveInstruction.Font = new System.Drawing.Font("Segoe UI Emoji", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.waveInstruction.ForeColor = System.Drawing.Color.DarkRed;
            this.waveInstruction.Location = new System.Drawing.Point(800, 20);
            this.waveInstruction.Name = "waveInstruction";
            this.waveInstruction.Size = new System.Drawing.Size(343, 40);
            this.waveInstruction.TabIndex = 5;
            this.waveInstruction.Text = "Press [SPACE] to start wave";
            this.waveInstruction.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tmrTextCrawl
            // 
            this.tmrTextCrawl.Interval = 20;
            this.tmrTextCrawl.Tick += new System.EventHandler(this.tmrTextCrawl_Tick);
            // 
            // tmrSpawnEnemies
            // 
            this.tmrSpawnEnemies.Tick += new System.EventHandler(this.tmrSpawnEnemies_Tick);
            // 
            // tmrMoveEnemies
            // 
            this.tmrMoveEnemies.Tick += new System.EventHandler(this.tmrMoveEnemies_Tick);
            // 
            // btnStoryLine
            // 
            this.btnStoryLine.AutoSize = true;
            this.btnStoryLine.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStoryLine.Location = new System.Drawing.Point(857, 827);
            this.btnStoryLine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStoryLine.Name = "btnStoryLine";
            this.btnStoryLine.Size = new System.Drawing.Size(251, 93);
            this.btnStoryLine.TabIndex = 3;
            this.btnStoryLine.Text = "Show Storyline";
            this.btnStoryLine.UseVisualStyleBackColor = true;
            this.btnStoryLine.Click += new System.EventHandler(this.btnStoryLine_Click);
            // 
            // tmrMoveArrows
            // 
            this.tmrMoveArrows.Interval = 10;
            this.tmrMoveArrows.Tick += new System.EventHandler(this.tmrMoveArrows_Tick);
            // 
            // tmrSpawnArrows
            // 
            this.tmrSpawnArrows.Interval = 5000;
            this.tmrSpawnArrows.Tick += new System.EventHandler(this.tmrSpawnArrows_Tick);
            // 
            // tmrLootSpawned
            // 
            this.tmrLootSpawned.Interval = 1;
            // 
            // OptionsBtn
            // 
            this.OptionsBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OptionsBtn.Location = new System.Drawing.Point(1269, 827);
            this.OptionsBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OptionsBtn.Name = "OptionsBtn";
            this.OptionsBtn.Size = new System.Drawing.Size(251, 93);
            this.OptionsBtn.TabIndex = 6;
            this.OptionsBtn.Text = "Options";
            this.OptionsBtn.UseVisualStyleBackColor = true;
            this.OptionsBtn.Click += new System.EventHandler(this.OptionsBtn_Click);
            // 
            // VolumeUpBtn
            // 
            this.VolumeUpBtn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VolumeUpBtn.Location = new System.Drawing.Point(191, 377);
            this.VolumeUpBtn.Name = "VolumeUpBtn";
            this.VolumeUpBtn.Size = new System.Drawing.Size(45, 79);
            this.VolumeUpBtn.TabIndex = 0;
            this.VolumeUpBtn.Text = "↑";
            this.VolumeUpBtn.UseVisualStyleBackColor = true;
            this.VolumeUpBtn.Visible = false;
            this.VolumeUpBtn.Click += new System.EventHandler(this.VolUp_Click);
            // 
            // VolumeDownBtn
            // 
            this.VolumeDownBtn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VolumeDownBtn.Location = new System.Drawing.Point(440, 377);
            this.VolumeDownBtn.Name = "VolumeDownBtn";
            this.VolumeDownBtn.Size = new System.Drawing.Size(45, 79);
            this.VolumeDownBtn.TabIndex = 1;
            this.VolumeDownBtn.Text = "↓";
            this.VolumeDownBtn.UseVisualStyleBackColor = true;
            this.VolumeDownBtn.Visible = false;
            this.VolumeDownBtn.Click += new System.EventHandler(this.VolDown_Click);
            // 
            // Vol1
            // 
            this.Vol1.BackColor = System.Drawing.Color.Gray;
            this.Vol1.Location = new System.Drawing.Point(253, 377);
            this.Vol1.Name = "Vol1";
            this.Vol1.Size = new System.Drawing.Size(29, 79);
            this.Vol1.TabIndex = 2;
            this.Vol1.TabStop = false;
            this.Vol1.Visible = false;
            // 
            // Vol2
            // 
            this.Vol2.BackColor = System.Drawing.Color.Gray;
            this.Vol2.Location = new System.Drawing.Point(288, 377);
            this.Vol2.Name = "Vol2";
            this.Vol2.Size = new System.Drawing.Size(29, 79);
            this.Vol2.TabIndex = 3;
            this.Vol2.TabStop = false;
            this.Vol2.Visible = false;
            // 
            // Vol3
            // 
            this.Vol3.BackColor = System.Drawing.Color.Gray;
            this.Vol3.Location = new System.Drawing.Point(323, 377);
            this.Vol3.Name = "Vol3";
            this.Vol3.Size = new System.Drawing.Size(29, 79);
            this.Vol3.TabIndex = 4;
            this.Vol3.TabStop = false;
            this.Vol3.Visible = false;
            // 
            // Vol4
            // 
            this.Vol4.BackColor = System.Drawing.Color.Gray;
            this.Vol4.Location = new System.Drawing.Point(358, 377);
            this.Vol4.Name = "Vol4";
            this.Vol4.Size = new System.Drawing.Size(29, 79);
            this.Vol4.TabIndex = 5;
            this.Vol4.TabStop = false;
            this.Vol4.Visible = false;
            // 
            // Vol5
            // 
            this.Vol5.BackColor = System.Drawing.Color.Gray;
            this.Vol5.Location = new System.Drawing.Point(393, 377);
            this.Vol5.Name = "Vol5";
            this.Vol5.Size = new System.Drawing.Size(29, 79);
            this.Vol5.TabIndex = 6;
            this.Vol5.TabStop = false;
            this.Vol5.Visible = false;
            // 
            // VolName
            // 
            this.VolName.BackColor = System.Drawing.SystemColors.ControlDark;
            this.VolName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VolName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.VolName.Location = new System.Drawing.Point(253, 481);
            this.VolName.Name = "VolName";
            this.VolName.Size = new System.Drawing.Size(169, 47);
            this.VolName.TabIndex = 7;
            this.VolName.Text = "Volume";
            this.VolName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VolName.Visible = false;
            // 
            // FullScreen
            // 
            this.FullScreen.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FullScreen.Location = new System.Drawing.Point(960, 361);
            this.FullScreen.Name = "FullScreen";
            this.FullScreen.Size = new System.Drawing.Size(177, 107);
            this.FullScreen.TabIndex = 9;
            this.FullScreen.Text = "Full Screen";
            this.FullScreen.UseVisualStyleBackColor = true;
            this.FullScreen.Visible = false;
            this.FullScreen.Click += new System.EventHandler(this.FullScreen_Click);
            // 
            // WindowedBtn
            // 
            this.WindowedBtn.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WindowedBtn.Location = new System.Drawing.Point(960, 517);
            this.WindowedBtn.Name = "WindowedBtn";
            this.WindowedBtn.Size = new System.Drawing.Size(177, 96);
            this.WindowedBtn.TabIndex = 10;
            this.WindowedBtn.Text = "Windowed";
            this.WindowedBtn.UseVisualStyleBackColor = true;
            this.WindowedBtn.Visible = false;
            this.WindowedBtn.Click += new System.EventHandler(this.WindowedBtn_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::TowerDefense_TheRPG.Properties.Resources.title;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1313, 749);
            this.Controls.Add(this.WindowedBtn);
            this.Controls.Add(this.FullScreen);
            this.Controls.Add(this.VolName);
            this.Controls.Add(this.Vol5);
            this.Controls.Add(this.Vol4);
            this.Controls.Add(this.Vol3);
            this.Controls.Add(this.Vol2);
            this.Controls.Add(this.Vol1);
            this.Controls.Add(this.VolumeUpBtn);
            this.Controls.Add(this.VolumeDownBtn);
            this.Controls.Add(this.OptionsBtn);
            this.Controls.Add(this.btnStoryLine);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblStoryLine);
            this.Controls.Add(this.waveCounter);
            this.Controls.Add(this.waveInstruction);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tower Defense The RPG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Vol1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vol2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vol3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vol4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vol5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

        private Label lblStoryLine;
        private Button btnStart;
        private Label waveCounter;
        private Label waveInstruction;
        private System.Windows.Forms.Timer tmrTextCrawl;
        private System.Windows.Forms.Timer tmrSpawnEnemies;
        private System.Windows.Forms.Timer tmrMoveEnemies;
        private Button btnStoryLine;
        private System.Windows.Forms.Timer tmrMoveArrows;
        private System.Windows.Forms.Timer tmrSpawnArrows;
        private System.Windows.Forms.Timer tmrLootSpawned;
        private Button OptionsBtn;
        private Button VolumeUpBtn;
        private Button VolumeDownBtn;
        private PictureBox Vol1;
        private PictureBox Vol2;
        private PictureBox Vol3;
        private PictureBox Vol4;
        private PictureBox Vol5;
        private TextBox VolName;
        private Button FullScreen;
        private Button WindowedBtn;
    }
}