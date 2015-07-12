using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Tests.Fakes
{
    class FakeOdeToFoodDb : IOdeToFoodDb
    {
        public IQueryable<T> Query<T>() where T : class
        {
            return Sets[typeof(T)] as IQueryable<T>;
        }

        public void Dispose() { }

        public void AddSet<T>(IQueryable<T> objects)
        {
            Sets.Add(typeof(T), objects);
        }


        void IOdeToFoodDb.Add<T>(T entity)
        {
            Added.Add(entity);
        }

        void IOdeToFoodDb.Update<T>(T entity)
        {
            Updated.Add(entity);
        }

        void IOdeToFoodDb.Remove<T>(T entity)
        {
            Removed.Add(entity);
        }

        void IOdeToFoodDb.SaveChanges()
        {
            Saved = true;
        }


        public Dictionary<Type, object> Sets = new Dictionary<Type, object>();

        public List<object> Added = new List<object>();
        public List<object> Updated = new List<object>();
        public List<object> Removed = new List<object>();
        public bool Saved;
    }
}