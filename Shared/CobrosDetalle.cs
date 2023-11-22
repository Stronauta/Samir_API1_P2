using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Samir_API1_P2.Shared
{
	public class CobrosDetalle
	{
		[Key]
		public int CobradoDetailId { get; set; }

		public int CobroId { get; set; }

		public int VentaId { get; set; }

		public double montoCobrado { get; set; }

		public bool esCobrado { get; set; } = false;

	}
}
