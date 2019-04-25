using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DM_helper.Models
{

    public partial class Equipment
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Cost { get; set; }
        public string Encumbrance { get; set; }
        public string TechLevel { get; set; }
    }

}