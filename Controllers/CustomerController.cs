using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Nbn.eCommenrce.ItemService.Models;
using Nbn.eCommenrce.ItemService.Repository;


namespace Nbn.eCommenrce.ItemService.Controllers
{
    
    public class CustomerController : ApiController
    {
        ICustomerRepository CustomerRepository;

        public CustomerController(ICustomerRepository _CustomerRepository)
        {
            CustomerRepository = _CustomerRepository;
        }

        [Route("Cust")]
        [HttpPost]
        public void InsertCustumer([FromBody] testcustomer testcustomer)
        {

            using (NBMKMDbContext NBMKMDbContext = new NBMKMDbContext())
            {
                NBMKMDbContext.Add(testcustomer);
                NBMKMDbContext.SaveChanges();
            }


               
        }

    
        
    }
}