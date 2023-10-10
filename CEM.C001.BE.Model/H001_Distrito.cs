using System.Runtime.Serialization;

namespace CEM.C001.BE.Model
{
	public class H001_Distrito
	{
		[DataMember]
		public string CodUbigeo { get; set; }
		[DataMember]
		public string CodDepartamento { get; set; }
		[DataMember]
		public string CodProvincia { get; set; }
		[DataMember]
		public string Distrito { get; set; }
		[DataMember]
		public bool EstadoRegistro { get; set; }
	}
}