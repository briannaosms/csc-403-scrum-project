using TowerDefense_TheRPG.code;
using TowerDefense_TheRPG.Properties;

namespace TowerDefense_TheRPG {
  public partial class Form1 : Form {
    PictureBox picPlayer;

    public Form1() {
      PlayerStats ps = new PlayerStats();
      InitializeComponent();
    }

    private void picPlayer_Click(object sender, EventArgs e) {
      picPlayer.Visible = false;
    }

    private void tmrMoveTower_Tick(object sender, EventArgs e) {
      picPlayer.Left++;
      if (picPlayer.Left > 100) {
        picPlayer.Visible = true;
      }
    }

    private void Form1_Load(object sender, EventArgs e) {
      picPlayer = new PictureBox() {
        BackgroundImage = Resources.tower2,
        BackgroundImageLayout = ImageLayout.Stretch,
        Top = 0,
        Left = 0
      };
      this.Controls.Add(picPlayer);
    }
  }
}
