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
                             DateTime releaseDate)
        {
            _name = name;
            _company = company;
            _description = description;
            _version = version;
            _releaseDate = releaseDate;
        }
        protected string _name;
        protected string _company;
        protected string _description;
        protected int _version;
        protected DateTime _releaseDate;
        protected ProgramRenderTypes _programType;
    }
}
