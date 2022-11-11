using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TDRPGCode;
using TowerDefense_TheRPG.code;

namespace TowerDefense_TheRPG
{
    public partial class FrmShop : Form
    {

        public Player Player { get; set; }

        public Village Village { get; set; }

        public FrmMain Mainform { get; set; }


        public FrmShop(Village village, Player player, FrmMain mainForm)
        {
            InitializeComponent();
            Village = village;
            Player = player;    
            Mainform = mainForm;
            UpdateCost();
        }

        public void UpdateCost()
        {
            PAttackCost.Text = "Cost: ";
            PAttackCost.Text += Player.getPrice(Player.shopAttackCounter);
            PSpeedCost.Text = "Cost: ";
            PSpeedCost.Text += Player.getPrice(Player.shopSpeedCounter);
            PHealthCost.Text = "Cost: ";
            PHealthCost.Text += Player.getPrice(Player.shopHealthCounter);
            VHealthCost.Text = "Cost: ";
            VHealthCost.Text += Player.getPrice(Village.shopHealthCounter);
            VHealCost.Text = "Cost: ";
            VHealCost.Text += Player.getPrice(Village.shopHealCounter);
            wallet.Text = "Wallet: ";
            wallet.Text += Player.Money;
        }

       

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void PattackUp_Click(object sender, EventArgs e)
        {
            if (Player.Money >= Player.getPrice(Player.shopAttackCounter))
            {
                if (Player.shopAttackCounter < 6)
                {
                    Player.buyUpgrade(Player.getPrice(Player.shopAttackCounter));
                    Player.ShopAttackUp();
                    UpdateCost();
                }
            }
        }

        private void PspeedUp_Click(object sender, EventArgs e)
        {
            if (Player.Money >= Player.getPrice(Player.shopSpeedCounter))
            {
                if (Player.shopSpeedCounter < 6)
                {
                    Player.buyUpgrade(Player.getPrice(Player.shopSpeedCounter));
                    Player.ShopSpeedUp();
                    UpdateCost();
                }
            }
            
        }

        private void PhealthUp_Click(object sender, EventArgs e)
        {
            if (Player.Money >= Player.getPrice(Player.shopHealthCounter))
            {
                if (Player.shopHealthCounter < 6)
                {
                    Player.buyUpgrade(Player.getPrice(Player.shopHealthCounter));
                    Player.ShopHealthUp();
                    UpdateCost();
                }
            }
        }

        private void VhealthUp_Click(object sender, EventArgs e)
        {
            if (Player.Money >= Player.getPrice(Village.shopHealthCounter))
            {
                if (Village.shopHealthCounter < 6)
                {
                    Player.buyUpgrade(Player.getPrice(Village.shopHealthCounter));
                    Village.ShopHealthUp();
                    UpdateCost();
                }
            }
        }

        private void VfullHeal_Click(object sender, EventArgs e)
        {
            if (Player.Money >= Player.getPrice(Village.shopHealCounter))
            {
                if (Village.shopHealCounter < 6)
                {
                    Player.buyUpgrade(Player.getPrice(Village.shopHealCounter));
                    Village.ShopHeal();
                    UpdateCost();
                }
            }
        }

        private void startWave_Click(object sender, EventArgs e)
        {
            Player.FullHeal();
            this.Hide();
            Mainform.StartWave();
           
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
