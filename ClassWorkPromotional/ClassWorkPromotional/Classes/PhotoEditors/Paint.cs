using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkPromotionals.Classes.PhotoEditors
{
    class Paint : GenericProgram
    {
        public Paint(int version, DateTime releaseDate) :
          base("Microsoft Paint",
              "Microsoft",
              "Simple raster graphics editor that has been included with all versions of Microsoft Windows",
              version,
              releaseDate)
        {
        }
        public string Name { get => _name; set => _name = value; }
        public string Company { get => _company; set => _company = value; }
        public string Description { get => _description; set => _description = value; }
        public int Version { get => _version; set => _version = value; }
        public DateTime ReleaseDate { get => _releaseDate; set => _releaseDate = value; }
        public ProgramRenderTypes ProgramType { get => _programType; set => _programType = value; }
    }
}
