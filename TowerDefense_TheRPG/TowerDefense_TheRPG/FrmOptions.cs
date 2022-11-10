using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TowerDefense_TheRPG.code;

namespace TowerDefense_TheRPG
{
    public partial class FrmOptions : Form
    {
        public FrmOptions()
        {
            InitializeComponent();
        }

        private void VolUp_Click(object sender, EventArgs e)
        {

        }

        private void VolDown_Click(object sender, EventArgs e)
        {

        }

        private void BackToMain_Click(object sender, EventArgs e)
        {
            Form frmGO = new FrmMain();
            frmGO.Show();
            this.Hide();
            FormManager.PushToFormStack(frmGO);
        }
    }
}
