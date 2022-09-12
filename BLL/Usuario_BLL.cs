using System;
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
        public int Incluir(Modelo.Modelo_Produto usuario)
        {
            try
            {
                return new DAL.Produtos_DAL().Incluir(usuario);
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
        public int Excluir(Modelo.Modelo_Produto usuario)
        {
            try
            {
                return new DAL.Produtos_DAL().Excluir(usuario);
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
        public int Recuperar(Modelo.Modelo_Produto usuario)
        {
            try
            {
                return new DAL.Produtos_DAL().Recuperar(usuario);
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
        public int Atualizar(Modelo.Modelo_Produto usuario)
        {
            try
            {
                return new DAL.Produtos_DAL().Atualizar(usuario);
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
