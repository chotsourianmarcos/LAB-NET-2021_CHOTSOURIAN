using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6_Linq.Entities.JoinEntities
{
    public partial class ProductsCategories
    {
        public ProductsCategories()
        {

        }
        public int ProductID { get; set; }

        [StringLength(40)]
        public string ProductName { get; set; }
        public int CategoryID { get; set; }

        [StringLength(15)]
        public string CategoryName { get; set; }
    }
}
