using CEM.C001.BE.Interface;
using CEM.C001.BE.Model;

using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CEM.C001.BE.DAL{
    public class DAL_H001_Persona : I_H001_Persona
    {
        private string database;

        public DAL_H001_Persona(IConfiguration config)
        {
            database = config["Database:CNX"];
        }
    
        public bool InsertarPersona(H001_Persona poH001_Persona){           
            return true;
        }
    }
}