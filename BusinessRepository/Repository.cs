using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DataContext;
using ViewModel;

namespace BusinessRepository
{
    public class Repository
    {
        DeltaWareProductEntities db = new DeltaWareProductEntities();
        #region Product
        public List<VmProduct> GetProduct()
        {
            List<VmProduct> vmproductlist = (from p in db.Products
                                             select new VmProduct
                                             {
                                                 ProductID = p.ProductID,
                                                 Name = p.Name,
                                                 Description = p.Description
                                             }).ToList();
            return vmproductlist;
        }
    }
}
#endregion