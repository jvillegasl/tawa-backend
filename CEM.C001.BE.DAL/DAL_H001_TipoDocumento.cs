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
	public class DAL_H001_TipoDocumento : I_H001_TipoDocumento
	{
		private string database;
		public DAL_H001_TipoDocumento(IConfiguration config)
		{
			database = config["Database:CNX"];
		}
		public IEnumerable<H001_TipoDocumento> ListarTipoDocumento()
		{
			List<H001_TipoDocumento> lst = new List<H001_TipoDocumento>();

			string queryString = "SELECT * FROM dbo.H001_TipoDocumento";

			using (SqlConnection connection = new SqlConnection(database))
			{
				SqlCommand command = new SqlCommand(queryString, connection);

				connection.Open();

				using (SqlDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						Console.WriteLine(String.Format("{0}, {1}, {2}, {3}, {4}", reader[0], reader[1], reader[2], reader[3], reader[8]));

						H001_TipoDocumento item = new H001_TipoDocumento
						{
							IdTipoDocumento = reader.GetInt32(0),
							TipoDocumento = reader.GetString(1),
							Abreviatura = reader.GetString(2),
							MaxNumDigito = !reader.IsDBNull(3) ? reader.GetInt32(3) : (int?)null,
							EstadoRegistro = reader.GetBoolean(8),
						};

						lst.Add(item);
					}
				}
			}

			return lst;
		}
	}
}