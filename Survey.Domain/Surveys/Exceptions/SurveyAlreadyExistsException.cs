using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Domain.Surveys.Exceptions
{
    public class SurveyAlreadyExistsException : Exception
    {
        public SurveyAlreadyExistsException() : base("Survey already exists")
        {

        }
    }
}
