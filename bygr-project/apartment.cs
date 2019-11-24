using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bygr_project
{
    public class Apartment
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public int residentialUnitGroupId { get; set; }
        public int floor { get; set; }
        public string layoutType { get; set; }
        public Deadline[] deadlines { get; set; }
        public Buyer[] buyers { get; set; }
    }
}