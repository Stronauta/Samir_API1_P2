using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samir_API1_P2.Shared
{
	public class VentasDetalles
	{
		[Key]
		public int ventasDetailId { get; set; }
		[ForeignKey("VentaId")]
		public int VentaId { get; set; }
		public int cobrado { get; set; }
	}
}
