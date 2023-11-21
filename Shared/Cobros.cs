using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samir_API1_P2.Shared
{
	public class Cobros
	{
		[Key]
		public int CobroId { get; set; }
		public string? Observaciones { get; set; } = string.Empty;

		[ForeignKey("EntradaId")]
		public ICollection<CobrosDetalle> CobradoDetail { get; set; } = new List<CobrosDetalle>();
	}
}
