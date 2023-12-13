using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Data.Entities
{
    public class LMSDBContext: DbContext
    {
        public LMSDBContext(DbContextOptions<LMSDBContext> options) : base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Daire> Daireler { get; set; }
        public DbSet<Aidat> Aidatlar { get; set; }
        public DbSet<Fatura> Faturalar { get; set; }
        public DbSet<Odeme> Odemeler { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Buraya ekleyin
            builder.Entity<User>(b =>
            {
                b.HasKey(u => new { u.Email, u.Password });
                b.HasKey(u => u.Id);
            });
            // İlişkileri burada tanımlayabilirsiniz
            builder.Entity<Aidat>()
      .HasOne(a => a.Daire)
      .WithMany(d => d.Aidatlar)
      .HasForeignKey(a => a.DaireID) // Use DaireID instead of Id
      .HasPrincipalKey(d => d.DaireID) // Use DaireID instead of Id
      .IsRequired();

            builder.Entity<Fatura>()
                .HasOne(f => f.Daire)
                .WithMany(d => d.Faturalar)
                .HasForeignKey(f => f.DaireID) // Use DaireID instead of Id
                .HasPrincipalKey(d => d.DaireID) // Use DaireID instead of Id
                .IsRequired();

            builder.Entity<Odeme>()
       .HasOne(o => o.Kullanici)
       .WithMany(u => u.Odemeler)
       .HasForeignKey(o => o.KullaniciId) // Use KullaniciId instead of Email and Password
       .HasPrincipalKey(u => u.Id);
        }
    
    }
}
