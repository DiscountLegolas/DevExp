using DevExp.EntityFramework;
using DevExp.EntityFramework.Models;
using DevExp.RepositoryPattern.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace DevExp.RepositoryPattern.Repositories.Classes
{
    public class SalesRepository:ISalesRepo
    {
        private readonly DEContext _dEContext;
        public SalesRepository(DEContext dEContext)
        {
            _dEContext = dEContext;
        }

        public List<ProductSale> GetAll()
        {
            return _dEContext.ProductSale.Include(x => x.Product).Include(x=>x.Customer).ToList();
        }
    }
}
