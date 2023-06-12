using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Shared.Domain.Responses
{
    public class UnAuthorizationResponse : IResponse
    {
        public Guid Id { get; set; }
        public int StatusCode { get; set; }
        public string? Message { get; set; }
        public UnAuthorizationResponse()
        {
            Id = Guid.NewGuid();
            StatusCode = 401;
        }
    }
}
