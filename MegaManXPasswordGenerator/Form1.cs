using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MegaManXPasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            cbBossAA.Checked = false;
            cbBossBK.Checked = false;
            cbBossCP.Checked = false;
            cbBossFM.Checked = false;
            cbBossLO.Checked = false;
            cbBossSC.Checked = false;
            cbBossSE.Checked = false;
            cbBossSM.Checked = false;

            cbHeartAA.Checked = false;
            cbHeartBK.Checked = false;
            cbHeartCP.Checked = false;
            cbHeartFM.Checked = false;
            cbHeartLO.Checked = false;
            cbHeartSC.Checked = false;
            cbHeartSE.Checked = false;
            cbHeartSM.Checked = false;

            cbSubAA.Checked = false;
            cbSubFM.Checked = false;
            cbSubSE.Checked = false;
            cbSubSM.Checked = false;

            cbUpgradeArmor.Checked = false;
            cbUpgradeBoots.Checked = false;
            cbUpgradeHelmet.Checked = false;
            cbUpgradeXBuster.Checked = false;

            txtPassword.Text = String.Empty;
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            PasswordCriteria pc = new PasswordCriteria();

            pc.BossAADefeated = cbBossAA.Checked;
            pc.BossBKDefeated = cbBossBK.Checked;
            pc.BossCPDefeated = cbBossCP.Checked;
            pc.BossFMDefeated = cbBossFM.Checked;
            pc.BossLODefeated = cbBossLO.Checked;
            pc.BossSCDefeated = cbBossSC.Checked;
            pc.BossSEDefeated = cbBossSE.Checked;
            pc.BossSMDefeated = cbBossSM.Checked;

            pc.HeartTankAAAcquired = cbHeartAA.Checked;
            pc.HeartTankBKAcquired = cbHeartBK.Checked;
            pc.HeartTankCPAcquired = cbHeartCP.Checked;
            pc.HeartTankFMAcquired = cbHeartFM.Checked;
            pc.HeartTankLOAcquired = cbHeartLO.Checked;
            pc.HeartTankSCAcquired = cbHeartSC.Checked;
            pc.HeartTankSEAcquired = cbHeartSE.Checked;
            pc.HeartTankSMAcquired = cbHeartSM.Checked;

            pc.SubTankAAAcquired = cbSubAA.Checked;
            pc.SubTankFMAcquired = cbSubFM.Checked;
            pc.SubTankSEAcquired = cbSubSE.Checked;
            pc.SubTankSMAcquired = cbSubSM.Checked;

            pc.UpgradeArmorAcquired = cbUpgradeArmor.Checked;
            pc.UpgradeBootsAcquired = cbUpgradeBoots.Checked;
            pc.UpgradeHelmetAcquired = cbUpgradeHelmet.Checked;
            pc.UpgradeXBusterAcquired = cbUpgradeXBuster.Checked;

            txtPassword.Text = String.Empty;
            txtPassword.Text = PasswordCriteria.GeneratePassword(pc);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About.SingleAboutForm.Show();
            About.SingleAboutForm.BringToFront();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}