using ELMS.AuthService.Infrastructure.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ELMS.AuthService.Infrastructure.Configurations;

internal class RolePermissionTableConfig : IEntityTypeConfiguration<RolePermissionEntity>
{
    public void Configure(EntityTypeBuilder<RolePermissionEntity> builder)
    {
        // Relationship with Role
        builder.HasOne<RoleEntity>()
               .WithMany()
               .HasForeignKey(rp => rp.RoleId)
               .OnDelete(DeleteBehavior.Cascade);

        // Relationship with Permission
        builder.HasOne<PermissionEntity>()
               .WithMany()
               .HasForeignKey(rp => rp.PermissionId)
               .OnDelete(DeleteBehavior.Cascade);

        // Prevent duplicate Role-Permission combinations
        builder.HasIndex(rp => new { rp.RoleId, rp.PermissionId })
               .IsUnique();
    }
}
