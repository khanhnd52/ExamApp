using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Application.Commands.StartExam
{
    public class StartExamCommand : IRequest<bool>
    {
        public string UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ExamId { get; set; }

        public DateTime StartDate { get; set; }
    }
}
