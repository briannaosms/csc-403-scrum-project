namespace TowerDefense_TheRPG.code {
    /// <summary>
    /// Could be used to describe a weapon, but
    /// as is the case right now, this is unused
    /// </summary>
    public class Weapon {

        public Control ControlWeapon { get; private set; }

        public Weapon(string className )
        {
            if (className.Equals("knight"))
            {
                ControlWeapon = new PictureBox()
                {
                    BackgroundImage = ControlManager.ResMan.GetObject("sword.png") as Bitmap,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Width = 20,
                    Height = 20,
                    BackColor = Color.Transparent,
                };
                ControlManager.Form.Controls.Add(ControlWeapon);
            }
            else
            {
                ControlWeapon = new PictureBox()
                {
                    BackgroundImage = ControlManager.ResMan.GetObject("fireball.png") as Bitmap,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Width = 20,
                    Height = 20,
                    BackColor = Color.Transparent,
                };
                ControlManager.Form.Controls.Add(ControlWeapon);
            }


        }

        public bool DidCollide(Character chr)
        {
            return ControlWeapon.Bounds.IntersectsWith(chr.ControlContainer.Bounds);
        }

        public void Move(float x, float y)
        {

        }

        public void Show()
        {

        }

        public void Hide()
        {

        }
    }
}
