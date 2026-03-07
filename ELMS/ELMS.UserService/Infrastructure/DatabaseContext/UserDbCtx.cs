using ELMS.UserService.Infrastructure.Entity;
using Microsoft.EntityFrameworkCore;

namespace ELMS.UserService.Infrastructure.DatabaseContext;

/// <summary>
/// Represents the Entity Framework database context for user entities.
/// </summary>
/// <param name="options">The options to configure the context.</param>
public class UserDbCtx(DbContextOptions<UserDbCtx> options) : DbContext(options)
{
    /// <summary>
    /// Represents the collection of users in the database context.
    /// </summary>
    public DbSet<UserEntity> Users { get; set; }
}
