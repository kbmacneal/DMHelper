using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using DM_helper.Archetypes;
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
        public Character Character { get; set; }
        public ArmorArchetype Archetype { get; set; }

        public Armor()
        { }

        public Armor(Armor armor)
        {
            this.Name = armor.Name;
            this.AC = armor.AC;
            this.Cost = armor.Cost;
            this.Encumbrance = armor.Encumbrance;
            this.TechLevel = armor.TechLevel;
            this.Archetype = armor.Archetype;
        }

        public Armor(ArmorArchetype arch)
        {
            this.Name = arch.Name;
            this.AC = arch.AC;
            this.Cost = arch.Cost;
            this.Encumbrance = arch.Encumbrance;
            this.TechLevel = arch.TechLevel;
            this.Archetype = arch;
        }
    }
}