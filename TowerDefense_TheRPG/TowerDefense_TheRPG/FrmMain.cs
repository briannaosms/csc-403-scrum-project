using TDRPGCode;
using System.Diagnostics;
using TowerDefense_TheRPG.code;
using TowerDefense_TheRPG.Properties;
using System;

namespace TowerDefense_TheRPG {
    public partial class FrmMain : Form {
        #region Fields
        private Player player;
        private Village village;
        private Wave wave = new Wave(50, 3);
        private List<Arrow> arrows;
        private Weapon weapon;
        private string storyLine;
        private int curStoryLineIndex;
        private Random rand;
        #endregion

        #region Methods
        #region Ctor
        public FrmMain() {
            InitializeComponent();
            FormManager.PushToFormStack(this);
            DoubleBuffered = true;
            ControlManager.ResMan = Resources.ResourceManager;
            ControlManager.Form = this;
            rand = new Random();
        }
        #endregion

        #region Event functions
        // timers
        // wave logic
        private void tmrTextCrawl_Tick(object sender, EventArgs e) {
            if (curStoryLineIndex < storyLine.Length) {
            lblStoryLine.Text += storyLine[curStoryLineIndex++];
            lblStoryLine.Refresh();
            }
            else {
            tmrTextCrawl.Enabled = false;
            }
        }
        private void tmrSpawnEnemies_Tick(object sender, EventArgs e) {
            // If spawn conditions are met, then spawn new wave and update UI.
            if(wave.IsSpawnConditionMet()) {
                waveInstruction.Visible = false;
                wave.SpawnNewWave(Height, Width);
                waveCounter.Text = "Wave: " + wave.GetWaveNumber();
                tmrSpawnEnemies.Enabled = false;
            }
        }

        private void SwingSword(object sender, EventArgs e)
        {

        }

        private void tmrMoveEnemies_Tick(object sender, EventArgs e) {
            MoveEnemies();
        }
        private void tmrSpawnArrows_Tick(object sender, EventArgs e) {
            FireArrows();
        }
        private void tmrMoveArrows_Tick(object sender, EventArgs e) {
            MoveArrows();
        }

