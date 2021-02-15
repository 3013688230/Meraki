using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Meraki.Entities
{
    public partial class MerakiFinalContext : DbContext
    {
        public MerakiFinalContext()
        {
        }

        public MerakiFinalContext(DbContextOptions<MerakiFinalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Barrio> Barrios { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Conductore> Conductores { get; set; }
        public virtual DbSet<Departamento> Departamentos { get; set; }
        public virtual DbSet<EstadoServicio> EstadoServicios { get; set; }
        public virtual DbSet<EstadoUsuario> EstadoUsuarios { get; set; }
        public virtual DbSet<Genero> Generos { get; set; }
        public virtual DbSet<Municipio> Municipios { get; set; }
        public virtual DbSet<Propietario> Propietarios { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Servicio> Servicios { get; set; }
        public virtual DbSet<TipoCarga> TipoCargas { get; set; }
        public virtual DbSet<TipoVehiculo> TipoVehiculos { get; set; }
        public virtual DbSet<TiposDocumento> TiposDocumentos { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Vehiculo> Vehiculos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-SD53LKE\\SQLEXPRESS;Database=MerakiFinal;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Barrio>(entity =>
            {
                entity.HasKey(e => e.IdBarrio)
                    .HasName("PK__Barrios__42F23FF829EF649B");

                entity.Property(e => e.IdBarrio).HasColumnName("idBarrio");

                entity.Property(e => e.IdMunicipio).HasColumnName("idMunicipio");

                entity.Property(e => e.NombreBarrio)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("nombreBarrio");

                entity.HasOne(d => d.IdMunicipioNavigation)
                    .WithMany(p => p.Barrios)
                    .HasForeignKey(d => d.IdMunicipio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Barrios_Municipios");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__Clientes__885457EE0BC748DE");

                entity.HasIndex(e => e.Celular, "clientes_celular_uq")
                    .IsUnique();

                entity.HasIndex(e => e.Correo, "clientes_correo_uq")
                    .IsUnique();

                entity.HasIndex(e => e.NumeroDocumento, "clientes_numerodocumento_uq")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("apellido");

                entity.Property(e => e.Celular).HasColumnName("celular");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.IdBarrio).HasColumnName("idBarrio");

                entity.Property(e => e.IdGenero).HasColumnName("idGenero");

                entity.Property(e => e.IdTipoDocumento).HasColumnName("idTipoDocumento");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.NumeroDocumento).HasColumnName("numeroDocumento");

                entity.HasOne(d => d.IdBarrioNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdBarrio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Clientes_Barrios");

                entity.HasOne(d => d.IdGeneroNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdGenero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Clientes_Generos");

                entity.HasOne(d => d.IdTipoDocumentoNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdTipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Clientes_tiposDocumento");
            });

            modelBuilder.Entity<Conductore>(entity =>
            {
                entity.HasKey(e => e.IdConductor)
                    .HasName("PK__Conducto__2E74F8E85D64E264");

                entity.HasIndex(e => e.Celular, "Conductores_celular_uq")
                    .IsUnique();

                entity.HasIndex(e => e.Correo, "Conductores_correo_uq")
                    .IsUnique();

                entity.HasIndex(e => e.NumeroDocumento, "Conductores_numeroDocumento_uq")
                    .IsUnique();

                entity.Property(e => e.IdConductor).HasColumnName("idConductor");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("apellido");

                entity.Property(e => e.Celular).HasColumnName("celular");

                entity.Property(e => e.CodigoV)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("codigoV");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.FechaFin)
                    .HasColumnType("date")
                    .HasColumnName("fechaFin");

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("date")
                    .HasColumnName("fechaInicio");

                entity.Property(e => e.FotoConductor)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("fotoConductor");

                entity.Property(e => e.IdBarrio).HasColumnName("idBarrio");

                entity.Property(e => e.IdGenero).HasColumnName("idGenero");

                entity.Property(e => e.IdTipoDocumento).HasColumnName("idTipoDocumento");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.NumeroDocumento).HasColumnName("numeroDocumento");

                entity.HasOne(d => d.CodigoVNavigation)
                    .WithMany(p => p.Conductores)
                    .HasForeignKey(d => d.CodigoV)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Conductores_Vehiculos");

                entity.HasOne(d => d.IdBarrioNavigation)
                    .WithMany(p => p.Conductores)
                    .HasForeignKey(d => d.IdBarrio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Conductores_Barrios");

                entity.HasOne(d => d.IdGeneroNavigation)
                    .WithMany(p => p.Conductores)
                    .HasForeignKey(d => d.IdGenero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Conductores_Generos");

                entity.HasOne(d => d.IdTipoDocumentoNavigation)
                    .WithMany(p => p.Conductores)
                    .HasForeignKey(d => d.IdTipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Conductores_TipoD");
            });

            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.HasKey(e => e.IdDepartamento)
                    .HasName("PK__Departam__C225F98DA7F0112C");

                entity.Property(e => e.IdDepartamento).HasColumnName("idDepartamento");

                entity.Property(e => e.NombreDepartamento)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("nombreDepartamento");
            });

            modelBuilder.Entity<EstadoServicio>(entity =>
            {
                entity.HasKey(e => e.IdEstadoServicio)
                    .HasName("PK__EstadoSe__69076D2A66EFF570");

                entity.Property(e => e.IdEstadoServicio).HasColumnName("idEstadoServicio");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<EstadoUsuario>(entity =>
            {
                entity.HasKey(e => e.IdEstadoUsuario)
                    .HasName("PK__EstadoUs__57088573822F5B29");

                entity.Property(e => e.IdEstadoUsuario).HasColumnName("idEstadoUsuario");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Genero>(entity =>
            {
                entity.HasKey(e => e.IdGenero)
                    .HasName("PK__Generos__85223DA314CEA644");

                entity.Property(e => e.IdGenero).HasColumnName("idGenero");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Municipio>(entity =>
            {
                entity.HasKey(e => e.IdMunicipio)
                    .HasName("PK__Municipi__FD10E400C87EB485");

                entity.Property(e => e.IdMunicipio).HasColumnName("idMunicipio");

                entity.Property(e => e.IdDepartamento).HasColumnName("idDepartamento");

                entity.Property(e => e.NombreMunicipio)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("nombreMunicipio");

                entity.HasOne(d => d.IdDepartamentoNavigation)
                    .WithMany(p => p.Municipios)
                    .HasForeignKey(d => d.IdDepartamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Deparmentos_Municipios");
            });

            modelBuilder.Entity<Propietario>(entity =>
            {
                entity.HasKey(e => e.IdPropietario)
                    .HasName("PK__Propieta__EB8275954DA066AF");

                entity.HasIndex(e => e.Celular, "Propietarios_celular_uq")
                    .IsUnique();

                entity.HasIndex(e => e.Correo, "Propietarios_correo_uq")
                    .IsUnique();

                entity.HasIndex(e => e.NumeroDocumento, "Propietarios_numerodocumento_uq")
                    .IsUnique();

                entity.Property(e => e.IdPropietario).HasColumnName("idPropietario");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("apellido");

                entity.Property(e => e.Celular).HasColumnName("celular");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.IdBarrio).HasColumnName("idBarrio");

                entity.Property(e => e.IdGenero).HasColumnName("idGenero");

                entity.Property(e => e.IdTipoDocumento).HasColumnName("idTipoDocumento");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.NumeroDocumento).HasColumnName("numeroDocumento");

                entity.HasOne(d => d.IdBarrioNavigation)
                    .WithMany(p => p.Propietarios)
                    .HasForeignKey(d => d.IdBarrio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Propietarios_Barrios");

                entity.HasOne(d => d.IdGeneroNavigation)
                    .WithMany(p => p.Propietarios)
                    .HasForeignKey(d => d.IdGenero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Propietarios_Generos");

                entity.HasOne(d => d.IdTipoDocumentoNavigation)
                    .WithMany(p => p.Propietarios)
                    .HasForeignKey(d => d.IdTipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Propietarios_tiposDocumento");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.IdRol)
                    .HasName("PK__Roles__3C872F76A2F59FBC");

                entity.Property(e => e.IdRol).HasColumnName("idRol");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Servicio>(entity =>
            {
                entity.HasKey(e => e.IdServicio)
                    .HasName("PK__Servicio__CEB98119B890DC09");

                entity.Property(e => e.IdServicio).HasColumnName("idServicio");

                entity.Property(e => e.CelularRecibe).HasColumnName("celularRecibe");

                entity.Property(e => e.DireccionCarga)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("direccionCarga");

                entity.Property(e => e.DireccionEntrega)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("direccionEntrega");

                entity.Property(e => e.FechaFin)
                    .HasColumnType("date")
                    .HasColumnName("fechaFin");

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("date")
                    .HasColumnName("fechaInicio");

                entity.Property(e => e.IdBarrio).HasColumnName("idBarrio");

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.IdConductor).HasColumnName("idConductor");

                entity.Property(e => e.IdEstadoServicio).HasColumnName("idEstadoServicio");

                entity.Property(e => e.IdTipoCarga).HasColumnName("idTipoCarga");

                entity.Property(e => e.IdTipoVehiculo).HasColumnName("idTipoVehiculo");

                entity.Property(e => e.PersonaRecibe)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("personaRecibe");

                entity.Property(e => e.PrecioServicio).HasColumnName("precioServicio");

                entity.HasOne(d => d.IdBarrioNavigation)
                    .WithMany(p => p.Servicios)
                    .HasForeignKey(d => d.IdBarrio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Servicios_Barrios");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Servicios)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Servicios_Clientes");

                entity.HasOne(d => d.IdConductorNavigation)
                    .WithMany(p => p.Servicios)
                    .HasForeignKey(d => d.IdConductor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Servicios_Coductores");

                entity.HasOne(d => d.IdEstadoServicioNavigation)
                    .WithMany(p => p.Servicios)
                    .HasForeignKey(d => d.IdEstadoServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Servicios_EstadoServicio");

                entity.HasOne(d => d.IdTipoCargaNavigation)
                    .WithMany(p => p.Servicios)
                    .HasForeignKey(d => d.IdTipoCarga)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Servicios_TipoCargas");

                entity.HasOne(d => d.IdTipoVehiculoNavigation)
                    .WithMany(p => p.Servicios)
                    .HasForeignKey(d => d.IdTipoVehiculo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Servicios_TipoVehiculos");
            });

            modelBuilder.Entity<TipoCarga>(entity =>
            {
                entity.HasKey(e => e.IdTipoCarga)
                    .HasName("PK__TipoCarg__C9C761C3E0369BB6");

                entity.Property(e => e.IdTipoCarga).HasColumnName("idTipoCarga");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<TipoVehiculo>(entity =>
            {
                entity.HasKey(e => e.IdTipoVehiculo)
                    .HasName("PK__TipoVehi__429A3B81590C355E");

                entity.Property(e => e.IdTipoVehiculo).HasColumnName("idTipoVehiculo");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<TiposDocumento>(entity =>
            {
                entity.HasKey(e => e.IdTipoDocumento)
                    .HasName("PK__tiposDoc__61FDF9F527E4600F");

                entity.ToTable("tiposDocumento");

                entity.Property(e => e.IdTipoDocumento).HasColumnName("idTipoDocumento");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuarios__645723A66B92151F");

                entity.HasIndex(e => e.Correo, "usuarios_correo_uq")
                    .IsUnique();

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("clave");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.IdEstado).HasColumnName("idEstado");

                entity.Property(e => e.IdRol).HasColumnName("idRol");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Usuarios_EstadoUsuarios");

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdRol)
                    .HasConstraintName("fk_Usuarios_Roles");
            });

            modelBuilder.Entity<Vehiculo>(entity =>
            {
                entity.HasKey(e => e.CodigoV)
                    .HasName("PK__Vehiculo__BC7B7B90A233FC64");

                entity.HasIndex(e => e.Placa, "Vehiculos_placa_uq")
                    .IsUnique();

                entity.Property(e => e.CodigoV)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("codigoV");

                entity.Property(e => e.Cilindraje).HasColumnName("cilindraje");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("color");

                entity.Property(e => e.FotoV)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("fotoV");

                entity.Property(e => e.IdPropietario).HasColumnName("idPropietario");

                entity.Property(e => e.IdTipoVehiculo).HasColumnName("idTipoVehiculo");

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("marca");

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("modelo");

                entity.Property(e => e.Placa)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("placa");

                entity.Property(e => e.SeguroCarga)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("seguroCarga");

                entity.Property(e => e.Soat)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("soat");

                entity.Property(e => e.TecnoMecanica)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("tecnoMecanica");

                entity.HasOne(d => d.IdPropietarioNavigation)
                    .WithMany(p => p.Vehiculos)
                    .HasForeignKey(d => d.IdPropietario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Vehiculos_Propietarios");

                entity.HasOne(d => d.IdTipoVehiculoNavigation)
                    .WithMany(p => p.Vehiculos)
                    .HasForeignKey(d => d.IdTipoVehiculo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Vehiculos_TipoVehiculos");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
