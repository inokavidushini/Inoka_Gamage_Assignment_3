using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using MyBudget.Core;

namespace MyBudget.Data;

public class JsonExpenseStore : IExpenseStore
{
    private readonly string _path;

    public JsonExpenseStore(string path)
    {
        _path = path;
    }
        public IReadOnlyList<Expense> Load()
    {
        if (!File.Exists(_path))
            return new List<Expense>();

    }
