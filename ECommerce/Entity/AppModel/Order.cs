using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.AppModel
{
    public class Order : BaseModel
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
        [DisplayName("Status")]
        public int Status { get; set; }
        [DisplayName("Quantity")]
        public int Quantity { get; set; }
        [DisplayName("Total Price")]

        public decimal TotalPrice { get; set; }
        [DisplayName("Order Date")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime OrderDate { get; set; }
    }
}
