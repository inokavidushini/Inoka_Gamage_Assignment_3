using System;
using System.Collections.Generic;
using System.Text;

namespace MyBudget.Core;
public static class ExpenseFactory
{
    public static decimal ValidateAmount(decimal amount)
    {
        if (amount <= 0 || amount > 1000000)
            throw new InvalidExpenseException(
                "Invalid amount");

        return Math.Round(amount, 2);
    }

    public static OneTimeExpense CreateOneTime(
        string description,
        decimal amount,
        ExpenseCategory category,
        DateOnly date)

    {
        if (string.IsNullOrWhiteSpace(description))
            throw new InvalidExpenseException(
                "Description required");

        description = description.Trim();

        amount = ValidateAmount(amount);

        return new OneTimeExpense(
           Guid.NewGuid(),
           description,
           amount,
           category,
           date);

    }
        public static RecurringExpense CreateRecurring(
        string description,
        decimal amount,
        ExpenseCategory category,
        DateOnly date,
        int timesPerMonth)
    {
        if (string.IsNullOrWhiteSpace(description))
            throw new InvalidExpenseException(
                "Description required");

        if (timesPerMonth < 1)
            throw new InvalidExpenseException(
                "Invalid frequency");

        description = description.Trim();

        amount = ValidateAmount(amount);
        return new RecurringExpense(
            Guid.NewGuid(),
            description,
            amount,
            category,
            date,
            timesPerMonth);
    }
}


