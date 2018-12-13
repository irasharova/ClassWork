using ClassWorkPromotional.Classes;
using ClassWorkPromotional.Classes.PhotoEditors;
using ClassWorkPromotionals.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkPromotional.UI
{
    public class ProgramWithHistoryViewModel: PropertyChangedBase
    {
        public ProgramWithHistoryViewModel(List<IPhotoEditor> photoEditors)
        {
            PhotoEditors = photoEditors;
            _start = new DateTime(2000, 1, 1);
            _end = new DateTime(2018, 1, 1);
        }
        DateTime _start;
        DateTime _end;
        int _photoAmount;
        private List<IPhotoEditor> _photoEditors;

        public string Image
        {
            get
            {
                return GetActualProgram().Image;
            }
        }
        public string Name
        {
            get
            {
                return GetActualProgram().Name;
            }
        }
        public string Company
        {
            get
            {
                return GetActualProgram().Company;
            }
        }
        public string Description
        {   get
            {
                return GetActualProgram().Description;
            }
        }
        public IPhotoEditor ActualProgram
        {
            get
            {
                return GetActualProgram();
            }
        }
        public List<IPhotoEditor> History
        {
            get
            {
                return PhotoEditors.OrderByDescending(x=>x.Version).ToList();
            }
        }
        public List<IPhotoEditor> PhotoEditors
        {
            get
            {
                return _photoEditors;
            }
            set
            {
                _photoEditors = value;
            }
        }
        public ResourcesUsage ResourceUsage
        {
            get
            {
                return GetActualProgram().CalculateResourceUsage(_photoAmount);
            }
        }

        public ResourcesUsage AverageResourceUsage
        {
            get
            {
                List<ResourcesUsage> usageResultList = new List<ResourcesUsage>();
                foreach(var programVersion in PhotoEditors.Where(x=>x.ReleaseDate>Start && x.ReleaseDate < End))
                {
                    usageResultList.Add(programVersion.CalculateResourceUsage(_photoAmount));
                }

                int averageMemoryUsage = 0;
                int averageProcessorUsage = 0;
                if (usageResultList.Count > 0)
                {
                    usageResultList.ForEach(x => averageMemoryUsage += x.Memory);
                    averageMemoryUsage = Convert.ToInt32(averageMemoryUsage / usageResultList.Count);

                    usageResultList.ForEach(x => averageProcessorUsage += x.Processor);
                    averageProcessorUsage = Convert.ToInt32(averageProcessorUsage / usageResultList.Count);
                }

                return new ResourcesUsage()
                {
                    Memory = averageMemoryUsage,
                    Processor = averageProcessorUsage
                };
            }
        }
        private IPhotoEditor GetActualProgram()
        {
            return PhotoEditors.OrderByDescending(x => x.Version).First();
        }

        public DateTime Start
        {
            get
            {
                return _start;
            }
            set
            {
                _start = value;
                OnPropertyChanged("ResourceUsage");
                OnPropertyChanged("AverageResourceUsage");
            }
        }
        public DateTime End
        {
            get
            {
                return _end;
            }
            set
            {
                _end = value;
                OnPropertyChanged("ResourceUsage");
                OnPropertyChanged("AverageResourceUsage");
            }
        }

        public int PhotoAmount
        {
            get
            {
                return _photoAmount;
            }
            set
            {
                _photoAmount = value;
                OnPropertyChanged("ResourceUsage");
                OnPropertyChanged("AverageResourceUsage");
            }
        } 
    }
}
