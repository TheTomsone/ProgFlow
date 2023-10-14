using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using ProgFlow.DAL.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProgFlow.DAL.Services.Base
{
    public class Readable<TModel> : BaseService<TModel>, IReadable<TModel> where TModel : class
    {
        public Readable(IConfiguration config) : base(config)
        {
        }

        public IEnumerable<TModel> GetAll()
        {
            using SqlCommand cmd = Connection.CreateCommand();
            List<TModel> list = new();
            string sql = $"SELECT * FROM [dbo].[V_{Tablename}]";

            cmd.CommandText = sql;

            Connection.Open();
            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) list.Add(Map(reader));

            try { return list; }
            finally { Connection.Close(); }
        }
        public TModel GetById(int id)
        {
            using SqlCommand cmd = Connection.CreateCommand();
            string sql = $"SELECT * FROM [dbo].[V_{Tablename}] WHERE [{Prefix.ToLower()}_id] = @id";

            cmd.Parameters.AddWithValue("id", id);
            cmd.CommandText = sql;

            Connection.Open();
            using SqlDataReader reader = cmd.ExecuteReader();

            try { return Map(reader); }
            finally { Connection.Close(); }
        }
        public TModel Map(IDataReader reader)
        {
            TModel model = Activator.CreateInstance<TModel>();
            PropertyInfo[] props = typeof(TModel).GetProperties();

            foreach (PropertyInfo prop in props)
            {
                object value = reader[$"{Prefix.ToLower()}_{prop.Name.UnderscoreBetweenLowerUpper().ToLower()}"];
                if (value is not null) prop.SetValue(model, value);
            }

            return model;
        }
    }
}