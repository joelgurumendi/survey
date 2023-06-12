using Surveys.Domain.Surveys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Version = Surveys.Domain.Surveys.Version;

namespace Surveys.Infrastructure.Data
{
    public partial class SurveyContext : DbContext
    {
        public virtual DbSet<Option> Options { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Survey> Surveys { get; set; }
        public virtual DbSet<AnswerType> TypeAnswers { get; set; }
        public virtual DbSet<Version> Versions { get; set; }
        public virtual DbSet<Answer> Answers { get; set; }

        public SurveyContext(DbContextOptions<SurveyContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Sur");
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SurveyContext).Assembly);
        }
    }
}
