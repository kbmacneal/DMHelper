using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DM_helper.Models
{

    public partial class Melee
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Damage { get; set; }
        public string ShockDamage { get; set; }
        public string Attribute { get; set; }
        public long Cost { get; set; }
        public long Encumbrance { get; set; }
        public long TechLevel { get; set; }
        public int CharacterID { get; set; }

        [ForeignKey ("CharacterID")]
        public Character Character { get; set; }

    }

}