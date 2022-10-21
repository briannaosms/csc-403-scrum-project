using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense_TheRPG.code {
  public class Character {
    public Control Control { get; protected set; }

    public Character(Control control) {
      Control = control;
    }

    public virtual void Move(int x, int y) {
      Control.Top += y;
      Control.Left += x;
    }

    public void Show() {
      Control.Visible = true;
    }

    public void Hide() {
      Control.Visible = false;
    }
  }
}
