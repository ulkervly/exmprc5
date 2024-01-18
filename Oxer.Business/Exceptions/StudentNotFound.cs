using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oxer.Business.Exceptions
{
    public class StudentNotFound:Exception
    {
        public StudentNotFound()
        {
        }

        public StudentNotFound(string? message) : base(message)
        {
        }
        public StudentNotFound(string propertyName, string? message) : base(message)
        {
            PropertyName = propertyName;
        }

        public string PropertyName { get; set; }
    }
}
