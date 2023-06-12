using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Shared.Domain
{
    public abstract class Request
    {
        public Guid CreatedBy { get; set; }
        public string Role { get; set; }
    }
}
