using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace MegaManXPasswordGenerator
{
    /// <summary>
    /// Class that describes a certain position within the password grid
    /// </summary>
    class Position
    {
        #region Const

        //define common Position Definitions
        private static readonly Position m_Position11 = new Position(new Point(1, 1), 1, 8, 4, 6, 3, 7, 2, 5, Factors.HeartTankAA, Factors.UpgradeBoots, Factors.BossAA, Factors.BossBK, Factors.HeartTankBK, Factors.HeartTankCP, Factors.HeartTankFM, Factors.HeartTankLO, Factors.HeartTankSC, Factors.SubTankSM, Factors.UpgradeArmor);
        public static Position Position11
        {
            get { return m_Position11; }
        }

        private static readonly Position m_Position21 = new Position(new Point(2, 1), 8, 8, 3, 3, 2, 2, 1, 1, Factors.BossSC, Factors.SubTankSE);
        public static Position Position21
        {
            get { return m_Position21; }
        }

        private static readonly Position m_Position31 = new Position(new Point(3, 1), 2, 6, 8, 7, 5, 3, 4, 1, Factors.HeartTankLO, Factors.SubTankSM, Factors.BossAA, Factors.BossBK, Factors.BossCP, Factors.BossFM, Factors.BossLO, Factors.BossSM, Factors.BossSC, Factors.BossSE);
        public static Position Position31
        {
            get { return m_Position31; }
        }

        private static readonly Position m_Position41 = new Position(new Point(4, 1), 1, 1, 4, 4, 6, 6, 8, 8, Factors.BossCP, Factors.HeartTankSM);
        public static Position Position41
        {
            get { return m_Position41; }
        }


        private static readonly Position m_Position12 = new Position(new Point(1, 2), 5, 7, 3, 2, 1, 8, 6, 4, Factors.BossLO, Factors.UpgradeArmor, Factors.BossAA, Factors.BossBK, Factors.BossCP, Factors.BossFM, Factors.BossSE, Factors.HeartTankAA, Factors.HeartTankBK, Factors.SubTankAA, Factors.UpgradeXBuster);
        public static Position Position12
        {
            get { return m_Position12; }
        }

        private static readonly Position m_Position22 = new Position(new Point(2, 2), 8, 2, 4, 7, 1, 3, 6, 5, Factors.BossBK, Factors.HeartTankBK, Factors.SubTankAA, Factors.SubTankFM, Factors.SubTankSM, Factors.SubTankSE, Factors.UpgradeBoots, Factors.UpgradeHelmet, Factors.UpgradeArmor, Factors.UpgradeXBuster);
        public static Position Position22
        {
            get { return m_Position22; }
        }

        private static readonly Position m_Position32 = new Position(new Point(3, 2), 5, 4, 8, 1, 3, 7, 6, 2, Factors.BossAA, Factors.UpgradeXBuster, Factors.BossLO, Factors.BossSE, Factors.HeartTankCP, Factors.HeartTankFM, Factors.SubTankSE, Factors.UpgradeHelmet);
        public static Position Position32
        {
            get { return m_Position32; }
        }

        private static readonly Position m_Position42 = new Position(new Point(4, 2), 2, 2, 6, 6, 8, 8, 7, 7, Factors.BossSM, Factors.HeartTankSC);
        public static Position Position42
        {
            get { return m_Position42; }
        }


        private static readonly Position m_Position13 = new Position(new Point(1, 3), 4, 1, 2, 7, 6, 5, 8, 3, Factors.HeartTankCP, Factors.SubTankAA, Factors.BossCP, Factors.BossFM, Factors.HeartTankLO, Factors.HeartTankSC, Factors.SubTankSM, Factors.SubTankSE, Factors.UpgradeHelmet, Factors.UpgradeArmor, Factors.UpgradeXBuster);
        public static Position Position13
        {
            get { return m_Position13; }
        }

        private static readonly Position m_Position23 = new Position(new Point(2, 3), 3, 2, 7, 8, 4, 1, 6, 5, Factors.BossFM, Factors.UpgradeHelmet, Factors.HeartTankAA, Factors.HeartTankBK, Factors.HeartTankCP, Factors.HeartTankFM, Factors.HeartTankLO, Factors.HeartTankSM, Factors.HeartTankSC, Factors.HeartTankSE);
        public static Position Position23
        {
            get { return m_Position23; }
        }

        private static readonly Position m_Position33 = new Position(new Point(3, 3), 2, 2, 4, 4, 6, 6, 7, 7, Factors.HeartTankFM, Factors.SubTankFM);
        public static Position Position33
        {
            get { return m_Position33; }
        }

        private static readonly Position m_Position43 = new Position(new Point(4, 3), 5, 5, 3, 3, 2, 2, 6, 6, Factors.BossSE, Factors.HeartTankSE);
        public static Position Position43
        {
            get { return m_Position43; }
        }

        private static readonly List<Position> m_lstAllPositions = new List<Position>(new Position[] { Position11, Position12, Position13, Position21, Position22, Position23, Position31, Position32, Position33, Position41, Position42, Position43 });
        public static List<Position> AllPositions
        {
            get { return m_lstAllPositions; }
        }

        #endregion //Const

        #region Properties

        private Point m_PositionCoordinate = new Point(0, 0);
        public Point PositionCoordinate
        {
            get { return m_PositionCoordinate; }
            set { m_PositionCoordinate = value; }
        }

        //N
        private int m_intDigitNEven;
        public int DigitNEven
        {
            get { return m_intDigitNEven; }
            set { m_intDigitNEven = value; }
        }
        private int m_intDigitNOdd;
        public int DigitNOdd
        {
            get { return m_intDigitNOdd; }
            set { m_intDigitNOdd = value; }
        }

        //X
        private int m_intDigitXEven;
        public int DigitXEven
        {
            get { return m_intDigitXEven; }
            set { m_intDigitXEven = value; }
        }
        private int m_intDigitXOdd;
        public int DigitXOdd
        {
            get { return m_intDigitXOdd; }
            set { m_intDigitXOdd = value; }
        }

        //Y
        private int m_intDigitYEven;
        public int DigitYEven
        {
            get { return m_intDigitYEven; }
            set { m_intDigitYEven = value; }
        }
        private int m_intDigitYOdd;
        public int DigitYOdd
        {
            get { return m_intDigitYOdd; }
            set { m_intDigitYOdd = value; }
        }

        //XY
        private int m_intDigitXYEven;
        public int DigitXYEven
        {
            get { return m_intDigitXYEven; }
            set { m_intDigitXYEven = value; }
        }
        private int m_intDigitXYOdd;
        public int DigitXYOdd
        {
            get { return m_intDigitXYOdd; }
            set { m_intDigitXYOdd = value; }
        }

        private Factors m_FactorsXFactor;
        public Factors XFactor
        {
            get { return m_FactorsXFactor; }
            set { m_FactorsXFactor = value; }
        }

        private Factors m_FactorsYFactor;
        public Factors YFactor
        {
            get { return m_FactorsYFactor; }
            set { m_FactorsYFactor = value; }
        }

        private List<Factors> m_lstMainFactors = new List<Factors>();
        public List<Factors> MainFactors
        {
            get { return m_lstMainFactors; }
            set { m_lstMainFactors = value; }
        }

        #endregion //Properties

        #region Constructors

        public Position()
        {
        }

        public Position(
            Point PositionCoordinate,
            int DigitNEven,
            int DigitNOdd,
            int DigitXEven,
            int DigitXOdd,
            int DigitYEven,
            int DigitYOdd,
            int DigitXYEven,
            int DigitXYOdd,
            Factors XFactor,
            Factors YFactor,
            params Factors[] MainFactors)
            : this(
            PositionCoordinate,
            DigitNEven,
            DigitNOdd,
            DigitXEven,
            DigitXOdd,
            DigitYEven,
            DigitYOdd,
            DigitXYEven,
            DigitXYOdd,
            XFactor,
            YFactor,
            new List<Factors>(MainFactors))
        {
            //empty
        }

        public Position(
            Point PositionCoordinate,
            int DigitNEven,
            int DigitNOdd,
            int DigitXEven,
            int DigitXOdd,
            int DigitYEven,
            int DigitYOdd,
            int DigitXYEven,
            int DigitXYOdd,
            Factors XFactor,
            Factors YFactor,
            IEnumerable<Factors> MainFactors)
        {
            //if (PositionCoordinate == null || MainFactors == null)
            //throw new ArgumentNullException("Something was NULL. ");

            this.PositionCoordinate = PositionCoordinate;

            this.DigitNEven = DigitNEven;
            this.DigitNOdd = DigitNOdd;
            this.DigitXEven = DigitXEven;
            this.DigitXOdd = DigitXOdd;
            this.DigitYEven = DigitYEven;
            this.DigitYOdd = DigitYOdd;
            this.DigitXYEven = DigitXYEven;
            this.DigitXYOdd = DigitXYOdd;

            this.XFactor = XFactor;
            this.YFactor = YFactor;
            this.MainFactors = new List<Factors>(MainFactors);

        }

        #endregion //Constructors

        #region Methods

        public int GetDigit(PasswordCriteria pc)
        {
            if (pc.EvaluateFactor(this.XFactor) && pc.EvaluateFactor(this.YFactor))
            {
                //XY
                if (pc.CountTrueFactors(this.MainFactors) % 2 == 0)//EVEN
                    return this.DigitXYEven;
                else //ODD
                    return this.DigitXYOdd;
            }
            else if (pc.EvaluateFactor(this.XFactor))
            {
                //X
                if (pc.CountTrueFactors(this.MainFactors) % 2 == 0)//EVEN
                    return this.DigitXEven;
                else //ODD
                    return this.DigitXOdd;
            }
            else if (pc.EvaluateFactor(this.YFactor))
            {
                //Y
                if (pc.CountTrueFactors(this.MainFactors) % 2 == 0)//EVEN
                    return this.DigitYEven;
                else //ODD
                    return this.DigitYOdd;
            }
            else
            {
                //N
                if (pc.CountTrueFactors(this.MainFactors) % 2 == 0)//EVEN
                    return this.DigitNEven;
                else //ODD
                    return this.DigitNOdd;
            }
        }

        #endregion //Methods

    }
}