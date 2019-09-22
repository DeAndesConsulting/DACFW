using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace DACFW.Entities
{
	[DataContract]
	public class ItrisRelevamientoArticuloEntity
	{
		[DataMember(EmitDefaultValue = false)]
		public int ID { get; set; }

		[DataMember(EmitDefaultValue = false)]
		public int FK_RELEVAMIENTO { get; set; }

		[DataMember(EmitDefaultValue = false)]
		public int FK_ARTICULOS { get; set; }

		[DataMember(EmitDefaultValue = false)]
		public int FK_COMERCIO { get; set; }

		[DataMember(EmitDefaultValue = false)]
		public bool EXISTE { get; set; }

		[DataMember(EmitDefaultValue = false)]
		public double PRECIO { get; set; }
	}
}
