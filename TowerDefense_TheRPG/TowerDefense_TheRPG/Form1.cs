using TowerDefense_TheRPG.code;
using TowerDefense_TheRPG.Properties;

namespace TowerDefense_TheRPG {
  public partial class Form1 : Form {
    private Player player;
    private List<Enemy> enemies;
    private string storyLine;
    private int curStoryLineIndex;
    private Random rand;

    public Form1() {
      InitializeComponent();
      rand = new Random();
      enemies = new List<Enemy>();
    }

    private Control MakeEnemyControl() {
      int enterDir = rand.Next(4);
      int top = 0;
      int left = 0;
      int offscreen = 50;
      switch (enterDir) {
        case 0: // left
          top = rand.Next(0, Height);
          left = -offscreen;
          break;
        case 1: // bottom
          left = rand.Next(0, Width);
          top = Height + offscreen;
          break;
        case 2: // right
          top = rand.Next(0, Height);
          left = Width + offscreen;
          break;
        case 3: // top
          left = rand.Next(0, Width);
          top = -offscreen;
          break;
      }
      var p = new PictureBox() {
        BackgroundImage = Resources.balloon,
        BackgroundImageLayout = ImageLayout.Stretch,
        Top = top,
        Left = left,
        Width = 50,
        Height = 50,
      };
      Controls.Add(p);
      return p;
    }

    private Control MakePlayerControl() {
      var p = new PictureBox() {
        BackgroundImage = Resources.player,
        BackgroundImageLayout = ImageLayout.Stretch,
        Top = Height / 2,
        Left = Width / 2,
        Width = 50,
        Height = 150,
      };
      p.BringToFront();
      Controls.Add(p);
      return p;
    }

    private void MoveEnemies() {
      foreach (var enemy in enemies) {
        int xDir = 0;
        int yDir = 0;
        if (enemy.Control.Left < Width / 2) {
          xDir = 1;
        }
        else {
          xDir = -1;
        }
        if (enemy.Control.Top < Height / 2) {
          yDir = 1;
        }
        else {
          yDir = -1;
        }
        enemy.Move(xDir, yDir);
        if (enemy.Control.Bounds.IntersectsWith(player.Control.Bounds)) {
          enemy.Hide();
        }
      }
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

    private void Form1_Load(object sender, EventArgs e) {
      btnStart.Visible = false;
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

    private void tmrTextCrawl_Tick(object sender, EventArgs e) {
      if (curStoryLineIndex < storyLine.Length) {
        lblStoryLine.Text += storyLine[curStoryLineIndex++];
        lblStoryLine.Refresh();
      }
      else {
        tmrTextCrawl.Enabled = false;
        btnStart.Visible = true;
      }
    }

    private void btnStart_Click(object sender, EventArgs e) {
      btnStart.Visible = false;
      btnStart.Enabled = false;
      lblStoryLine.Visible = false;

      player = new Player(MakePlayerControl());
      picVillage.SendToBack();
      tmrSpawnEnemies.Enabled = true;
      Focus();
    }

    private void tmrSpawnEnemies_Tick(object sender, EventArgs e) {
      enemies.Add(new Enemy(MakeEnemyControl()));
    }

    private void tmrMoveEnemies_Tick(object sender, EventArgs e) {
      MoveEnemies();
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e) {
      PlayerMove(e.KeyCode);
    }
  }
}
