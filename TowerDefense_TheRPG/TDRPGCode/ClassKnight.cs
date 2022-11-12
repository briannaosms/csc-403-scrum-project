
using System;

namespace TowerDefense_TheRPG.code {
    public class ClassKnight : Player {

        public Weapon wepaon;

        public ClassKnight(int x, int y, Weapon weapon) : base(x, y) {

            weapon = new Weapon("knight");

        }

        public override void DoAttack(float x, float y, Weapon weapon)
        {
            if (x >= 0 && x > Math.Abs(y)) //right
            {
                weapon.Move(1, 0);
            }
            else if (x < 0 && x < -(y)) //left
            {
                weapon.Move(-1, 0);
            }
            else if (y >= 0 && y > Math.Abs(x)) //up
            {
                weapon.Move(0, 1);
            }
            else //down
            {
                weapon.Move(0, -1);
            }
        }

        public override void AbilityAOE() {

        }

        public override void AbilityKnockback() {

        }

        public override void AbilityMultishot() {

        }
    }
}
