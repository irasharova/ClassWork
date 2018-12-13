using ClassWorkPromotional.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkPromotionals.Classes
{
    public abstract class GenericProgram
    {
        public GenericProgram(string name,
                             string company,
                             string description,
                             int version,
                             DateTime releaseDate,
                             ProgramRenderTypes programRenderType,
                             int memoryUsage,
                             int processorUsage,
                             string image)
        {
            _name = name;
            _company = company;
            _description = description;
            _version = version;
            _releaseDate = releaseDate;
            _programRenderType = programRenderType;
            _memoryUsage = memoryUsage;
            _processorUsage = processorUsage;
            _image = image;
        }
        protected string _image;
        protected string _name;
        protected string _company;
        protected string _description;
        protected int _version;
        protected DateTime _releaseDate;
        protected ProgramRenderTypes _programRenderType;
        protected int _memoryUsage;
        protected int _processorUsage;

        public ResourcesUsage CalculateResourceUsage(int photoAmount)
        {
            var CurrentMemory = 0;
            var CurrentProcessor = 0;

            switch (_programRenderType)
            {
                case ProgramRenderTypes.RasterGraphics:
                    CurrentMemory = _memoryUsage;
                    CurrentProcessor = _processorUsage;
                    break;

                case ProgramRenderTypes.VectorGraphics:
                    CurrentMemory = photoAmount * _memoryUsage;
                    CurrentProcessor = photoAmount * _processorUsage;
                    break;

                case ProgramRenderTypes.CombineVectorAndRaster:
                    if (photoAmount < 10)
                    {
                        CurrentMemory = photoAmount * _memoryUsage + 10;
                        CurrentProcessor = photoAmount * _processorUsage + 2;
                    }
                    else
                    {
                        CurrentMemory = photoAmount * _memoryUsage - 5;
                        CurrentProcessor = photoAmount * _processorUsage - 2;
                    }
                    break;

                case ProgramRenderTypes.CachedRaster:
                    if ((photoAmount * _memoryUsage) > Convert.ToInt32(MaxResources.MaxMemory / 2))
                    {
                        CurrentMemory = Convert.ToInt32((MaxResources.MaxMemory * 0.5));
                    }
                    else
                    {
                        CurrentMemory = photoAmount * _memoryUsage;
                    }
                    if ((photoAmount * _processorUsage) > Convert.ToInt32(MaxResources.MaxProcessor / 4))
                    {
                        CurrentProcessor = Convert.ToInt32((MaxResources.MaxProcessor / 4));
                    }
                    else
                    {
                        CurrentProcessor = photoAmount * _processorUsage;
                    }
                    break;
            }

            return new ResourcesUsage()
            {
                Memory = CurrentMemory,
                Processor = CurrentProcessor
            };
        }
    }
}
