using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace csglxt716
{
    public class columnAttribute: Attribute
    {
        public columnAttribute()
        {
           
        }

        public string ColName { get; set; }
        public bool PrimaryKey { get; set; }
    }

    public class tableAttribute : Attribute
    {
        public tableAttribute()
        {
        }

        public string TableName { get; set; }
    }
}