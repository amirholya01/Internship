using Internship.Datalayer.Entities.User;
using Microsoft.EntityFrameworkCore;

namespace Internship.Datalayer.Context;

public class InternshipAppContext: DbContext
{
    public InternshipAppContext(DbContextOptions<InternshipAppContext>options):base(options)
    {
        
    }

    #region User

    public DbSet<Role> Roles { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserRole> UserRoles { get; set; }

    #endregion 
}