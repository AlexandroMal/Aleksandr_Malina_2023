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

        public override void AddStory()
        {
            Console.WriteLine("Enter name of the legend");
            var name = Console.ReadLine();
            Console.WriteLine("Enter object of the legend");
            var storyObject = Console.ReadLine();
            Console.WriteLine("Enter the story");
            var storyText = Console.ReadLine();


            this.Name = name;
            this.Object = storyObject;
            this.Content = storyText;
            
        }
    }
}
