using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;

namespace TowerDefense_TheRPG.code {
  public class Player : Character {
    public int Money { get; private set; }
    public int XP { get; private set; }
    public int Level { get; private set; }
    public bool AutoShoot { get; private set; }
    
    public Player(int x, int y) : base("player", x, y, 50, 100) {
      SetMaxHealth(1.0f);
      Money = 0;
      Attack = 0.15f;
      MoveSpeed = 15;
      Level = 1;
      XP = 0;
      ChangeCharacterPic("playerL" + Level);
    }

    public void GainXP(int xpGained) {
      XP += xpGained;
      if (XP > 10 && Level == 1) {
        GainLevel();
      }
      else if (XP > 30 && Level == 2) {
        GainLevel();
      }
    }

    private void GainLevel() {
      Level++;
      Attack *= 1.5f;
      ChangeCharacterPic("playerL" + Level);
      if (Level >= 2) {
        AutoShoot = true;
      }
    }
  }
}
