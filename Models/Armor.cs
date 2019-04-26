using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DM_helper.Archetypes;

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
        public Character Character { get; set; }

        public Armor()
        {
        }

        public Armor(ArmorArchetype arch)
        {
            this.Name = arch.Name;
            this.AC = arch.AC;
            this.Cost = arch.Cost;
            this.Encumbrance = arch.Encumbrance;
            this.TechLevel = arch.Encumbrance;
            this.TechLevel = arch.TechLevel;
        }
    }
}