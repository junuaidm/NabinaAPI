using Nbn.eCommenrce.ItemService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nbn.eCommenrce.ItemService.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        NBMDbContext NBMDbContext;
        NBMKMDbContext NBMKMDbContext = new NBMKMDbContext();

        public CustomerRepository(NBMDbContext _NBMDbContext)
        {
            NBMDbContext = _NBMDbContext;
        }
    }
}
