using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DM_helper.Archetypes
{
    public partial class ArmorArchetype
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public int AC { get; set; }
        public long Cost { get; set; }
        public long Encumbrance { get; set; }
        public long TechLevel { get; set; }
    }

    public partial class EquipmentArchetype
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Cost { get; set; }
        public string Encumbrance { get; set; }
        public string TechLevel { get; set; }
    }

    public partial class FociArchetype
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }

    }

    public partial class MeleeArchetype
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Damage { get; set; }
        public string ShockDamage { get; set; }
        public string Attribute { get; set; }
        public long Cost { get; set; }
        public long Encumbrance { get; set; }
        public long TechLevel { get; set; }

    }

    public class SkillsArchetype

    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int Specialist { get; set; }
    }

    public partial class WeaponArchetype
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Damage { get; set; }
        public string Range { get; set; }
        public string Cost { get; set; }
        public string Magazine { get; set; }
        public string Encumbrance { get; set; }
        public string Attribute { get; set; }
        public int TechLevel { get; set; }

    }

    public class CharacterClassArchetype
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    public class BackgroundArchetype
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    public class GenderArchetype
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

}