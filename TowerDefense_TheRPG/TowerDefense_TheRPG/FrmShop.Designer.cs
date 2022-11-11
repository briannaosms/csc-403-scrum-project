namespace TowerDefense_TheRPG
{
    partial class FrmShop
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
            this.Phealthup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Pattackup = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Pspeedup = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Vfullheal = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.Vhealthup = new System.Windows.Forms.Button();
            this.PAttackCost = new System.Windows.Forms.Label();
            this.PSpeedCost = new System.Windows.Forms.Label();
            this.PHealthCost = new System.Windows.Forms.Label();
            this.VHealthCost = new System.Windows.Forms.Label();
            this.VHealCost = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.wallet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Phealthup
            // 
            this.Phealthup.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.Phealthup.Location = new System.Drawing.Point(117, 295);
            this.Phealthup.Name = "Phealthup";
            this.Phealthup.Size = new System.Drawing.Size(107, 39);
            this.Phealthup.TabIndex = 0;
            this.Phealthup.Text = "Health+";
            this.Phealthup.UseVisualStyleBackColor = true;
            this.Phealthup.Click += new System.EventHandler(this.PhealthUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(331, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Shop";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Pattackup
            // 
            this.Pattackup.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.Pattackup.Location = new System.Drawing.Point(117, 144);
            this.Pattackup.Margin = new System.Windows.Forms.Padding(1);
            this.Pattackup.Name = "Pattackup";
            this.Pattackup.Padding = new System.Windows.Forms.Padding(3);
            this.Pattackup.Size = new System.Drawing.Size(107, 42);
            this.Pattackup.TabIndex = 2;
            this.Pattackup.Text = "Attack+";
            this.Pattackup.UseVisualStyleBackColor = true;
            this.Pattackup.Click += new System.EventHandler(this.PattackUp_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.linkLabel1.Location = new System.Drawing.Point(224, 97);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 15);
            this.linkLabel1.TabIndex = 3;
            // 
            // Pspeedup
            // 
            this.Pspeedup.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.Pspeedup.Location = new System.Drawing.Point(117, 222);
            this.Pspeedup.Name = "Pspeedup";
            this.Pspeedup.Size = new System.Drawing.Size(107, 39);
            this.Pspeedup.TabIndex = 4;
            this.Pspeedup.Text = "Speed+";
            this.Pspeedup.UseVisualStyleBackColor = true;
            this.Pspeedup.Click += new System.EventHandler(this.PspeedUp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(512, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 37);
            this.label3.TabIndex = 10;
            this.label3.Text = "Village Upgrades";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Vfullheal
            // 
            this.Vfullheal.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.Vfullheal.Location = new System.Drawing.Point(561, 259);
            this.Vfullheal.Name = "Vfullheal";
            this.Vfullheal.Size = new System.Drawing.Size(108, 39);
            this.Vfullheal.TabIndex = 9;
            this.Vfullheal.Text = "Full Heal";
            this.Vfullheal.UseVisualStyleBackColor = true;
            this.Vfullheal.Click += new System.EventHandler(this.VfullHeal_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.SaddleBrown;
            this.linkLabel2.Location = new System.Drawing.Point(607, 97);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(0, 15);
            this.linkLabel2.TabIndex = 8;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Vhealthup
            // 
            this.Vhealthup.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.Vhealthup.Location = new System.Drawing.Point(562, 177);
            this.Vhealthup.Name = "Vhealthup";
            this.Vhealthup.Size = new System.Drawing.Size(107, 42);
            this.Vhealthup.TabIndex = 7;
            this.Vhealthup.Text = "Health+";
            this.Vhealthup.UseVisualStyleBackColor = true;
            this.Vhealthup.Click += new System.EventHandler(this.VhealthUp_Click);
            // 
            // PAttackCost
            // 
            this.PAttackCost.AutoSize = true;
            this.PAttackCost.BackColor = System.Drawing.Color.Transparent;
            this.PAttackCost.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.PAttackCost.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PAttackCost.Location = new System.Drawing.Point(117, 184);
            this.PAttackCost.Name = "PAttackCost";
            this.PAttackCost.Size = new System.Drawing.Size(58, 28);
            this.PAttackCost.TabIndex = 11;
            this.PAttackCost.Text = "Cost:";
            // 
            // PSpeedCost
            // 
            this.PSpeedCost.AutoSize = true;
            this.PSpeedCost.BackColor = System.Drawing.Color.Transparent;
            this.PSpeedCost.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.PSpeedCost.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PSpeedCost.Location = new System.Drawing.Point(117, 259);
            this.PSpeedCost.Name = "PSpeedCost";
            this.PSpeedCost.Size = new System.Drawing.Size(58, 28);
            this.PSpeedCost.TabIndex = 12;
            this.PSpeedCost.Text = "Cost:";
            // 
            // PHealthCost
            // 
            this.PHealthCost.AutoSize = true;
            this.PHealthCost.BackColor = System.Drawing.Color.Transparent;
            this.PHealthCost.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.PHealthCost.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PHealthCost.Location = new System.Drawing.Point(117, 336);
            this.PHealthCost.Name = "PHealthCost";
            this.PHealthCost.Size = new System.Drawing.Size(58, 28);
            this.PHealthCost.TabIndex = 13;
            this.PHealthCost.Text = "Cost:";
            // 
            // VHealthCost
            // 
            this.VHealthCost.AutoSize = true;
            this.VHealthCost.BackColor = System.Drawing.Color.Transparent;
            this.VHealthCost.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.VHealthCost.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.VHealthCost.Location = new System.Drawing.Point(562, 222);
            this.VHealthCost.Name = "VHealthCost";
            this.VHealthCost.Size = new System.Drawing.Size(58, 28);
            this.VHealthCost.TabIndex = 14;
            this.VHealthCost.Text = "Cost:";
            // 
            // VHealCost
            // 
            this.VHealCost.AutoSize = true;
            this.VHealCost.BackColor = System.Drawing.Color.Transparent;
            this.VHealCost.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.VHealCost.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.VHealCost.Location = new System.Drawing.Point(562, 300);
            this.VHealCost.Name = "VHealCost";
            this.VHealCost.Size = new System.Drawing.Size(58, 28);
            this.VHealCost.TabIndex = 15;
            this.VHealCost.Text = "Cost:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(64, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(229, 37);
            this.label8.TabIndex = 16;
            this.label8.Text = "Player Upgrades";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(331, 336);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(128, 43);
            this.button6.TabIndex = 17;
            this.button6.Text = "Start Wave";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.startWave_Click);
            // 
            // wallet
            // 
            this.wallet.AutoSize = true;
            this.wallet.BackColor = System.Drawing.Color.Transparent;
            this.wallet.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.wallet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.wallet.Location = new System.Drawing.Point(575, 25);
            this.wallet.Name = "wallet";
            this.wallet.Size = new System.Drawing.Size(85, 30);
            this.wallet.TabIndex = 18;
            this.wallet.Text = "Wallet:";
            // 
            // FrmShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::TowerDefense_TheRPG.Properties.Resources.Shopfront;
            this.ClientSize = new System.Drawing.Size(800, 404);
            this.Controls.Add(this.wallet);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.VHealCost);
            this.Controls.Add(this.VHealthCost);
            this.Controls.Add(this.PHealthCost);
            this.Controls.Add(this.PSpeedCost);
            this.Controls.Add(this.PAttackCost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Vfullheal);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.Vhealthup);
            this.Controls.Add(this.Pspeedup);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Pattackup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Phealthup);
            this.Name = "FrmShop";
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Phealthup;
        private Label label1;
        private Button Pattackup;
        private LinkLabel linkLabel1;
        private Button Pspeedup;
        private Label label3;
        private Button Vfullheal;
        private LinkLabel linkLabel2;
        private Button Vhealthup;
        private Label PAttackCost;
        private Label PSpeedCost;
        private Label PHealthCost;
        private Label VHealthCost;
        private Label VHealCost;
        private Label label8;
        private Button button6;
        private Label wallet;
    }
}