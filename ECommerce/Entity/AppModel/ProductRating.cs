using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.AppModel
{
    public class ProductRating : BaseModel
    {
        [ForeignKey(nameof(User))]
        [DisplayName("User")]

        public int Fk_user { get; set; }
        [DisplayName("User")]
        public User User { get; set; }
        [ForeignKey(nameof(Product))]
        [DisplayName("Product")]

        public int Fk_Product { get; set; }
        [DisplayName("Product")]
        public Product Product { get; set; }
        [DisplayName("Rate")]
        public int Rate { get; set; }
    }
}
