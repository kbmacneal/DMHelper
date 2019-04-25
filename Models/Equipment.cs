using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DM_helper.Models
{

    public partial class Equipment
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Cost { get; set; }
        public string Encumbrance { get; set; }
        public string TechLevel { get; set; }
        public int CharacterID {get;set;}
        [ForeignKey("CharacterID")]
        public Character Character {get;set;}
    }

}