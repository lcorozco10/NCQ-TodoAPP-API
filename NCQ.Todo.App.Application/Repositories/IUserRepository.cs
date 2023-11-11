﻿using NCQ.Todo.App.Domain.Entities;

namespace NCQ.Todo.App.Application.Repositories
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<User?> GetByEmail(string email, CancellationToken cancellationToken);
    }
}