using System;
using Xunit;
using Util = Domain.Utils.CalculationUtil;

namespace Domain.Tests.CalculationUtil
{
    public class TaxDiscountTest
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        public void GivenInvalidMonthLenghtValue_WhenTaxDiscountMethodCall_ThenRaiseException(int months)
        {
            #region Arrange
            var dummyMonetaryValue = 1000;
            #endregion

            #region Act - Assert
            Assert.Throws<ArgumentException>(() => Util.TaxDiscount(dummyMonetaryValue, months));
            #endregion
        }

        [Fact]
        public void GivenValidMonthLenghtValue_WhenTaxDiscountMethodCall_ThenProceedProcessing()
        {
            #region Arrange
            var dummyMonetaryValue = 1000;
            #endregion

            #region Act
            var result = Util.TaxDiscount(dummyMonetaryValue, 2);
            #endregion

            #region Assert
            Assert.IsType<double>(result);
            #endregion
        }

        [Theory]
        //De 2 a 6 Meses
        [InlineData(0.15, 0.11, 2)]
        [InlineData(0.15, 0.11, 6)]
        //De 7 a 12 Meses
        [InlineData(0.15, 0.12, 7)]
        [InlineData(0.15, 0.12, 12)]
        //De 13 a 24 Meses
        [InlineData(150, 123.75, 13)]
        [InlineData(150, 123.75, 24)]
        //Acima de 24 Meses
        [InlineData(0.15, 0.13, 25)]
        [InlineData(0.15, 0.13, 42)]

        public void GivenMonthLimits_WhenTaxCalculationMethodCall_ThenReturnFinalValue(double initialValue, double finalValue, int months)
        {
            #region Arrange - Act
            var result = Util.TaxDiscount(initialValue, months);
            #endregion

            #region Assert
            Assert.Equal(finalValue, result, 1);
            #endregion
        }
    }
}
