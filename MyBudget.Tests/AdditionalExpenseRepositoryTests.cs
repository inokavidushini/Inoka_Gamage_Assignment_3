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
    public void AddMultipleExpenses_ShouldStoreAllExpenses() //multiple expenses are added, the repository should store all of them.
    {
        // Arrange
        var store = new InMemoryExpenseStore();             //create a fake in-memory store.
        var repository = new ExpenseRepository(store);      //Create repository and give it to the store and save it into this store

        //Verify ExpenseRepository add multiple expenses
        var expense1 = new OneTimeExpense(
            Guid.NewGuid(),
            "Coffee",
            5m,
            ExpenseCategory.Food,
            default);

        var expense2 = new OneTimeExpense(
            Guid.NewGuid(),
            "Book",
            20m,
            ExpenseCategory.Other,
            default);

        //Act

        repository.Add(expense1);               //Expenses adds it to the store
        repository.Add(expense2);
        

        //Assert
        Assert.Equal(2, repository.GetAll().Count); //Verify that 2 expenses were stored

    }
}

