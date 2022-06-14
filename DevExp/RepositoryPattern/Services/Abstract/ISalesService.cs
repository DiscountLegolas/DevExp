using DevExp.EntityFramework.Models;
namespace DevExp.RepositoryPattern.Services.Abstract
{
    public interface ISalesService
    {
        public List<ProductSale> GetAllProductSales();
        public List<ProductSale> GetProductSalesByYear(int year);
        public List<ProductSale> GetProductSalesByMonth(int month);
        public List<ProductSale> GetProductSalesByYearAndMonth(int year,int month);

    }
}
