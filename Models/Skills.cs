using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations.Schema;
using DM_helper.Archetypes;

namespace DM_helper.Models
{
    public class Skills

    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int Specialist { get; set; }
        public Character Character { get; set; }
        public SkillsArchetype Archetype { get; set; }

        public Skills()
        {
        }

        public Skills(SkillsArchetype arch)
        {
            this.Name = arch.Name;
            this.Level = arch.Level;
            this.Specialist = arch.Specialist;
        }
    }
}