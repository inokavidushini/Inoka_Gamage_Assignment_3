using System;
using System.Collections.Generic;
using System.Text;

namespace MyBudget.Core;

    public record RecurringExpense(
    Guid Id,
    string Description,
    decimal Amount,
    ExpenseCategory Category,
    DateOnly Date,
    int TimesPerMonth
) : Expense(Id, Description, Amount, Category, Date)

{
    public override decimal MonthlyImpact =>
       Amount * TimesPerMonth;


}
