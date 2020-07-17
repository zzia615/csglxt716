using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace csglxt716
{
    public class columnAttribute: Attribute
    {
        public columnAttribute(string colName,bool primaryKey)
        {
            ColName = colName;
            PrimaryKey = primaryKey;
        }

        public string ColName { get; }
        public bool PrimaryKey { get; }
    }

    public class tableAttribute : Attribute
    {
        public tableAttribute(string tableName)
        {
            TableName = tableName;
        }

        public string TableName { get; }
    }
}