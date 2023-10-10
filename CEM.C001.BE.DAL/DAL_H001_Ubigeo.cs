using CEM.C001.BE.Interface;
using CEM.C001.BE.Model;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CEM.C001.BE.DAL
{
	public class DAL_H001_Ubigeo : I_H001_Ubigeo
	{
		private string database;
		public DAL_H001_Ubigeo(IConfiguration config)
		{
			database = config["Database:CNX"];
		}

		public IEnumerable<H001_Departamento> ListarDepartamento()
		{
			List<H001_Departamento> lst = new List<H001_Departamento>();

			string queryString = "SELECT * FROM dbo.H001_Departamento";

			using (SqlConnection connection = new SqlConnection(database))
			{
				SqlCommand command = new SqlCommand(queryString, connection);

				connection.Open();

				using (SqlDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						H001_Departamento item = new H001_Departamento
						{
							CodDepartamento = reader.GetString(0),
							Departamento = reader.GetString(1),
							EstadoRegistro = reader.GetBoolean(6)
						};

						lst.Add(item);
					}
				}
			}

			return lst;
		}

		public IEnumerable<H001_Provincia> ListarProvincia(string psCodDepartamento)
		{
			List<H001_Provincia> lst = new List<H001_Provincia>();

			string queryString = "SELECT * FROM dbo.H001_Provincia WHERE CodDepartamento=@Cod";

			using (SqlConnection connection = new SqlConnection(database))
			{
				SqlCommand command = new SqlCommand(queryString, connection);
				command.Parameters.Add("@Cod", SqlDbType.VarChar);
				command.Parameters["@Cod"].Value = psCodDepartamento;

				connection.Open();

				using (SqlDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						H001_Provincia item = new H001_Provincia
						{
							CodDepartamento = reader.GetString(0),
							CodProvincia = reader.GetString(1),
							Provincia = reader.GetString(2),
							EstadoRegistro = reader.GetBoolean(7)
						};

						lst.Add(item);
					}
				}
			}

			return lst;
		}

		public IEnumerable<H001_Distrito> ListarDistrito(string psCodDepartamento, string psCodProvincia)
		{
			List<H001_Distrito> lst = new List<H001_Distrito>();

			string queryString = "SELECT * FROM dbo.H001_Ubigeo WHERE CodDepartamento=@CodDepartamento AND CodProvincia=@CodProvincia";

			using (SqlConnection connection = new SqlConnection(database))
			{
				SqlCommand command = new SqlCommand(queryString, connection);
				command.Parameters.Add("@CodDepartamento", SqlDbType.VarChar);
				command.Parameters["@CodDepartamento"].Value = psCodDepartamento;
				command.Parameters.Add("@CodProvincia", SqlDbType.VarChar);
				command.Parameters["@CodProvincia"].Value = psCodProvincia;

				connection.Open();

				using (SqlDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						H001_Distrito item = new H001_Distrito
						{
							CodUbigeo = reader.GetString(0),
							CodDepartamento = reader.GetString(1),
							CodProvincia = reader.GetString(2),
							Distrito = reader.GetString(3),
							EstadoRegistro = reader.GetBoolean(8)
						};

						lst.Add(item);
					}
				}
			}

			return lst;
		}
	}
}