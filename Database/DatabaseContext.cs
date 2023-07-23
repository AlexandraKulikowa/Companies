using Companies.Models;
using Microsoft.EntityFrameworkCore;

namespace Companies.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>()
                .HasData(
                    new Company[]
                    {
                        new Company { Id = 1, Name = "Super Mart of the West", CityId = 1, StateId = 1, Phone = "(800) 555-2797", Address = "702 SW 8th Street"},
                        new Company { Id = 2, Name = "Electronics Depot", CityId = 3, StateId = 2, Phone = "(800) 595-3232"},
                        new Company { Id = 3, Name = "K&S Music", CityId = 4, StateId = 3, Phone = "(612) 304-6073"},
                        new Company { Id = 4, Name = "Tom's Club", CityId = 5, StateId = 4, Phone = "(800) 955-2292"},
                        new Company { Id = 5, Name = "E-Mart", CityId = 6, StateId = 5, Phone = "(847) 286-2500"},
                        new Company { Id = 6, Name = "Walters", CityId = 7, StateId = 5, Phone = "(847) 940-2500"},
                        new Company { Id = 7, Name = "StereoShack", CityId = 8, StateId = 6, Phone = "(817) 820-0741"},
                        new Company { Id = 8, Name = "Circuit Town", CityId = 9, StateId = 5, Phone = "(800) 955-2929"},
                        new Company { Id = 9, Name = "Premier Buy", CityId = 10, StateId = 3, Phone = "(612) 291-1000"},
                        new Company { Id = 10, Name = "ElectrixMax", CityId = 11, StateId = 5, Phone = "(630) 438-7800"},
                        new Company { Id = 11, Name = "Video Emporium", CityId = 12, StateId = 6, Phone = "(214) 854-3000"},
                        new Company { Id = 12, Name = "Screen Shop", CityId = 13, StateId = 7, Phone = "(800) 445-6937"},
                    });

            modelBuilder.Entity<City>()
                .HasData(
                    new City[]
                    {
                        new City { Id = 1, Name = "Bentonville"},
                        new City { Id = 2, Name = "Las Vegas"},
                        new City { Id = 3, Name = "Atlanta"},
                        new City { Id = 4, Name = "Minneapolis"},
                        new City { Id = 5, Name = "Issaquah"},
                        new City { Id = 6, Name = "Hoffman Estates"},
                        new City { Id = 7, Name = "Deerfield"},
                        new City { Id = 8, Name = "Fort Worth"},
                        new City { Id = 9, Name = "Oak Brook"},
                        new City { Id = 10, Name = "Richfield"},
                        new City { Id = 11, Name = "Naperville"},
                        new City { Id = 12, Name = "Dallas"},
                        new City { Id = 13, Name = "Mooresville"},
                        new City { Id = 14, Name = "San Jose"},
                        new City { Id = 15, Name = "Denver"},
                        new City { Id = 16, Name = "Seattle"},
                    });

            modelBuilder.Entity<State>()
                .HasData(
                    new State[]
                    {
                        new State { Id = 1, Name = "Arkansas"},
                        new State { Id = 2, Name = "Georgia"},
                        new State { Id = 3, Name = "Minnesota"},
                        new State { Id = 4, Name = "Washington"},
                        new State { Id = 5, Name = "Illinois"},
                        new State { Id = 6, Name = "Texas"},
                        new State { Id = 7, Name = "North Carolina"},
                    });

            modelBuilder.Entity<Order>()
                .HasData(
                    new Order[]
                    {
                        new Order { Id = 1, OrderDate = new DateOnly(2013,11,12), CityId = 2, CompanyId = 1},
                        new Order { Id = 2, OrderDate = new DateOnly(2013,11,14), CityId = 2, CompanyId = 1},
                        new Order { Id = 3, OrderDate = new DateOnly(2013,11,18), CityId = 14, CompanyId = 1},
                        new Order { Id = 4, OrderDate = new DateOnly(2013,11,22), CityId = 15, CompanyId = 1},
                        new Order { Id = 5, OrderDate = new DateOnly(2013,11,30), CityId = 16, CompanyId = 1},
                        new Order { Id = 6, OrderDate = new DateOnly(2013,12,01), CityId = 14, CompanyId = 1},
                    });

            modelBuilder.Entity<Note>()
                .HasData(
                    new Note[]
                    {
                        new Note { Id = 1, InvoiceNumber = 35703, EmployeeId = 2, CompanyId = 1},
                        new Note { Id = 2, InvoiceNumber = 35711, EmployeeId = 3, CompanyId = 1},
                        new Note { Id = 3, InvoiceNumber = 35714, EmployeeId = 2, CompanyId = 1},
                        new Note { Id = 4, InvoiceNumber = 35983, EmployeeId = 4, CompanyId = 1},
                        new Note { Id = 5, InvoiceNumber = 36987, EmployeeId = 5, CompanyId = 1},
                        new Note { Id = 6, InvoiceNumber = 38466, EmployeeId = 2, CompanyId = 1},
                        new Note { Id = 7, InvoiceNumber = 38599, EmployeeId = 1, CompanyId = 1},

                    });

            modelBuilder.Entity<Employee>()
                 .HasData(
                    new Employee[]
                    {
                        new Employee { Id = 1, FirstName = "John", LastName = "Heart", Title = false, BirthDate = new DateOnly(1964,3,16), Position = "CEO", CompanyId = 1},
                        new Employee { Id = 2, FirstName = "Harv", LastName = "Mudd", CompanyId = 1},
                        new Employee { Id = 3, FirstName = "Jim", LastName = "Packard", CompanyId = 1},
                        new Employee { Id = 4, FirstName = "Todd", LastName = "Hoffman", CompanyId = 1},
                        new Employee { Id = 5, FirstName = "Clark", LastName = "Morgan", CompanyId = 1},
                    });
        }
    }
}