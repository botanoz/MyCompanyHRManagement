﻿using System;

namespace MyCompanyHRManagement.Application.DTOs
{
    public class CompanyDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime SubscriptionEndDate { get; set; }
    }
}