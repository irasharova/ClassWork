using ClassWorkPromotionals.Classes;
using ClassWorkPromotionals.Classes.PhotoEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkPromotional.Data
{
    public class ProgramsData
    {
        public List<GenericProgram> GetProgramsList()
        {
            List<GenericProgram> genericPrograms = new List<GenericProgram>()
            {
                new Photoshop(1,new DateTime(2010,1,1), ProgramRenderTypes.RasterGraphics),
                new Photoshop(2,new DateTime(2012,3,6), ProgramRenderTypes.RasterGraphics),
                new Photoshop(3,new DateTime(2014,5,11), ProgramRenderTypes.RasterGraphics),
                new Photoshop(4,new DateTime(2016,8,23), ProgramRenderTypes.VectorGraphics),

                new CorelDraw(1,new DateTime(2011,2,15), ProgramRenderTypes.RasterGraphics),
                new CorelDraw(2,new DateTime(2012,4,11), ProgramRenderTypes.RasterGraphics),
                new CorelDraw(3,new DateTime(2015,1,18), ProgramRenderTypes.RasterGraphics),
                new CorelDraw(4,new DateTime(2016,8,6), ProgramRenderTypes.VectorGraphics),
                new CorelDraw(5,new DateTime(2018,3,25), ProgramRenderTypes.CombineVectorAndRaster),

                new Paint(1,new DateTime(2006,1,12), ProgramRenderTypes.RasterGraphics),
                new Paint(2,new DateTime(2008,3,5), ProgramRenderTypes.RasterGraphics),
                new Paint(3,new DateTime(2012,5,15), ProgramRenderTypes.VectorGraphics),
                new Paint(4,new DateTime(2014,11,14), ProgramRenderTypes.VectorGraphics),
                new Paint(5,new DateTime(2017,2,22), ProgramRenderTypes.VectorGraphics),

                new MovaviPhotoEditor(1,new DateTime(2002,1,12), ProgramRenderTypes.RasterGraphics),
                new MovaviPhotoEditor(2,new DateTime(2002,4,8), ProgramRenderTypes.RasterGraphics),
                new MovaviPhotoEditor(3,new DateTime(2003,5,15), ProgramRenderTypes.RasterGraphics),
                new MovaviPhotoEditor(4,new DateTime(2006,11,14), ProgramRenderTypes.RasterGraphics),
                new MovaviPhotoEditor(5,new DateTime(2017,2,22), ProgramRenderTypes.CachedRaster),

                new Instagram(1,new DateTime(2010,1,12), ProgramRenderTypes.RasterGraphics),
                new Instagram(2,new DateTime(2012,2,8), ProgramRenderTypes.VectorGraphics),
                new Instagram(3,new DateTime(2013,3,1), ProgramRenderTypes.VectorGraphics),
                new Instagram(4,new DateTime(2016,5,14), ProgramRenderTypes.VectorGraphics),
                new Instagram(5,new DateTime(2018,12,1), ProgramRenderTypes.VectorGraphics)
            };
            return genericPrograms;
        }
    }
}
