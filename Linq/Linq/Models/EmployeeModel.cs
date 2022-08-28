using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Linq.Models
{
    public class EmployeeModel
    {
        [Key]
        public string empno { get; set; }

        public string birthdate { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }

        public string gender { get; set; }
        public string hire_date { get; set; }


    }
}
