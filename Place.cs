using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlanner
{
    public class Place
    {
        public Place(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }

        public Location location;

        //string for file
        public string FileStr()
        {
            string filestr = "";

            filestr = Name;

            return filestr;
        }
    }
}
