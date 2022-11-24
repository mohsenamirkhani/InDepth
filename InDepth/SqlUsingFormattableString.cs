using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace InDepth
{
    public static class SqlUsingFormattableString
    {
        public static SqlCommand NewSqlCommand(this SqlConnection conn, FormattableString formattableString)
        {
            
            var sqlParameters = formattableString.GetArguments()
                .Select((value, position) => 
                    new SqlParameter(FormattableString.Invariant($"@p{position}"), value)).ToArray();

            var formatArguments = sqlParameters
                .Select(p => new FormatCapturingParameter(p)).ToArray();

            var sql = string.Format(formattableString.Format, formatArguments);

            var command = new SqlCommand(sql, conn);
            command.Parameters.AddRange(sqlParameters);
            return command;
        }

        private class FormatCapturingParameter
        {
            private readonly SqlParameter parameter;

            internal FormatCapturingParameter(SqlParameter parameter)
            {
                this.parameter = parameter;
            }

            public string ToString(string format, IFormatProvider formatProvider)
            {
                if (!string.IsNullOrEmpty(format))
                {
                    parameter.SqlDbType = (SqlDbType)Enum.Parse(typeof(SqlDbType), format, true);
                }
                return parameter.ParameterName;
            }
        }
    }
}
