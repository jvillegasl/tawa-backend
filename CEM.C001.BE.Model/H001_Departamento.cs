using System;
using System.Runtime.Serialization;

namespace CEM.C001.BE.Model
{
	public class H001_Departamento
	{
		[DataMember]
		public string CodDepartamento { get; set; }
		[DataMember]
		public string Departamento { get; set; }
		[DataMember]
		public bool EstadoRegistro { get; set; }
	}
}