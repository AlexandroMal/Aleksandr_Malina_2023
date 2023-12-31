﻿using System;
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

        public override void AddStory()
        {
            Console.WriteLine("Enter name of the myth");
            var name = Console.ReadLine();
            Console.WriteLine("Enter the story");
            var storyText = Console.ReadLine();
            Console.WriteLine("Enter some fact");
            var fact = Console.ReadLine();

            this.Name = name;
            this.Fact = fact;
            this.Content = storyText;
            
        }
    }
}
