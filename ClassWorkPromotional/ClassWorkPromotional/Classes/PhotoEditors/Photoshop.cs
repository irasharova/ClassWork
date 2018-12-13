using ClassWorkPromotional.Classes.PhotoEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkPromotionals.Classes.PhotoEditors
{
    class Photoshop : GenericProgram, IPhotoEditor
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
                 processorUsage,
                 "/Data/Images/photoshop.jpg")
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
