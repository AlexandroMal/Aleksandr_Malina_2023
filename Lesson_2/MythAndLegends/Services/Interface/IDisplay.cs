using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MythAndLegends.Services.Interface
{
    interface IDisplay
    {
        public void DisplayByCode(string code);
        public void AddNewStory();
    }
}
