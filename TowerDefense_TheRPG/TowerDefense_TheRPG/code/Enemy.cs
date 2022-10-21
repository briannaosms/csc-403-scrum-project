using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense_TheRPG.code {
  public class Enemy : Character {
    public PlayerStats Stats { get; private set; }

    public Enemy(Control control) : base(control) {
      Stats = new PlayerStats();
      Stats.MoveSpeed = 3;
    }

    public override void Move(int x, int y) {
      base.Move(x * Stats.MoveSpeed, y * Stats.MoveSpeed);
    }
  }
}
