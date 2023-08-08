using MythAndLegends.Data.Entity;
using MythAndLegends.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MythAndLegends.Services.Interface;

namespace MythAndLegends.Services
{
    class DisplayerStory : IDisplayerStory
    {
        public void DisplayStoryByCode(string code)
        {
            var story = GetStoryByCode(code);

            if (story is not null)
            {
                story.Tell();
            }
            else
            {
                Console.WriteLine($"No myth or legend with code {code}");
            }
        }

        public Story? GetStoryByCode(string code)
        {
            return Storage.MythsAndLegends.FirstOrDefault(x => x.StoryCode.Equals(code));
        }
    }
}
