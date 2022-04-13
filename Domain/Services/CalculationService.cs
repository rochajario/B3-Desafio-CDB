using Domain.Models;
using Domain.Utils;
using System;

namespace Domain.Services
{
    public class CalculationService : ICalculationService
    {
        public InvestmentBusinessEntity ProcessInvestment(InvestmentDto request)
        {
            var investment = request.ToBusinessEntity();

            SetPeriodMonthlyGrossProfit(investment);
            SetInvestmentClearProfit(investment);
            SetInvestmentFinalValue(investment);

            return investment;
        }

        private static void SetPeriodMonthlyGrossProfit(InvestmentBusinessEntity investment)
        {
            var currentInvestmentValue = investment.InitialValue;

            for (var i = 0; i < investment.MonthsCommited; i++)
            {
                var actualMonthProfit = (CalculationUtil.CdbCalculation(currentInvestmentValue));

                currentInvestmentValue += actualMonthProfit;
                investment.GrossProfit += actualMonthProfit;
            }
            investment.GrossProfit = Math.Round(investment.GrossProfit, 2);
        }

        private static void SetInvestmentClearProfit(InvestmentBusinessEntity investment)
        {
            var value = CalculationUtil.TaxDiscount(investment.GrossProfit, investment.MonthsCommited);
            investment.ClearProfit = Math.Round(value, 2);
        }

        private static void SetInvestmentFinalValue(InvestmentBusinessEntity investment)
        {
            var value = investment.InitialValue + investment.ClearProfit;
            investment.FinalValue = Math.Round(value, 2);
        }
    }
}
