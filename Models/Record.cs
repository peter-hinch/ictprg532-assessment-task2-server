using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentTask2Server.Models
{
    public class Record
    {
        public long Id { get; set; }
        public string Heading { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public DateTime Date { get; set; }
    }
}
