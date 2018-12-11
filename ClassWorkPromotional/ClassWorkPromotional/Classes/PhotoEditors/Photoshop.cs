using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkPromotionals.Classes.PhotoEditors
{
    class Photoshop : GenericProgram
    {
        public Photoshop(int version,
            DateTime releaseDate,
            ProgramRenderTypes programRenderType,
            int memoryUsage,
            int processorUsage) :
            base("Adobe Photoshop",
                 "Adobe",
                 "Adobe Photoshop is a raster graphics editor developed and published by Adobe Systems for macOS and Windows.",
                 version,
                 releaseDate,
                 programRenderType,
                 memoryUsage,
                 processorUsage)
        {
        }
        public string Name { get => _name; set => _name = value; }
        public string Company { get => _company; set => _company = value; }
        public string Description { get => _description; set => _description = value; }
        public int Version { get => _version; set => _version = value; }
        public DateTime ReleaseDate { get => _releaseDate; set => _releaseDate = value; }
        public ProgramRenderTypes ProgramType { get => _programRenderType; set => _programRenderType = value; }
    }
}
