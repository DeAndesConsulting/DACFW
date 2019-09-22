using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace DACFW.Entities
{
	[DataContract]
	public class ItrisRelevamientoEntity
	{
		[DataMember(EmitDefaultValue = false)]
		public int ID { get; set; }

		[DataMember(EmitDefaultValue = false)]
		public string FK_ERP_EMPRESAS { get; set; }

		[DataMember(EmitDefaultValue = false)]
		public int FK_ERP_ASESORES { get; set; }

		[DataMember(EmitDefaultValue = false)]
		public string FECHA { get; set; }

		[DataMember(EmitDefaultValue = false)]
		public string CODIGO { get; set; }

		[DataMember(EmitDefaultValue = false)]
		public bool ENVIADO_POR_MAIL { get; set; }
	}
}
