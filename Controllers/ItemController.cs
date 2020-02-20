//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Net.Http.Headers;
//using System.Text.Json;
//using System.Threading.Tasks;
//using System.Web.Http.Description;
//using ItemLatest.Models;
//using ItemLatest.Repository;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Nancy.Json;

//using System.Text.Json.Serialization;
//using Newtonsoft.Json;
//using Microsoft.Extensions.Options;

//namespace ItemLatest.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ItemController : ControllerBase
//    {
//        IItemRepository itemRepository;

//        public ItemController(IItemRepository _itemRepository)
//        {
//            itemRepository = _itemRepository;
//        }

//        [HttpGet]
//        [Route("GetItemTypes")]
//        public async Task<IActionResult> GetItemTypes(int id)
//        {
//            try
//            {
//                var categories = await itemRepository.GetItemTypes(id);


//                if (categories == null)
//                {
//                    return NotFound();
//                }

//                return Ok(categories);
//            }
//            catch (Exception Ex)
//            {
//                throw Ex;

//            }

//        }
//        [HttpGet]
//        [Route("GetNavbarDetails")]
//        public JsonResults GetItemDetails()
//        {

//            try
//            {
//                var NBMData = itemRepository.NavbarDataNBM();
//                var NBMKMData = itemRepository.GetNavbarDetails_Km();
//                int count = NBMData.Count;
//                string[] Division = new string[count];
//                string[] Division_km = new string[NBMKMData.Count];
//                string[] Catagory = new string[count];
//                string[] Catagory_km = new string[NBMKMData.Count];
//                string[] SubCatagory = new string[count];
//                string[] SubCatagory_km = new string[NBMKMData.Count];
//                string[] Result = new string[count];

//                int j = 0, s = 0, p = 0;
//                JsonResponseNavbar_NBM JsonResponseNavbar_NBM = new JsonResponseNavbar_NBM();
//                JsonResponseNavbar_NBMKM JsonResponseNavbar_NBMKM = new JsonResponseNavbar_NBMKM();
//                Dictionary<object, Dictionary<object, List<object>>> DivNbm = new Dictionary<object, Dictionary<object, List<object>>>();
//                Dictionary<dynamic, Dictionary<dynamic, List<dynamic>>> NBM = new Dictionary<dynamic, Dictionary<dynamic, List<dynamic>>>();
//                List<Division> nbm_cat = new List<Division>();
//                List<Division> NavbarData_km = new List<Division>();
//                List<List<dynamic>> gg = new List<List<dynamic>>();
//                Dictionary<dynamic, Dictionary<dynamic, List<dynamic>>> NBM_Km = new Dictionary<dynamic, Dictionary<dynamic, List<dynamic>>>();
//                Dictionary<object, Dictionary<object, List<object>>> Div_km = new Dictionary<object, Dictionary<object, List<object>>>();
//                List<dynamic> DataLst = new List<dynamic>();
//                gg.Add(new List<dynamic> { "a", "b" });


//                ////var cat = NBMData.Select(x => new { x.catagory, x.catagory_id }).Distinct().ToList();
//                ////var items = NBMData.Select(item => new Division
//                ////{
//                ////    division = item.division,
//                ////    catagorylst = item.

//                ////}).ToList();
//                for (var i = 0; i < NBMData.Count; i++)
//                {
//                    var Costcentrename = NBMData[i].division;
//                    var cat = NBMData[i].catagory;
//                    var subcat = NBMData[i].subcatagory;


//                    if (!Division.Contains(Costcentrename))
//                    {
//                        Division[j] = Costcentrename;
//                        j++;


//                    }
//                    if (!Catagory.Contains(cat))
//                    {
//                        Catagory[s] = cat;
//                        s++;
//                    }
//                }
//                j = 0;
//                for (var i = 0; i < NBMKMData.Count; i++)
//                {
//                    j = 0;
//                    s = 0; 
//                    p = 0;
//                    var Costcentrename_km = NBMKMData[i].division;
//                    var cat_km = NBMKMData[i].catagory;
//                    var subcat_km = NBMKMData[i].subcatagory;


//                    if (!Division_km.Contains(Costcentrename_km))
//                    {
//                        Division_km[j] = Costcentrename_km;
//                        j++;


