using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RihalChallenge.Models
{
    public class SqliteDbContext : DbContext
    {
        #region Contructor
        public SqliteDbContext(DbContextOptions<SqliteDbContext> options)
                : base(options)
        {
            Database.EnsureCreated();
        }
        #endregion

        #region 
        public DbSet<Students> Students { get; set; }
        public DbSet<Countries> Countries { get; set; }
        public DbSet<Classes> Classes { get; set; }
        #endregion

        #region Overidden methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Students>().HasData(GetStudents());

             modelBuilder.Entity<Countries>().HasData(GetCountries());

             modelBuilder.Entity<Classes>().HasData(GetClasses());

            modelBuilder.Entity<Students>()
                        .HasOne<Classes>(b => b.Classes)
                        .WithMany(a => a.Students)
                        .HasForeignKey(b => b.Class_id);

            modelBuilder.Entity<Students>()
                        .HasOne<Countries>(b => b.Countries)
                        .WithMany(a => a.Students)
                        .HasForeignKey(b => b.Country_id);

            base.OnModelCreating(modelBuilder);
        }
        #endregion


        #region Private methods
        private List<Students> GetStudents()
        {

            List<Students> Students = new List<Students>();

            for (int i = 0; i < 100; i++)
            {
                Students.Add(new Students { Id = (i + 1), Class_id = Faker.RandomNumber.Next(1, 5), Country_id = Faker.RandomNumber.Next(1, 5), name = Faker.Name.FullName() , Date_of_birth = Faker.Identification.DateOfBirth() });
            }

            return Students;
        }

        private List<Countries> GetCountries()
        {
            return new List<Countries>
            {
                new Countries { Id = 1, Name = "Oman"},
                new Countries { Id = 2, Name = "KSA"},
                new Countries { Id = 3, Name = "UAE"},
                new Countries { Id = 4, Name = "Qatar"},
                new Countries { Id = 5, Name = "Kuwait"}
            };
        }

        private List<Classes> GetClasses()
        {

            return new List<Classes>
            {
                new Classes { Id = 1, class_name = "Dot.Net"},
                new Classes { Id = 2, class_name = "AI"},
                new Classes { Id = 3, class_name = "ML"},
                new Classes { Id = 4, class_name = "Laravel"},
                new Classes { Id = 5, class_name = "Game Development"}
            };
        }
        #endregion
    }
}
