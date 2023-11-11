﻿using NCQ.Todo.App.Domain.Common;

namespace NCQ.Todo.App.Domain.Entities
{
    public sealed class User : BaseEntity
    {
        public string? Email { get; set; }
        public string? Name { get; set; }
    }
}
