using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.AppModel
{
    public class User : AccountModel
    {
        [DisplayName("Address")]
        public string Address { get; set; }
        public List<ProductRating> Ratings { get; set; }
        public List<Order> Orders { get; set; }
    }
}
