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
                             int processorUsage)
        {
            _name = name;
            _company = company;
            _description = description;
            _version = version;
            _releaseDate = releaseDate;
            _programRenderType = programRenderType;
            _memoryUsage = memoryUsage;
            _processorUsage = processorUsage;
        }
        protected string _name;
        protected string _company;
        protected string _description;
        protected int _version;
        protected DateTime _releaseDate;
        protected ProgramRenderTypes _programRenderType;
        protected int _memoryUsage;
        protected int _processorUsage;

        public ResourcesUsage ResourcesUsage
        {
            get
            { 
                return CalculateResurceUsage();
            }
        }

        private ResourcesUsage CalculateResurceUsage()
        {
            var PhotoAmount = 12;

            var CurrentMemory = 0;
            var CurrentProcessor = 0;

            switch (_programRenderType)
            {
                case ProgramRenderTypes.RasterGraphics:
                    CurrentMemory = _memoryUsage;
                    CurrentProcessor = _processorUsage;
                    break;

                case ProgramRenderTypes.VectorGraphics:
                    CurrentMemory = PhotoAmount * _memoryUsage;
                    CurrentProcessor = PhotoAmount * _processorUsage;
                    break;

                case ProgramRenderTypes.CombineVectorAndRaster:
                    if (PhotoAmount < 10)
                    {
                        CurrentMemory = PhotoAmount * _memoryUsage + 10;
                        CurrentProcessor = PhotoAmount * _processorUsage + 2;
                    }
                    else
                    {
                        CurrentMemory = PhotoAmount * _memoryUsage - 5;
                        CurrentProcessor = PhotoAmount * _processorUsage - 2;
                    }
                    break;

                case ProgramRenderTypes.CachedRaster:
                    if ((PhotoAmount * _memoryUsage) > Convert.ToInt32(MaxResources.MaxMemory / 2))
                    {
                        CurrentMemory = Convert.ToInt32((MaxResources.MaxMemory * 0.5));
                    }
                    else
                    {
                        CurrentMemory = PhotoAmount * _memoryUsage;
                    }
                    if ((PhotoAmount * _processorUsage) > Convert.ToInt32(MaxResources.MaxProcessor / 4))
                    {
                        CurrentProcessor = Convert.ToInt32((MaxResources.MaxProcessor / 4));
                    }
                    else
                    {
                        CurrentProcessor = PhotoAmount * _processorUsage;
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
