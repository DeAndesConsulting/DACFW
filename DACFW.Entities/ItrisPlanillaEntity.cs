using System;
using System.Collections.Generic;

namespace DACFW.Entities
{
	public class ItrisPlanillaEntity
	{
		public ItrisRelevamientoEntity Relevamiento { get; set; }
		public List<ItrisComercioArticulo> Comercios { get; set; }
		public string CodigoRequest { get; set; }
	}
}
