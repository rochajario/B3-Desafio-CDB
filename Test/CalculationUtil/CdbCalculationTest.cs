using System;
using Xunit;
using Util = Domain.Utils.CalculationUtil;

namespace Domain.Tests.CalculationUtil
{
    public class CdbCalculationTest
    {
        [Theory]
        [InlineData(-10)]
        [InlineData(0)]
        public void GivenNonPositiveMonetaryValue_WhenCdbCalculationMethodCall_ThenRaiseException(double value)
        {
            #region Arrange - Act
            Assert.Throws<ArgumentException>(() => Util.CdbCalculation(value));
            #endregion
        }

        [Theory]
        [InlineData(2485.75, 24.20)]
        [InlineData(1525, 14.80)]
        public void GivenPositiveMonetaryValue_WhenCdbCalculationMethodCall_ThenReturnFinalValue(double initialValue, double finalValue)
        {
            #region Arrange - Act
            var result = Util.CdbCalculation(initialValue);
            #endregion

            #region Assert
            Assert.Equal(finalValue, result, 1);
            #endregion
        }
    }
}
