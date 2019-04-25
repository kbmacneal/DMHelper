using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations.Schema;

namespace DM_helper.Models {
    public class Skills

    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int Specialist { get; set; }
        public int CharacterID{get;set;}
        [ForeignKey ("CharacterID")]
        public Character Character {get;set;}
    }
}