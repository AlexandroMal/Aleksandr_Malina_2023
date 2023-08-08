using MythAndLegends.Data.Entity;
using MythAndLegends.Services;
using System.ComponentModel.DataAnnotations;

CreatorStory creator = new CreatorStory();
DisplayerStory displayer = new DisplayerStory();

Myth myth = new Myth();
Legend legend = new Legend();

displayer.DisplayStoryByCode("MGL");
creator.AddNewStory(myth);
creator.AddNewStory(legend);
displayer.DisplayStoryByCode("sg-4");
