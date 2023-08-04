using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MythAndLegends.Data.Entity
{
    public class Myth : Story
    {
        public string Fact { get; set; }

        public override void Tell()
        {
            Console.WriteLine($"Myth {StoryCode} - {Name} \n" +
                              $"{Content} \n" +
                              $"Fact: {Fact}");
            base.Tell();
        }
    }
}
