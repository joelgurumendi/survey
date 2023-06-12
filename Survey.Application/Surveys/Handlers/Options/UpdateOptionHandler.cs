using Surveys.Application.Surveys.Commands;
using Surveys.Domain.Surveys.Exceptions;
using Surveys.Domain.Surveys;
using Surveys.Shared.Domain.Services;
using Surveys.Shared.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Application.Surveys.Handlers.Options
{
    internal class UpdateOptionHandler : IRequestHandler<UpdateOptionCommand>
    {
        private readonly IUnitOfWork _repository;
        public UpdateOptionHandler(IUnitOfWork repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateOptionCommand request, CancellationToken cancellationToken)
        {
            var option = await new DomainService<Option>(_repository.OptionRepository).GetById(request.Id, cancellationToken) ?? throw new SurveyNotFoundException();
            option.Label = request.Label;
            option.Order = request.Order;
            option.Update();
            await _repository.SaveChange(cancellationToken);
        }
    }
}
