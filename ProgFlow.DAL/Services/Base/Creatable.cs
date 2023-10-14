using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using ProgFlow.DAL.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProgFlow.DAL.Services.Base
{
    public class Creatable<TModel> : Modifiable<TModel>, ICreatable<TModel> where TModel : class
    {
        public Creatable(IConfiguration config) : base(config)
        {
        }

        public bool Create(TModel model)
        {
            using SqlCommand cmd = Connection.CreateCommand();
            StringBuilder sb = new();
            PropertyInfo[] props = typeof(TModel).GetProperties();

            sb.Append($"INSERT INTO [dbo].[{FullTablename}] (");
            foreach (PropertyInfo prop in props)
                if (prop.Name is not "Id") sb.Append($"{Prefix.ToLower()}_{prop.Name.ToLower()}");
            sb.Append(") VALUES (");
            foreach (PropertyInfo prop in props)
                if (prop.Name is not "Id") sb.Append($"@{prop.Name.ToString()}");
            sb.Append(')');

            cmd.CommandText = sb.ToString();
            foreach (PropertyInfo prop in props)
                if (prop.Name is not "Id") cmd.Parameters.AddWithValue(prop.Name.ToLower(), prop.GetValue(model));

            Connection.Open();

            try { return cmd.ExecuteNonQuery() > 0; }
            finally { Connection.Close(); }
        }
    }
}
