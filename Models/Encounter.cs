using System.Collections.Generic;

namespace DM_helper.Models
{
    public class Encounter
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<CharacterEncounter> CharacterEncounter { get; set; }
        public string Notes { get; set; }
        public int SessionID { get; set; }
        public Session Session { get; set; }
        public string Initiative { get; set; }
    }

    //join model

    public class CharacterEncounter
    {
        public int ID { get; set; }
        public int EncounterID { get; set; }
        public Encounter Encounter { get; set; }
        public int CharacterID { get; set; }
        public Character Character { get; set; }
    }
}