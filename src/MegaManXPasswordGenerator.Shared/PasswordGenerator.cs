using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MegaManXPasswordGenerator.Shared
{
    public class PasswordGenerator
    {
        public string GeneratePassword(PasswordCriteria passwordCriteria)
        {
            // array that represents the password input grid.
            var passwordArray = new int[4, 3];

            // the string representation of the password array.
            var password = string.Empty;

            // for each column
            for (int x = 0; x <= 3; x++)
            {
                // for each row
                for (int y = 0; y <= 2; y++)
                {
                    var passwordGridPosition = GetPasswordGridPositionForCoordinates(x + 1, y + 1);

                    var cellDigit = GetPasswordDigit(passwordCriteria, passwordGridPosition);

                    passwordArray[x, y] = cellDigit;
                }
            }

            // for each row
            for (int y = 2; y >= 0; y--)
            {
                // for each column
                for (int x = 0; x <= 3; x++)
                {
                    password += passwordArray[x, y].ToString() + " ";
                }

                password += Environment.NewLine;
            }

            return password.Trim();
        }

        public PasswordGridPosition GetPasswordGridPositionForCoordinates(int x, int y)
        {
            var passwordGridPosition = PasswordGridPositions
                .AllPositions
                .SingleOrDefault(
                    p =>
                        p.PositionCoordinate.X == x
                        && p.PositionCoordinate.Y == y);

            return passwordGridPosition;
        }

        /// <summary>
        /// Retrieves the correct "Digit" value from the `PasswordGridPosition` instance based on the state of the `PasswordCriteria`.
        /// Counts the number of selected `PasswordGridPosition.MainFactors` within the provided `PasswordCriteria`.
        /// Also evenulates if the XFactor and YFactor are selected.
        /// Based on that information combined, returns the appropriate "Digit" from the `PasswordGridPosition`.
        /// </summary>
        /// <param name="passwordCriteria"></param>
        /// <param name="passwordGridPosition"></param>
        /// <returns></returns>
        public int GetPasswordDigit(PasswordCriteria passwordCriteria, PasswordGridPosition passwordGridPosition)
        {
            var countOfSelectedFactors = CountSelectedFactors(passwordCriteria, passwordGridPosition.MainFactors);
            var selectedFactorCountIsEven = countOfSelectedFactors % 2 == 0;

            var xFactorIsSelected = IsFactorSelected(passwordCriteria, passwordGridPosition.XFactor);
            var yFactorIsSelected = IsFactorSelected(passwordCriteria, passwordGridPosition.YFactor);

            if (xFactorIsSelected && yFactorIsSelected) // X and Y
            {
                if (selectedFactorCountIsEven)
                    return passwordGridPosition.DigitXYEven;
                else
                    return passwordGridPosition.DigitXYOdd;
            }
            else if (xFactorIsSelected) // only X
            {
                if (selectedFactorCountIsEven)
                    return passwordGridPosition.DigitXEven;
                else
                    return passwordGridPosition.DigitXOdd;
            }
            else if (yFactorIsSelected) // only Y
            {
                if (selectedFactorCountIsEven)
                    return passwordGridPosition.DigitYEven;
                else
                    return passwordGridPosition.DigitYOdd;
            }
            else // Neither X nor Y
            {
                if (selectedFactorCountIsEven)
                    return passwordGridPosition.DigitNEven;
                else
                    return passwordGridPosition.DigitNOdd;
            }
        }

        public bool IsFactorSelected(PasswordCriteria passwordCriteria, Factor factor)
        {
            switch (factor)
            {
                case Factor.BossAA:
                    return passwordCriteria.BossAADefeated;
                case Factor.BossBK:
                    return passwordCriteria.BossBKDefeated;
                case Factor.BossCP:
                    return passwordCriteria.BossCPDefeated;
                case Factor.BossFM:
                    return passwordCriteria.BossFMDefeated;
                case Factor.BossLO:
                    return passwordCriteria.BossLODefeated;
                case Factor.BossSC:
                    return passwordCriteria.BossSCDefeated;
                case Factor.BossSE:
                    return passwordCriteria.BossSEDefeated;
                case Factor.BossSM:
                    return passwordCriteria.BossSMDefeated;

                case Factor.HeartTankAA:
                    return passwordCriteria.HeartTankAAAcquired;
                case Factor.HeartTankBK:
                    return passwordCriteria.HeartTankBKAcquired;
                case Factor.HeartTankCP:
                    return passwordCriteria.HeartTankCPAcquired;
                case Factor.HeartTankFM:
                    return passwordCriteria.HeartTankFMAcquired;
                case Factor.HeartTankLO:
                    return passwordCriteria.HeartTankLOAcquired;
                case Factor.HeartTankSC:
                    return passwordCriteria.HeartTankSCAcquired;
                case Factor.HeartTankSE:
                    return passwordCriteria.HeartTankSEAcquired;
                case Factor.HeartTankSM:
                    return passwordCriteria.HeartTankSMAcquired;

                case Factor.SubTankAA:
                    return passwordCriteria.SubTankAAAcquired;
                case Factor.SubTankFM:
                    return passwordCriteria.SubTankFMAcquired;
                case Factor.SubTankSE:
                    return passwordCriteria.SubTankSEAcquired;
                case Factor.SubTankSM:
                    return passwordCriteria.SubTankSMAcquired;

                case Factor.UpgradeArmor:
                    return passwordCriteria.UpgradeArmorAcquired;
                case Factor.UpgradeBoots:
                    return passwordCriteria.UpgradeBootsAcquired;
                case Factor.UpgradeHelmet:
                    return passwordCriteria.UpgradeHelmetAcquired;
                case Factor.UpgradeXBuster:
                    return passwordCriteria.UpgradeXBusterAcquired;

                default:
                    //throw new Exception("Factor was not handled. ");
                    return false;
            }
        }

        public int CountSelectedFactors(PasswordCriteria passwordCriteria, IEnumerable<Factor> factors)
        {
            var countOfSelectedFactors = 0;

            foreach (Factor factor in factors)
            {
                if (IsFactorSelected(passwordCriteria, factor))
                {
                    countOfSelectedFactors++;
                }
            }

            return countOfSelectedFactors;
        }
    }
}
