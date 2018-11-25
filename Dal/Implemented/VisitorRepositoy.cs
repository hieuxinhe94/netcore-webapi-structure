using Dal.Implemented.Base;
using Dal.Interfaces;
using Domains; 

namespace Dal.Implemented
{
    public class VisitorRepositoy : RepositoryBase<Visitor>, IVisitorRepositoy
    {
        public VisitorRepositoy(ApplicationContext context) : base(context)
        {

        }
 
    }
}
