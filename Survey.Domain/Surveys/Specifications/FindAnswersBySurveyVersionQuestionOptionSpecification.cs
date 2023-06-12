using Surveys.Shared.Domain.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Domain.Surveys.Specifications
{
    public class FindAnswersBySurveyVersionQuestionOptionSpecification : Specification<Answer>
    {
        private readonly Guid _surveyId;
        private readonly Guid _versionId;
        private readonly Guid _questionId;
        private readonly Guid _optionId;
        public FindAnswersBySurveyVersionQuestionOptionSpecification(Guid surveyId, Guid versionId, Guid questionId, Guid optionId)
        {
            _surveyId = surveyId;
            _versionId = versionId;
            _questionId = questionId;
            _optionId = optionId;
        }

        public override Expression<Func<Answer, bool>> ToExpression()
        {

           return answer => answer.SurveyId.Equals(_surveyId) && answer.VersionId.Equals(_versionId) && answer.QuestionId.Equals(_questionId) && answer.OptionId.Equals(_optionId);
        }
    }
}
