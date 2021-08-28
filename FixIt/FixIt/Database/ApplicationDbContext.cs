using FixIt.Database.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;

namespace FixIt.Database
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<City> Cities { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobStatus> JobStatuses { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceRating> ServiceRatings { get; set; }
        public DbSet<ServiceRequest> ServiceRequests { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<Sex> Sexes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedCities(builder);
            SeedSexes(builder);
            SeedUsers(builder);
            SeedRoles(builder);
            SeedUserRoles(builder);

            SeedProfessions(builder);
            SeedEmployees(builder);

            SeedServiceTypes(builder);
            SeedServices(builder);

            SeedPaymentTypes(builder);
            SeedPayments(builder);

            SeedServiceRequests(builder);

            SeedJobStatus(builder);
            SeedJobs(builder);

            SeedServiceRatings(builder);
        }

        private void SeedServiceRatings(ModelBuilder builder)
        {
            builder.Entity<ServiceRating>().HasData(
                new ServiceRating { Id = 1, RatingDate = DateTime.Now, Rating = 5, ServiceId = 9, UserId = "864ddd14-6340-4840-fr23-db12554843e5" },
                new ServiceRating { Id = 2, RatingDate = DateTime.Now, Rating = 3, ServiceId = 1, UserId = "864ddd14-6340-4840-fr23-db12554843e5" },
                new ServiceRating { Id = 3, RatingDate = DateTime.Now, Rating = 4, ServiceId = 1, UserId = "724ddd14-1234-4840-fr23-db12554843e5" },
                new ServiceRating { Id = 4, RatingDate = DateTime.Now, Rating = 4, ServiceId = 7, UserId = "724ddd14-1234-4840-fr23-db12554843e5" },
                new ServiceRating { Id = 5, RatingDate = DateTime.Now, Rating = 5, ServiceId = 5, UserId = "724ddd14-1234-4840-fr23-db12554843e5" }
                );
        }

        private void SeedJobs(ModelBuilder builder)
        {
            builder.Entity<Job>().HasData(
                new Job
                {
                    Id = 1,
                    CreatedAt = DateTime.Now,
                    EmployeeId = 1,
                    FinishedDate = DateTime.Now.AddDays(3),
                    JobDescription = "Potrebno zamijeniti utičnice u kuhinji",
                    JobStatusId = 2,
                    ServiceRequestId = 1,
                    Paid = true
                },
                new Job
                {
                    Id = 2,
                    CreatedAt = DateTime.Now,
                    EmployeeId = 2,
                    FinishedDate = DateTime.Now.AddDays(2),
                    JobStatusId = 2,
                    ServiceRequestId = 3,
                    Paid = true
                },
                new Job
                {
                    Id = 3,
                    CreatedAt = DateTime.Now,
                    EmployeeId = 1,
                    JobDescription = "Popravka frižidera",
                    JobStatusId = 1,
                    ServiceRequestId = 4,
                    Paid = true
                }
                );
        }

        private void SeedPayments(ModelBuilder builder)
        {
            builder.Entity<Payment>().HasData(
                new Payment { Id = 1, PaymentTypeId = 2, Total = 40 },
                new Payment { Id = 2, PaymentTypeId = 1, Total = 100, FullName = "Amer Hasanbegovic", CreditCardNumber = "1234555522223333", PaymentDate = DateTime.Now, CVV = "132" },
                new Payment { Id = 3, PaymentTypeId = 2, Total = 100 },
                new Payment { Id = 4, PaymentTypeId = 1, Total = 30, FullName = "Ada Lovelace", CreditCardNumber = "00009999111122222", CVV = "178", PaymentDate = DateTime.Now },
                new Payment { Id = 5, PaymentTypeId = 2, Total = 50 }
                );
        }

        private void SeedServiceRequests(ModelBuilder builder)
        {
            builder.Entity<ServiceRequest>().HasData(
                new ServiceRequest
                {
                    Id = 1,
                    JobDescription = "Potrebno zamijeniti utičnice u kuhinji",
                    PaymentId = 1,
                    Processed = true,
                    RequestDate = DateTime.Now,
                    ServiceId = 9,
                    UserId = "864ddd14-6340-4840-fr23-db12554843e5"
                },
                new ServiceRequest
                {
                    Id = 2,
                    JobDescription = "Potrebno okrečiti cijeli stan",
                    PaymentId = 2,
                    Processed = false,
                    RequestDate = DateTime.Now,
                    ServiceId = 1,
                    UserId = "864ddd14-6340-4840-fr23-db12554843e5"
                },
                new ServiceRequest
                {
                    Id = 3,
                    PaymentId = 3,
                    Processed = true,
                    RequestDate = DateTime.Now,
                    ServiceId = 1,
                    UserId = "724ddd14-1234-4840-fr23-db12554843e5"
                },
                new ServiceRequest
                {
                    Id = 4,
                    PaymentId = 4,
                    JobDescription = "Popravka frižidera",
                    Processed = true,
                    RequestDate = DateTime.Now,
                    ServiceId = 7,
                    UserId = "724ddd14-1234-4840-fr23-db12554843e5"
                },
                new ServiceRequest
                {
                    Id = 5,
                    PaymentId = 5,
                    JobDescription = "Zamjena parketa u dječijoj sobi",
                    Processed = false,
                    RequestDate = DateTime.Now,
                    ServiceId = 5,
                    UserId = "724ddd14-1234-4840-fr23-db12554843e5"
                }
                );
        }

        private void SeedEmployees(ModelBuilder builder)
        {
            builder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Address = "Ulica uposlenika 1",
                    Biography = "Završio zanatsku školu, ima 30 godina iskustva",
                    BirthDate = DateTime.Now,
                    CityId = 1,
                    Firstname = "Nikola",
                    HireDate = DateTime.Now,
                    Lastname = "Tesla",
                    PhoneNumber = "061111222",
                    ProfessionId = 1,
                    SexId = 2,
                    Photo = File.ReadAllBytes("Assets/profile2.jpg")
                },
                new Employee
                {
                    Id = 2,
                    Address = "Ulica uposlenika 2",
                    Biography = "Završio molersku školu, radio u Jub",
                    BirthDate = DateTime.Now,
                    CityId = 2,
                    Firstname = "Ejub",
                    HireDate = DateTime.Now,
                    Lastname = "Četkić",
                    PhoneNumber = "061113333",
                    ProfessionId = 2,
                    SexId = 1,
                    Photo = File.ReadAllBytes("Assets/profile1.jpg")
                },
                new Employee
                {
                    Id = 3,
                    Address = "Ulica uposlenika 3",
                    Biography = "Završila zanatsku školu za parketare",
                    BirthDate = DateTime.Now,
                    CityId = 2,
                    Firstname = "Sanela",
                    HireDate = DateTime.Now,
                    Lastname = "Parketovska",
                    PhoneNumber = "061113321",
                    ProfessionId = 4,
                    SexId = 2,
                    Photo = File.ReadAllBytes("Assets/profile3.jpg")
                }
                );
        }

        private void SeedServices(ModelBuilder builder)
        {
            builder.Entity<Service>().HasData(
                new Service { Id = 1, Name = "Krečenje", Description = "Krečenje stanova i domova", Price = 100, CreatedAt = DateTime.Now, ServiceTypeId = 1, TimesRequested = 2, Rating = 3.5 },
                new Service { Id = 2, Name = "Farbanje ograda", Description = "Farbanje ograda od bilo kojeg materijala u bilo koje boje", Price = 80, CreatedAt = DateTime.Now, ServiceTypeId = 1, TimesRequested = 0, Rating = 0 },
                new Service { Id = 3, Name = "Uređenje vrta", Description = "Uređenje vrta, košenje trave, šišanje živice", Price = 60, CreatedAt = DateTime.Now, ServiceTypeId = 7, TimesRequested = 0, Rating = 0 },
                new Service { Id = 4, Name = "Čišćenje dimnjaka", Description = "Čišćenje dimnjaka u domovima i stanovima", Price = 100, CreatedAt = DateTime.Now, ServiceTypeId = 6, TimesRequested = 0, Rating = 0 },
                new Service { Id = 5, Name = "Postavljanje parketa", Description = "Postavaljanje parketa u domovima i stanovima", Price = 50, CreatedAt = DateTime.Now, ServiceTypeId = 10, TimesRequested = 1, Rating = 5 },
                new Service { Id = 6, Name = "Obrada parketa", Description = "Brušenje i lakiranje parketa u domovima i stanovima", Price = 120, CreatedAt = DateTime.Now, ServiceTypeId = 10, TimesRequested = 0, Rating = 0 },
                new Service { Id = 7, Name = "Popravka aparata u domu", Description = "Popravke svih vrsta aparata u domu", Price = 30, CreatedAt = DateTime.Now, ServiceTypeId = 8, TimesRequested = 1, Rating = 4 },
                new Service { Id = 8, Name = "Zamjena prozora", Description = "Zamjena prozora u domovima i stanovima", Price = 110, CreatedAt = DateTime.Now, ServiceTypeId = 2, TimesRequested = 0, Rating = 0 },
                new Service { Id = 9, Name = "Popravka utičnica", Description = "Popravke i zamjene utičnica", Price = 40, CreatedAt = DateTime.Now, ServiceTypeId = 3, TimesRequested = 1, Rating = 5 },
                new Service { Id = 10, Name = "Postavljanje tapeta", Description = "Postavljanje novih tapeta u stanovima i domovima", Price = 80, CreatedAt = DateTime.Now, ServiceTypeId = 9, TimesRequested = 0, Rating = 0 }
                );
        }

        private void SeedServiceTypes(ModelBuilder builder)
        {
            builder.Entity<ServiceType>().HasData(
                new ServiceType { Id = 1, Name = "Molerski radovi" },
                new ServiceType { Id = 2, Name = "Stolarski radovi" },
                new ServiceType { Id = 3, Name = "Elektrotehnički radovi" },
                new ServiceType { Id = 4, Name = "Vodoinstalaterski radovi" },
                new ServiceType { Id = 5, Name = "Stolarski radovi" },
                new ServiceType { Id = 6, Name = "Dimnjačarstvo" },
                new ServiceType { Id = 7, Name = "Baštovanstvo" },
                new ServiceType { Id = 8, Name = "Servis tehnike" },
                new ServiceType { Id = 9, Name = "Tapetarski radovi" },
                new ServiceType { Id = 10, Name = "Parketarski radovi" }
                );
        }

        private void SeedProfessions(ModelBuilder builder)
        {
            builder.Entity<Profession>().HasData(
                new Profession { Id = 1, Name = "Električar" },
                new Profession { Id = 2, Name = "Moler" },
                new Profession { Id = 3, Name = "Vodoinstalater" },
                new Profession { Id = 4, Name = "Parketar" },
                new Profession { Id = 5, Name = "Stolar" },
                new Profession { Id = 6, Name = "Dimnjačar" },
                new Profession { Id = 7, Name = "Baštovan" }
                );
        }

        private void SeedJobStatus(ModelBuilder builder)
        {
            builder.Entity<JobStatus>().HasData(
                new JobStatus { Id = 1, Status = "Aktivan" },
                new JobStatus { Id = 2, Status = "Završen" }
                );
        }

        private void SeedPaymentTypes(ModelBuilder builder)
        {
            builder.Entity<PaymentType>().HasData(
                new PaymentType { Id = 1, Name = "Online plaćanje" },
                new PaymentType { Id = 2, Name = "Plaćanje na licu mjesta" }
                );
        }

        private void SeedCities(ModelBuilder builder)
        {
            builder.Entity<City>().HasData(
                new City { Id = 1, Name = "Mostar", PostalCode = "88000" },
                new City { Id = 2, Name = "Sarajevo", PostalCode = "71000" },
                new City { Id = 3, Name = "Sanski Most", PostalCode = "79260" }
            );
        }
        private void SeedSexes(ModelBuilder builder)
        {
            builder.Entity<Sex>().HasData(
                new Sex { Id = 1, Name = "Muški" },
                new Sex { Id = 2, Name = "Ženski" }
            );
        }

        private void SeedUsers(ModelBuilder builder)
        {
            User user = new User()
            {
                Id = "b74ddd14-6340-4840-95c2-db12554843e5",
                UserName = "desktop",
                NormalizedUserName = "DESKTOP"
            };

            PasswordHasher<User> passwordHasher = new PasswordHasher<User>();
            user.PasswordHash = passwordHasher.HashPassword(user, "test");

            User user2 = new User()
            {
                Id = "864ddd14-6340-4840-fr23-db12554843e5",
                UserName = "mobile",
                NormalizedUserName = "MOBILE",
                Firstname = "Amer",
                Lastname = "Hasanbegovic",
                Address = "Ulica informatičara 38",
                Photo = File.ReadAllBytes("Assets/profile1.jpg"),
                SexId = 1,
                Email = "amer@fixit.com",
                PhoneNumber = "062111223",
                CityId = 3,
                MemberSince = DateTime.Now
            };
            PasswordHasher<User> passwordHasher2 = new PasswordHasher<User>();
            user2.PasswordHash = passwordHasher2.HashPassword(user2, "test");

            User user3 = new User()
            {
                Id = "724ddd14-1234-4840-fr23-db12554843e5",
                UserName = "mobile2",
                NormalizedUserName = "MOBILE2",
                Firstname = "Ada",
                Lastname = "Lovelace",
                Address = "Ulica informatičara 38",
                SexId = 2,
                Email = "ada@fixit.com",
                PhoneNumber = "062112342",
                CityId = 1,
                MemberSince = DateTime.Now
            };
            PasswordHasher<User> passwordHasher3 = new PasswordHasher<User>();
            user3.PasswordHash = passwordHasher3.HashPassword(user3, "test");

            builder.Entity<User>().HasData(user);
            builder.Entity<User>().HasData(user2);
            builder.Entity<User>().HasData(user3);
        }

        private void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Id = "fab4fac1-c546-41de-aebc-a14da6895711", Name = "admin", ConcurrencyStamp = "1", NormalizedName = "Admin" },
                new IdentityRole() { Id = "c7b013f0-5201-4317-abd8-c211f91b7330", Name = "user", ConcurrencyStamp = "2", NormalizedName = "User" }
                );
        }

        private void SeedUserRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895711", UserId = "b74ddd14-6340-4840-95c2-db12554843e5" },
                new IdentityUserRole<string>() { RoleId = "c7b013f0-5201-4317-abd8-c211f91b7330", UserId = "864ddd14-6340-4840-fr23-db12554843e5" },
                new IdentityUserRole<string>() { RoleId = "c7b013f0-5201-4317-abd8-c211f91b7330", UserId = "724ddd14-1234-4840-fr23-db12554843e5" }
                );
        }
    }
}
