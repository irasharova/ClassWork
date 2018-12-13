using ClassWorkPromotional.Classes.PhotoEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkPromotionals.Classes.PhotoEditors
{
    class Instagram : GenericProgram, IPhotoEditor
    {
        public Instagram(int version, 
            DateTime releaseDate, 
            ProgramRenderTypes programRenderType,
            int memoryUsage,
            int processorUsage) :
            base("Instagram",
                 "INSTAGRAM",
                 "Instagram (also known as IG[9]) is a photo and video-sharing social networking service owned by Facebook, Inc. It was created by Kevin Systrom and Mike Krieger, and launched in October 2010",
                 version,
                 releaseDate,
                 programRenderType,
                 memoryUsage,
                 processorUsage,
                 "/Data/Images/instagram.jpg")
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
