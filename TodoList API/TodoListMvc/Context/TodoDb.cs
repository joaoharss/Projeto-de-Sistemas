﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TodoListMvc.Model;

namespace TodoListMvc.Context
{
    public class TodoDb : DbContext
    {
        public TodoDb(DbContextOptions<TodoDb> options)
            : base(options) { }

        public DbSet<Todo> Todos => Set<Todo>();
    }
}
