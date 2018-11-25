using Dal.Implemented.Base;
using Dal.Interfaces;
using Domains; 

namespace Dal.Implemented
{
    public class OrderStatusRepository : RepositoryBase<OrderStatus>, IOrderStatusRepository
    {
        public OrderStatusRepository(ApplicationContext context) : base(context)
        {

        }
 
    }
}
