using Core.Models;
using Core.Repositories;
using Core.Services;
using Core.UnitOfWorks;
using System.Threading.Tasks;

namespace Service.Services
{
    public class CategoryService : Service<Category>, ICategoryService
    {

        public CategoryService(IUnitOfWork unitOfWork,IRepository<Category> repository):base(unitOfWork,repository)
        {

        }

        public async Task<Category> GetWithProdutsByIdAsync(int categoryId)
        {
            return await _unitOfWork.Categories.GetWithProductsByIdAsync(categoryId);     
        }


    }
}
