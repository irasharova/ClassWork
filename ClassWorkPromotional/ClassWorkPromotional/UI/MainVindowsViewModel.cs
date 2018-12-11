using ClassWorkPromotional.Data;
using ClassWorkPromotionals.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkPromotional.UI
{
    public class MainVindowViewModel
    {
        public MainVindowViewModel()
        {
            ProgramsData.GetProgramsList().GroupBy(x=>x.)
        }
        public List<ProgramWithHistoryViewModel> PhotoEditors { get; set; }
    }
}