//                    }
//                    if (!Catagory.Contains(cat_km))
//                    {
//                        Catagory[s] = cat_km;
//                        s++;
//                    }
//                }


//                foreach (string Divs in Division)
//                {
//                    if (Divs != null)
//                    {
//                        p = 0;
//                        Array.Clear(SubCatagory, 0, SubCatagory.Length);

//                        foreach (ItemCatDetails category in NBMData)
//                        {
//                            if (!SubCatagory.Contains(category.subcatagory))
//                            {
//                                ////var divCat = NBMData.Where (x=>x.division == Divs && ).any()

//                                if (Divs == category.division)
//                                {

//                                    if (DivNbm.ContainsKey(category.division))
//                                    {
//                                        if (DivNbm[category.division].ContainsKey(category.catagory))
//                                        {
//                                            DivNbm[category.division][category.catagory].Add(category.subcatagory);
//                                            NBM[new { category.division, category.division_id }][new { category.catagory, category.catagory_id }].Add(new { category.subcatagory, category.subcatagory_id });


//                                        }
//                                        else
//                                        {
//                                            DivNbm[category.division].Add(category.catagory, new List<object>());
//                                            DivNbm[category.division][category.catagory].Add(category.subcatagory);
//                                            NBM[new { category.division, category.division_id }].Add(new { category.catagory, category.catagory_id }, new List<dynamic>());
//                                            NBM[new { category.division, category.division_id }][new { category.catagory, category.catagory_id }].Add(new { category.subcatagory, category.subcatagory_id });


//                                        }
//                                        var div = nbm_cat.Where(x => x.division_id == category.division_id).FirstOrDefault();///.catagorylst;
//                                        if (div != null && div.catagorylst.Any(y => y.catagory_id == category.catagory_id))
//                                        {
//                                            var divCat = div.catagorylst.Where(y => y.catagory_id == category.catagory_id).FirstOrDefault();
                                            
//                                                divCat.subcatagorylst.Add(new Subcatagory
//                                                {
//                                                    subcatagory = category.subcatagory,
//                                                    subcatagory_id = category.subcatagory_id
//                                                });
                                            
                                            
//                                        }
//                                        else
//                                        {
//                                            div.catagorylst.Add(new Catagory
//                                            {
//                                                catagory = category.catagory,
//                                                catagory_id = category.catagory_id,
//                                                subcatagorylst = new List<Subcatagory>()
//                                                {
//                                                     new Subcatagory
//                                                          {
//                                                               subcatagory = category.subcatagory,
//                                                               subcatagory_id = category.subcatagory_id
//                                                          }

//                                                 }


//                                            });
//                                        }



//                                    }
//                                    else
//                                    {
//                                        DivNbm.Add(category.division, new Dictionary<object, List<object>>());
//                                        DivNbm[category.division].Add(category.catagory, new List<object>());
//                                        DivNbm[category.division][category.catagory].Add(category.subcatagory);
//                                        NBM.Add(new { category.division, category.division_id }, new Dictionary<dynamic, List<dynamic>>());
//                                        NBM[new { category.division, category.division_id }].Add(new { category.catagory, category.catagory_id }, new List<dynamic>());
//                                        NBM[new { category.division, category.division_id }][new { category.catagory, category.catagory_id }].Add(new { category.subcatagory, category.subcatagory_id });

//                                        nbm_cat.Add(new Division
//                                        {
//                                            division = category.division,
//                                            division_id = category.division_id,
//                                            catagorylst = new List<Catagory>()
//                                             {
//                                                 new Catagory
//                                                 {
//                                                     catagory_id = category.catagory_id,
//                                                     catagory = category.catagory,
//                                                     subcatagorylst = new  List <Subcatagory>()
//                                                     {
//                                                          new Subcatagory
//                                                          {
//                                                               subcatagory = category.subcatagory,
//                                                               subcatagory_id = category.subcatagory_id
//                                                          }

//                                                     }
//                                                 }
//                                             }

//                                        });
//                                    }

//                                }

//                                SubCatagory[p] = category.subcatagory;
//                                p++;
//                            }

//                        }

//                    }

