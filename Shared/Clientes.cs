using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samir_API1_P2.Shared
{
	public class Clientes
	{
		[Key]
		public int ClienteId { get; set; }
		public string? Nombres { get; set; }
	}
}
