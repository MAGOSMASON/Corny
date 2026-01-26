using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class FarmModel
    {
        //farmid
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FarmId { get; set; }

        //name
        public String Name { get; set; }


        //description
        public String Description { get; set; }

        //location
        public String Location { get; set; }

      



    }
}
