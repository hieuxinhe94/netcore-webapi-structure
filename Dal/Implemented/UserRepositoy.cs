using Dal.Implemented.Base;
using Dal.Interfaces;
using Domains; 

namespace Dal.Implemented
{
    public class UserRepositoy : RepositoryBase<User>, IUserRepositoy
    {
        public UserRepositoy(ApplicationContext context) : base(context)
        {

        }
 
    }
}
