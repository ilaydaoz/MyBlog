using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService : IGenericService<Category>
    {
            ICollection<Category> GetAllStatusActive();
    }
}

