using ClassWorkPromotionals.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkPromotional.Classes.PhotoEditors
{
    public interface IPhotoEditor
    {
        string Name { get; }
        string Company { get; }
        string Description { get; }
        string Image { get; }
        int Version { get; }
        DateTime ReleaseDate { get; }
        ProgramRenderTypes ProgramType { get; }
        ResourcesUsage CalculateResourceUsage(int photoAmount);
    }
}