//                }
//                foreach (string Divs in Division_km)
//                {
//                    if (Divs != null)
//                    {
//                        p = 0;
//                        Array.Clear(SubCatagory_km, 0, SubCatagory_km.Length);

//                        foreach (ItemCatDetails category_km in NBMKMData)
//                        {
//                            if (!SubCatagory_km.Contains(category_km.subcatagory))
//                            {
//                                if (Divs == category_km.division)
//                                {

//                                    if (Div_km.ContainsKey(category_km.division))
//                                    {
//                                        if (Div_km[category_km.division].ContainsKey(category_km.catagory))
//                                        {
//                                            Div_km[category_km.division][category_km.catagory].Add(category_km.subcatagory);
//                                            NBM_Km[new { category_km.division, category_km.division_id }][new { category_km.catagory, category_km.catagory_id }].Add(new { category_km.subcatagory, category_km.subcatagory_id });
//                                        }
//                                        else
//                                        {
//                                            Div_km[category_km.division].Add(category_km.catagory, new List<object>());
//                                            Div_km[category_km.division][category_km.catagory].Add(category_km.subcatagory);
//                                            NBM_Km[new { category_km.division, category_km.division_id }].Add(new { category_km.catagory, category_km.catagory_id }, new List<dynamic>());
//                                            NBM_Km[new { category_km.division, category_km.division_id }][new { category_km.catagory, category_km.catagory_id }].Add(new { category_km.subcatagory, category_km.subcatagory_id });

//                                        }
//                                        var DivisionKM = NavbarData_km.Where(x => x.division_id == category_km.division_id).FirstOrDefault();
//                                        if (DivisionKM != null && DivisionKM.catagorylst.Any(y => y.catagory == category_km.catagory))
//                                        {
//                                            var CatagoryKM = DivisionKM.catagorylst.Where(y => y.catagory_id == category_km.catagory_id).FirstOrDefault();
//                                            CatagoryKM.subcatagorylst.Add(new Subcatagory
//                                            {
//                                                subcatagory = category_km.subcatagory,
//                                                subcatagory_id = category_km.subcatagory_id
//                                            });
//                                        }
//                                        else
//                                        {
//                                            DivisionKM.catagorylst.Add(new Catagory
//                                            {
//                                                catagory = category_km.catagory,
//                                                catagory_id = category_km.catagory_id,
//                                                subcatagorylst = new List<Subcatagory>()
//                                                {
//                                                     new Subcatagory
//                                                          {
//                                                               subcatagory = category_km.subcatagory,
//                                                               subcatagory_id = category_km.subcatagory_id
//                                                          }

//                                                 }


//                                            });
//                                        }
//                                    }
//                                    else
//                                    {
//                                        Div_km.Add(category_km.division, new Dictionary<object, List<object>>());
//                                        Div_km[category_km.division].Add(category_km.catagory, new List<object>());
//                                        Div_km[category_km.division][category_km.catagory].Add(category_km.subcatagory);
//                                        NBM_Km.Add(new { category_km.division, category_km.division_id }, new Dictionary<dynamic, List<dynamic>>());
//                                        NBM_Km[new { category_km.division, category_km.division_id }].Add(new { category_km.catagory, category_km.catagory_id }, new List<dynamic>());
//                                        NBM_Km[new { category_km.division, category_km.division_id }][new { category_km.catagory, category_km.catagory_id }].Add(new { category_km.subcatagory, category_km.subcatagory_id });
//                                        NavbarData_km.Add(new Division
//                                        {
//                                            division = category_km.division,
//                                            division_id = category_km.division_id,
//                                            catagorylst = new List<Catagory>()
//                                             {
//                                                 new Catagory
//                                                 {
//                                                     catagory_id = category_km.catagory_id,
//                                                     catagory = category_km.catagory,
//                                                     subcatagorylst = new  List <Subcatagory>()
//                                                     {
//                                                          new Subcatagory
//                                                          {
//                                                               subcatagory = category_km.subcatagory,
//                                                               subcatagory_id = category_km.subcatagory_id
//                                                          }

//                                                     }
//                                                 }
//                                             }

//                                        });
//                                    }

//                                }

//                                SubCatagory_km[p] = category_km.subcatagory;
//                                p++;
//                            }

//                        }

