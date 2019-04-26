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
using DM_helper.Controllers;
using DM_helper.InterOp;
using Newtonsoft.Json;

namespace DM_helper.Models
{
    public class Character
    {
        public int ID { get; set; }
        public string Name { get; set; }
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
        public string Goals { get; set; }
        public string Notes { get; set; }

        public Gender Gender { get; set; }
        public CharacterClass Class { get; set; }
        public Background Background { get; set; }
        public List<Armor> Armor { get; set; }
        public List<Equipment> Equipment { get; set; }
        public List<Foci> Foci { get; set; }
        public List<Melee> Melee { get; set; }
        public List<Skills> Skills { get; set; }
        public List<Weapon> Weapon { get; set; }

        public Character()
        {
            
        }

        public Character(CharacterInterOp character)
        {
            this.Name = character.Name;
            this.Faction = character.Faction;
            this.Homeworld = character.Homeworld;
            this.CurrentHP = character.CurrentHP;
            this.MaxHP = character.MaxHP;
            this.CurrentSystemStrain = character.CurrentSystemStrain;
            this.MaxSystemStrain = character.MaxSystemStrain;
            this.PermanentStrain = character.PermanentStrain;
            this.CurrentXP = character.CurrentXP;
            this.XPTilNextLevel = character.XPTilNextLevel;
            this.AC = character.AC;
            this.AtkBonus = character.AtkBonus;
            this.Strength = character.Strength;
            this.Dexterity = character.Dexterity;
            this.Constitution = character.Constitution;
            this.Intelligence = character.Intelligence;
            this.Wisdom = character.Wisdom;
            this.Charisma = character.Charisma;
            this.Credits = character.Credits;
            this.Goals = character.Goals;
            this.Notes = character.Notes;
        }
    }
}