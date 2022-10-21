using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense_TheRPG.code {
  public class Player : Character {
    public float Health { get; private set; }
    public PlayerStats Stats { get; private set; } 
    public int Money { get; private set; }
    
    public Player(Control control) : base(control) {
      Health = 1.0f;
      Stats = new PlayerStats();
      Stats.MoveSpeed = 13;
      Money = 0;
    }

    public override void Move(int x, int y) {
      base.Move(x * Stats.MoveSpeed, y * Stats.MoveSpeed);
    }
  }
}
