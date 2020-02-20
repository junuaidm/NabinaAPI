using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nbn.eCommenrce.ItemService.Service;
using Microsoft.AspNetCore.Mvc;

namespace Nbn.eCommenrce.ItemService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {


        private ItemsService ItemsService;
        public ItemsController()
        {

            ItemsService = new ItemsService();
        }

        [HttpGet]
        [Route("NavbarData")]
        public IActionResult NavbarData()
        {
            var Data = ItemsService.NavbarData();
            if (Data== null)
            {
                return NotFound();
            }

            return Ok(Data);
        }
    }
}