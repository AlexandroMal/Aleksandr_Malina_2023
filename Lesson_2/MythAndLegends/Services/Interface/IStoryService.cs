using MythAndLegends.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MythAndLegends.Services.Interface
{
    interface IStoryService
    {
        public void AddNewStory(Story story);
        public Story? GetStoryByCode(string code);
    }
}
