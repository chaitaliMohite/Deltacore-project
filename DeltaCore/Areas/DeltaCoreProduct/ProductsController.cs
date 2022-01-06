using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel;
using BusinessRepository;

namespace DeltaCore.Areas.DeltaCoreProduct.Controllers
{
    public class ProductsController : Controller
    {
        Repository repository = new Repository();
        // GET: DeltaCoreProduct/Products
        public ActionResult index()
        {
            return View();
        }
     
        public JsonResult GetProduct()
        {
            List<VmProduct> vmproductlist = new List<VmProduct>();
            try
            {
                vmproductlist = repository.GetProduct();
            }
            catch(Exception ex)
            {
                vmproductlist = new List<VmProduct>();
            }
            return Json(new { data = vmproductlist }, JsonRequestBehavior.AllowGet);
        }
    }
}