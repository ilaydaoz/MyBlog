using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete
{
    public class CommentRepository : GenericRepositories<Comment>, ICommentRepository
    {
    }
}
