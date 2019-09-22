﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace DACFW.Entities
{
	[DataContract]
	public class ItrisComercioEntity
	{
		[DataMember(EmitDefaultValue = false)]
		public int ID { get; set; }

		[DataMember(EmitDefaultValue = false)]
		public int FK_TIP_COM { get; set; }

		[DataMember(EmitDefaultValue = false)]
		public string NOMBRE { get; set; }

		[DataMember(EmitDefaultValue = false)]
		public string CALLE { get; set; }

		[DataMember(EmitDefaultValue = false)]
		public string NUMERO { get; set; }

		[DataMember(EmitDefaultValue = false)]
		public int FK_ERP_LOCALIDADES { get; set; }

		[DataMember(EmitDefaultValue = false)]
		public int FK_ERP_PROVINCIAS { get; set; }

		[DataMember(EmitDefaultValue = false)]
		public string LATITUD { get; set; }

		[DataMember(EmitDefaultValue = false)]
		public string LONGITUD { get; set; }
	}
}
