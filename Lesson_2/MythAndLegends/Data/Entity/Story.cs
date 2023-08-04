using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MythAndLegends.Data.Entity
{
    public abstract class Story
    {
        public string StoryCode { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }

        public virtual void Tell()
        {
            Console.WriteLine("------------------------------");
        }
    }
}
