using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Interface;

namespace Data.Repository
{
    public class DeskRepository : IRepository
    {
        private readonly DbContext _context;

        public DeskRepository()
        {
            _context = new LearnContext();
        }

        public IQueryable<T> Query<T>() where T : class
        {
            return _context.Set<T>().AsQueryable<T>();
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Set<T>().Add(entity);
        }

        public T Find<T>(Func<T, bool> where) where T : class
        {
            return _context.Set<T>().SingleOrDefault(where);
        }

        public IEnumerable<T> FindAll<T>() where T : class
        {
            return _context.Set<T>().AsEnumerable();
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Entry(entity).State = EntityState.Deleted;
        }

        public T Clone<T>(T entity) where T : class
        {
            _context.Entry(entity).State = EntityState.Detached;

            return entity;
        }

        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }

        }
    }
}
