﻿using Microsoft.EntityFrameworkCore;
using Skeleton.DAL.Context;
using Skeleton.DAL.Entities;
using Skeleton.DAL.Interfaces;

namespace Skeleton.DAL.Repositories;

public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>
    where TEntity : BaseEntity
{
    protected QuizHubDatabaseContext _dbContext;

    protected BaseRepository(QuizHubDatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        var result = await _dbContext.Set<TEntity>().ToListAsync();
        return result;
    }

    public async Task<TEntity?> GetByIdAsync(Guid id)
    {
        var result = await _dbContext.Set<TEntity>().FindAsync(id);
        return result;
    }

    public async Task AddAsync(TEntity entity)
    {
        await _dbContext.Set<TEntity>().AddAsync(entity);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(TEntity entity)
    {
        _dbContext.Set<TEntity>().Update(entity);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await _dbContext.Set<TEntity>().FirstAsync(x => x.Id == id);
        _dbContext.Set<TEntity>().Remove(entity);
        await _dbContext.SaveChangesAsync();
    }
}