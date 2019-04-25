using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Linq;

namespace DM_helper.Classes
{
    public class Helpers

    {
        public static object GetPropValue(object src, string propName)
        {
            return src.GetType().GetProperty(propName).GetValue(src, null);
        }

        public static object SetPropValue(object src, string propName, object value)
        {
            src.GetType().GetProperty(propName).SetValue(src,value);

            return src;
        }
    }

}