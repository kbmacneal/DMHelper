using System.Collections.Generic;
using System.Linq;
using DM_helper.Models;

namespace DM_helper.InterOp
{
    public class CharacterInterOp : Character
    {
        public int BackgroundID { get; set; }
        public int ClassID { get; set; }
        public int GenderID { get; set; }
        public List<int> SelectedArmor { get; set; }

        public CharacterInterOp()
        {
        }

        public CharacterInterOp(Character character)
        {
            this.ID = character.ID;
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
            this.BaseAC = character.BaseAC;
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

        public CharacterInterOp(Character character, Context _context)
        {
            this.ID = character.ID;
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
            this.BaseAC = character.BaseAC;
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

            //new stuff

            this.BackgroundID = _context.Backgrounds.FirstOrDefault(e => e.CharacterID == this.ID).ID;
            this.GenderID = _context.Genders.FirstOrDefault(e => e.CharacterID == this.ID).ID;
            this.ClassID = _context.CharacterClasses.FirstOrDefault(e => e.CharacterID == this.ID).ID;

            //lists
            this.Armor = _context.Armor.Where(e => e.Character.ID == this.ID).ToList();
            this.Equipment = _context.Equipment.Where(e => e.Character.ID == this.ID).ToList();
            this.Foci = _context.Foci.Where(e => e.Character.ID == this.ID).ToList();
            this.Melee = _context.Melee.Where(e => e.Character.ID == this.ID).ToList();
            this.Skills = _context.Skills.Where(e => e.Character.ID == this.ID).ToList();
            this.Weapon = _context.Weapons.Where(e => e.Character.ID == this.ID).ToList();
        }
    }
}