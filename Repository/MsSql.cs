using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using Dapper.FastCrud;
using Microsoft.Data.SqlClient;

namespace Repository
{
    public class MsSql<T> where T : class, new()
    {
        private readonly SqlConnection _conn;
        
        public MsSql(string connstr)
        {
            OrmConfiguration.DefaultDialect = SqlDialect.MsSql;
            _conn = new SqlConnection(connstr);
        }

        protected SqlConnection GetConnection()
        {
            return _conn;
        }

        public dynamic Insert(T item)
        {
            dynamic result = null;
            try
            {
                _conn.Open();
                _conn.Insert(item);
                result = item;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw new Exception(ex.ToString());
            }
            finally
            {
                _conn.Close();
            }
            return result;
        }
        
        public bool Update(T item)
        {
            var result = false;
            try
            {
                _conn.Open();
                result = _conn.Update(item);
            }
            catch (Exception ex)
            {
                var exstr = ex.Message;
                throw;
            }
            finally
            {
                _conn.Close();
            }
            return result;
        }
        
        public bool Delete(T entity)
        {
            var result = false;

            try
            {
                _conn.Open();
                result = _conn.Delete<T>(entity);
            }
            catch (Exception ex)
            {
                string exstr = ex.Message;
                throw;
            }
            finally
            {
                _conn.Close();
            }
            return result;
        }
        
        public List<T> GetAll()
        {
            var result = new List<T>();
            try
            {
                _conn.Open();
                result = _conn.Find<T>().ToList();
            }
            catch (Exception ex)
            {
                string exstr = ex.Message;
            }
            finally
            {
                _conn.Close();
            }
            return result;
        }
       
        public T ItemQuery(string query)
        {
            var result = new T();
            try
            {
                _conn.Open();
                result = _conn.Query<T>(query).FirstOrDefault();
            }
            catch (Exception ex)
            {
                string err = ex.Message;
            }
            finally
            {
                _conn.Close();
            }
            return result;
        }
        
        public List<T> ListQuery(string query)
        {
            var result = new List<T>();
            try
            {
                _conn.Open();
                result = _conn.Query<T>(query).ToList();
            }
            catch (Exception ex)
            {
                string err = ex.Message;
            }
            finally
            {
                _conn.Close();
            }
            return result;
        }
        
        public int CountQuery(string query)
        {
            var result = 0;
            try
            {
                _conn.Open();
                result = _conn.Query<int>(query).FirstOrDefault();
            }
            catch (Exception ex)
            {
                string err = ex.Message;
            }
            finally
            {
                _conn.Close();
            }
            return result;
        }
        
        public static List<G> ListQueryGeneric<G>(string query)
        {
            var result = new List<G>();
            var conn = new SqlConnection(DbConfiguration.mssql_Connstr);
            try
            {
                conn.Open();
                result = conn.Query<G>(query).ToList();
            }
            catch (Exception ex)
            {
                string err = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
     
        
    }
}