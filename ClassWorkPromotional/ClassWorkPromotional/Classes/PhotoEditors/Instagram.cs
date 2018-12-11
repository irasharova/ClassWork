using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkPromotionals.Classes.PhotoEditors
{
    class Instagram : GenericProgram
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
