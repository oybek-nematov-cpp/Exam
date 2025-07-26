using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain.Models
{
    public class Students
    {
        public int Id { get; set; } 
        public string FullName { get; set; }

        public DateTime BirthDate { get; set; }

        public int Pasportid { get; set; }
        

    }
}
