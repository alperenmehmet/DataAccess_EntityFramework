using Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities.Concrete
{
    public class Writer: BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get;set; }
        public string Email { get;set; }
        public string Password { get;set; }

        public virtual List<Article> Articles { get; set; }
        

        
    }
}
