using Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities.Concrete
{
    public class Article : BaseEntity
    {
        public string CategoryName { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public virtual List<Comment> Comments { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        [ForeignKey("Writer")]
        public int WriterId { get; set; }
        public virtual Writer Writer { get; set; }

        

    }
}
