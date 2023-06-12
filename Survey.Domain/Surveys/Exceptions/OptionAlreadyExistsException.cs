using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Domain.Surveys.Exceptions
{
    public class OptionAlreadyExistsException : Exception
    {
        public OptionAlreadyExistsException() :base("Option Already Exist") 
        {
            
        }
    }
}
