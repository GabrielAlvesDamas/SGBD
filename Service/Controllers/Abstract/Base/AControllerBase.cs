using Data;
using Data.Entity;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Controllers.Abstract.Base
{
    public abstract class AControllerBase<T>
    {
        static ISession Session;

        protected AControllerBase() {
            Session = NHibernateContext.GetCurrentSession();
        }

        public void Save(T baseClass) 
        {
            using (ITransaction tx = Session.BeginTransaction())
            {
                try
                {
                    Session.SaveOrUpdate(baseClass);
                    tx.Commit();
                }
                catch(Exception ex)
                {
                    tx.Rollback();
                }
            }
        }

        public void Delete(T baseClass)
        {
            using (ITransaction tx = Session.BeginTransaction())
            {
                try
                {
                    Session.Delete(baseClass);
                    tx.Commit();
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                }
            }
        }

        public IList<T> SearchFilter(string className)
        {
            IList<T> list = new List<T>();
            using (ITransaction tx = Session.BeginTransaction())
            {
                try
                {
                    list = Session.Query<T>(className).ToList();
                    tx.Commit();
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                }
                return list;
            }
        }
    }
}
