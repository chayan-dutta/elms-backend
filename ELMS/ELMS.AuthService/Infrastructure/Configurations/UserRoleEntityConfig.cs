using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ELMS.AuthService.Infrastructure.Configurations;

internal class UserRoleEntityConfig : IEntityTypeConfiguration<UserRoleEntity>
{
    public void Configure(EntityTypeBuilder<UserRoleEntity> builder)
    {
        builder.HasOne<EmployeeEntity>()
            .WithMany()
            .HasForeignKey(ur => ur.UserId);

        builder.HasOne<RoleEntity>()
               .WithMany()
               .HasForeignKey(ur => ur.RoleId);

        builder.HasIndex(ur => new { ur.UserId, ur.RoleId })
               .IsUnique();
    }
}
