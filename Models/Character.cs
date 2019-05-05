using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using DM_helper.Controllers;
using DM_helper.InterOp;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace DM_helper.Models
{
    public class Character
    {
        [DisplayName("ID")]
        public int ID { get; set; }

        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Faction")]
        public string Faction { get; set; }

        [DisplayName("Homeworld")]
        public string Homeworld { get; set; }

        [DisplayName("Level")]
        public int Level { get; set; }

        [DisplayName("HP")]
        public int CurrentHP { get; set; }

        [DisplayName("Max HP")]
        public int MaxHP { get; set; }

        [DisplayName("System Strain")]
        public int CurrentSystemStrain { get; set; }

        [DisplayName("Max System Strain")]
        public int MaxSystemStrain { get; set; }

        [DisplayName("Permanent Sys. Strain")]
        public int PermanentStrain { get; set; }

        [DisplayName("XP")]
        public int CurrentXP { get; set; }

        [DisplayName("XP Until Level Up")]
        public int XPTilNextLevel { get; set; }

        [DisplayName("AC")]
        public int BaseAC { get; set; }

        [DisplayName("Attack Bonus")]
        public int AtkBonus { get; set; }

        [DisplayName("Strength")]
        public int Strength { get; set; }

        [DisplayName("Dexterity")]
        public int Dexterity { get; set; }

        [DisplayName("Constitution")]
        public int Constitution { get; set; }

        [DisplayName("Intelligence")]
        public int Intelligence { get; set; }

        [DisplayName("Wisdom")]
        public int Wisdom { get; set; }

        [DisplayName("Charisma")]
        public int Charisma { get; set; }

        [DisplayName("Credits On Hand")]
        public int Credits { get; set; }

        [DisplayName("Goals")]
        public string Goals { get; set; }

        [DisplayName("Notes")]
        public string Notes { get; set; }

        [DisplayName("Gender")]
        public Gender Gender { get; set; }

        [DisplayName("Character Class")]
        public CharacterClass Class { get; set; }

        [DisplayName("Background")]
        public Background Background { get; set; }

        [DisplayName("Armor Worn")]
        public List<Armor> Armor { get; set; }

        [DisplayName("Equipment On Hand")]
        public List<Equipment> Equipment { get; set; }

        [DisplayName("Foci")]
        public List<Foci> Foci { get; set; }

        [DisplayName("Melee Weapons")]
        public List<Melee> Melee { get; set; }

        [DisplayName("Character Skills")]
        public List<Skills> Skills { get; set; }

        [DisplayName("Weapons Equipped")]
        public List<Weapon> Weapon { get; set; }

        public List<CharacterEncounter> CharacterEncounter { get; set; }
        public List<PsionicAbility> PsionicAbilities { get; set; }

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

        public static async Task CloneCharacterAsync(int ID, Context _context)
        {
            var character = await _context.Character.AsNoTracking().Include(e => e.Equipment).ThenInclude(e => e.Archetype).Include(e => e.Weapon).ThenInclude(e => e.Archetype).Include(e => e.Melee).ThenInclude(e => e.Archetype).Include(e => e.Armor).ThenInclude(e => e.Archetype).Include(e => e.Skills).ThenInclude(e => e.Archetype).Include(e => e.Foci).ThenInclude(e => e.Archetype).Include(e => e.Class).ThenInclude(e => e.Archetype).Include(e => e.Background).ThenInclude(e => e.Archetype).Include(e => e.Gender).ThenInclude(e => e.Archetype).Include(e => e.PsionicAbilities).ThenInclude(e => e.Archetype)
                .FirstOrDefaultAsync(m => m.ID == ID);

            var adder = new Character(CharacterInterOp.NoIDClone(character));

            adder.Class = new CharacterClass(character.Class);
            adder.Background = new Background(character.Background);
            adder.Gender = new Gender(character.Gender);

            adder.Armor = new List<Armor>();
            character.Armor.ForEach(e => adder.Armor.Add(new Armor(e.Archetype)));
            adder.Armor.ForEach(e => _context.Entry(e).State = EntityState.Added);

            adder.Equipment = new List<Equipment>();
            character.Equipment.ForEach(e => adder.Equipment.Add(new Equipment(e.Archetype)));
            adder.Equipment.ForEach(e => _context.Entry(e).State = EntityState.Added);

            adder.Weapon = new List<Weapon>();
            character.Weapon.ForEach(e => adder.Weapon.Add(new Weapon(e.Archetype)));
            adder.Weapon.ForEach(e => _context.Entry(e).State = EntityState.Added);

            adder.Melee = new List<Melee>();
            character.Melee.ForEach(e => adder.Melee.Add(new Melee(e.Archetype)));
            adder.Melee.ForEach(e => _context.Entry(e).State = EntityState.Added);

            adder.Skills = new List<Skills>();
            character.Skills.ForEach(e => adder.Skills.Add(new Skills(e.Archetype)));
            adder.Skills.ForEach(e => _context.Entry(e).State = EntityState.Added);

            adder.Foci = new List<Foci>();
            character.Foci.ForEach(e => adder.Foci.Add(new Foci(e.Archetype)));
            adder.Foci.ForEach(e => _context.Entry(e).State = EntityState.Added);

            adder.PsionicAbilities = new List<PsionicAbility>();
            character.PsionicAbilities.ForEach(e => adder.PsionicAbilities.Add(new PsionicAbility(e.Archetype)));
            adder.PsionicAbilities.ForEach(e => _context.Entry(e).State = EntityState.Added);

            await _context.Character.AddAsync(adder);

            await _context.SaveChangesAsync();
        }
    }
}