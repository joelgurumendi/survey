using AutoMapper;
using Surveys.Application.Surveys.Commands;
using Surveys.Application.Surveys.Responses;
using Surveys.Domain.Surveys;
using Version = Surveys.Domain.Surveys.Version;
using Surveys.Application.Report.Response;

namespace Surveys.Application.Mapping
{
    public class SurveyProfile: Profile
    {
        public SurveyProfile()
        {
            CreateMap<CreateSurveyCommand, Survey>();
            CreateMap<Survey, SurveyResponse>();
            CreateMap<Survey, SurveyVersionResponse>();
            CreateMap<Question, QuestionResponse>();
            CreateMap<QuestionResponse, QuestionAnswerResponse>();
            CreateMap<CreateQuestionCommand, Question>().ForMember(x => x.Options, opt => opt.Ignore());
            CreateMap<Version, VersionResponse>();
            CreateMap<CreateVersionCommand, Version>();
            CreateMap<Option, OptionResponse>();
            CreateMap<AnswerType, AnswerTypeResponse>();
            CreateMap<AnswerCommand, Answer>();
            CreateMap<Answer, AnswerResponse>();
            CreateMap<CreateOptionCommand, Option>();
        }
    }
}