//                    }

//                }
//                if (NBM != null)
//                {

//                    JsonResponseNavbar_NBM.status = "true";
//                    JsonResponseNavbar_NBM.databasename = "NBM";
//                   //JsonResponseNavbar_NBM.data1 = NBM;
//                    JsonResponseNavbar_NBM.data = nbm_cat;
//                }
//                else
//                {

//                    JsonResponseNavbar_NBM.status = "false";
//                    JsonResponseNavbar_NBM.databasename = "null";
//                    JsonResponseNavbar_NBM.data = null;
//                }
//                if (NBM_Km != null)
//                {

//                    JsonResponseNavbar_NBMKM.status = "true";
//                    JsonResponseNavbar_NBMKM.databaseName = "NBMKM";
//                    JsonResponseNavbar_NBMKM.data = NavbarData_km;
//                }
//                else
//                {

//                    JsonResponseNavbar_NBMKM.status = "false";
//                    JsonResponseNavbar_NBMKM.databaseName = "null";
//                    JsonResponseNavbar_NBMKM.data = null;
//                }



//                if (JsonResponseNavbar_NBM != null || JsonResponseNavbar_NBMKM != null)
//                {
//                    JsonResults JSONResponse = new JsonResults();
//                    JSONResponse.status = "true";
//                    DataLst.Add(new { NBM_data = JsonResponseNavbar_NBM, NBMKM_data = JsonResponseNavbar_NBMKM });
//                    JSONResponse.data = DataLst;
//                    return JSONResponse;
//                }

//                else
//                {
//                    JsonResults JSONResponse = new JsonResults();
//                    JSONResponse.status = "false";
//                    JSONResponse.data = null;

//                    return JSONResponse;
//                }


//            }




//            catch (Exception Ex)
//            {
//                throw Ex;
//                //return BadRequest();
//            }

//        }
//        [HttpGet]
//        [Route("GetAllDivisions")]
//        public JsonResults GetAllDivisions()
//        {
//            try
//            {
//                var Alldivisions = itemRepository.GetAllDivisions();
//                var Alldivisons_km = itemRepository.GetAllDivisions_km();
//                var i = 0;
//                int count = Alldivisions.Count();
//                var lstAlldivisions = new List<dynamic>();
//                var lstAlldivisions_km = new List<dynamic>();
//                var lstData = new List<dynamic>();
//                JSONResponse_NBM JSONResponse_NBM = new JSONResponse_NBM();
//                JSONResponse_NBMkm JSONResponse_NBMkm = new JSONResponse_NBMkm();

//                foreach (CostCentre cost in Alldivisions)
//                {
//                    lstAlldivisions.Add(new { division_id = cost.CostCentreId, division = cost.CostCentreName });
//                    JSONResponse_NBM.status = "true";
//                    JSONResponse_NBM.databasename = "NBM";
//                    JSONResponse_NBM.data = lstAlldivisions;
//                    i++;
//                }
//                foreach (CostCentre cost in Alldivisons_km)
//                {
//                    lstAlldivisions_km.Add(new { division_id = cost.CostCentreId, division = cost.CostCentreName });
//                    JSONResponse_NBMkm.status = "true";
//                    JSONResponse_NBMkm.databasename = "NBMKM";
//                    JSONResponse_NBMkm.data = lstAlldivisions_km;
//                    i++;
//                }
//                if (Alldivisions.Count != 0 || Alldivisons_km.Count != 0)
//                {
//                    JsonResults JSONResponse = new JsonResults();
//                    JSONResponse.status = "true";
//                    lstData.Add(new { NBM_data = JSONResponse_NBM, NBMKM_data = JSONResponse_NBMkm });
//                    JSONResponse.data = lstData;
//                    //JSONResponse.DatabaseName = "NBM";
//                    string json = JsonConvert.SerializeObject(JSONResponse);
//                    JsonResults response = JsonConvert.DeserializeObject<JsonResults>(json);
//                    return response;
//                }
//                else
//                {
//                    JsonResults JSONResponse = new JsonResults();
//                    JSONResponse.status = "false";
//                    JSONResponse.data = null;
//                    //  JSONResponse.DatabaseName = null;
//                    string json = JsonConvert.SerializeObject(JSONResponse);
//                    JsonResults response = JsonConvert.DeserializeObject<JsonResults>(json);
//                    return response;
//                }
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }


