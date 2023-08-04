using MythAndLegends.Data;
using MythAndLegends.Data.Entity;
using MythAndLegends.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MythAndLegends.Services
{
    public class Displayer : IDisplay
    {

        //open-closed
        private readonly IStoryService _storyService;

        public Displayer()
        {
            _storyService = new StoryService();
        }

        public void DisplayByCode(string code)
        {
            var story = _storyService.GetStoryByCode(code);

            if (story is not null)
            {
                story.Tell();
            }
            else
            {
                Console.WriteLine($"No myth or legend with code {code}");
            }

        }

        public void AddNewStory()
        {
            Console.WriteLine("Enter story type (myth/legend)");
            var input = Console.ReadLine();

            if (input == "legend")
            {
                Console.WriteLine("Enter name of the legend");
                var name = Console.ReadLine();
                Console.WriteLine("Enter object of the legend");
                var storyObject = Console.ReadLine();
                Console.WriteLine("Enter the story");
                var storyText = Console.ReadLine();

                var story = new Legend()
                {
                    Name = name,
                    Object = storyObject,
                    Content = storyText
                };

                Storage.MythsAndLegends.Add(story);
            }
            else if (input == "myth")
            {
                Console.WriteLine("Enter name of the myth");
                var name = Console.ReadLine();
                Console.WriteLine("Enter the story");
                var storyText = Console.ReadLine();
                Console.WriteLine("Enter some fact");
                var fact = Console.ReadLine();

                var story = new Myth()
                {
                    Name = name,
                    Fact = fact,
                    Content = storyText
                };

                Storage.MythsAndLegends.Add(story);
            }
            else
            {
                Console.WriteLine("Oops, wrong input");
            }
            
        }
    }

}
