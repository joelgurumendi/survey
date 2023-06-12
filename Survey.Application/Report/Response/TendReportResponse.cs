using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Application.Report.Response
{
   
    public class AnswerUserResponses
    {
        public AnswerUserResponses() 
        {

            AnswerUserResponsesDay = new List<AnswerUserResponsesDay>();
        }    
        public Guid Id { get; set; }
        public List<AnswerUserResponsesDay> AnswerUserResponsesDay { get; set; }
    }

    public class AnswerUserResponsesDay
    {
        public AnswerUserResponsesDay()
        {

            ListQuestion = new List<AnswerUserResponsesQuestion>();
        }
        public string Dia { get; set; }
        public long SurveySum { get; set; }
        public List<AnswerUserResponsesQuestion> ListQuestion { get; set; }
    }

    public class AnswerUserResponsesQuestion
    {
        public AnswerUserResponsesQuestion()
        {

            ListOption = new List<AnswerOption>();
        }
        public int Order { get; set; }
        public Guid QuestionId { get; set; }
        public List<AnswerOption> ListOption { get; set; }
    }


    public class AnswerOption
    {
        public string Option { get;set;  }
        public int Value { get; set;}
    }

    public record UserReportResponsse(Guid Id, string Name, string Email);
}