//        }
//        [HttpGet]
//        [Route("GetItemDetailsdata")]
//        public JsonResults GetItemDetailsdata()
//        {
//            try
//            {
//                var Items = itemRepository.GetItemDetailsdata();
//                var Items_km = itemRepository.GetItemDetailsdata_km();
//                var Itemlst = new List<dynamic>();
//                var Itemlst_km = new List<dynamic>();
//                var DataLst = new List<dynamic>();
//                JSONResponse_NBM JSONResponse_NBM = new JSONResponse_NBM();
//                JSONResponse_NBMkm JSONResponse_NBMkm = new JSONResponse_NBMkm();
//                var i = 0;
//                foreach (Items item in Items)
//                {
//                    Itemlst.Add(new { item.ItemId, item.ItemName, item.ItemPrice });
//                    JSONResponse_NBM.status = "true";
//                    JSONResponse_NBM.databasename = "NBM";
//                    JSONResponse_NBM.data = Itemlst;
//                    i++;
//                }
//                foreach (Items item in Items_km)
//                {
//                    Itemlst_km.Add(new { item.ItemId, item.ItemName, item.ItemPrice });
//                    JSONResponse_NBMkm.status = "true";
//                    JSONResponse_NBMkm.databasename = "NBMKM";
//                    JSONResponse_NBMkm.data = Itemlst_km;
//                    i++;
//                }
//                if (Items.Count != 0 || Items_km.Count != 0)
//                {
//                    JsonResults JSONResponse = new JsonResults();
//                    JSONResponse.status = "true";
//                    DataLst.Add(new { NBM_data = Itemlst, NBMKM_data = Itemlst_km });
//                    JSONResponse.data = DataLst;
//                    string json = JsonConvert.SerializeObject(JSONResponse);
//                    JsonResults response = JsonConvert.DeserializeObject<JsonResults>(json);
//                    return response;
//                }
//                else
//                {
//                    JsonResults JSONResponse = new JsonResults();
//                    JSONResponse.status = "false";
//                    JSONResponse.data = null;
//                    // JSONResponse.DatabaseName = null;
//                    string json = JsonConvert.SerializeObject(JSONResponse);
//                    JsonResults response = JsonConvert.DeserializeObject<JsonResults>(json);
//                    return response;
//                }

//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }

//        }

//        //[HttpGet]
//        [Route("GetDisionId")]
//        public string GetDisionId(int id)
//        {


//            try
//            {

//                var Alldivisions = itemRepository.GetDisionId(id);
//                var i = 0;
//                int count = Alldivisions.Count();
//                var list = new List<dynamic>();
//                foreach (CostCentre cost in Alldivisions)
//                {
//                    list.Add(new { Division_Id = cost.CostCentreId, Division = cost.CostCentreName });
//                    i++;
//                }
//                //  var json = JsonConvert.SerializeObject(list);
//                string json = "";

//                return json;
//            }


//            catch (Exception Ex)
//            {
//                throw Ex;

//            }

//        }
//        [Route("GetDisionbyCat")]
//        public JsonResults GetDisionbyCat(int id, string db)
//        {
//            try
//            {
//                int s = Convert.ToInt32(id);
//                var Dividbycat = itemRepository.GetDisionbyCat(id);
//                var Dividbycat_km = itemRepository.GetDisionbyCat_km(id);
//                var i = 0;
//                var list = new List<dynamic>();
//                var list_km = new List<dynamic>();
//                var lstData = new List<dynamic>();
//                JSONResponse_NBM JSONResponse_NBM = new JSONResponse_NBM();
//                JSONResponse_NBMkm JSONResponse_NBMkm = new JSONResponse_NBMkm();

//                foreach (ItemCatDetails ItemCatDetails in Dividbycat)
//                {
//                    JSONResponse_NBM.status = "true";
//                    JSONResponse_NBM.databasename = "NBM";
//                    list.Add(new { catagory_id = ItemCatDetails.catagory_id, catagory = ItemCatDetails.catagory });
//                    JSONResponse_NBM.data = list;
//                    i++;

