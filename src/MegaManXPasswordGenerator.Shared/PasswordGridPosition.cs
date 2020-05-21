using System.Collections.Generic;
using System.Drawing;

namespace MegaManXPasswordGenerator.Shared
{
    /// <summary>
    /// Password Grid Position has a driving XFactor and YFactor.
    /// Those Factors combined with the Count of active "MainFactors" (Even or Odd) results in a integer result.
    /// </summary>
    public class PasswordGridPosition
    {
        // todo: this can likely be refactored out, "Point" not needed here
        public Point PositionCoordinate { get; set; } = new Point(0, 0);

        public Factor XFactor { get; set; }
        public Factor YFactor { get; set; }

        public IEnumerable<Factor> MainFactors { get; set; } = new List<Factor>();

        // Neither X Factor nor Y Factor active
        public int DigitNEven { get; set; }
        public int DigitNOdd { get; set; }

        // Only X Factor active
        public int DigitXEven { get; set; }
        public int DigitXOdd { get; set; }

        // Only Y Factor active
        public int DigitYEven { get; set; }
        public int DigitYOdd { get; set; }

        // Both X and Y Factors Active
        public int DigitXYEven { get; set; }
        public int DigitXYOdd { get; set; }
    }

    /// <summary>
    /// Password grid is 3 rows with 4 columns.
    /// Each of these PasswordGridPosition properties represents one of those cells.
    /// </summary>
    public static class PasswordGridPositions
    {
        /// ********************
        /// Row 1
        /// ********************

        /// <summary>
        /// Note: PasswordGridPosition X1Y1 is the top left corner.
        /// </summary>
        public static readonly PasswordGridPosition Position_X1Y1 = new PasswordGridPosition()
        {
            PositionCoordinate = new Point(1, 1),
            DigitNEven = 1,
            DigitNOdd = 8,
            DigitXEven = 4,
            DigitXOdd = 6,
            DigitYEven = 3,
            DigitYOdd = 7,
            DigitXYEven = 2,
            DigitXYOdd = 5,
            XFactor = Factor.HeartTankAA,
            YFactor = Factor.UpgradeBoots,
            MainFactors = new List<Factor>()
            {
                Factor.BossAA,
                Factor.BossBK,
                Factor.HeartTankBK,
                Factor.HeartTankCP,
                Factor.HeartTankFM,
                Factor.HeartTankLO,
                Factor.HeartTankSC,
                Factor.SubTankSM,
                Factor.UpgradeArmor,
            },
        };

        public static readonly PasswordGridPosition Position_X2Y1 = new PasswordGridPosition()
        {
            PositionCoordinate = new Point(2, 1),
            DigitNEven = 8,
            DigitNOdd = 8,
            DigitXEven = 3,
            DigitXOdd = 3,
            DigitYEven = 2,
            DigitYOdd = 2,
            DigitXYEven = 1,
            DigitXYOdd = 1,
            XFactor = Factor.BossSC,
            YFactor = Factor.SubTankSE,
        };

        public static readonly PasswordGridPosition Position_X3Y1 = new PasswordGridPosition()
        {
            PositionCoordinate = new Point(3, 1),
            DigitNEven = 2,
            DigitNOdd = 6,
            DigitXEven = 8,
            DigitXOdd = 7,
            DigitYEven = 5,
            DigitYOdd = 3,
            DigitXYEven = 4,
            DigitXYOdd = 1,
            XFactor = Factor.HeartTankLO,
            YFactor = Factor.SubTankSM,
            MainFactors = new List<Factor>()
            {
                Factor.BossAA,
                Factor.BossBK,
                Factor.BossCP,
                Factor.BossFM,
                Factor.BossLO,
                Factor.BossSM,
                Factor.BossSC,
                Factor.BossSE,
            },
        };

        public static readonly PasswordGridPosition Position_X4Y1 = new PasswordGridPosition()
        {
            PositionCoordinate = new Point(4, 1),
            DigitNEven = 1,
            DigitNOdd = 1,
            DigitXEven = 4,
            DigitXOdd = 4,
            DigitYEven = 6,
            DigitYOdd = 6,
            DigitXYEven = 8,
            DigitXYOdd = 8,
            XFactor = Factor.BossCP,
            YFactor = Factor.HeartTankSM,
        };

        /// ********************
        /// Row 2
        /// ********************

        public static readonly PasswordGridPosition Position_X1Y2 = new PasswordGridPosition()
        {
            PositionCoordinate = new Point(1, 2),
            DigitNEven = 5,
            DigitNOdd = 7,
            DigitXEven = 3,
            DigitXOdd = 2,
            DigitYEven = 1,
            DigitYOdd = 8,
            DigitXYEven = 6,
            DigitXYOdd = 4,
            XFactor = Factor.BossLO,
            YFactor = Factor.UpgradeArmor,
            MainFactors = new List<Factor>()
            {
                Factor.BossAA,
                Factor.BossBK,
                Factor.BossCP,
                Factor.BossFM,
                Factor.BossSE,
                Factor.HeartTankAA,
                Factor.HeartTankBK,
                Factor.SubTankAA,
                Factor.UpgradeXBuster,
            },
        };

