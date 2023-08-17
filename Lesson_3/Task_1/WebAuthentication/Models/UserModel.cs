using System;
using System.Xml.Linq;

namespace WebAuthentication.Models
{
    public class UserModel
    {
        public Guid id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool admin { get; set; }

    }
}
