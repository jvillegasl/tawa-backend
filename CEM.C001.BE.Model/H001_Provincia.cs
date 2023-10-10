using System.Runtime.Serialization;

namespace CEM.C001.BE.Model
{
	public class H001_Provincia
	{
		[DataMember]
		public string CodDepartamento { get; set; }
		[DataMember]
		public string CodProvincia { get; set; }
		[DataMember]
		public string Provincia { get; set; }
		[DataMember]
		public bool EstadoRegistro { get; set; }
	}
}