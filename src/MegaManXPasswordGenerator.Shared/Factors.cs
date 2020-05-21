namespace MegaManXPasswordGenerator.Shared
{
    public enum Factor : int
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
}
