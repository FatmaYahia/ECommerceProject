using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.AppModel
{
    public class Product : BaseModel
    {
        [Required(ErrorMessage ="Please fill this field")]
        [DisplayName("Product Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please fill this field")]
        [DisplayName("Product Price")]

        public decimal Price { get; set; }
        [DisplayName("Offer")]

        public int Offer { get; set; }
        [DisplayName("Description")]

        public string Description { get; set; }
        [DisplayName("Summary")]

        public string Summary { get; set; }
        [DisplayName("Product Image")]

        public string Cover { get; set; } = "";
        public List<ProductRating> Ratings { get; set; }
    }
}
