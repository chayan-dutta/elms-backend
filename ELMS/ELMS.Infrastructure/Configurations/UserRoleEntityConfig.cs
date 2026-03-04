using ELMS.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ELMS.Infrastructure.Configurations;

internal class UserRoleEntityConfig : IEntityTypeConfiguration<UserRoleEntity>
{
    public void Configure(EntityTypeBuilder<UserRoleEntity> builder)
    {
        builder.HasOne<EmployeeEntity>()
            .WithMany()
            .HasForeignKey(ur => ur.EmployeeId);

        builder.HasOne<RoleEntity>()
               .WithMany()
               .HasForeignKey(ur => ur.RoleId);

        builder.HasIndex(ur => new { ur.EmployeeId, ur.RoleId })
               .IsUnique();
    }
}
