using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using ProgFlow.DAL.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFlow.DAL.Services.Base
{
    public class Modifiable<TModel> : Readable<TModel>, IModifiable<TModel> where TModel : class
    {
        public Modifiable(IConfiguration config) : base(config)
        {
        }

        public bool Delete(int id)
        {
            using SqlCommand cmd = Connection.CreateCommand();
            string sql = $"DELETE FROM [dbo].[{FullTablename}] WHERE [{Prefix.ToLower()}_id] = @id";

            cmd.Parameters.AddWithValue("id", id);
            cmd.CommandText = sql;

            Connection.Open();

            try { return cmd.ExecuteNonQuery() > 0; }
            finally { Connection.Close(); }
        }
        public bool Update(TModel model)
        {
            throw new NotImplementedException();
        }
    }
}
