﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oxer.Core.Entities
{
    public class BaseEntity
    {
        public bool IsDeleted { get; set; }
        public int Id { get; set; }
        public DateTime CreatedTime {  get; set; }
        public DateTime UpdatedTime { get; set;}
        
    }
}
