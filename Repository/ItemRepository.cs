using Nbn.eCommenrce.ItemService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nbn.eCommenrce.ItemService.Repository
{
    public class ItemRepository : IItemRepository
    {
        public ItemRepository()
        {

        }
        NBMDbContext NBMDbContext = new NBMDbContext();
        NBMKMDbContext NBMKMDbContext = new NBMKMDbContext();



       
        public List<Navbar> NavbarDataNBM()
        {
            

                var NavbarDataNBM =


                           (from Items in NBMDbContext.Items
                            join Itemtypes in NBMDbContext.ItemType on Items.ItemTypeId equals Itemtypes.ItemTypeId
                            join Itemcatt in NBMDbContext.ItemType on Itemtypes.ItemParentType equals Itemcatt.ItemTypeId
                            join ItemDivision in NBMDbContext.CostCentre on Itemtypes.CostCentreId equals ItemDivision.CostCentreId
                            select  new Navbar
                            {

                                DivisionName = ItemDivision.CostCentreName,
                                CatagoryName = Itemcatt.ItemTypeName,
                                SubcatagoryName = Itemtypes.ItemTypeName,
                                SubcatagoryId = Itemtypes.ItemTypeId,
                                CatagoryId = Itemcatt.ItemTypeId,
                                DivisionId = ItemDivision.CostCentreId


                                 }).Distinct().ToList();

                return NavbarDataNBM;
            

            

        }
        public List<Navbar> NavbarDataNBMKM()
        {
            if (NBMKMDbContext != null)
            {

                var NavbarDataNBMKM =


                           (from Items in NBMKMDbContext.Items
                            join Itemtypes in NBMKMDbContext.ItemType on Items.ItemTypeId equals Itemtypes.ItemTypeId
                            join Itemcatt in NBMKMDbContext.ItemType on Itemtypes.ItemParentType equals Itemcatt.ItemTypeId
                            join ItemDivision in NBMKMDbContext.CostCentre on Itemtypes.CostCentreId equals ItemDivision.CostCentreId

                            select new Navbar
                            {

                                DivisionName = ItemDivision.CostCentreName,
                                CatagoryName = Itemcatt.ItemTypeName,
                                SubcatagoryName = Itemtypes.ItemTypeName,
                                SubcatagoryId = Itemtypes.ItemTypeId,
                                CatagoryId = Itemcatt.ItemTypeId,
                                DivisionId = ItemDivision.CostCentreId

                            }).ToList();

                return NavbarDataNBMKM;
            }

            return null;

        }

        //public async Task<List<Items>> GetItemTypes(int id)
        //{
        //    if (NBMDbContext != null)
        //    {
        //        return await NBMDbContext.Items.ToListAsync();
        //    }

        //    return null;
        //}
        //public List<ItemType> Getitemtypes()
        //{
        //    if (NBMDbContext != null)
        //    {

        //        var employeeList =

        //            NBMDbContext.Items
        //                            .Select(e => new ItemType
        //                            {

        //                                ItemTypeId = e.ItemTypeId,
        //                                CostCentreId = e.CostCentreId


        //                            }).ToList();

        //        return employeeList;
        //    }

        //    return null;

        //}
        //public List<Itemcatagorydata> GetItemTypeNames(string[] ItemTypeId)
        //{
        //    int itemtypeIds = 0;
        //    var catagorylist = new List<Itemcatagorydata>();
        //    var employeeList = new List<CostCentreNamedata>();
        //    List<CostCentreNamedata> ss = new List<CostCentreNamedata>();
        //    var CostCentre = new List<CostCentre>();
        //    List<Itemcatagorydata> Itemcatagorydata = new List<Itemcatagorydata>();
        //    if (NBMDbContext != null)
        //    {
        //        //foreach (int type in ItemTypeId)
        //        //{

        //        //    if (type != 0 && type!= itemtypeIds)
        //        //    {
        //        //        itemtypeIds = type;
        //        //        employeeList = (from p in db.ItemType
        //        //                        from e in db.CostCentre
        //        //                        where p.ItemTypeId == type && p.CostCentreId == e.CostCentreId
        //        //                        select new CostCentreNamedata
        //        //                        {

        //        //                            ItemTypeName = p.ItemTypeName,
        //        //                            ItemParentType = p.ItemParentType,
        //        //                            CostCentreId = p.CostCentreId,
        //        //                            CostCentreName = e.CostCentreName



        //        //                        }).ToList();



        //        //        ss.AddRange(employeeList);


        //        //    }

        //        //    //ItemTypedata = employeeList;

        //        //}


        //        for (var i = 0; i < ss.Count; i++)
        //        {
        //            if (ss[i].ItemParentType != 0)
        //            {
        //                catagorylist =
        //                   (from p in NBMDbContext.ItemType

        //                    where p.ItemTypeId == ss[i].ItemParentType
        //                    select new Itemcatagorydata
        //                    {

        //                        ItemcatatgoryName = p.ItemTypeName,
        //                        CostCentreName = ss[i].CostCentreName,
        //                        ItemSubcatatgoryName = ss[i].ItemTypeName




        //                    }).ToList();
        //                Itemcatagorydata.AddRange(catagorylist);
        //            }

        //        }






        //        return Itemcatagorydata;




        //    }
        //    return null;
        //}
        //public List<CostCentre> GetCostcentre()
        //{

        //    if (NBMDbContext != null)
        //    {

        //        var CostcentreLst =

        //            NBMDbContext.CostCentre
        //                            .Select(e => new CostCentre
        //                            {

        //                                CostCentreId = e.CostCentreId,
        //                                CostCentreName = e.CostCentreName


        //                            }).ToList();

        //        return CostcentreLst;
        //    }

        //    return null;

        //}
        //public List<CostCentre> GetAllDivisions()
        //{
        //    if (NBMDbContext != null)
        //    {
        //        var DivisonLst = (from division in NBMDbContext.CostCentre
        //                          where division.CostCentreActive == true
        //                          orderby division.CostCentreName
        //                          select new CostCentre
        //                          {
        //                              CostCentreId = division.CostCentreId,
        //                              CostCentreName = division.CostCentreName
        //                          }).ToList();

        //        return DivisonLst;
        //    }
        //    return null;
        //}
        //public List<CostCentre> GetAllDivisions_km()
        //{
        //    if (NBMKMDbContext != null)
        //    {
        //        var DivisonLst = (from division in NBMKMDbContext.CostCentre
        //                          where division.CostCentreActive == true
        //                          orderby division.CostCentreName
        //                          select new CostCentre
        //                          {
        //                              CostCentreId = division.CostCentreId,
        //                              CostCentreName = division.CostCentreName
        //                          }).ToList();

        //        return DivisonLst;
        //    }
        //    return null;
        //}
        
        //public List<Items> GetItemDetailsdata()
        //{
        //    if (NBMDbContext != null)
        //    {
        //        var Itemlst = NBMDbContext.Items.Select(item => new Items
        //        {

        //            ItemId = item.ItemId,
        //            ItemName = item.ItemName,
        //            ItemPrice = item.ItemPrice

        //        }).ToList();
        //        return Itemlst;
        //    }
        //    return null;
        //}
        //public List<Items> GetItemDetailsdata_km()
        //{
        //    if (NBMKMDbContext != null)
        //    {
        //        var Itemlst = NBMKMDbContext.Items.Select(item => new Items
        //        {

        //            ItemId = item.ItemId,
        //            ItemName = item.ItemName,
        //            ItemPrice = item.ItemPrice

        //        }).ToList();
        //        return Itemlst;
        //    }
        //    return null;
        //}
        //public List<CostCentre> GetDisionId(int id)
        //{
        //    if (NBMDbContext != null)
        //    {
        //        var DisionbyId = (from div in NBMDbContext.CostCentre
        //                          where div.CostCentreId == id
        //                          select new CostCentre
        //                          {
        //                              CostCentreId = id,
        //                              CostCentreName = div.CostCentreName

        //                          }).ToList();
        //        return DisionbyId;
        //    }

        //    return null;
        //}
        //public List<ItemCatDetails> GetDisionbyCat(int id)
        //{
        //    if (NBMDbContext != null)
        //    {
        //        var DisionbyCat = (from div in NBMDbContext.ItemType
        //                           where div.CostCentreId == id && div.ItemParentType == 0
        //                           orderby div.ItemTypeName
        //                           select new ItemCatDetails
        //                           {
        //                               catagory_id = div.ItemTypeId,
        //                               catagory = div.ItemTypeName


        //                           }).ToList();
        //        return DisionbyCat;
        //    }

        //    return null;
        //}
        //public List<ItemCatDetails> GetDisionbyCat_km(int id)
        //{
        //    if (NBMKMDbContext != null)
        //    {
        //        var DisionbyCat = (from div in NBMKMDbContext.ItemType
        //                           where div.CostCentreId == id && div.ItemParentType == 0
        //                           orderby div.ItemTypeName
        //                           select new ItemCatDetails
        //                           {
        //                               catagory_id = div.ItemTypeId,
        //                               catagory = div.ItemTypeName


        //                           }).ToList();
        //        return DisionbyCat;
        //    }

        //    return null;
        //}
        
        //public List<ItemCatDetails> GetcatidbySubcat(int id)
        //{
        //    if (NBMDbContext != null)
        //    {
        //        var catidbySubcat = (from div in NBMDbContext.ItemType
        //                             where div.ItemParentType == id && div.ItemParentType != 0
        //                             orderby div.ItemTypeName
        //                             select new ItemCatDetails
        //                             {
        //                                 subcatagory_id = div.ItemTypeId,
        //                                 subcatagory = div.ItemTypeName


        //                             }).ToList();
        //        return catidbySubcat;
        //    }

        //    return null;
        //}
        //public List<ItemCatDetails> GetcatidbySubcat_km(int id)
        //{
        //    if (NBMKMDbContext != null)
        //    {
        //        var catidbySubcat = (from div in NBMKMDbContext.ItemType
        //                             where div.ItemParentType == id && div.ItemParentType != 0
        //                             orderby div.ItemTypeName
        //                             select new ItemCatDetails
        //                             {
        //                                 subcatagory_id = div.ItemTypeId,
        //                                 subcatagory = div.ItemTypeName


        //                             }).ToList();
        //        return catidbySubcat;
        //    }

        //    return null;
        //}
        //public List<ItemCategories> GetProperties(int subcatid)
        //{
        //    if (NBMDbContext != null && NBMKMDbContext != null)
        //    {
        //        var Propertieslst = (from ItemProperties in NBMDbContext.ItemProperties
        //                             join SubCategories in NBMDbContext.ItemSubCategories on ItemProperties.SubCategId equals SubCategories.SubCategId
        //                             join Categories in NBMDbContext.ItemCategories on SubCategories.ItemCategId equals Categories.ItemCategId
        //                             orderby Categories.ItemCategName
        //                             where ItemProperties.ItemId == subcatid
        //                             select new ItemCategories
        //                             {
        //                                 ItemCategName = Categories.ItemCategName,
        //                                 ItemCategId = Categories.ItemCategId

        //                             }).ToList();

               

        //        return Propertieslst;
        //    }

        //    return null;
        //}
        //public List<ItemCategories> GetProperties_km(int subcatid)
        //{
        //    if (NBMDbContext != null && NBMKMDbContext != null)
        //    {
        //        var Propertieslst_km = (from ItemProperties in NBMKMDbContext.ItemProperties
        //                                join SubCategories in NBMKMDbContext.ItemSubCategories on ItemProperties.SubCategId equals SubCategories.SubCategId
        //                                join Categories in NBMKMDbContext.ItemCategories on SubCategories.ItemCategId equals Categories.ItemCategId
        //                                orderby Categories.ItemCategName
        //                                where ItemProperties.ItemId == subcatid
        //                                select new ItemCategories
        //                                {
        //                                    ItemCategName = Categories.ItemCategName,
        //                                    ItemCategId = Categories.ItemCategId

        //                                }).ToList();



        //        return Propertieslst_km;
        //    }

        //    return null;
        //}

       

    }
}


