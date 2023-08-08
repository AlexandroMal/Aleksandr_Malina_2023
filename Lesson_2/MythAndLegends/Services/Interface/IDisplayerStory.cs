using MythAndLegends.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MythAndLegends.Services.Interface
{
    interface IDisplayerStory
    {
        public void DisplayStoryByCode(string code);
        public Story? GetStoryByCode(string code);
    }
}
