using System.Diagnostics.CodeAnalysis;

namespace Domain.Models
{
    [ExcludeFromCodeCoverage]
    public struct FinancialRates
    {
        public const double CDI = 0.009;
        public const double TB = 1.08;
        public const double SIX_MONTH_TAX = 0.225;
        public const double TWELVE_MONTH_TAX = 0.20;
        public const double TWNETYFOUR_MONTH_TAX = 0.175;
        public const double BEYOND_TAX = 0.15;
    }
}
