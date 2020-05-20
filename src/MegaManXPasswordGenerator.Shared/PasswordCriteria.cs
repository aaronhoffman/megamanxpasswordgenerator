using System;
using System.Collections.Generic;
using System.Text;

namespace MegaManXPasswordGenerator.Shared
{
    public class PasswordCriteria
    {
        public bool BossAADefeated { get; set; }
        public bool BossBKDefeated { get; set; }
        public bool BossCPDefeated { get; set; }
        public bool BossFMDefeated { get; set; }
        public bool BossLODefeated { get; set; }
        public bool BossSCDefeated { get; set; }
        public bool BossSEDefeated { get; set; }
        public bool BossSMDefeated { get; set; }

        public bool HeartTankAAAcquired { get; set; }
        public bool HeartTankBKAcquired { get; set; }
        public bool HeartTankCPAcquired { get; set; }
        public bool HeartTankFMAcquired { get; set; }
        public bool HeartTankLOAcquired { get; set; }
        public bool HeartTankSCAcquired { get; set; }
        public bool HeartTankSEAcquired { get; set; }
        public bool HeartTankSMAcquired { get; set; }

        public bool SubTankAAAcquired { get; set; }
        public bool SubTankFMAcquired { get; set; }
        public bool SubTankSEAcquired { get; set; }
        public bool SubTankSMAcquired { get; set; }

        public bool UpgradeArmorAcquired { get; set; }
        public bool UpgradeBootsAcquired { get; set; }
        public bool UpgradeHelmetAcquired { get; set; }
        public bool UpgradeXBusterAcquired { get; set; }
    }
}
