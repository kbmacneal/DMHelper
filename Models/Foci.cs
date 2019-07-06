using DM_helper.Archetypes;

namespace DM_helper.Models
{
    public partial class Foci
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public Character Character { get; set; }
        public FociArchetype Archetype { get; set; }

        public Foci()
        {
        }

        public Foci(Foci arch)
        {
            this.Name = arch.Name;
            this.Level = arch.Level;
            this.Archetype = arch.Archetype;
        }

        public Foci(FociArchetype arch)
        {
            this.Name = arch.Name;
            this.Level = arch.Level;
            this.Archetype = arch;
        }
    }
}