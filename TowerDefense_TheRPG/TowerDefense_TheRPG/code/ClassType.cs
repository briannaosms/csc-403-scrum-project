using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense_TheRPG.code {
  public abstract class ClassType {
    public int XP { get; protected set; }
    public int Level { get; protected set; }
    public WeaponType WeaponType { get; protected set; }

  }
}
