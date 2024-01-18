using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oxer.Business.Exceptions
{
    public class StudentInvalidImage:Exception
    {
        public StudentInvalidImage()
        {
        }

        public StudentInvalidImage(string? message) : base(message)
        {
        }
        public StudentInvalidImage(string propertyName,string? message) : base(message)
        {
            PropertyName = propertyName;
        }

        public string PropertyName {  get; set; }

    }
}
