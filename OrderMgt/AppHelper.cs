using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// App Helper class providing general string handling utility functions

namespace OrderMgt
{
    public static class AppHelper
    {
        public static String SqlSafe(String value)
        {
            return value.Replace("'", "''");
        }
    }

}
