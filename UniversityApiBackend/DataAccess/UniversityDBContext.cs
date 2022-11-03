using Microsoft.EntityFrameworkCore;
<<<<<<< HEAD
<<<<<<< HEAD
using UniversityApiBackend.Models;
=======
>>>>>>> 2e7232a633bf4a597ef4321da9869b479b256789
=======
>>>>>>> 2e7232a633bf4a597ef4321da9869b479b256789
using UniversityApiBackend.Models.DataModels;

namespace UniversityApiBackend.DataAccess
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options) : base(options) 
        { 

        }

        // TODO: Add DbSets (tables of our Data Base)
        public DbSet<User>? Users { get; set; }
<<<<<<< HEAD
<<<<<<< HEAD
        public DbSet<Course>? Courses { get; set; }
        public DbSet<Chapter>? Chapters{ get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Student>? Students { get; set; }
=======
>>>>>>> 2e7232a633bf4a597ef4321da9869b479b256789
=======
>>>>>>> 2e7232a633bf4a597ef4321da9869b479b256789

    }
}
