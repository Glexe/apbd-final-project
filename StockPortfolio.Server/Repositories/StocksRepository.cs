﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StockPortfolio.Models;
using StockPortfolio.Server.Contexts;

namespace StockPortfolio.Server.Repositories
{
    public class StocksRepository : IStocksRepository
    {
        private readonly ApplicationContext _dbContext;

        public StocksRepository(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Stock> AddAsync(Stock entity)
        {
            if (entity is null) return null;
            var createdEntityEntry = await _dbContext.Set<Stock>().AddAsync(entity);
            return createdEntityEntry.Entity;
        }

        public async Task<Stock> DeleteAsync(int id)
        {
            var stocksSet = _dbContext.Set<Stock>();
            var entityToRemove = await stocksSet.FindAsync(id);
            if (entityToRemove == null)
            {
                return null;
            }

            stocksSet.Remove(entityToRemove);
            return entityToRemove;
        }

        public async Task<IEnumerable<Stock>> GetAllAsync() => await _dbContext.Set<Stock>().ToListAsync();

        public async Task<Stock> GetAsync(string symbol) => await _dbContext.Set<Stock>().FirstOrDefaultAsync(stock => stock.Symbol == symbol);

        public async Task<Stock> UpdateAsync(int id, Stock entity)
        {
            if (id != entity.StockID)
            {
                return null;
            }
            var record = await _dbContext.Set<Stock>().FindAsync(id);
            if (record is null) return null;
            _dbContext.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public async Task SaveAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }

    public interface IStocksRepository : IRepository<Stock>
    {
        public Task<Stock> GetAsync(string symbol);
    }  
}
