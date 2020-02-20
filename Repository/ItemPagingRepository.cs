using Nbn.eCommenrce.ItemService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nbn.eCommenrce.ItemService.Repository
{
    public class ItemPagingRepository : IItemPagingRepository
    {

        NBMDbContext NBMDbContext;
        NBMKMDbContext NBMKMDbContext = new NBMKMDbContext();

        public ItemPagingRepository(NBMDbContext _NBMDbContext)
        {
            NBMDbContext = _NBMDbContext;
        }
        public List<Items> GetItemPagingByRow(int currentPage, int pageSize)
        {
            if (NBMDbContext != null)
            {
                var data = (from div in NBMDbContext.Items
                                    
                                     orderby div.ItemId
                                     select new Items
                                     {
                                         ItemId = div.ItemId,
                                         ItemName = div.ItemName

                                     }).ToList();
                var PagingData = data.OrderBy(d => d.ItemId).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
                return PagingData;
            }

            return null;
        }
        public List<ItemCategories> GetIttemSubcat(int currentPage,int pageSize,int subcatid)
        {
            if (NBMDbContext != null && NBMKMDbContext != null)
            {
                var Propertieslst = (from ItemProperties in NBMDbContext.ItemProperties
                                     join SubCategories in NBMDbContext.ItemSubCategories on ItemProperties.SubCategId equals SubCategories.SubCategId
                                     join Categories in NBMDbContext.ItemCategories on SubCategories.ItemCategId equals Categories.ItemCategId
                                     orderby Categories.ItemCategName
                                     where ItemProperties.SubCategId == subcatid
                                     select new ItemCategories
                                     {
                                         ItemCategName = Categories.ItemCategName,
                                         ItemCategId = Categories.ItemCategId

                                     }).ToList();

                var PagingData = Propertieslst.OrderBy(d => d.ItemCategName).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
                return PagingData;

                
            }

            return null;
        }
        public List<ItemCategories> GetIttemSubcat_km(int currentPage, int pageSize, int subcatid)
        {
            if (NBMKMDbContext != null)
            {
                var Propertieslst = (from ItemProperties in NBMKMDbContext.ItemProperties
                                     join SubCategories in NBMKMDbContext.ItemSubCategories on ItemProperties.SubCategId equals SubCategories.SubCategId
                                     join Categories in NBMKMDbContext.ItemCategories on SubCategories.ItemCategId equals Categories.ItemCategId
                                     orderby Categories.ItemCategName
                                     where ItemProperties.SubCategId == subcatid
                                     select new ItemCategories
                                     {
                                         ItemCategName = Categories.ItemCategName,
                                         ItemCategId = Categories.ItemCategId

                                     }).ToList();

                var PagingData = Propertieslst.OrderBy(d => d.ItemCategName).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
                return PagingData;


            }

            return null;
        }
        
    }
}
