using System;
using System.Collections.Generic;
using System.Text;

namespace MyBudget.Core;

    public class ExpenseRepository : IExpenseRepository
    {
        private readonly IExpenseStore _store;
        private readonly List<Expense> _expenses;

    public ExpenseRepository(IExpenseStore store)
    {
        _store = store;
        _expenses = store.Load().ToList();
    }

    public IReadOnlyList<Expense> GetAll()
    {
        return _expenses.OrderBy(e => e.Date).ToList();

    }
    public void Add(Expense expense)
    {
        ArgumentNullException.ThrowIfNull(expense);

        _expenses.Add(expense);
    }

    public decimal Total()
    {
        return _expenses.Sum(e => e.MonthlyImpact);
    }



}
