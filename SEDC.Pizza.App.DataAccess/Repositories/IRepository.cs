using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Pizza.App.DataAccess.Repositories
{
    public interface IRepository<T>
    {
        T GetById(int id);
        List<T> GetAll();
    }
}
