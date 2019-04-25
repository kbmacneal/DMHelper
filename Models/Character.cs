using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DM_helper.Models
{
    public class Character
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<CharacterClass> Class { get; set; }
        public Background Background { get; set; }
        public Gender Gender { get; set; }
        public List<Skills> Skills { get; set; }
        public List<Foci> Foci { get; set; }
        public string Faction { get; set; }
        public string Homeworld { get; set; }
        public int CurrentHP { get; set; }
        public int MaxHP { get; set; }
        public int CurrentSystemStrain { get; set; }
        public int MaxSystemStrain { get; set; }
        public int PermanentStrain { get; set; }
        public int CurrentXP { get; set; }
        public int XPTilNextLevel { get; set; }
        public int AC { get; set; }
        public int AtkBonus { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public int Credits { get; set; }
        public Armor Armor { get; set; }
        public List<Weapon> Weapons { get; set; }
        public string Goals {get;set;}
        public string Notes {get;set;}
        public List<Equipment> Equipment {get;set;}
    }

}