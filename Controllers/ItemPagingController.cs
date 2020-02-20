using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nbn.eCommenrce.ItemService.Models;
using Nbn.eCommenrce.ItemService.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Nbn.eCommenrce.ItemService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemPagingController : ControllerBase
    {
        IItemPagingRepository ItemPagingRepository;
        public ItemPagingController(IItemPagingRepository _ItemPagingRepository)
        {
            ItemPagingRepository = _ItemPagingRepository;
        }

        
        [Route("GetItemTypes")]
        [HttpPost]
        public JsonResults GetItemPagingByRow(int PageNumber,int RowspPage)
        {
            try
            { 
                var Alldivisions = ItemPagingRepository.GetItemPagingByRow(PageNumber, RowspPage);
                var i = 0;
                int count = Alldivisions.Count();
                var list = new List<dynamic>();
                foreach (Items Item in Alldivisions)
                {
                    list.Add(new { item_id = Item.ItemId, item_name = Item.ItemName });
                    i++;
                }
                JsonResults JsonResults = new JsonResults();
                JsonResults.Data = list;
                JsonResults.Status = "true";
                return JsonResults;


            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        [Route("GetIttemSubcat")]
        [HttpGet]
        public JsonResults GetIttemSubcat(int PageNumber, int RowspPage,int id)
        {
            try
            {
                var GetIttemSubcat = ItemPagingRepository.GetIttemSubcat(PageNumber, RowspPage,id);
                var GetIttemSubcat_km = ItemPagingRepository.GetIttemSubcat_km(PageNumber, RowspPage, id);
                var i = 0;
                int count = GetIttemSubcat.Count();
                var list = new List<dynamic>();
                foreach (ItemCategories Item in GetIttemSubcat)
                {
                    list.Add(new { item_id = Item.ItemCategId, item_name = Item.ItemCategName });
                    i++;
                }
                JsonResults JsonResults = new JsonResults();
                JsonResults.Data = list;
                JsonResults.Status = "true";
                return JsonResults;


            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
    }
}