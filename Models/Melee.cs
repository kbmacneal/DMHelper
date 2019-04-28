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
        public Character Character { get; set; }
        public MeleeArchetype Archetype { get; set; }

        public Melee()
        {
        }

        public Melee(MeleeArchetype arch)
        {
            this.Name = arch.Name;
            this.Damage = arch.Damage;
            this.ShockDamage = arch.Damage;
            this.Attribute = arch.Attribute;
            this.Cost = arch.Cost;
            this.Encumbrance = arch.Encumbrance;
            this.TechLevel = arch.TechLevel;
            this.Archetype = arch;
        }
    }
}