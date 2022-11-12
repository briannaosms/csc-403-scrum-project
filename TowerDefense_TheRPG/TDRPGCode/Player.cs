namespace TowerDefense_TheRPG.code {
    /// <summary>
    /// Class for our player
    /// </summary>
    public abstract class Player : Character {
        /// <summary>
        /// Amount of money the player has. Currently this is not being
        /// used but you could add this as a feature.
        /// </summary>
        public int Money { get; set; }

        /// <summary>
        /// Current amount of experience. You gain experience by defeating
        /// <see cref="Enemy"/> objects (e.g. balloons)
        /// </summary>
        public int XP { get; private set; }

        /// <summary>
        /// Current level player has
        /// </summary>
        public int Level { get; private set; }

        /// <summary>
        /// If this is set to true, player will automatically shoot arrows
        /// every so often (the time interval is set as the Interval property
        /// of the tmrSpawnArrows object in FrmMain)
        /// </summary>
        public bool AutoShoot { get; private set; }

        public int shopAttackCounter { get; set; }

        public int shopHealthCounter { get; set; }  

        public int shopSpeedCounter { get; set; }

        /// <summary>
        /// Explicit constructor
        /// </summary>
        /// <param name="x">Initial x position of player</param>
        /// <param name="y">Initial y position of player</param>
        public Player(int x, int y) : base("player", x, y, 50, 100) {
            SetMaxHealth(1.0f);
            Money = 100;
            Attack = 0.15f;
            MoveSpeed = 15;
            Level = 1;
            XP = 0;
            shopAttackCounter = 1;
            shopHealthCounter = 1;
            shopSpeedCounter = 1;
            ChangeCharacterPic("playerL" + Level);
        }

        /// <summary>
        /// Call this function whenever the player defeats an <see cref="Enemy"/>
        /// </summary>
        /// <param name="xpGained">How much experience the player should gain. 
        ///                        Use <see cref="Enemy.XPGiven"/> for this</param>
        public void GainXP(int xpGained) {
            XP += xpGained;
            if (XP > 10 && Level == 1) {
                GainLevel();
            }
            else if (XP > 30 && Level == 2) {
                GainLevel();
            }
        }

        /// <summary>
        /// Internal function that is automatically called when 
        /// player gains a level (called from GainXP method)
        /// </summary>
        private void GainLevel() {
            Level++;
            Attack *= 1.5f;
            ChangeCharacterPic("playerL" + Level);
            if (Level >= 2) {
                AutoShoot = true;
            }
        }

        public abstract void DoAttack(float x, float y, Weapon weapon);

        public abstract void AbilityAOE();

        public abstract void AbilityMultishot();

        public abstract void AbilityKnockback();

        #region Shop Methods
        
        public void ShopAttackUp()
        {
            if (shopAttackCounter < 6)
            {
                float attackIncrement = 5;
                Attack += attackIncrement;
                shopAttackCounter++;
            }
        }
        public void ShopHealthUp()
        {
            if (shopHealthCounter < 6)
            {
                float healthIncrement = 5;
                float tempHealth = MaxHealth;
                SetMaxHealth(tempHealth + healthIncrement);
                shopHealthCounter++;
            }
        }
        public void ShopSpeedUp()
        {
            if (shopSpeedCounter < 6)
            {
                int speedIncrement = 10;
                MoveSpeed += speedIncrement;
                shopSpeedCounter++;
            }
        }
        public void FullHeal()
        {
            SetMaxHealth(MaxHealth);
        }

        public void buyUpgrade(int price)
        {
            Money -= price;
        }

        public int getPrice(int counter)
        {
            int baseUpgradeCost = 100;
            int price = baseUpgradeCost * counter;
            return price;
        }
        
        #endregion


    }




}
