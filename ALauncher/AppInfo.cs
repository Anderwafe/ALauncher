using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALauncher
{
    class AppInfo
    {
        private string _name;
        private string _smalldescription;
        private string _description;


        public string Name { get => _name; set => _name = value; }
        public string Description { get => _description; set => _description = value; }
        public string SmallDescription { get => _smalldescription; set => _smalldescription = value; }

        public AppInfo(string Name, string Description, string SmallDescription)
        {
            (_name, _smalldescription, _description) = (Name, SmallDescription, Description);
        }
    }
}
