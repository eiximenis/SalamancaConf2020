using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeersWeb.Data
{
    public class Beer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Style { get; set; }
        public string Image { get; set; }
        public string Link { get; set; }
    }
}
