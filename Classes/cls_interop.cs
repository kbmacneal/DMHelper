using System.Collections.Generic;
using System.Linq;
using DM_helper.Models;
using Microsoft.EntityFrameworkCore;

namespace DM_helper.InterOp
{
    public class CharacterInterOp : Character
    {
        public int BackgroundID { get; set; }
        public int ClassID { get; set; }
        public int GenderID { get; set; }
        public List<int> SelectedArmor { get; set; }
        public List<int> SelectedEquipment { get; set; }
        public List<int> SelectedWeapon { get; set; }
        public List<int> SelectedMelee { get; set; }

        public CharacterInterOp()
        {
        }

        public static CharacterInterOp NoIDClone(Character character)
        {
            var interop = new CharacterInterOp();
            interop.Name = character.Name;
            interop.Faction = character.Faction;
            interop.Homeworld = character.Homeworld;
            interop.CurrentHP = character.CurrentHP;
            interop.MaxHP = character.MaxHP;
            interop.CurrentSystemStrain = character.CurrentSystemStrain;
            interop.MaxSystemStrain = character.MaxSystemStrain;
            interop.PermanentStrain = character.PermanentStrain;
            interop.CurrentXP = character.CurrentXP;
            interop.XPTilNextLevel = character.XPTilNextLevel;
            interop.BaseAC = character.BaseAC;
            interop.AtkBonus = character.AtkBonus;
            interop.Strength = character.Strength;
            interop.Dexterity = character.Dexterity;
            interop.Constitution = character.Constitution;
            interop.Intelligence = character.Intelligence;
            interop.Wisdom = character.Wisdom;
            interop.Charisma = character.Charisma;
            interop.Credits = character.Credits;
            interop.Goals = character.Goals;
            interop.Notes = character.Notes;

            return interop;
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

            this.BackgroundID = _context.Backgrounds.Include(e => e.Archetype).FirstOrDefault(e => e.CharacterID == this.ID).ID;
            this.GenderID = _context.Genders.Include(e => e.Archetype).FirstOrDefault(e => e.CharacterID == this.ID).ID;
            this.ClassID = _context.CharacterClasses.Include(e => e.Archetype).FirstOrDefault(e => e.CharacterID == this.ID).ID;

            //lists
            this.Armor = _context.Armor.Include(e => e.Archetype).Where(e => e.Character.ID == this.ID).OrderBy(e => e.Name).ToList();
            this.Equipment = _context.Equipment.Include(e => e.Archetype).Where(e => e.Character.ID == this.ID).OrderBy(e => e.Name).ToList();
            this.Foci = _context.Foci.Include(e => e.Archetype).Where(e => e.Character.ID == this.ID).OrderBy(e => e.Name).ToList();
            this.Melee = _context.Melee.Include(e => e.Archetype).Where(e => e.Character.ID == this.ID).OrderBy(e => e.Name).ToList();
            this.Skills = _context.Skills.Include(e => e.Archetype).Where(e => e.Character.ID == this.ID).OrderBy(e => e.Name).ToList();
            this.Weapon = _context.Weapons.Include(e => e.Archetype).Where(e => e.Character.ID == this.ID).OrderBy(e => e.Name).ToList();

            this.PsionicAbilities = _context.PsionicAbilities.Include(e => e.Archetype).Where(e => e.Character.ID == this.ID).OrderBy(e => e.Name).ToList();
        }
    }
}