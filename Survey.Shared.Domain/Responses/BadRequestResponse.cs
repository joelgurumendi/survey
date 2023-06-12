using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Shared.Domain.Responses
{
    public class BadRequestResponse : IResponse
    {
        public Guid Id { get; set; }
        public int StatusCode { get; set; }
        public string? Message { get; set; }

        public BadRequestResponse(string message)
        {
            Id = Guid.NewGuid();
            StatusCode = 400;
            Message = message;
        }
    }
}
