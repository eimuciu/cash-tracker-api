using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cash_tracker_api.Data
{
    public class ContextTableName
    {
        public ContextTableName(string _tableName)
        {
            TableName = _tableName;
        }
        public string TableName = "";
    }
}