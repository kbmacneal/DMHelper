using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DM_helper.Models
{
    public partial class Armor
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public int AC { get; set; }
        public long Cost { get; set; }
        public long Encumbrance { get; set; }
        public long TechLevel { get; set; }
    }

}