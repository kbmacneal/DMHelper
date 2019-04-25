using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DM_helper.Models
{

    public partial class Foci
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Id { get; set; }
    }

}