using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_control_model
{
    public class AttendenceType
    {
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public DateTime date { get; set; }
        public bool status { get;set; }
    }
}
