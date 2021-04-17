using Entity.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities.Abstract
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public DateTime _createDate = DateTime.Now;
        public DateTime CreateDate 
        {
            get => _createDate;
            set => _createDate = value;
        }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeleteDate { get; set; }

        private Status _status = Status.Active;
        public Status Status { get; set; }

    }
}
