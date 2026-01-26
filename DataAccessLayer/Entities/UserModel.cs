using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class UserModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        //name
        public string FirstName { get; set; }

        public string LastName { get; set; }

        //email
        public string Email { get; set; }

        //pasword
        public string Password { get; set; }  

        //bday

        public DateOnly Bday { get; set; }




    }
}
