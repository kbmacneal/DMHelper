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

    public partial class Foci
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int CharacterID {get;set;}
        [ForeignKey("CharacterID")]
        public Character Character {get;set;}
        public Foci(){}

        public Foci (FociArchetype arch)
        {
            this.Name = arch.Name;
            this.Level = arch.Level;
        }
        
    }

}