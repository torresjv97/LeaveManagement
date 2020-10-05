using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using LeaveManagement.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LeaveManagement.Models
{
    public class LeaveAllocationViewModel
    {
        public int Id { get; set; }
        [Required]
        public int NumberOfDays { get; set; }
        public DateTime DateCreated { get; set; }
        public Employee Employee { get; set; }
        public string EmployeeId { get; set; }

        public LeaveTypeViewModel LeaveType { get; set; }
        public int LeaveTypeId { get; set; }

        public IEnumerable<SelectListItem> Employees { get; set; }
        public IEnumerable<SelectListItem> LeaveTypes { get; set; }

    }
}
