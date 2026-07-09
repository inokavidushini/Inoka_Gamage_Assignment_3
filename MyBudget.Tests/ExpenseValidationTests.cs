using System;
using MyBudget.Core;
using MyBudget.Data;
using MyBudget.Tests.Fakes;
using Xunit;

namespace MyBudget.Tests;

    public class ExpenseValidationTests
{
    // Xunit tests to check ExpenseRepository behavior
    [Fact]
    public void CreateExpense_WithEmptyDescription_ShouldThrowException()
    {
        /*// Arrange + Act + Assert

        Assert.Throws<InvalidExpenseException>(() =>
            ExpenseFactory.CreateOneTime(
                "",
                10m,
                ExpenseCategory.Food,
                default));*/
        // Arrange
        string description = "";
        decimal amount = 10m;
        ExpenseCategory category = ExpenseCategory.Food;

        //Act
        Action action = () => ExpenseFactory.CreateOneTime(description, amount, category, default);

        // Assert
        var Exception = Assert.Throws<InvalidExpenseException>((action));
        Assert.Equal("Expense description cannot be empty.", Exception.Message);
    }
       
    
    [Fact]
    public void CreateExpense_WithNegativeAmount_ShouldThrowException()
    {
        /*Assert.Throws<InvalidExpenseException>(() =>
            ExpenseFactory.CreateOneTime(
                "Coffee",
                -5m,
                ExpenseCategory.Food,
                default));*/
        // Arrange
        string description = "Coffee";
        decimal amount = -5m;
        ExpenseCategory category = ExpenseCategory.Food;

        //Act
        Action action = ()=> ExpenseFactory.CreateOneTime(description, amount, category, default);

        // Assert
        var Exception = Assert.Throws<InvalidExpenseException>((action));
        Assert.Equal(
            "Expense amount cannot be negative.",
            Exception.Message);


    }

}

