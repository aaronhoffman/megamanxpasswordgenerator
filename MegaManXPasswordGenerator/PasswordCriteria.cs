using System;
using System.Collections.Generic;
using System.Text;

namespace MegaManXPasswordGenerator
{
    public enum Factors : int
    {
        BossAA = 1,
        BossBK = 2,
        BossCP = 4,
        BossFM = 8,
        BossLO = 16,
        BossSC = 32,
        BossSE = 64,
        BossSM = 128,

        HeartTankAA = 256,
        HeartTankBK = 512,
        HeartTankCP = 1024,
        HeartTankFM = 2048,
        HeartTankLO = 4096,
        HeartTankSC = 8192,
        HeartTankSE = 16384,
        HeartTankSM = 32768,

        SubTankAA = 65536,
        SubTankFM = 131072,
        SubTankSE = 262144,
        SubTankSM = 524288,

        UpgradeArmor = 1048576,
        UpgradeBoots = 2097152,
        UpgradeHelmet = 4194304,
        UpgradeXBuster = 8388608
    }

    /// <summary>
    /// Class that holds all the Password Criteria from the form
    /// </summary>
    class PasswordCriteria
    {
        #region Properties

        //BOSSES
        private bool m_blnBossAADefeated = false;
        public bool BossAADefeated
        {
            get { return m_blnBossAADefeated; }
            set { m_blnBossAADefeated = value; }
        }

        private bool m_blnBossBKDefeated = false;
        public bool BossBKDefeated
        {
            get { return m_blnBossBKDefeated; }
            set { m_blnBossBKDefeated = value; }
        }

        private bool m_blnBossCPDefeated = false;
        public bool BossCPDefeated
        {
            get { return m_blnBossCPDefeated; }
            set { m_blnBossCPDefeated = value; }
        }

        private bool m_blnBossFMDefeated = false;
        public bool BossFMDefeated
        {
            get { return m_blnBossFMDefeated; }
            set { m_blnBossFMDefeated = value; }
        }

        private bool m_blnBossLODefeated = false;
        public bool BossLODefeated
        {
            get { return m_blnBossLODefeated; }
            set { m_blnBossLODefeated = value; }
        }

        private bool m_blnBossSCDefeated = false;
        public bool BossSCDefeated
        {
            get { return m_blnBossSCDefeated; }
            set { m_blnBossSCDefeated = value; }
        }

        private bool m_blnBossSEDefeated = false;
        public bool BossSEDefeated
        {
            get { return m_blnBossSEDefeated; }
            set { m_blnBossSEDefeated = value; }
        }

        private bool m_blnBossSMDefeated = false;
        public bool BossSMDefeated
        {
            get { return m_blnBossSMDefeated; }
            set { m_blnBossSMDefeated = value; }
        }


        //HEART TANKS
        private bool m_blnHeartTankAAAcquired = false;
        public bool HeartTankAAAcquired
        {
            get { return m_blnHeartTankAAAcquired; }
            set { m_blnHeartTankAAAcquired = value; }
        }

        private bool m_blnHeartTankBKAcquired = false;
        public bool HeartTankBKAcquired
        {
            get { return m_blnHeartTankBKAcquired; }
            set { m_blnHeartTankBKAcquired = value; }
        }

        private bool m_blnHeartTankCPAcquired = false;
        public bool HeartTankCPAcquired
        {
            get { return m_blnHeartTankCPAcquired; }
            set { m_blnHeartTankCPAcquired = value; }
        }

        private bool m_blnHeartTankFMAcquired = false;
        public bool HeartTankFMAcquired
        {
            get { return m_blnHeartTankFMAcquired; }
            set { m_blnHeartTankFMAcquired = value; }
        }

        private bool m_blnHeartTankLOAcquired = false;
        public bool HeartTankLOAcquired
        {
            get { return m_blnHeartTankLOAcquired; }
            set { m_blnHeartTankLOAcquired = value; }
        }

        private bool m_blnHeartTankSCAcquired = false;
        public bool HeartTankSCAcquired
        {
            get { return m_blnHeartTankSCAcquired; }
            set { m_blnHeartTankSCAcquired = value; }
        }

        private bool m_blnHeartTankSEAcquired = false;
        public bool HeartTankSEAcquired
        {
            get { return m_blnHeartTankSEAcquired; }
            set { m_blnHeartTankSEAcquired = value; }
        }

        private bool m_blnHeartTankSMAcquired = false;
        public bool HeartTankSMAcquired
        {
            get { return m_blnHeartTankSMAcquired; }
            set { m_blnHeartTankSMAcquired = value; }
        }


        //SUB-TANKS
        private bool m_blnSubTankAAAcquired = false;
        public bool SubTankAAAcquired
        {
            get { return m_blnSubTankAAAcquired; }
            set { m_blnSubTankAAAcquired = value; }
        }