//                }
//                foreach (ItemCatDetails ItemCatDetails in Dividbycat_km)
//                {
//                    list_km.Add(new { catagory_id = ItemCatDetails.catagory_id, catagory = ItemCatDetails.catagory });
//                    JSONResponse_NBMkm.status = "true";
//                    JSONResponse_NBMkm.databasename = "NBMKM";
//                    JSONResponse_NBMkm.data = list_km;
//                    i++;

//                }
//                if (db == "NBM" && Dividbycat.Count != 0)
//                {
//                    JsonResults JSONResponse = new JsonResults();
//                    JSONResponse.status = "true";
//                    lstData.Add(new { NBM_data = JSONResponse_NBM });
//                    JSONResponse.data = lstData;
//                    string json = JsonConvert.SerializeObject(JSONResponse);
//                    JsonResults response = JsonConvert.DeserializeObject<JsonResults>(json);
//                    return response;
//                }
//                else if (db == "NBMKM" && Dividbycat_km.Count != 0)
//                {
//                    JsonResults JSONResponse = new JsonResults();
//                    JSONResponse.status = "true";
//                    lstData.Add(new { NBMKM_data = JSONResponse_NBMkm });
//                    JSONResponse.data = lstData;
//                    string json = JsonConvert.SerializeObject(JSONResponse);
//                    JsonResults response = JsonConvert.DeserializeObject<JsonResults>(json);
//                    return response;
//                }

//                else
//                {
//                    JsonResults JSONResponse = new JsonResults();
//                    JSONResponse.status = "false";
//                    JSONResponse.data = null;
//                    //JSONResponse.DatabaseName = null;
//                    string json = JsonConvert.SerializeObject(JSONResponse);
//                    JsonResults response = JsonConvert.DeserializeObject<JsonResults>(json);
//                    return response;
//                }

//            }
//            catch (Exception Ex)
//            {
//                throw Ex;

//            }


//        }
//        [HttpGet]
//        [Route("GetcatidbySubcat")]
//        public JsonResults GetcatidbySubcat(int? id, string db)
//        {

//            try
//            {

//                int s = Convert.ToInt32(id);

//                var Allsubcat = itemRepository.GetcatidbySubcat(s);
//                var Allsubcat_km = itemRepository.GetcatidbySubcat_km(s);
//                var i = 0;
//                var list = new List<dynamic>();
//                var list_km = new List<dynamic>();
//                var lstData = new List<dynamic>();
//                JSONResponse_NBM JSONResponse_NBM = new JSONResponse_NBM();
//                JSONResponse_NBMkm JSONResponse_NBMkm = new JSONResponse_NBMkm();
//                foreach (ItemCatDetails ItemCatDetails in Allsubcat)
//                {
//                    list.Add(new { subcatagory_id = ItemCatDetails.subcatagory_id, subcatagory = ItemCatDetails.subcatagory });
//                    JSONResponse_NBM.status = "true";
//                    JSONResponse_NBM.databasename = "NBM";
//                    JSONResponse_NBM.data = list;
//                    i++;

//                }
//                foreach (ItemCatDetails ItemCatDetails in Allsubcat_km)
//                {
//                    list_km.Add(new { subcatagory_id = ItemCatDetails.subcatagory_id, subcatagory = ItemCatDetails.subcatagory });
//                    JSONResponse_NBMkm.status = "true";
//                    JSONResponse_NBMkm.databasename = "NBMKM";
//                    JSONResponse_NBMkm.data = list_km;
//                    i++;

//                }
//                if (db == "NBM" && Allsubcat.Count != 0)
//                {

//                    JsonResults JSONResponse = new JsonResults();
//                    JSONResponse.status = "true";
//                    lstData.Add(new { NBM_data = JSONResponse_NBM });

//                    JSONResponse.data = lstData;
//                    //JSONResponse.DatabaseName = "NBM";
//                    string json = JsonConvert.SerializeObject(JSONResponse);
//                    JsonResults response = JsonConvert.DeserializeObject<JsonResults>(json);
//                    return response;
//                }
//                else if (db == "NBMKM" && Allsubcat_km.Count != 0)
//                {
//                    JsonResults JSONResponse = new JsonResults();
//                    JSONResponse.status = "true";

