using System;
using System.Collections.Generic;
using System.Text;

namespace MyBudget.Core;

    public record OneTimeExpense(
    Guid Id,
    string Description,
    decimal Amount,
    ExpenseCategory Category,
    DateOnly Date
    )
{
    internal class OneTimeExpense
    {
    }
}
