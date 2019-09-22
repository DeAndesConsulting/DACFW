using System;
using System.Collections.Generic;
using System.Text;

namespace DACFW.Entities
{
	public class ItrisComercioArticulo
	{
		public ItrisComercioEntity Comercio { get; set; }
		public List<ItrisRelevamientoArticuloEntity> RelevamientoArticulo { get; set; }
	}
}
