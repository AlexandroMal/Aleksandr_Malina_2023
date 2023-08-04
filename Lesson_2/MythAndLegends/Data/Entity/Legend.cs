using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MythAndLegends.Data.Entity
{
    public class Legend : Story
    {
        public string Object { get; set; }

        public override void Tell()
        {
            Console.WriteLine($"Legend {StoryCode} - {Name} \n" +
                              $"Legend tells about {Object} \n" +
                              $"{Content}");
            base.Tell();
        }
    }
}
