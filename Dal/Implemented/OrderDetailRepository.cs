using Dal.Implemented.Base;
using Dal.Interfaces;
using Domains; 

namespace Dal.Implemented
{
    public class OrderDetailRepository : RepositoryBase<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(ApplicationContext context) : base(context)
        {

        }
 
    }
}
