using DevExp.RepositoryPattern.Services.Abstract;
using DevExp.RepositoryPattern.Repositories.Abstract;
using DevExp.EntityFramework.Models;

namespace DevExp.RepositoryPattern.Services.Classes
{
    public class SalesService : ISalesService
    {
        private readonly ISalesRepo _salesRepo;
        public SalesService(ISalesRepo salesRepo)
        {
            _salesRepo = salesRepo;
        }
        public List<ProductSale> GetAllProductSales()
        {
            return _salesRepo.GetAll();
        }

        public List<ProductSale> GetProductSalesByMonth(int month)
        {
            return _salesRepo.GetAll().Where(x=>x.TransictionDate.Year==DateTime.Now.Year&&x.TransictionDate.Month==month).ToList();
        }

        public List<ProductSale> GetProductSalesByYear(int year)
        {
            return _salesRepo.GetAll().Where(x => x.TransictionDate.Year == year).ToList();
        }

        public List<ProductSale> GetProductSalesByYearAndMonth(int year, int month)
        {
            return _salesRepo.GetAll().Where(x => x.TransictionDate.Year == year && x.TransictionDate.Month == month).ToList();
        }
    }
}
