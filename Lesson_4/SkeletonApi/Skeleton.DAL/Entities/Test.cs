using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skeleton.DAL.Entities
{
    public class Test : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid CreadtedForUserId { get; set; }

        public virtual User? User { get; set; }
        public virtual ICollection<Question>? Questions { get; set; } 
    }

}