        // form
        private void Form1_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Space && wave.enemies.Count == 0) {
                tmrSpawnEnemies.Enabled = true;
                wave.EnableNextWaveSpawning();
            }
            else {
                PlayerMove(e.KeyCode);
            }  
        }

        // buttons
        private void btnStart_Click(object sender, EventArgs e) {
            BackgroundImage = null;
            btnStart.Visible = false;
            btnStart.Enabled = false;
            btnStoryLine.Visible = false;
            btnStart.Enabled = false;
            OptionsBtn.Visible = false;
            OptionsBtn.Enabled = false;
            lblStoryLine.Visible = false;
            waveCounter.Show();
            arrows = new List<Arrow>();
            weapon = new Weapon();

            // defualting a player to be a knight for right now. selection menu will be made later.
            player = new ClassKnight(Width / 2, Height / 2 + 100);
            village = new Village(Width / 2 - 80, Height / 2 - 50);
            village.ControlContainer.SendToBack();
            tmrMoveEnemies.Enabled = true;
            tmrMoveArrows.Enabled = true;
            tmrTextCrawl.Enabled = false;
            wave.SetGameActive(true);

            // TODO: setting the background image here causes visual defects as enemies and player move
            //       around the screen. Consider either fixing these defects or setting BackgroundImage to null
            BackgroundImage = Resources.ground;

            // important, keep this call to Focus()!
            // otherwise, for whatever reason, the start button retains focus (even when enabled = false)
            // and arrow key presses are ignored and won't move player.
            Focus();
        }
        private void btnStoryLine_Click(object sender, EventArgs e) {
            if (btnStoryLine.Text.StartsWith("Show")) {
            Storyline();
            BackgroundImage = null;
            OptionsBtn.Visible = false;
            btnStart.Visible = false;
            btnStoryLine.Text = "Hide Storyline";
            lblStoryLine.Visible = true;

            tmrSpawnEnemies.Enabled = false;
            tmrMoveEnemies.Enabled = false;
            tmrMoveArrows.Enabled = false;
            tmrTextCrawl.Enabled = true;
            }
            else {
            BackgroundImage = Resources.title;
            btnStart.Visible = true;
            OptionsBtn.Visible = true;
            btnStoryLine.Text = "Show Storyline";
            lblStoryLine.Visible = false;

            tmrTextCrawl.Enabled = false;
            }
        }
        #endregion

        #region Helper functions
        private void Storyline() {
            // TODO: probably should be read from a resource text file
            storyLine = "Ok, you want a story line, here it is. Once upon a time, there was this village. ";
            storyLine += "In this village were towers. These were great times where towers could roam around, ";
            storyLine += "free of their nature predator..... the balloon! One day, dark clouds appeared in the sky. ";
            storyLine += "It looked like M Night Shamaleon was creating another movie. Then, something strange happened! ";
            storyLine += "Evil balloons started entering the village. 1 balloon, then 2 balloons, then several more. The towers became afraid. ";
            storyLine += "As everyone knows, if a balloon hits a tower and pops, the tower loses health (and it hurts the tower's feelings). ";
            storyLine += "Well, one of the towers was having none of this and decided to take action! Wearing the only balloon proof vest in the entire town, ";
            storyLine += "Peaches the tower stood guard against the balloons. ";
            storyLine += "Your role in this game is to play as Peaches and defeat the evil balloons thereby defending the village (and the towers within).";
            lblStoryLine.Text = "";
            tmrTextCrawl.Enabled = true;
            curStoryLineIndex = 0;
        }

        private void MoveEnemies()
        {
            foreach (var enemy in wave.enemies)
            {

                if (enemy.CurHealth <= 0)
                {
                    continue;
                }
                int xDir = 0;
                int yDir = 0;
                if (enemy.ControlContainer.Left < Width / 2)
                {
                    xDir = 1;
                }
                else
                {
                    xDir = -1;
                }
                if (enemy.ControlContainer.Top < Height / 2)
                {
                    yDir = 1;
                }
                else
                {
                    yDir = -1;
                }
                enemy.Move(xDir, yDir);
                if (enemy.DidCollide(player))
                {
                    enemy.TakeDamageFrom(player);
                    if (enemy.CurHealth <= 0)
                    {
                        enemy.Hide();
                        int levelBefore = player.Level;
                        player.GainXP(enemy.XPGiven);
                        player.Money += enemy.MoneyGiven;
                        int levelAfter = player.Level;
                        if (levelBefore == 1 && levelAfter == 2)
                        {
                            tmrSpawnArrows.Enabled = true;
                            tmrMoveArrows.Enabled = true;
                            FireArrows();
                        }
                        else if (levelBefore == 2 && levelAfter == 3)
                        {
                            tmrSpawnArrows.Interval = 2500;
                            tmrSpawnArrows.Enabled = true;
                            FireArrows();
                        }
                        
                    }
                    else
                    {
                        enemy.KnockBack();
                    }
                }
                else if (enemy.DidCollide(village))
                {
                    village.TakeDamageFrom(enemy);

                    if (village.CurHealth <= 0)
                    {
                        village.Hide(); // defeated
                        wave.SetGameActive(false);
                        Form frmGO = new FrmGameOver();
                        frmGO.Show();
                        this.Hide();
                        FormManager.PushToFormStack(frmGO);

                        // disable timers
                        tmrMoveArrows.Enabled = false;
                        tmrMoveEnemies.Enabled = false;
                        tmrSpawnArrows.Enabled = false;

                        tmrSpawnEnemies.Enabled = false;
                    }
                    else
                    {
                        enemy.KnockBack();
                    }


                }

            }

            List<Enemy> enemiesToRemove = new List<Enemy>();
            foreach (Enemy enemy in wave.enemies)
            {
                if (enemy.CurHealth <= 0)
                {
                    enemiesToRemove.Add(enemy);
                }
            }

            foreach (Enemy enemy in enemiesToRemove)
            {
                wave.enemies.Remove(enemy);
                //Opens a shop when no more enemies are alive
                if (wave.enemies.Count == 0)
                {
                    wave.SetGameActive(false);
                    Form frmShop = new FrmShop(village, player, this);
                    frmShop.Show();
                    this.Hide();
                    FormManager.PushToFormStack(frmShop);

                    // disable timers
                    tmrMoveArrows.Enabled = false;
                    tmrMoveEnemies.Enabled = false;
                    tmrSpawnArrows.Enabled = false;

                    tmrSpawnEnemies.Enabled = false;


                }
            }
            

        }

        public void StartWave()
        {
            wave.SetGameActive(true);
            this.Show();
            FormManager.PushToFormStack(this);
            tmrSpawnEnemies.Enabled = true;
            wave.EnableNextWaveSpawning();
            tmrMoveArrows.Enabled = true;
            tmrMoveEnemies.Enabled = true;
            tmrSpawnArrows.Enabled = true;

        }

        private void MoveArrows() {
            List<Arrow> arrowsToRemove = new List<Arrow>();
            foreach (Arrow arrow in arrows) {
            arrow.Move();
            foreach (Enemy enemy in wave.enemies) {
                if (arrow.DidCollide(enemy)) {
                enemy.TakeDamage(0.1f);
                if (enemy.CurHealth <= 0) {
                    enemy.Hide();
                    player.GainXP(enemy.XPGiven);
                }
                else {
                    enemy.KnockBack();
                }
                arrowsToRemove.Add(arrow);
                }
            }
            }
            foreach (Arrow arrow in arrowsToRemove) {
            arrows.Remove(arrow);
            Controls.Remove(arrow.ControlCharacter);
            }
        }

        private void MoveSword()
        {

            foreach (Enemy enemy in wave.enemies)
            {
                if (weapon.DidCollide(enemy))
                {
                    enemy.TakeDamage(0.1f);
                    if (enemy.CurHealth <= 0)
                    {
                        enemy.Hide();
                        player.GainXP(enemy.XPGiven);
                    }
                    else
                    {
                        enemy.KnockBack();
                    }
                }
            }
        }

        private void FireArrows() {
            Arrow arrowLeft = new Arrow(player.X, player.Y, -1, 0);
            Arrow arrowRight = new Arrow(player.X, player.Y, +1, 0);
            arrows.Add(arrowLeft);
            arrows.Add(arrowRight);
            arrowLeft.ControlCharacter.BringToFront();
            arrowRight.ControlCharacter.BringToFront();
        }

        private void PlayerMove(Keys keyCode) {
            switch (keyCode) {
            case Keys.Up:
            case Keys.W:
                player.Move(0, -1);
                break;
            case Keys.Down:
            case Keys.S:
                player.Move(0, +1);
                break;
            case Keys.Left:
            case Keys.A:
                player.Move(-1, 0);
                break;
            case Keys.Right:
            case Keys.D:
                player.Move(+1, 0);
                break;
            }
        }
        #endregion

        #endregion

        private void OptionsBtn_Click(object sender, EventArgs e)
        {
           if (OptionsBtn.Text.StartsWith("Options"))
            {
                OptionsBtn.Text = "Return to Main Menu";
                btnStart.Visible = false;
                btnStart.Enabled = false;
                VolumeUpBtn.Visible= true;
                VolumeUpBtn.Enabled = true;
                VolumeDownBtn.Visible= true;
                VolumeUpBtn.Enabled = true;
                Vol1.Visible= true;
                Vol2.Visible= true;
                Vol3.Visible= true;
                Vol4.Visible= true;
                Vol5.Visible= true;
                FullScreen.Visible= true;
                FullScreen.Enabled= true;
                WindowedBtn.Visible= true;
                WindowedBtn.Enabled= true;
                VolName.Visible= true;
                btnStoryLine.Visible = false;
                tmrSpawnEnemies.Enabled = false;
                tmrMoveEnemies.Enabled = false;
                tmrMoveArrows.Enabled = false;
                tmrTextCrawl.Enabled = false;

            }
            else
            {
                OptionsBtn.Text = "Options";
                VolumeUpBtn.Visible = false;
                VolumeUpBtn.Enabled = false;
                VolumeDownBtn.Visible = false;
                VolumeDownBtn.Enabled = false; 
                Vol1.Visible = false;
                Vol2.Visible = false;
                Vol3.Visible = false;
                Vol4.Visible = false;
                Vol5.Visible = false;
                FullScreen.Visible = false;
                FullScreen.Enabled = false;
                WindowedBtn.Visible = false;
                WindowedBtn.Enabled = false;
                VolName.Visible = false;
                btnStart.Visible = true;
                btnStart.Enabled = true;
                btnStoryLine.Visible = true;
            }
        }
        private void VolUp_Click(object sender, EventArgs e)
        {
            if (Vol1.BackColor == Color.Gray)
            {
                Vol1.BackColor = Color.Blue;
            }
            else if (Vol2.BackColor == Color.Gray)
            {
                Vol2.BackColor = Color.Blue;
            }
            else if (Vol3.BackColor == Color.Gray)
            {
                Vol3.BackColor = Color.Blue;
            }
            else if (Vol4.BackColor == Color.Gray)
            {
                Vol4.BackColor = Color.Blue;
            }
            else if (Vol5.BackColor == Color.Gray)
            {
                Vol5.BackColor = Color.Blue;
            }

        }
        private void VolDown_Click(object sender, EventArgs e)
        {

            if (Vol5.BackColor == Color.Blue)
            {
                Vol5.BackColor = Color.Gray;
            }
            else if (Vol4.BackColor == Color.Blue)
            {
                Vol4.BackColor = Color.Gray;
            }
            else if (Vol3.BackColor == Color.Blue)
            {
                Vol3.BackColor = Color.Gray;
            }
            else if (Vol2.BackColor == Color.Blue)
            {
                Vol2.BackColor = Color.Gray;
            }
            else if (Vol1.BackColor == Color.Blue)
            {
                Vol1.BackColor = Color.Gray;
            }
        }
        private void FullScreen_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;


        }

        private void WindowedBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            FormBorderStyle = FormBorderStyle.Sizable;
        }
    }
}