        public static readonly PasswordGridPosition Position_X2Y2 = new PasswordGridPosition()
        {
            PositionCoordinate = new Point(2, 2),
            DigitNEven = 8,
            DigitNOdd = 2,
            DigitXEven = 4,
            DigitXOdd = 7,
            DigitYEven = 1,
            DigitYOdd = 3,
            DigitXYEven = 6,
            DigitXYOdd = 5,
            XFactor = Factor.BossBK,
            YFactor = Factor.HeartTankBK,
            MainFactors = new List<Factor>()
            {
                Factor.SubTankAA,
                Factor.SubTankFM,
                Factor.SubTankSM,
                Factor.SubTankSE,
                Factor.UpgradeBoots,
                Factor.UpgradeHelmet,
                Factor.UpgradeArmor,
                Factor.UpgradeXBuster,
            },
        };

        public static readonly PasswordGridPosition Position_X3Y2 = new PasswordGridPosition()
        {
            PositionCoordinate = new Point(3, 2),
            DigitNEven = 5,
            DigitNOdd = 4,
            DigitXEven = 8,
            DigitXOdd = 1,
            DigitYEven = 3,
            DigitYOdd = 7,
            DigitXYEven = 6,
            DigitXYOdd = 2,
            XFactor = Factor.BossAA,
            YFactor = Factor.UpgradeXBuster,
            MainFactors = new List<Factor>()
            {
                Factor.BossLO,
                Factor.BossSE,
                Factor.HeartTankCP,
                Factor.HeartTankFM,
                Factor.SubTankSE,
                Factor.UpgradeHelmet,
            },
        };

        public static readonly PasswordGridPosition Position_X4Y2 = new PasswordGridPosition()
        {
            PositionCoordinate = new Point(4, 2),
            DigitNEven = 2,
            DigitNOdd = 2,
            DigitXEven = 6,
            DigitXOdd = 6,
            DigitYEven = 8,
            DigitYOdd = 8,
            DigitXYEven = 7,
            DigitXYOdd = 7,
            XFactor = Factor.BossSM,
            YFactor = Factor.HeartTankSC,
        };

        /// ********************
        /// Row 3
        /// ********************

        public static readonly PasswordGridPosition Position_X1Y3 = new PasswordGridPosition()
        {
            PositionCoordinate = new Point(1, 3),
            DigitNEven = 4,
            DigitNOdd = 1,
            DigitXEven = 2,
            DigitXOdd = 7,
            DigitYEven = 6,
            DigitYOdd = 5,
            DigitXYEven = 8,
            DigitXYOdd = 3,
            XFactor = Factor.HeartTankCP,
            YFactor = Factor.SubTankAA,
            MainFactors = new List<Factor>()
            {
                Factor.BossCP,
                Factor.BossFM,
                Factor.HeartTankLO,
                Factor.HeartTankSC,
                Factor.SubTankSM,
                Factor.SubTankSE,
                Factor.UpgradeHelmet,
                Factor.UpgradeArmor,
                Factor.UpgradeXBuster,
            },
        };

        public static readonly PasswordGridPosition Position_X2Y3 = new PasswordGridPosition()
        {
            PositionCoordinate = new Point(2, 3),
            DigitNEven = 3,
            DigitNOdd = 2,
            DigitXEven = 7,
            DigitXOdd = 8,
            DigitYEven = 4,
            DigitYOdd = 1,
            DigitXYEven = 6,
            DigitXYOdd = 5,
            XFactor = Factor.BossFM,
            YFactor = Factor.UpgradeHelmet,
            MainFactors = new List<Factor>()
            {
                Factor.HeartTankAA,
                Factor.HeartTankBK,
                Factor.HeartTankCP,
                Factor.HeartTankFM,
                Factor.HeartTankLO,
                Factor.HeartTankSM,
                Factor.HeartTankSC,
                Factor.HeartTankSE,
            },
        };

        public static readonly PasswordGridPosition Position_X3Y3 = new PasswordGridPosition()
        {
            PositionCoordinate = new Point(3, 3),
            DigitNEven = 2,
            DigitNOdd = 2,
            DigitXEven = 4,
            DigitXOdd = 4,
            DigitYEven = 6,
            DigitYOdd = 6,
            DigitXYEven = 7,
            DigitXYOdd = 7,
            XFactor = Factor.HeartTankFM,
            YFactor = Factor.SubTankFM,
        };

        public static readonly PasswordGridPosition Position_X4Y3 = new PasswordGridPosition()
        {
            PositionCoordinate = new Point(4, 3),
            DigitNEven = 5,
            DigitNOdd = 5,
            DigitXEven = 3,
            DigitXOdd = 3,
            DigitYEven = 2,
            DigitYOdd = 2,
            DigitXYEven = 6,
            DigitXYOdd = 6,
            XFactor = Factor.BossSE,
            YFactor = Factor.HeartTankSE,
        };

        public static readonly List<PasswordGridPosition> AllPositions = new List<PasswordGridPosition>()
        {
            // row 1
            Position_X1Y1,
            Position_X2Y1,
            Position_X3Y1,
            Position_X4Y1,

            // row 2
            Position_X1Y2,
            Position_X2Y2,
            Position_X3Y2,
            Position_X4Y2,

            // row 3
            Position_X1Y3,
            Position_X2Y3,
            Position_X3Y3,
            Position_X4Y3,
        };
    }
}
