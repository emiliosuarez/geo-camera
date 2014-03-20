namespace GeoNote.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using Dapper;
    using GeoNote.Models;
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;

    public class DataAccessor
    {
        private string ConnString = ConfigurationManager.ConnectionStrings["AzureGeoNote"].ConnectionString.ToString();

        public DataAccessor()
        {
        }

        private IDbConnection GetConnection()
        {
            return new SqlConnection(ConnString);
        }

        public List<T> QueryForList<T>(string query, dynamic parameters) where T : class
        {
            List<T> items = PerformQuery<T>(query, parameters);

            if (items != null && items.Count > 0)
            {
                return items;
            }
            else
            {
                return null;
            }
        }

        public List<T> PerformQuery<T>(string query, dynamic parameters) where T : class
        {
            IDbTransaction trans = null;

            IDbConnection conn = (GetConnection());

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                CommandType commandType = CommandType.Text;

                var items = SqlMapper.Query<T>(conn, query, parameters, commandType: commandType, transaction: trans);
                return items;
            }
            catch (Exception e)
            {
                throw new Exception("Statement failed due to: " + e.ToString());
            }
            finally
            {

                if (conn == null)
                {
                    conn.Close();
                }
            }

        }

        public List<Image> GetImages()
        {
            List<Image> images = new List<Image>();

            images = PerformQuery<Image>("select * from Images", new { });

            return images;
        }
    }
}