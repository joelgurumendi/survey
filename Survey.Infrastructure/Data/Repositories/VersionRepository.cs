using Surveys.Domain.Surveys.Repositories;
using Surveys.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Version = Surveys.Domain.Surveys.Version;

namespace Surveys.Infrastructure.Data.Repositories
{
    public class VersionRepository : IVersionRepository
    {
        private readonly SurveyContext _context;
        public VersionRepository(SurveyContext context)
        {
            _context = context;
        }
        public async Task Add(Version entity, CancellationToken cancellationToken)
        {
            await _context.Versions.AddAsync(entity, cancellationToken);
        }

        public async Task AddRange(IEnumerable<Version> entities, CancellationToken cancellationToken)
        {
            await _context.Versions.AddRangeAsync(entities, cancellationToken);
        }

        public async Task<Version?> FindByCriteria(Expression<Func<Version, bool>> expression, CancellationToken cancellationToken)
        {
            return await _context.Versions.Where(expression).SingleOrDefaultAsync(cancellationToken);
        }

        public async Task<IEnumerable<Version>> FindManyByCriteria(Expression<Func<Version, bool>> expression, CancellationToken cancellationToken)
        {
            return await _context.Versions.Where(expression).ToListAsync(cancellationToken);
        }

        public async Task SaveChange(CancellationToken cancellationToken)
        {
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
