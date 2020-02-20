using Nbn.eCommenrce.ItemService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Nbn.eCommenrce.ItemService.Repository
{
    public interface IItemPagingRepository
    {
        List<Items> GetItemPagingByRow(int PageNumber, int RowspPage);
        List<ItemCategories> GetIttemSubcat(int PageNumber, int RowspPage,int id);
        List<ItemCategories> GetIttemSubcat_km(int PageNumber, int RowspPage, int id);


    }
}
