namespace TowerDefense_TheRPG
{
    partial class FrmOptions
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
            this.VolumeUpBtn = new System.Windows.Forms.Button();
            this.VolumeDownBtn = new System.Windows.Forms.Button();
            this.Vol1 = new System.Windows.Forms.PictureBox();
            this.Vol2 = new System.Windows.Forms.PictureBox();
            this.Vol3 = new System.Windows.Forms.PictureBox();
            this.Vol4 = new System.Windows.Forms.PictureBox();
            this.Vol5 = new System.Windows.Forms.PictureBox();
            this.VolName = new System.Windows.Forms.TextBox();
            this.BackToMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Vol1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vol2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vol3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vol4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vol5)).BeginInit();
            this.SuspendLayout();
            // 
            // VolumeUpBtn
            // 
            this.VolumeUpBtn.Location = new System.Drawing.Point(191, 377);
            this.VolumeUpBtn.Name = "VolumeUpBtn";
            this.VolumeUpBtn.Size = new System.Drawing.Size(45, 79);
            this.VolumeUpBtn.TabIndex = 0;
            this.VolumeUpBtn.Text = "↑";
            this.VolumeUpBtn.UseVisualStyleBackColor = true;
            this.VolumeUpBtn.Click += new System.EventHandler(this.VolUp_Click);
            // 
            // VolumeDownBtn
            // 
            this.VolumeDownBtn.Location = new System.Drawing.Point(440, 377);
            this.VolumeDownBtn.Name = "VolumeDownBtn";
            this.VolumeDownBtn.Size = new System.Drawing.Size(45, 79);
            this.VolumeDownBtn.TabIndex = 1;
            this.VolumeDownBtn.Text = "↓";
            this.VolumeDownBtn.UseVisualStyleBackColor = true;
            this.VolumeDownBtn.Click += new System.EventHandler(this.VolDown_Click);
            // 
            // Vol1
            // 
            this.Vol1.Location = new System.Drawing.Point(253, 377);
            this.Vol1.Name = "Vol1";
            this.Vol1.Size = new System.Drawing.Size(29, 79);
            this.Vol1.TabIndex = 2;
            this.Vol1.TabStop = false;
            // 
            // Vol2
            // 
            this.Vol2.Location = new System.Drawing.Point(288, 377);
            this.Vol2.Name = "Vol2";
            this.Vol2.Size = new System.Drawing.Size(29, 79);
            this.Vol2.TabIndex = 3;
            this.Vol2.TabStop = false;
            // 
            // Vol3
            // 
            this.Vol3.Location = new System.Drawing.Point(323, 377);
            this.Vol3.Name = "Vol3";
            this.Vol3.Size = new System.Drawing.Size(29, 79);
            this.Vol3.TabIndex = 4;
            this.Vol3.TabStop = false;
            // 
            // Vol4
            // 
            this.Vol4.Location = new System.Drawing.Point(358, 377);
            this.Vol4.Name = "Vol4";
            this.Vol4.Size = new System.Drawing.Size(29, 79);
            this.Vol4.TabIndex = 5;
            this.Vol4.TabStop = false;
            // 
            // Vol5
            // 
            this.Vol5.Location = new System.Drawing.Point(393, 377);
            this.Vol5.Name = "Vol5";
            this.Vol5.Size = new System.Drawing.Size(29, 79);
            this.Vol5.TabIndex = 6;
            this.Vol5.TabStop = false;
            // 
            // VolName
            // 
            this.VolName.Location = new System.Drawing.Point(253, 481);
            this.VolName.Name = "VolName";
            this.VolName.Size = new System.Drawing.Size(169, 27);
            this.VolName.TabIndex = 7;
            // 
            // BackToMain
            // 
            this.BackToMain.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackToMain.Location = new System.Drawing.Point(566, 809);
            this.BackToMain.Name = "BackToMain";
            this.BackToMain.Size = new System.Drawing.Size(247, 121);
            this.BackToMain.TabIndex = 8;
            this.BackToMain.Text = "Click to return to main menu";
            this.BackToMain.UseVisualStyleBackColor = true;
            this.BackToMain.Click += new System.EventHandler(this.BackToMain_Click);
            // 
            // FrmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TowerDefense_TheRPG.Properties.Resources.title;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1313, 1003);
            this.Controls.Add(this.BackToMain);
            this.Controls.Add(this.VolName);
            this.Controls.Add(this.Vol5);
            this.Controls.Add(this.Vol4);
            this.Controls.Add(this.Vol3);
            this.Controls.Add(this.Vol2);
            this.Controls.Add(this.Vol1);
            this.Controls.Add(this.VolumeUpBtn);
            this.Controls.Add(this.VolumeDownBtn);
            this.DoubleBuffered = true;
            this.Name = "FrmOptions";
            this.Text = "FrmOptions";
            ((System.ComponentModel.ISupportInitialize)(this.Vol1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vol2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vol3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vol4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vol5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button VolumeUpBtn;
        private Button VolumeDownBtn;
        private PictureBox Vol1;
        private PictureBox Vol2;
        private PictureBox Vol3;
        private PictureBox Vol4;
        private PictureBox Vol5;
        private TextBox VolName;
        private Button BackToMain;
    }
}