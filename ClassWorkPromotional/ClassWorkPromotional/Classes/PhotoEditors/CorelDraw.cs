using ClassWorkPromotional.Classes.PhotoEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkPromotionals.Classes.PhotoEditors
{
    public class CorelDraw: GenericProgram, IPhotoEditor
    {
        public CorelDraw(int version, 
            DateTime releaseDate,
            ProgramRenderTypes programRenderType,
            int memoryUsage,
            int processorUsage) :
            base("Corel Draw", 
                 "Corel Corporation",
                 "CorelDRAW Graphics Suite 2018 Graphic design software",
                 version,
                 releaseDate,
                 programRenderType,
                 memoryUsage,
                 processorUsage,
                 "/Data/Images/coreldraw.jpg")
            {
            }

        public string Name { get => _name;  }
        public string Company { get => _company; }
        public string Description { get => _description;  }
        public string Image { get => _image; }
        public int Version { get => _version;  }
        public DateTime ReleaseDate { get => _releaseDate; }
        public ProgramRenderTypes ProgramType { get => _programRenderType; }
    }
}
