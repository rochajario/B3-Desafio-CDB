namespace Domain.Models
{
    public class InvestmentDto
    {
        public double InitialValue { get; set; }
        public int MonthsCommited { get; set; }

        public InvestmentBusinessEntity ToBusinessEntity()
        {
            return new InvestmentBusinessEntity
            {
                InitialValue = InitialValue,
                MonthsCommited = MonthsCommited,
                GrossProfit = 0,
                ClearProfit = 0,
            };
        }
    }
}
