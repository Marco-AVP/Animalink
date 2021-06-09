using Animalink.Data.Base;
using Animalink.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animalink.DataAccess.Base
{
    public class GenericDao
    {
        #region Create
        public void Create<T>(T item) where T : Entity
        {
            using (var context = new AnimalinkDBContext())
            {
                context.Set<T>().Add(item);
                context.SaveChanges();
            }
        }

        public async Task CreateAsync<T>(T item) where T : Entity
        {
            using (var context = new AnimalinkDBContext())
            {
                await context.Set<T>().AddAsync(item);
                await context.SaveChangesAsync();
            }
        }

        public async Task AddListAsync<T>(List<T> items) where T : Entity
        {
            using (var context = new AnimalinkDBContext())
            {
                await context.Set<T>().AddRangeAsync(items);
                await context.SaveChangesAsync();
            }
        }

        #endregion

        #region Read

        public T Read<T>(Guid id) where T : Entity
        {
            var context = new AnimalinkDBContext();
            return context.Set<T>().SingleOrDefault(x => x.Id == id);
        }

        public async Task<T> ReadAsync<T>(Guid id) where T : Entity
        {
            var context = new AnimalinkDBContext();
            return await context.Set<T>().SingleOrDefaultAsync(x => x.Id == id);
        }

        #endregion

        #region Update
        public void Update<T>(T item) where T : Entity
        {
            using (var context = new AnimalinkDBContext())
            {
                context.Entry(item).State = EntityState.Modified;
                item.UpdatedAt = DateTime.UtcNow;
                context.SaveChanges();
            }
        }

        public async Task UpdateAsync<T>(T item) where T : Entity
        {
            using (var context = new AnimalinkDBContext())
            {
                context.Entry(item).State = EntityState.Modified;
                item.UpdatedAt = DateTime.UtcNow;
                await context.SaveChangesAsync();
            }
        }

        public async Task UpdateListAsync<T>(List<T> items) where T : Entity
        {
            using (var context = new AnimalinkDBContext())
            {
                foreach (var item in items)
                {
                    context.Entry(item).State = EntityState.Modified;
                    item.UpdatedAt = DateTime.UtcNow;
                }

                await context.SaveChangesAsync();
            }
        }
        #endregion


        #region List
        public List<T> List<T>() where T : Entity
        {
            using (var context = new AnimalinkDBContext())
            {
                return context.Set<T>().ToList();
            }

        }

        public async Task<List<T>> ListAsync<T>() where T : Entity
        {
            using (var context = new AnimalinkDBContext())
            {
                return await context.Set<T>().ToListAsync();
            }
        }
        #endregion


        #region Delete
        public void Delete<T>(T item) where T : Entity
        {
            var context = new AnimalinkDBContext();
            item.UpdatedAt = DateTime.UtcNow;
            item.IsDeleted = true;
            context.SaveChangesAsync();
        }
        #endregion
    }
}
