using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DM_helper.Models
{
    public partial class Weapon
    {
        public int ID {get;set;}
        public string Name { get; set; }
        public string Damage { get; set; }
        public string Range { get; set; }
        public string Cost { get; set; }
        public string Magazine { get; set; }
        public string Encumbrance { get; set; }
        public string Attribute { get; set; }
        public int TechLevel { get; set; }
        public int CharacterID {get;set;}
        [ForeignKey ("CharacterID")]
        public Character Character {get;set;}

    }
}