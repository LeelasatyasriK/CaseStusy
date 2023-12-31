﻿using System.ComponentModel.DataAnnotations;

namespace HotelBooking.DataModels
{
    public class Staff
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int Age { get; set; }
        public string EmployeeAddress { get; set; }
        public decimal Salary { get; set; }
        public string Designation { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }   
    }
}
