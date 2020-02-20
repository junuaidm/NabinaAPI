
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nbn.eCommenrce.ItemService.Models
{
    public class CostcenterNmes
    {
        public string CostCentreName { get; set; }
    }
    public class CostCentreNamedata
    {
        public string CostCentreName { get; set; }
        public string ItemTypeName { get; set; }
        public int? ItemParentType { get; set; }
        public int? CostCentreId { get; set; }
    }
    public class Itemcatagorydata
    {
        public string CostCentreName { get; set; }
        public string ItemcatatgoryName { get; set; }
        public string ItemSubcatatgoryName { get; set; }
    }
    public class Navbar
    {

        public string DivisionName { get; set; }
        public string CatagoryName { get; set; }
        public string SubcatagoryName { get; set; }
        public int SubcatagoryId { get; set; }
        public int CatagoryId { get; set; }
        public int DivisionId { get; set; }
    }
    public class Divisions
    {
        public string Division { get; set; }
    }
    public class JSONResponse
    {
        public string status { get; set; }
        //public List<dynamic> NBMData { get; set; }
        public List<JSONResponse_NBM> NBMData { get; set; }
        public List<JSONResponse_NBMkm> NBMData_km { get; set; }
      

    }

    public class JSONResponse_NBM
    {
        public string status { get; set; }
        public string databasename { get; set; }
        public List<dynamic> data { get; set; }

    }
    public class JSONResponse_NBMkm
    {
        public string status { get; set; }
        public string databasename { get; set; }
        public List<dynamic> data { get; set; }

    }
    public class JsonResults
    {
        public string Status { get; set; }
        public List<dynamic> Data { get; set; }
       
    }
    public class JsonResponseNavbar_NBM
    {
        public string Status { get; set; }
        public string DatabaseName;
      //public Dictionary<dynamic, Dictionary<dynamic, List<dynamic>>> data1 { get; set; }
       public List<Division> Data = new List<Division>();
    }
    public class JsonResponseNavbar_NBMKM
    {
        public string status { get; set; }
        public string databaseName;
        public List<Division> data = new List<Division>();
        //public Dictionary<dynamic, Dictionary<dynamic, List<dynamic>>> data { get; set; }

    }
    public class Division
    {
        public int DivisionId { get; set; }
        public string DivisionName { get; set; }
        public List<Catagory> CatagoryList = new List<Catagory>();
       
    }
    public class Catagory
    {
        public int CatagoryId { get; set; }
        public string CatagoryName { get; set; }
        public List<Subcatagory> SubcatagoryList = new List<Subcatagory>();
    }
    public class Subcatagory
    {
        public int SubcatagoryId { get; set; }
        public string SubcatagoryName { get; set; }
    }


}
