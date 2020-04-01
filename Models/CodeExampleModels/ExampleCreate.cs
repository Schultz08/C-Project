﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.CodeExampleModels
{
    public class ExampleCreate
    {
        public int CodeExampleId { get; set; }

        public string ProfileId { get; set; }
        
        public int CategoryId { get; set; }
        
        public string ExampleCode { get; set; }

        public string ExampleDiscription { get; set; }

        public DateTimeOffset TimeStamp { get; set; }


    }
}
