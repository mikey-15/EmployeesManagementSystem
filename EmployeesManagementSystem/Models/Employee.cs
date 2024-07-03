﻿namespace EmployeesManagementSystem.Models
{
    public class Employee: UserActivity
    {
        public int Id { get; set; }
        public string EmpNo { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string FullName=>$"{FirstName}{LastName}";
        public int PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Country { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }
    }
}
