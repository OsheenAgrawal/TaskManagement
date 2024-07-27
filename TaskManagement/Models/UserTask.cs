using System;
using System.ComponentModel.DataAnnotations;

namespace TaskManagementSystem.Models
{
    public class UserTask
    {
        [Key]
        public int TaskId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public DateTime DueDate { get; set; }

        public bool IsCompleted { get; set; }

        public string Notes { get; set; }

        public string DocumentPath { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }

    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public string Role { get; set; } // MD, Manager, Employee

        public int? ManagerId { get; set; }
        public Employee Manager { get; set; }
    }
}