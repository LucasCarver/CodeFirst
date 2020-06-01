using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EntityCodeFirst.Context
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(40)]
        public string Location { get; set; }
        [MaxLength(20)]
        public string Type { get; set; }
        public double Budget { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
