using ClassWorkPromotional.Classes.PhotoEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkPromotionals.Classes.PhotoEditors
{
    class Paint : GenericProgram, IPhotoEditor
    {
        public Paint(int version, 
            DateTime releaseDate, 
            ProgramRenderTypes programRenderType,
            int memoryUsage,
            int processorUsage) :
            base("Microsoft Paint",
                 "Microsoft",
                 "Simple raster graphics editor that has been included with all versions of Microsoft Windows",
                 version,
                 releaseDate,
                 programRenderType,
                 memoryUsage,
                 processorUsage,
                 "/Data/Images/paint.jpg")
            {
            }

        public string Name { get => _name; }
        public string Company { get => _company; }
        public string Description { get => _description; }
        public string Image { get => _image; }
        public int Version { get => _version; }
        public DateTime ReleaseDate { get => _releaseDate; }
        public ProgramRenderTypes ProgramType { get => _programRenderType; }
    }
}
