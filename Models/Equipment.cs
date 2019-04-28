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
    public partial class Equipment
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Cost { get; set; }
        public string Encumbrance { get; set; }
        public string TechLevel { get; set; }
        public Character Character { get; set; }
        public EquipmentArchetype Archetype { get; set; }

        public Equipment()
        {
        }

        public Equipment(Equipment arch)
        {
            this.Name = arch.Name;
            this.Cost = arch.Cost;
            this.Encumbrance = arch.Encumbrance;
            this.TechLevel = arch.Encumbrance;
            this.Archetype = arch.Archetype;
        }

        public Equipment(EquipmentArchetype arch)
        {
            this.Name = arch.Name;
            this.Cost = arch.Cost;
            this.Encumbrance = arch.Encumbrance;
            this.TechLevel = arch.Encumbrance;
            this.Archetype = arch;
        }
    }

    public class PresentationEquipment
    {
        public long ID { get; set; }
        public string DropDownString { get; set; }

        public PresentationEquipment()
        {
        }

        public PresentationEquipment(EquipmentArchetype eq)
        {
            this.ID = eq.ID;
            this.DropDownString = eq.Name + " | " + eq.TechLevel;
        }
    }
}