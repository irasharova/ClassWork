using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkPromotionals.Classes.PhotoEditors
{
    class MovaviPhotoEditor : GenericProgram
    {
        public MovaviPhotoEditor(int version, DateTime releaseDate) :
           base("Movavi Photo Editor",
               "MOVAVI",
               "Easy-to-Use Photo Editing Software",
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
