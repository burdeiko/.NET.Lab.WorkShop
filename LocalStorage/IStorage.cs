using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LocalStorage
{
    public interface IStorage 
    {
        void Add(PortfolioItemDAL item);
        void Update(PortfolioItemDAL item);
        void Delete(int id);
        IEnumerable<PortfolioItemDAL> GetAll();
        PortfolioItemDAL GetById(int id);
    }
}
