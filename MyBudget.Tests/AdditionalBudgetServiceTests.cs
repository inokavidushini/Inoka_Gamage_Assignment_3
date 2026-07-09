using MyBudget.Core;
using Xunit;


//check whether the Remaining() method in BudgetService works properly when when no monthly limit has been set
namespace MyBudget.Tests;


public class AdditionalBudgetServiceTests
{
    [Fact]
    public void Remaining_WhenNoLimitAndExpensesExist_ShouldReturnNegativeAmount()
    {
        // Arrange
        var service = new BudgetService();

        // Act
        var remaining = service.Remaining(100m);

        // Assert
        Assert.Equal(-100m, remaining);


    }
}
