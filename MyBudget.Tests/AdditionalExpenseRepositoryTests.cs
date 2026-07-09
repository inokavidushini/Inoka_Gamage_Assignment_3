using System;
using System.Collections.Generic;
using System.Text;
using MyBudget.Core;
using MyBudget.Data;
using MyBudget.Tests.Fakes;
using Xunit;

namespace MyBudget.Tests;
//Xunit test to checks whether the ExpenseRepository can store multiple expenses

public class AdditionalExpenseRepositoryTests
{
    [Fact]
    public void AddMultipleExpenses_ShouldStoreAllExpenses()
    {
        // Arrange
        var store = new InMemoryExpenseStore();
        var repository = new ExpenseRepository(store);


    }
}

