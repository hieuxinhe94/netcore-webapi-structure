using Dal.Implemented.Base;
using Dal.Interfaces;
using Domains;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dal.Implemented
{
    public class AppRepository : RepositoryBase<ApplicationParam>, IAppRepository
    {
        public AppRepository(ApplicationContext context) : base(context)
        {

        }
 
    }
}
