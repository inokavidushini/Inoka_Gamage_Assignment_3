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



}
