using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DM_helper.Archetypes;
using DM_helper.Models;
using Humanizer;

namespace DM_helper
{

    public class CharacterClass
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CharacterID { get; set; }

        [ForeignKey ("CharacterID")]
        public Character Character { get; set; }

        public CharacterClass () { }

        public CharacterClass (CharacterClassArchetype arch)
        {
            this.Name = arch.Name;
        }
    }
    public class Background
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CharacterID { get; set; }

        [ForeignKey ("CharacterID")]
        public Character Character { get; set; }
        public Background () { }

        public Background (BackgroundArchetype arch)
        {
            this.Name = arch.Name;
        }
    }
    public class Gender
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CharacterID { get; set; }

        [ForeignKey ("CharacterID")]
        public Character Character { get; set; }
        public Gender () { }

        public Gender (GenderArchetype arch)
        {
            this.Name = arch.Name;
        }
    }
}