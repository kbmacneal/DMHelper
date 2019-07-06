using System.Collections.Generic;

namespace DM_helper.Models
{
    public class Session
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Encounter> Encounters { get; set; }
        public string Notes { get; set; }
        public Campaign Campaign { get; set; }
    }
}