using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete
{
    public class CategoryRepository : GenericRepositories<Category> , ICategoryRepository
    {
    }
}
