using DM_helper.Archetypes;
using DM_helper.Models;

namespace DM_helper
{
    public class CharacterClass
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CharacterID { get; set; }
        public Character Character { get; set; }
        public CharacterClass Archetype { get; set; }

        public CharacterClass()
        {
        }

        public CharacterClass(CharacterClass charclass)
        {
            this.Name = charclass.Name;
            this.Archetype = charclass.Archetype;
        }

        public CharacterClass(CharacterClassArchetype arch)
        {
            this.Name = arch.Name;
        }
    }

    public class Background
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CharacterID { get; set; }
        public Character Character { get; set; }
        public BackgroundArchetype Archetype { get; set; }

        public Background()
        {
        }

        public Background(Background bg)
        {
            this.Name = bg.Name;
            this.Archetype = bg.Archetype;
        }

        public Background(BackgroundArchetype arch)
        {
            this.Name = arch.Name;
        }
    }

    public class Gender
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CharacterID { get; set; }
        public Character Character { get; set; }
        public GenderArchetype Archetype { get; set; }

        public Gender()
        {
        }

        public Gender(Gender gender)
        {
            this.Name = gender.Name;
            this.Archetype = gender.Archetype;
        }

        public Gender(GenderArchetype arch)
        {
            this.Name = arch.Name;
        }
    }
}