using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class ProductModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProdcutId { get; set; }

        //name
        public String Name { get; set; }

        //farmid
        public int FarmId { get; set; }


        //description
        public String Description { get; set; }

        //price
        public Decimal Price { get; set; }

        //Avilible
        public Boolean IsAvalible { get; set; }

        //category
        public String Category { get; set; }

        //subcatergory
        public String SubCategory { get; set; }

        //quantityAvalible
        public int QuantityAvalible { get; set; }

   

    }
}