//                    lstData.Add(new { NBMKM_data = JSONResponse_NBMkm });
//                    JSONResponse.data = lstData;
//                    //JSONResponse.DatabaseName = "NBM";
//                    string json = JsonConvert.SerializeObject(JSONResponse);
//                    JsonResults response = JsonConvert.DeserializeObject<JsonResults>(json);
//                    return response;
//                }
//                else
//                {
//                    JsonResults JSONResponse = new JsonResults();
//                    JSONResponse.status = "false";
//                    JSONResponse.data = null;
//                    //JSONResponse.DatabaseName = null;
//                    string json = JsonConvert.SerializeObject(JSONResponse);
//                    JsonResults response = JsonConvert.DeserializeObject<JsonResults>(json);
//                    return response;
//                }


//            }
//            catch (Exception Ex)
//            {
//                throw Ex;

//            }


//        }
//        [HttpGet]
//        [Route("GetProperties")]
//        public JSONResponse GetProperties(int? id, string db)
//        {
//            try
//            {
//                var subid = Convert.ToInt32(id);
//                var GetProperties = itemRepository.GetProperties(subid);
//                var GetProperties_km = itemRepository.GetProperties_km(subid);
//                var LstProperties = new List<dynamic>();
//                var LstProperties_km = new List<dynamic>();
//                var lstData = new List<dynamic>();
//                JSONResponse_NBM JSONResponse_NBM = new JSONResponse_NBM();
//                JSONResponse_NBMkm JSONResponse_NBMkm = new JSONResponse_NBMkm();
//                var i = 0;
//                foreach (ItemCategories ItemCat in GetProperties)
//                {
//                    LstProperties.Add(new { itemCateg_id = ItemCat.ItemCategId, itemCateg_name = ItemCat.ItemCategName });
//                    JSONResponse_NBM.status = "true";
//                    JSONResponse_NBM.databasename = "NBM";
//                    JSONResponse_NBM.data = LstProperties;
//                    i++;
//                }
//                foreach (ItemCategories ItemCat in GetProperties_km)
//                {
//                    LstProperties_km.Add(new { itemCateg_id = ItemCat.ItemCategId, itemCateg_name = ItemCat.ItemCategName });
//                    JSONResponse_NBMkm.status = "true";
//                    JSONResponse_NBMkm.databasename = "NBMKM";
//                    JSONResponse_NBMkm.data = LstProperties_km;
//                    i++;
//                }

//                if (db == "NBM" && GetProperties.Count != 0)
//                {
//                    JsonResults JSONResponse = new JsonResults();
//                    JSONResponse.status = "true";
//                    lstData.Add(new { NBM_data = JSONResponse_NBM });
//                    JSONResponse.data = lstData;
//                    string json = JsonConvert.SerializeObject(JSONResponse);
//                    JSONResponse response = JsonConvert.DeserializeObject<JSONResponse>(json);
//                    return response;
//                }
//                else if (db == "NBMKM" && GetProperties_km.Count != 0)
//                {
//                    JsonResults JSONResponse = new JsonResults();
//                    JSONResponse.status = "true";
//                    lstData.Add(new { NBMKM_data = JSONResponse_NBMkm });
//                    JSONResponse.data = lstData;
//                    string json = JsonConvert.SerializeObject(JSONResponse);
//                    JSONResponse response = JsonConvert.DeserializeObject<JSONResponse>(json);
//                    return response;
//                }
//                else
//                {
//                    JSONResponse JSONResponse = new JSONResponse();
//                    JSONResponse.status = "false";
//                    // JSONResponse.DatabaseName = null;
//                    string json = JsonConvert.SerializeObject(JSONResponse);
//                    JSONResponse response = JsonConvert.DeserializeObject<JSONResponse>(json);
//                    return response;
//                }
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }
//        }

//        [Route("AddItems")]
//        [HttpPost]
//        public void InsertCustomer([FromBody] testcustomer testcustomer)
//        {

//            using (NBMKMDbContext NBMKMDbContext = new NBMKMDbContext())
//            {
//                NBMKMDbContext.Add(testcustomer);
//                NBMKMDbContext.SaveChanges();
//            }


//        }

//    }
//}


