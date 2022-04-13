using Domain.Models;

namespace Domain.Services
{
    public interface ICalculationService
    {
        InvestmentBusinessEntity ProcessInvestment(InvestmentDto request);
    }
}