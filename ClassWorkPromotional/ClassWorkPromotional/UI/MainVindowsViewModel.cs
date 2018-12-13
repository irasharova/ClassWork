using ClassWorkPromotional.Data;
using ClassWorkPromotionals.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkPromotional.UI
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            PhotoEditors = ProgramsData.GetProgramsViewModelList();
        }
        public List<ProgramWithHistoryViewModel> PhotoEditors { get; set; }
    }
}
