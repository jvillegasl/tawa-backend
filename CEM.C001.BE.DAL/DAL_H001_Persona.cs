using CEM.C001.BE.Interface;
using CEM.C001.BE.Model;

using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CEM.C001.BE.DAL
{
	public class DAL_H001_Persona : I_H001_Persona
	{
		private string database;

		public DAL_H001_Persona(IConfiguration config)
		{
			database = config["Database:CNX"];
		}

		public bool InsertarPersona(H001_NuevoPaciente poH001_NuevoPaciente)
		{
			string queryString = "INSERT INTO H001_Persona (IdTipoDocumento, NumDocIdentidad, Nombre, ApellidoPaterno, ApellidoMaterno, Sexo, FechaNacimiento, CodUbigeoNacimiento, TelefonoMovil, Correo, CodPersona, FechaCreaRegistro) VALUES (@IdTipoDocumento, @NumDocIdentidad, @Nombre, @ApellidoPaterno, @ApellidoMaterno, @Sexo, @FechaNacimiento, @CodUbigeoNacimiento, @TelefonoMovil, @Correo, @CodPersona, @FechaCreaRegistro)";

			using (SqlConnection connection = new SqlConnection(database))
			{
				SqlCommand command = new SqlCommand(queryString, connection);
				command.Parameters.AddWithValue("@IdTipoDocumento", poH001_NuevoPaciente.IdTipoDocumento);
				command.Parameters.AddWithValue("@NumDocIdentidad", poH001_NuevoPaciente.NumDocIdentidad);
				command.Parameters.AddWithValue("@Nombre", poH001_NuevoPaciente.Nombre);
				command.Parameters.AddWithValue("@ApellidoPaterno", poH001_NuevoPaciente.ApellidoPaterno);
				command.Parameters.AddWithValue("@ApellidoMaterno", poH001_NuevoPaciente.ApellidoMaterno);
				command.Parameters.AddWithValue("@Sexo", poH001_NuevoPaciente.IdSexo);
				command.Parameters.AddWithValue("@FechaNacimiento", poH001_NuevoPaciente.FechaNacimiento);
				command.Parameters.AddWithValue("@CodUbigeoNacimiento", poH001_NuevoPaciente.CodUbigeoNacimiento);
				command.Parameters.AddWithValue("@TelefonoMovil", poH001_NuevoPaciente.TelefonoMovil);
				command.Parameters.AddWithValue("@Correo", poH001_NuevoPaciente.Correo);
				command.Parameters.AddWithValue("@CodPersona", (new Random()).Next().ToString());
				command.Parameters.AddWithValue("@FechaCreaRegistro", DateTime.Now);

				connection.Open();

				command.ExecuteNonQuery();
			}

			return true;
		}
	}
}
// CodPersona
// IdTipoDocumento
// NumDocIdentidad
// Nombre
// ApellidoPaterno
// ApellidoMaterno
// Sexo
// FechaNacimiento
// IdPertenenciaEtnica
// IdPaisNacimiento
// CodUbigeoNacimiento
// Foto
// IdGradoInstruccion
// IdReligion
// CentroEducativo
// IdEstadoCivil
// IdOcupacion
// TelefonoFijo
// TelefonoMovil
// Correo
// IdTipoPersona
// TratamientoDato
// TerminoCondicion
// CodUsuario
// CodUsuCreaRegistro
// FechaCreaRegistro
// CodUsuModificaRegistro
// FechaModificaRegistro
// EstadoRegistro