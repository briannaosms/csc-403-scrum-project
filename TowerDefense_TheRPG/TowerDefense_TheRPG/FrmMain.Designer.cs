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
            #region Initialization
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
            //this.b = new System.Windows.Forms
            this.SuspendLayout();
            #endregion

            #region lblStoryLine
            this.lblStoryLine.BackColor = System.Drawing.Color.Transparent;
            this.lblStoryLine.Font = new System.Drawing.Font("Segoe UI Emoji", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStoryLine.ForeColor = System.Drawing.Color.White;
            this.lblStoryLine.Location = new System.Drawing.Point(8, 8);
            this.lblStoryLine.Name = "lblStoryLine";
            this.lblStoryLine.Size = new System.Drawing.Size(1128, 616);
            this.lblStoryLine.TabIndex = 0;
            #endregion

            #region btnStart
            this.btnStart.AutoSize = true;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(315, 617);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(220, 70);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Play";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            #endregion

            #region tmrTextCrawl
            this.tmrTextCrawl.Interval = 20;
            this.tmrTextCrawl.Tick += new System.EventHandler(this.tmrTextCrawl_Tick);
            #endregion

            #region tmrSpawnEnemies
            // increase inverval per wave
            //this.tmrSpawnEnemies.Interval = 3000;
            this.tmrSpawnEnemies.Tick += new System.EventHandler(this.tmrSpawnEnemies_Tick);
            Debug.WriteLine(tmrSpawnEnemies.Enabled);
            #endregion

            #region waveCounter
            this.waveCounter.Name = "Wave Counter";
            this.waveCounter.Size = new System.Drawing.Size(140, 30);
            this.waveCounter.TextAlign = ContentAlignment.TopCenter;
            this.waveCounter.BackColor = System.Drawing.Color.Transparent;
            this.waveCounter.Font = new System.Drawing.Font("Segoe UI Emoji", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.waveCounter.ForeColor = System.Drawing.Color.White;
            this.waveCounter.Location = new System.Drawing.Point(15, 15);
            this.waveCounter.BringToFront();
            #endregion

            // wip
            #region waveInstruction 
            this.waveInstruction.Name = "Wave";
            this.waveInstruction.Size = new System.Drawing.Size(300, 30);
            this.waveInstruction.TextAlign = ContentAlignment.TopCenter;
            this.waveInstruction.BackColor = System.Drawing.Color.Transparent;
            this.waveInstruction.Font = new System.Drawing.Font("Segoe UI Emoji", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.waveInstruction.Text = "Press [SPACE] to start wave";
            this.waveInstruction.ForeColor = System.Drawing.Color.DarkRed;
            this.waveInstruction.Location = new System.Drawing.Point(425, 15);
            //this.waveInstruction
            #endregion

            #region tmrMoveEnemies
            this.tmrMoveEnemies.Tick += new System.EventHandler(this.tmrMoveEnemies_Tick);
            #endregion

            #region btnStoryLine
            this.btnStoryLine.AutoSize = true;
            this.btnStoryLine.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStoryLine.Location = new System.Drawing.Point(630, 617);
            this.btnStoryLine.Name = "btnStoryLine";
            this.btnStoryLine.Size = new System.Drawing.Size(220, 70);
            this.btnStoryLine.TabIndex = 3;
            this.btnStoryLine.Text = "Show Storyline";
            this.btnStoryLine.UseVisualStyleBackColor = true;
            this.btnStoryLine.Click += new System.EventHandler(this.btnStoryLine_Click);
            #endregion

            #region tmrMoveArrows
            this.tmrMoveArrows.Interval = 10;
            this.tmrMoveArrows.Tick += new System.EventHandler(this.tmrMoveArrows_Tick);
            #endregion

            #region tmrSpawnArrows
            this.tmrSpawnArrows.Interval = 5000;
            this.tmrSpawnArrows.Tick += new System.EventHandler(this.tmrSpawnArrows_Tick);
            #endregion

            #region FrmMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::TowerDefense_TheRPG.Properties.Resources.title;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1149, 726);
            this.Controls.Add(this.btnStoryLine);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblStoryLine);
            this.Controls.Add(this.waveCounter);
            this.Controls.Add(this.waveInstruction);
            this.DoubleBuffered = true;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tower Defense The RPG";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();
            #endregion
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
        }
}