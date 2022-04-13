using Domain.Models;
using System;

namespace Domain.Utils
{
    public static class CalculationUtil
    {
        public static double CdbCalculation(double monetaryValue)
        {
            ValidateRequirement(
                validation: () => (monetaryValue <= 0),
                errMessage: "Invalid Monetary Value.");

            return monetaryValue * (FinancialRates.CDI * FinancialRates.TB);
        }

        public static double TaxDiscount(double monetaryValue, int monthsCommited)
        {
            ValidateRequirement(
                validation: () => (monthsCommited <= 1),
                errMessage: "Invalid Months Length.");

            if (monthsCommited <= 6)
            {
                return monetaryValue - (monetaryValue * FinancialRates.SIX_MONTH_TAX);
            }

            if (monthsCommited <= 12)
            {
                return monetaryValue - (monetaryValue * FinancialRates.TWELVE_MONTH_TAX);
            }

            if (monthsCommited <= 24)
            {
                return monetaryValue - (monetaryValue * FinancialRates.TWNETYFOUR_MONTH_TAX);
            }

            return monetaryValue - (monetaryValue * FinancialRates.BEYOND_TAX);
        }

        private static void ValidateRequirement(Func<bool> validation, string errMessage)
        {
            var testResult = validation.Invoke();
            if (testResult)
            {
                throw new ArgumentException(errMessage);
            }
        }
    }
}
