using ClassWorkPromotionals.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkPromotional.UI
{
    public class ProgramWithHistoryViewModel
    {
        public string Name { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public List<GenericProgram> History { get; set; }
    }
}
