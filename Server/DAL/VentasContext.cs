﻿using Microsoft.EntityFrameworkCore;
using Samir_API1_P2.Shared;

namespace Samir_API1_P2.Server.DAL
{
	public class VentasContext : DbContext
	{
		public DbSet<Ventas> Ventas { get; set; }
		public DbSet<Clientes> Clientes { get; set; }
		public DbSet<Cobros> Cobros { get; set; }

		public DbSet<CobrosDetalle> CobrosDetalle { get; set; }
		public VentasContext(DbContextOptions<VentasContext> options) : base(options)
		{

		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Clientes>().HasData(new Clientes() { ClienteId = 1, Nombres = "FERRETERIA GAMA" });

			modelBuilder.Entity<Ventas>().HasData(new Ventas() { VentaId = 1, Fecha = new DateTime(2020, 09, 01), ClienteId = 1, Monto = 1000, Balance = 1000 });

			modelBuilder.Entity<Ventas>().HasData(new Ventas() { VentaId = 2, Fecha = new DateTime(2020, 10, 01), ClienteId = 1, Monto = 900, Balance = 800 });

			modelBuilder.Entity<Clientes>().HasData(new Clientes() { ClienteId = 2, Nombres = "AVALON DISCO" });

			modelBuilder.Entity<Ventas>().HasData(new Ventas() { VentaId = 3, Fecha = new DateTime(2020, 09, 01), ClienteId = 2, Monto = 2000, Balance = 2000 });

			modelBuilder.Entity<Ventas>().HasData(new Ventas() { VentaId = 4, Fecha = new DateTime(2020, 10, 01), ClienteId = 2, Monto = 1900, Balance = 1800 });

			modelBuilder.Entity<Clientes>().HasData(new Clientes() { ClienteId = 3, Nombres = "PRESTAMOS CEFIPROD" });

			modelBuilder.Entity<Ventas>().HasData(new Ventas() { VentaId = 5, Fecha = new DateTime(2020, 09, 01), ClienteId = 3, Monto = 3000, Balance = 3000 });

			modelBuilder.Entity<Ventas>().HasData(new Ventas() { VentaId = 6, Fecha = new DateTime(2020, 10, 01), ClienteId = 3, Monto = 2900, Balance = 1900 });
		}
	}
}
