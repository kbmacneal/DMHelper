using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DM_helper.Models
{

    public partial class Melee
    {
        public string Name { get; set; }
        public string Damage { get; set; }
        public string ShockDamage { get; set; }
        public string Attribute { get; set; }
        public long Cost { get; set; }
        public long Encumbrance { get; set; }
        public long TechLevel { get; set; }
        public long Id { get; set; }
    }

}