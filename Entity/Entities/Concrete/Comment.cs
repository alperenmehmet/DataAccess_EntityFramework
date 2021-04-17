using Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities.Concrete
{
    public class Comment: BaseEntity
    {
        public string Description { get; set; }

        [ForeignKey("AppUser")]
        public int AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }

        [ForeignKey("Article")]
        public int ArticleId { get; set; }
        public virtual Article Article { get; set; }

        

        
    }
}
