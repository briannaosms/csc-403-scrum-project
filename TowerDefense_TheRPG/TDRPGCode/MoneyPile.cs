using System.Xml.Linq;

namespace TowerDefense_TheRPG.code
{
    /// <summary>
    /// Money that will be dropped by enemies
    /// </summary>
	public class MoneyPile
    {
        /// <summary>
        /// Current X position of money pile
        /// </summary>
        public int X { get; private set; }

        /// <summary>
        /// Current Y position of money pile
        /// </summary>
        public int Y { get; private set; }

        /// <summary>
        /// Current value of the money pile
        /// </summary>
        public int Value { get; private set; }

        /// <summary>
        /// Visual representation of money pile as a picture box
        /// </summary>
        public Control ControlCharacter { get; private set; }


        public MoneyPile(int x, int y, int value)
        {
            X = x;
            Y = y;
            Value = value;
            ControlCharacter = new PictureBox()
            {
                BackgroundImage = ControlManager.ResMan.GetObject("Money") as Bitmap,
                BackgroundImageLayout = ImageLayout.Stretch,
                Width = 30,
                Height = 30,
                BackColor = Color.Transparent
            };
            ControlManager.Form.Controls.Add(ControlCharacter);
        }

        /// <summary>
        /// Determines if the arrow collided with a <see cref="Character">character</see> object
        /// </summary>
        /// <param name="chr">The <see cref="Character">character</see> object to check collision with</param>
        /// <returns>True if collided, false otherwise</returns>
        public bool DidCollide(Character chr)
        {
            return ControlCharacter.Bounds.IntersectsWith(chr.ControlContainer.Bounds);
        }

        public void SetValue(int value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Show this pile to the screen
        /// </summary>
        public void Show()
        {
            ControlCharacter.Visible = true;
        }

        /// <summary>
        /// Hide this pile from the screen./>
        /// </summary>
        public void Hide()
        {
            ControlCharacter.Visible = false;
        }
    }
}