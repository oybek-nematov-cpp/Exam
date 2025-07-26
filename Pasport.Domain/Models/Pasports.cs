using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain.Models
{
    public class Pasports
    {
        public int Id { get; set; } 
        public string SerialNumber { get; set; }
        public DateTime IssueDate { get; set; } 
        public DateTime ExpiryDate { get; set; }
        	

    }
}
