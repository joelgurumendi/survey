using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Domain.Surveys.Exceptions
{
    public class SurveyNotFoundException : Exception
    {
        public SurveyNotFoundException() : base("Survey not found")
        {

        }
    }
}
