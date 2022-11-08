namespace TowerDefense_TheRPG.code {
    /// <summary>
    /// Represents our village, the thing we are trying to protect
    /// </summary>
    public class Village : Character {

        public int shopHealCounter { get; set; }

        public int shopHealthCounter { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="x">Initial X (aka left) position of village</param>
        /// <param name="y">Initial Y (aka top) position of village</param>
        public Village(int x, int y) : base("village", x, y, 165, 100) {
            SetMaxHealth(5.0f);
        }
        #region Shop Methods
        public void ShopHeal()
        {
            SetMaxHealth(MaxHealth);
            shopHealCounter++;
        }
        public void ShopHealthUp()
        {
            if (shopHealthCounter < 6)
            {
                float healthIncrement = 5f;
                float tempHealth = MaxHealth;
                SetMaxHealth(tempHealth + healthIncrement);
                shopHealthCounter++;
            }
        }
        #endregion
    
    }
}
