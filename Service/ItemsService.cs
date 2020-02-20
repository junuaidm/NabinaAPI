using Nbn.eCommenrce.ItemService.Models;
using Nbn.eCommenrce.ItemService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nbn.eCommenrce.ItemService.Service
{
    public class ItemsService 
    {
      



        public ItemsService()
        {

        }
        ItemRepository ItemRepository = new ItemRepository();
        public JsonResults NavbarData()
        {

            try
            {
                var NBMData = ItemRepository.NavbarDataNBM();
                var NBMKMData = ItemRepository.NavbarDataNBMKM();
                string[] DivisionNBMArray = new string[NBMData.Count];
                string[] DivisionNBMKMArray = new string[NBMKMData.Count];
                string[] CatagoryNBMArray = new string[NBMData.Count];
                string[] CatagoryNBMKMArray = new string[NBMKMData.Count];
                string[] SubCatagoryNBMArray = new string[NBMData.Count];
                string[] SubCatagoryNBMKMArray = new string[NBMKMData.Count];
                int j = 0, s = 0, p = 0;
                List<Division> NBMNavbarList = new List<Division>();
                List<Division> NBMKMNavbarList = new List<Division>();
                JsonResponseNavbar_NBM JsonResponseNavbar_NBM = new JsonResponseNavbar_NBM();
                List<dynamic> DataLst = new List<dynamic>();
                for (var i = 0; i < NBMData.Count; i++)
                {
                    var Division = NBMData[i].DivisionName;
                    var Catagory = NBMData[i].CatagoryName;
                    var Subcatagory = NBMData[i].SubcatagoryName;
                    //NBM Database Data
                    if (!Division.Contains(Division))
                    {
                        DivisionNBMArray[j] = Division;
                        j++;


                    }
                    if (!CatagoryNBMArray.Contains(Catagory))
                    {
                        CatagoryNBMArray[s] = Catagory;
                        s++;
                    }
                }
                foreach (string DivsionData in DivisionNBMArray)
                {
                    foreach (Navbar NavbarData in NBMData)
                    {
                        if (!SubCatagoryNBMArray.Contains(NavbarData.SubcatagoryName))
                        {

                            var divsion = NBMNavbarList.Where(x => x.DivisionId == NavbarData.DivisionId).FirstOrDefault();///.catagorylst;
                            if (divsion != null)
                            {
                                if (divsion.CatagoryList.Any(y => y.CatagoryId == NavbarData.CatagoryId))
                                {
                                    var divCat = divsion.CatagoryList.Where(y => y.CatagoryId == NavbarData.CatagoryId).FirstOrDefault();

                                    divCat.SubcatagoryList.Add(new Subcatagory
                                    {
                                        SubcatagoryName = NavbarData.SubcatagoryName,
                                        SubcatagoryId = NavbarData.SubcatagoryId
                                    });


                                }
                                else
                                {
                                    divsion.CatagoryList.Add(new Catagory
                                    {
                                        CatagoryName = NavbarData.CatagoryName,
                                        CatagoryId = NavbarData.CatagoryId,
                                        SubcatagoryList = new List<Subcatagory>()
                                                {
                                                     new Subcatagory
                                                     {
                                                               SubcatagoryName = NavbarData.SubcatagoryName,
                                                               SubcatagoryId = NavbarData.SubcatagoryId
                                                     }

                                                 }

                                    });
                                }
                            }
                            else
                            {
                                NBMNavbarList.Add(new Division
                                {
                                    DivisionName = NavbarData.DivisionName,
                                    DivisionId = NavbarData.DivisionId,
                                    CatagoryList = new List<Catagory>()
                                             {
                                                 new Catagory
                                                 {
                                                     CatagoryId = NavbarData.CatagoryId,
                                                     CatagoryName = NavbarData.CatagoryName,
                                                     SubcatagoryList = new  List <Subcatagory>()
                                                     {
                                                          new Subcatagory
                                                          {
                                                               SubcatagoryName = NavbarData.SubcatagoryName,
                                                               SubcatagoryId = NavbarData.SubcatagoryId
                                                          }

                                                     }
                                                 }
                                             }

                                });
                            }
                            SubCatagoryNBMArray[p] = NavbarData.SubcatagoryName;
                            p++;
                        }




                    }

                }
                if (NBMNavbarList != null)
                {
                    JsonResponseNavbar_NBM.Status = "true";
                    JsonResponseNavbar_NBM.DatabaseName = "NBM";
                    //JsonResponseNavbar_NBM.data1 = NBM;
                    JsonResponseNavbar_NBM.Data = NBMNavbarList;
                }
                else
                {

                    JsonResponseNavbar_NBM.Status = "false";
                    JsonResponseNavbar_NBM.DatabaseName = "null";
                    JsonResponseNavbar_NBM.Data = null;
                }
                if (JsonResponseNavbar_NBM != null)
                {
                    JsonResults JSONResponse = new JsonResults();
                    JSONResponse.Status = "true";
                    DataLst.Add(new { NBMData = JsonResponseNavbar_NBM });
                    JSONResponse.Data = DataLst;
                    return JSONResponse;
                }

                else
                {
                    JsonResults JSONResponse = new JsonResults();
                    JSONResponse.Status = "false";
                    JSONResponse.Data = null;

                    return JSONResponse;
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}


