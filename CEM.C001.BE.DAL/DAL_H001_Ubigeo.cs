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

		public IEnumerable<H001_Ubigeo> ListarProvincia(string psCodDepartamento)
		{
			List<H001_Ubigeo> lst = new List<H001_Ubigeo>();
			return lst;
		}

		public IEnumerable<H001_Ubigeo> ListarDistrito(string psCodDepartamento, string psCodProvincia)
		{
			List<H001_Ubigeo> lst = new List<H001_Ubigeo>();
			return lst;
		}
	}
}