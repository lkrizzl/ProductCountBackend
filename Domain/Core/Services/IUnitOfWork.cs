﻿namespace Domain.Core.Services;
public  interface IUnitOfWork
{
    Task<int> SaveChangesAsync(CancellationToken token = default);
}
