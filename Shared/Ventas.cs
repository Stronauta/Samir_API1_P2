using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samir_API1_P2.Shared
{
	public class Ventas
	{
		[Key]
		public int VentaId { get; set; }
		public DateTime Fecha { get; set; } = DateTime.Now;
		public int ClienteId { get; set; }
		public double Monto { get; set; }
		public double Balance { get; set; }
		public string? Observaciones { get; set; }

		public ICollection<VentasDetalles> ventasDetalles { get; set; } = new List<VentasDetalles>();
	}
}
