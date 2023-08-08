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
    class CreatorStory : ICreatorStory
    {
        public void AddNewStory(Story story)
        {
            try
            {
                story.AddStory();

                if (string.IsNullOrEmpty(story.StoryCode))
                {
                    story.StoryCode = CreateCode(story.Name);
                }

                Storage.MythsAndLegends.Add(story);
            }
            catch
            {
                Console.WriteLine("Oops, wrong input");
            }

            Console.WriteLine("Story saved!");
        }

        private string CreateCode(string name)
        {
            var code = $"{name.First()}{name.Last()}-{name.Length}";

            return code;
        }
    }
}
