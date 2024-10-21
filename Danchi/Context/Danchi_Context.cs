using Danchi.Models;
using Microsoft.EntityFrameworkCore;

namespace Danchi.Context
{
    public class Danchi_Context : DbContext
    {
        public Danchi_Context(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Administrador> administrador { get; set; }
        public DbSet<AnuncioAcontecimientos> anuncioAcontecimientos { get; set; }
        public DbSet<AutenticacionUsuario> autenticacionUsuario { get; set; }
        public DbSet<ChatInterno> chatInterno { get; set; }
        public DbSet<NotificacionEmergencias> notificacionEmergencias { get; set; }
        public DbSet<Residente> residentes { get; set; }
        public DbSet<SoporteTecnico> soporteTecnicos { get; set; }
        public DbSet<SugerenciasReporteErrores> sugerenciasReporteErrores { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            EntityConfuguration(modelBuilder);
        }

        private void EntityConfuguration(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administrador>().ToTable("Administrador");
            modelBuilder.Entity<Administrador>().HasKey(u => u.IdAdministrador);
            modelBuilder.Entity<Administrador>().Property(u => u.IdAdministrador).HasColumnName("IdAdministrador").ValueGeneratedOnAdd();
            modelBuilder.Entity<Administrador>().Property(u => u.Nombre).HasColumnName("Nombre");
            modelBuilder.Entity<Administrador>().Property(u => u.CelularAdministrador).HasColumnName("CelularAdministrador");
            modelBuilder.Entity<Administrador>().Property(u => u.CorreoElectronicoAd).HasColumnName("CorreoElectronicoAd");

            modelBuilder.Entity<AnuncioAcontecimientos>().ToTable("AnuncioAcontecimientos");
            modelBuilder.Entity<AnuncioAcontecimientos>().HasKey(u => u.IdAcontecimiento);
            modelBuilder.Entity<AnuncioAcontecimientos>().Property(u => u.IdAcontecimiento).HasColumnName("IdAcontecimiento").ValueGeneratedOnAdd();
            modelBuilder.Entity<AnuncioAcontecimientos>().Property(u => u.TipoAcontecimiento).HasColumnName("TipoAcontecimiento");
            modelBuilder.Entity<AnuncioAcontecimientos>().Property(u => u.Descripcion).HasColumnName("Descripcion");
            modelBuilder.Entity<AnuncioAcontecimientos>().Property(u => u.EstadoAcontecimiento).HasColumnName("EstadoAcontecimiento");
            modelBuilder.Entity<AnuncioAcontecimientos>().Property(u => u.LugarAcontecimiento).HasColumnName("LugarAcontecimiento");
            modelBuilder.Entity<AnuncioAcontecimientos>().Property(u => u.FechaYHora).HasColumnName("FechaYHora");




        }

        public async Task<bool> SaveAsync()
        {
            return await SaveChangesAsync() > 0;
        }
    }
}
