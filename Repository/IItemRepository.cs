using Nbn.eCommenrce.ItemService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nbn.eCommenrce.ItemService.Repository
{
    public interface IItemRepository
    {

        //    //Task<List<Items>> GetItemTypes(int id);
        //    //List<ItemType> Getitemtypes();
        //    //List<Itemcatagorydata> GetItemTypeNames(string[] itemtypename);
        //    //List<CostCentre> GetCostcentre();
        List<Navbar> NavbarDataNBM();
        List<Navbar> NavbarDataNBMKM();
        //    //List<CostCentre> GetAllDivisions();
        //    //List<CostCentre> GetAllDivisions_km();
        //    //List<Items> GetItemDetailsdata();
        //    //List<Items> GetItemDetailsdata_km(); 
        //    //List<CostCentre> GetDisionId(int id);
        //    //List<Navbar> GetDisionbyCat(int id);
        //    //List<Navbar> GetDisionbyCat_km(int id);
        //    //List<Navbar> GetcatidbySubcat(int id);
        //    //List<Navbar> GetcatidbySubcat_km(int id); 
        //    //List<ItemCategories> GetProperties(int Subcatid);
        //    //List<ItemCategories> GetProperties_km(int Subcatid);

        //    //Task<List<Items>> GetItemsById(Id);
        }
    }
