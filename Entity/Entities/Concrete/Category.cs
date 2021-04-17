using Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities.Concrete
{
    public class Category: BaseEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public virtual List<Article> Articles { get; set; }
    }
}
