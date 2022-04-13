using Domain.Models;
using Domain.Services;
using Xunit;
using Service = Domain.Services.CalculationService;

namespace Domain.Tests.CalculationService
{
    public class GetFinalValueTest
    {
        private readonly InvestmentDto _dummyRequest;
        public GetFinalValueTest()
        {
            _dummyRequest = new InvestmentDto
            {
                InitialValue = 1100,
                MonthsCommited = 3
            };
        }

        [Fact]
        public void GivenMethodCall_ThenInitialValueRemainsTheSame()
        {
            #region Arrange
            ICalculationService service = new Service();
            #endregion

            #region Act
            var result = service.ProcessInvestment(_dummyRequest);
            #endregion

            #region Assert
            Assert.Equal(1100, result.InitialValue);
            #endregion
        }

        [Fact]
        public void GivenMethodCall_WhenSetPeriodMonthlyGrossProfit_ThenValidateProperty()
        {
            #region Arrange
            ICalculationService service = new Service();
            #endregion

            #region Act
            var result = service.ProcessInvestment(_dummyRequest);
            #endregion

            #region Assert
            Assert.Equal(32.39, result.GrossProfit);
            #endregion
        }

        [Fact]
        public void GivenMethodCall_WhenSetInvestmentClearProfit_ThenValidateProperty()
        {
            #region Arrange
            ICalculationService service = new Service();
            #endregion

            #region Act
            var result = service.ProcessInvestment(_dummyRequest);
            #endregion

            #region Assert
            Assert.Equal(25.10, result.ClearProfit);
            #endregion
        }

        [Fact]
        public void GivenMethodCall_WhenSetInvestmentFinalValue_ThenValidateProperty()
        {
            #region Arrange
            ICalculationService service = new Service();
            #endregion

            #region Act
            var result = service.ProcessInvestment(_dummyRequest);
            #endregion

            #region Assert
            Assert.Equal(1125.10, result.FinalValue);
            #endregion
        }
    }
}
