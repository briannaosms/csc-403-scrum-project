namespace TowerDefense_TheRPG {
  partial class Form1 {
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
      this.tmrTextCrawl = new System.Windows.Forms.Timer(this.components);
      this.picVillage = new System.Windows.Forms.PictureBox();
      this.tmrSpawnEnemies = new System.Windows.Forms.Timer(this.components);
      this.tmrMoveEnemies = new System.Windows.Forms.Timer(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.picVillage)).BeginInit();
      this.SuspendLayout();
      // 
      // lblStoryLine
      // 
      this.lblStoryLine.Font = new System.Drawing.Font("Segoe UI Emoji", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblStoryLine.ForeColor = System.Drawing.Color.White;
      this.lblStoryLine.Location = new System.Drawing.Point(12, 9);
      this.lblStoryLine.Name = "lblStoryLine";
      this.lblStoryLine.Size = new System.Drawing.Size(1125, 619);
      this.lblStoryLine.TabIndex = 0;
      // 
      // btnStart
      // 
      this.btnStart.AutoSize = true;
      this.btnStart.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnStart.Location = new System.Drawing.Point(455, 654);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(176, 42);
      this.btnStart.TabIndex = 1;
      this.btnStart.Text = "Let\'s Do This!";
      this.btnStart.UseVisualStyleBackColor = true;
      this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
      // 
      // tmrTextCrawl
      // 
      this.tmrTextCrawl.Interval = 45;
      this.tmrTextCrawl.Tick += new System.EventHandler(this.tmrTextCrawl_Tick);
      // 
      // picVillage
      // 
      this.picVillage.BackgroundImage = global::TowerDefense_TheRPG.Properties.Resources.village;
      this.picVillage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picVillage.Location = new System.Drawing.Point(502, 286);
      this.picVillage.Name = "picVillage";
      this.picVillage.Size = new System.Drawing.Size(165, 108);
      this.picVillage.TabIndex = 2;
      this.picVillage.TabStop = false;
      // 
      // tmrSpawnEnemies
      // 
      this.tmrSpawnEnemies.Interval = 3000;
      this.tmrSpawnEnemies.Tick += new System.EventHandler(this.tmrSpawnEnemies_Tick);
      // 
      // tmrMoveEnemies
      // 
      this.tmrMoveEnemies.Enabled = true;
      this.tmrMoveEnemies.Tick += new System.EventHandler(this.tmrMoveEnemies_Tick);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Black;
      this.ClientSize = new System.Drawing.Size(1149, 726);
      this.Controls.Add(this.lblStoryLine);
      this.Controls.Add(this.btnStart);
      this.Controls.Add(this.picVillage);
      this.Name = "Form1";
      this.Text = "Tower Defense The RPG";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
      ((System.ComponentModel.ISupportInitialize)(this.picVillage)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Label lblStoryLine;
    private Button btnStart;
    private System.Windows.Forms.Timer tmrTextCrawl;
    private PictureBox picVillage;
    private System.Windows.Forms.Timer tmrSpawnEnemies;
    private System.Windows.Forms.Timer tmrMoveEnemies;
  }
}