using Haevekort2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HaevekortUnitTest
{
    public class AccountUnitTest
    {
        [Theory]
        [InlineData(2000, 1000)]
        [InlineData(1000, 1000)]
        public void AccountShouldWithDraw(float money, float withdrawAmount)
        {
            // Arrange
            ICustomerInfo cus = new CustomerInfo("", "", DateTime.Now);
            IAccount acc = new Account(cus, money);
            float expected = money - withdrawAmount;

            // Act
            float withdraw = acc.WithDraw(withdrawAmount);

            // Assert
            Xunit.Assert.Equal(expected, acc.Money);
        }

        [Theory]
        [InlineData(2000, 3000)]
        [InlineData(1000, 1001)]
        public void AccountShouldNotWithDraw(float money, float withdrawAmount)
        {
            // Arrange
            ICustomerInfo cus = new CustomerInfo("", "", DateTime.Now);
            IAccount acc = new Account(cus, money);
            float expected = money - withdrawAmount;

            // Act & Assert
            Xunit.Assert.Throws<ArgumentException>(() => acc.WithDraw(withdrawAmount));
        }

        [Theory]
        [InlineData(2000, 1000)]
        [InlineData(1000, 1000)]
        public void AccountShouldDeposit(float money, float depositAmount)
        {
            // Arrange
            ICustomerInfo cus = new CustomerInfo("", "", DateTime.Now);
            IAccount acc = new Account(cus, money);
            float expected = money + depositAmount;

            // Act
            acc.Deposit(depositAmount);

            // Assert
            Xunit.Assert.Equal(expected, acc.Money);
        }

    }
}
