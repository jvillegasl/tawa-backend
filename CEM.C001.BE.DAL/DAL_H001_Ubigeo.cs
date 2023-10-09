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
    public class DAL_H001_Ubigeo:I_H001_Ubigeo
    {
        private string database;
        public DAL_H001_Ubigeo(IConfiguration config)
        {
            database = config["Database:CNX"];
        }
   
        public IEnumerable<H001_Ubigeo> ListarDepartamento(){
            List<H001_Ubigeo> lst = new List<H001_Ubigeo>();        
            return lst;
        }

        public IEnumerable<H001_Ubigeo> ListarProvincia(string psCodDepartamento){
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