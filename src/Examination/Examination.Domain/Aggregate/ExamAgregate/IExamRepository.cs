using Examination.Domain.AggregateModels.ExamAggregate;
using Examination.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Domain.Aggregate.ExamAgregate
{
    public interface IExamRepository : IRepositoryBase<Exam>
    {
        Task<IEnumerable<Exam>> GetExamListAsync();
        Task<Exam> GetExamByIdAsync(string id);
    }
}
