using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense_TheRPG.code {
  public class Stats {
    public float Attack { get; protected set; }
    public float Defense { get; protected set; }
  }

  public class PlayerStats : Stats {
    public float Health { get; set; }
    public int MoveSpeed { get; set; }

    public PlayerStats() {
      Health = 1.0f;
      MoveSpeed = 8;
    }
  }
  
  public class WeaponStats : Stats {

  }
}
