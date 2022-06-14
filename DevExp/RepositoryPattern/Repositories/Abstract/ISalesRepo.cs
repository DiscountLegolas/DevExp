using DevExp.EntityFramework.Models;
namespace DevExp.RepositoryPattern.Repositories.Abstract
{
    public interface ISalesRepo
    {
        public List<ProductSale> GetAll();
    }
}
