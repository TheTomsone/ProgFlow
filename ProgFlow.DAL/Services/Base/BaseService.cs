using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using ProgFlow.DAL.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProgFlow.DAL.Services.Base
{
    public class BaseService<TModel> : IBaseService<TModel> where TModel : class
    {
        private readonly SqlConnection _connection;
        public string Prefix => typeof(TModel).Name.DeleteLowerChar();
        public string Tablename => typeof(TModel).Name.UnderscoreBetweenLowerUpper().ToUpper();
        public string FullTablename => Prefix + "_" + Tablename;
        public SqlConnection Connection => _connection;

        public BaseService(IConfiguration config)
        {
            _connection = new SqlConnection(config.GetConnectionString("default"));
        }
    }
    public static partial class RegexConverter
    {
        [GeneratedRegex("[a-z]")]
        private static partial Regex RegexDeleteLowerChar();
        [GeneratedRegex("([a-z])([A-Z])")]
        private static partial Regex RegexUnderscoreBetweenLowerUpper();

        public static string UnderscoreBetweenLowerUpper(this string str)
        {
            return RegexUnderscoreBetweenLowerUpper().Replace(str, "$1_$2");
        }
        public static string DeleteLowerChar(this string str)
        {
            return RegexDeleteLowerChar().Replace(str, "");
        }
    }
}
