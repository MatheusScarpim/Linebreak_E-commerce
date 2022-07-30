﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace BLL
{
    public class Usuario_BLL
    {
        public int Incluir(Modelo.Modelo_Usuario usuario)
        {
            try
            {
                return new DAL.Usuario_DAL().Incluir(usuario);
            }
            catch (SqlException sqlEx)
            {
                string msg = Funcoes.Messagens.RetornaMsgSQLException(sqlEx);
                throw new Exception(msg);
            }
            catch (Exception ex)
            {
                string msg = Funcoes.Messagens.RetornaMsgException(ex);
                throw new Exception(msg);
            }
        }
    }
}
