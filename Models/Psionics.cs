using DM_helper.Archetypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DM_helper.Models
{
    public class PsionicAbility
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Level { get; set; } = -1;
        public int PsionicSchoolID { get; set; }
        public PsionicSchool PsionicSchool { get; set; }
        public int CharacterID { get; set; }
        public Character Character { get; set; }
        public int ArchetypeID { get; set; }
        public PsionicSkillArchetype Archetype { get; set; }
        public Boolean is_active { get; set; }

        public PsionicAbility()
        {
        }

        public PsionicAbility(PsionicAbility arch)
        {
            this.Name = arch.Name;
            this.Level = arch.Level;
            this.Description = arch.Description;
            this.Archetype = arch.Archetype;
            this.PsionicSchool = arch.PsionicSchool;
        }

        public PsionicAbility(PsionicSkillArchetype arch)
        {
            this.Name = arch.Name;
            this.Level = arch.Level;
            this.Description = arch.Description;
            this.Archetype = arch;
            this.PsionicSchool = arch.PsionicSchool;
            this.PsionicSchoolID = arch.PsionicSchool.ID;
        }
    }
}