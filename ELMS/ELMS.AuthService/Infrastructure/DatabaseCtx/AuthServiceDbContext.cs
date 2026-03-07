using ELMS.AuthService.Infrastructure.Entity;
using Microsoft.EntityFrameworkCore;

namespace ELMS.AuthService.Infrastructure.DatabaseCtx;

/// <summary>
/// Represents the Entity Framework Core database context for authentication and authorization data, including users,
/// roles, permissions, and their relationships.
/// </summary>
/// <param name="options">The options to be used by the DbContext.</param>
public class AuthServiceDbContext(DbContextOptions<AuthServiceDbContext> options) 
    : DbContext(options)
{
    /// <summary>
    /// Represents the collection of user credential entities in the context.
    /// </summary>
    public DbSet<UserCredentialEntity> Users { get; set; }
    
    /// <summary>
    /// Represents the collection of permission entities in the database context.
    /// </summary>
    public DbSet<PermissionEntity> Permissions { get; set; }
    
    /// <summary>
    /// Represents the collection of role entities in the context.
    /// </summary>
    public DbSet<RoleEntity> Roles { get; set; }
    
    /// <summary>
    /// Represents the collection of role permission entities in the context.
    /// </summary>
    public DbSet<RolePermissionEntity> RolePermissions { get; set; }
    
    /// <summary>
    /// Represents the collection of user roles in the database.
    /// </summary>
    public DbSet<UserRoleEntity> UserRoles { get; set; }

    /// <summary>
    /// Configures the model for the context by applying entity configurations from the current assembly.
    /// </summary>
    /// <param name="modelBuilder">The builder used to construct the model for the context.</param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AuthServiceDbContext).Assembly);
    }
}