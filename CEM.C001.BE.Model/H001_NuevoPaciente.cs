using System;
using System.Runtime.Serialization;

namespace CEM.C001.BE.Model
{
	public class H001_NuevoPaciente
	{
		[DataMember]
		public string Nombre { get; set; }
		[DataMember]
		public string ApellidoMaterno { get; set; }
		[DataMember]
		public string ApellidoPaterno { get; set; }
		[DataMember]
		public string CodUbigeoNacimiento { get; set; }
		[DataMember]
		public string Correo { get; set; }
		[DataMember]
		public DateTime FechaNacimiento { get; set; }
		[DataMember]
		public int IdTipoDocumento { get; set; }
		[DataMember]
		public string NumDocIdentidad { get; set; }
		[DataMember]
		public string IdSexo { get; set; }
		[DataMember]
		public string TelefonoMovil { get; set; }
	}
}