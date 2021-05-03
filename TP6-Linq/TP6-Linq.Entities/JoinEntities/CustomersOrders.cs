using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6_Linq.Entities
{
    public partial class CustomersOrders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomersOrders()
        {

        }

        [StringLength(5)]
        public string CustomerID { get; set; }

        [StringLength(30)]
        public string ContactName { get; set; }

        public int OrderID { get; set; }

        public int OrderAmount { get; set; }
    }
}
