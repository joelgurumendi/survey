using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Shared.Domain.Responses
{
    public class ConflictResponse : IResponse
    {
        public Guid Id { get; set; }
        public int StatusCode { get; set; }
        public string? Message { get; set; }

        public ConflictResponse(string message)
        {
            Id = Guid.NewGuid();
            StatusCode = 409;
            Message = message;
        }
    }
}
