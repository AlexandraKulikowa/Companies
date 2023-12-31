﻿namespace Companies.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool? Title { get; set; }
        public DateOnly? BirthDate { get; set; }
        public string? Position { get; set; }
        public List<Note> Notes { get; set; }
        public Company Company { get; set; }
        public int CompanyId { get; set; }
    }
}