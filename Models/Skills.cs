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

        public Skills(Skills arch)
        {
            this.Name = arch.Name;
            this.Level = arch.Level;
            this.Specialist = arch.Specialist;
            this.Archetype = arch.Archetype;
        }

        public Skills(SkillsArchetype arch)
        {
            this.Name = arch.Name;
            this.Level = arch.Level;
            this.Specialist = arch.Specialist;
            this.Archetype = arch;
        }
    }
}