        private bool m_blnSubTankFMAcquired = false;
        public bool SubTankFMAcquired
        {
            get { return m_blnSubTankFMAcquired; }
            set { m_blnSubTankFMAcquired = value; }
        }

        private bool m_blnSubTankSEAcquired = false;
        public bool SubTankSEAcquired
        {
            get { return m_blnSubTankSEAcquired; }
            set { m_blnSubTankSEAcquired = value; }
        }

        private bool m_blnSubTankSMAcquired = false;
        public bool SubTankSMAcquired
        {
            get { return m_blnSubTankSMAcquired; }
            set { m_blnSubTankSMAcquired = value; }
        }


        //UPGRADES
        private bool m_blnUpgradeArmorAcquired = false;
        public bool UpgradeArmorAcquired
        {
            get { return m_blnUpgradeArmorAcquired; }
            set { m_blnUpgradeArmorAcquired = value; }
        }

        private bool m_blnUpgradeBootsAcquired = false;
        public bool UpgradeBootsAcquired
        {
            get { return m_blnUpgradeBootsAcquired; }
            set { m_blnUpgradeBootsAcquired = value; }
        }

        private bool m_blnUpgradeHelmetAcquired = false;
        public bool UpgradeHelmetAcquired
        {
            get { return m_blnUpgradeHelmetAcquired; }
            set { m_blnUpgradeHelmetAcquired = value; }
        }

        private bool m_blnUpgradeXBusterAcquired = false;
        public bool UpgradeXBusterAcquired
        {
            get { return m_blnUpgradeXBusterAcquired; }
            set { m_blnUpgradeXBusterAcquired = value; }
        }

        #endregion //Properties

        public PasswordCriteria()
        {

        }

        public bool EvaluateFactor(Factors f)
        {
            switch (f)
            {
                case Factors.BossAA:
                    return BossAADefeated;
                case Factors.BossBK:
                    return BossBKDefeated;
                case Factors.BossCP:
                    return BossCPDefeated;
                case Factors.BossFM:
                    return BossFMDefeated;
                case Factors.BossLO:
                    return BossLODefeated;
                case Factors.BossSC:
                    return BossSCDefeated;
                case Factors.BossSE:
                    return BossSEDefeated;
                case Factors.BossSM:
                    return BossSMDefeated;

                case Factors.HeartTankAA:
                    return HeartTankAAAcquired;
                case Factors.HeartTankBK:
                    return HeartTankBKAcquired;
                case Factors.HeartTankCP:
                    return HeartTankCPAcquired;
                case Factors.HeartTankFM:
                    return HeartTankFMAcquired;
                case Factors.HeartTankLO:
                    return HeartTankLOAcquired;
                case Factors.HeartTankSC:
                    return HeartTankSCAcquired;
                case Factors.HeartTankSE:
                    return HeartTankSEAcquired;
                case Factors.HeartTankSM:
                    return HeartTankSMAcquired;

                case Factors.SubTankAA:
                    return SubTankAAAcquired;
                case Factors.SubTankFM:
                    return SubTankFMAcquired;
                case Factors.SubTankSE:
                    return SubTankSEAcquired;
                case Factors.SubTankSM:
                    return SubTankSMAcquired;

                case Factors.UpgradeArmor:
                    return UpgradeArmorAcquired;
                case Factors.UpgradeBoots:
                    return UpgradeBootsAcquired;
                case Factors.UpgradeHelmet:
                    return UpgradeHelmetAcquired;
                case Factors.UpgradeXBuster:
                    return UpgradeXBusterAcquired;

                default:
                    //throw new Exception("Factor was not handled. ");
                    return false;
            }
        }

        public int CountTrueFactors(params Factors[] factors)
        {
            return CountTrueFactors(new List<Factors>(factors));
        }

        public int CountTrueFactors(IEnumerable<Factors> factors)
        {
            int m_intCountOfTrueFactors = 0;

            foreach (Factors f in factors)
            {
                if (EvaluateFactor(f))
                    m_intCountOfTrueFactors++;
            }

            return m_intCountOfTrueFactors;
        }

        public static string GeneratePassword(PasswordCriteria pc)
        {
            string m_strPassword = String.Empty;

            int[,] m_arrPassword = new int[4, 3];

            for (int i = 0; i <= 3; i++)
                for (int j = 0; j <= 2; j++)
                {
                    m_arrPassword[i, j] = Position.AllPositions.Find(delegate(Position p)
                    {
                        return p.PositionCoordinate.X == i + 1 && p.PositionCoordinate.Y == j + 1;
                    }).GetDigit(pc);
                }

            for (int i = 2; i >= 0; i--)
            {
                for (int j = 0; j <= 3; j++)
                {
                    m_strPassword += m_arrPassword[j, i].ToString() + " ";
                }

                m_strPassword += Environment.NewLine;
            }

            return m_strPassword;
        }
    }
}