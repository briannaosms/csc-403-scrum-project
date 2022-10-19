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
    public float Health { get; private set; }
    public float MoveSpeed { get; private set; }
  }
  public class WeaponStats : Stats {

  }
}
