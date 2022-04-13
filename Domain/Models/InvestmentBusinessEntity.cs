using System.Diagnostics.CodeAnalysis;

namespace Domain.Models
{
    [ExcludeFromCodeCoverage]
    public class InvestmentBusinessEntity
    {
        public double InitialValue { get; set; }
        public double FinalValue { get; set; }
        public int MonthsCommited { get; set; }
        public double ClearProfit { get; set; }
        public double GrossProfit { get; set; }
    }
}