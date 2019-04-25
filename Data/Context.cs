using DM_helper.Archetypes;
using DM_helper.Models;
using Microsoft.EntityFrameworkCore;

namespace DM_helper
{
    public partial class Context : DbContext
    {
        public Context () { }

        public Context (DbContextOptions<Context> options) : base (options) { }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql (Program.conn);
            }
        }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation ("ProductVersion", "2l.2.0-rtm-35687");

            modelBuilder.Entity<Armor> (entity =>
            {
                entity.HasKey (e => e.ID);
                entity.Property (e => e.ID)
                    .HasColumnName ("ID")
                    .ValueGeneratedOnAdd ();
                entity.Property (e => e.Name)
                    .HasColumnName ("name");
                entity.Property (e => e.AC)
                    .HasColumnName ("ac");
                entity.Property (e => e.Cost)
                    .HasColumnName ("cost");
                entity.Property (e => e.Encumbrance)
                    .HasColumnName ("encumbrance");
                entity.Property (e => e.TechLevel)
                    .HasColumnName ("techlevel");
            });

            modelBuilder.Entity<Equipment> (entity =>
            {
                entity.HasKey (e => e.ID);
                entity.Property (e => e.ID)
                    .HasColumnName ("ID")
                    .ValueGeneratedOnAdd ();
                entity.Property (e => e.Name)
                    .HasColumnName ("name");
                entity.Property (e => e.Cost)
                    .HasColumnName ("cost");
                entity.Property (e => e.Encumbrance)
                    .HasColumnName ("encumbrance");
                entity.Property (e => e.TechLevel)
                    .HasColumnName ("techlevel");
            });

            modelBuilder.Entity<Foci> (entity =>
            {
                entity.HasKey (e => e.ID);
                entity.Property (e => e.ID)
                    .HasColumnName ("ID")
                    .ValueGeneratedOnAdd ();
                entity.Property (e => e.Name)
                    .HasColumnName ("name");
                entity.Property (e => e.Level)
                    .HasColumnName ("level");
            });

            modelBuilder.Entity<Weapon> (entity =>
            {
                entity.HasKey (e => e.ID);
                entity.Property (e => e.ID)
                    .HasColumnName ("ID")
                    .ValueGeneratedOnAdd ();
                entity.Property (e => e.Name)
                    .HasColumnName ("name");
                entity.Property (e => e.Damage)
                    .HasColumnName ("damage");
                entity.Property (e => e.Range)
                    .HasColumnName ("range");
                entity.Property (e => e.Cost)
                    .HasColumnName ("cost");
                entity.Property (e => e.Magazine)
                    .HasColumnName ("magazine");
                entity.Property (e => e.Encumbrance)
                    .HasColumnName ("encumbrance");
                entity.Property (e => e.Attribute)
                    .HasColumnName ("attribute");
                entity.Property (e => e.TechLevel)
                    .HasColumnName ("techlevel");
            });

            modelBuilder.Entity<Skills> (entity =>
            {
                entity.HasKey (e => e.ID);
                entity.Property (e => e.ID)
                    .HasColumnName ("ID")
                    .ValueGeneratedOnAdd ();
                entity.Property (e => e.Name)
                    .HasColumnName ("name");
                entity.Property (e => e.Level)
                    .HasColumnName ("level");
                entity.Property (e => e.Specialist)
                    .HasColumnName ("specialist");
            });

            modelBuilder.Entity<Melee> (entity =>
            {
                entity.HasKey (e => e.ID);
                entity.Property (e => e.ID)
                    .HasColumnName ("ID")
                    .ValueGeneratedOnAdd ();
                entity.Property (e => e.Name)
                    .HasColumnName ("name");
                entity.Property (e => e.Damage)
                    .HasColumnName ("damage");
                entity.Property (e => e.ShockDamage)
                    .HasColumnName ("shockdamage");
                entity.Property (e => e.Attribute)
                    .HasColumnName ("attribute");
                entity.Property (e => e.Cost)
                    .HasColumnName ("cost");
                entity.Property (e => e.Encumbrance)
                    .HasColumnName ("encumbrance");
                entity.Property (e => e.TechLevel)
                    .HasColumnName ("techlevel");
                entity.Property (e => e.CharacterID)
                    .HasColumnName ("characterid");
            });

            modelBuilder.Entity<CharacterClass> (entity =>
            {
                entity.HasKey (e => e.ID);
                entity.Property (e => e.ID)
                    .HasColumnName ("ID")
                    .ValueGeneratedOnAdd ();
                entity.Property (e => e.Name)
                    .HasColumnName ("name");
                entity.Property (e => e.CharacterID)
                    .HasColumnName ("characterid");
            });

            modelBuilder.Entity<Background> (entity =>
            {
                entity.HasKey (e => e.ID);
                entity.Property (e => e.ID)
                    .HasColumnName ("ID")
                    .ValueGeneratedOnAdd ();
                entity.Property (e => e.Name)
                    .HasColumnName ("name");
                entity.Property (e => e.CharacterID)
                    .HasColumnName ("characterid");
            });

            modelBuilder.Entity<Gender> (entity =>
            {
                entity.HasKey (e => e.ID);
                entity.Property (e => e.ID)
                    .HasColumnName ("ID")
                    .ValueGeneratedOnAdd ();
                entity.Property (e => e.Name)
                    .HasColumnName ("name");
                entity.Property (e => e.CharacterID)
                    .HasColumnName ("characterid");
            });

            modelBuilder.Entity<Character> (entity =>
            {
                entity.HasKey (e => e.ID);
                entity.Property (e => e.ID)
                    .HasColumnName ("ID")
                    .ValueGeneratedOnAdd ();
                entity.Property (e => e.Name)
                    .HasColumnName ("name");
                entity.Property (e => e.BackgroundID)
                    .HasColumnName ("backgroundid");
                entity.Property (e => e.GenderID)
                    .HasColumnName ("genderid");
                entity.Property (e => e.Faction)
                    .HasColumnName ("faction");
                entity.Property (e => e.Homeworld)
                    .HasColumnName ("homeworld");
                entity.Property (e => e.CurrentHP)
                    .HasColumnName ("currenthp");
                entity.Property (e => e.MaxHP)
                    .HasColumnName ("maxhp");
                entity.Property (e => e.MaxHP)
                    .HasColumnName ("maxhp");
                entity.Property (e => e.CurrentSystemStrain)
                    .HasColumnName ("currentsystemstrain");
                entity.Property (e => e.MaxSystemStrain)
                    .HasColumnName ("maxsystemstrain");
                entity.Property (e => e.PermanentStrain)
                    .HasColumnName ("permanentstrain");
                entity.Property (e => e.CurrentXP)
                    .HasColumnName ("currentxp");
                entity.Property (e => e.XPTilNextLevel)
                    .HasColumnName ("xptilnextlevel");
                entity.Property (e => e.AC)
                    .HasColumnName ("ac");
                entity.Property (e => e.AtkBonus)
                    .HasColumnName ("atkbonus");
                entity.Property (e => e.Strength)
                    .HasColumnName ("strength");
                entity.Property (e => e.Dexterity)
                    .HasColumnName ("dexterity");
                entity.Property (e => e.Constitution)
                    .HasColumnName ("constitution");
                entity.Property (e => e.Intelligence)
                    .HasColumnName ("intelligence");
                entity.Property (e => e.Wisdom)
                    .HasColumnName ("wisdom");
                entity.Property (e => e.Charisma)
                    .HasColumnName ("charisma");
                entity.Property (e => e.Credits)
                    .HasColumnName ("credits");
                entity.Property (e => e.ArmorID)
                    .HasColumnName ("armorid");
                entity.Property (e => e.Goals)
                    .HasColumnName ("goals");
                entity.Property (e => e.Notes)
                    .HasColumnName ("notes");
            });

            modelBuilder.Entity<ArmorArchetype> (entity =>
            {
                entity.HasKey (e => e.ID);
                entity.Property (e => e.ID)
                    .HasColumnName ("ID")
                    .ValueGeneratedOnAdd ();
                entity.Property (e => e.Name)
                    .HasColumnName ("name");
                entity.Property (e => e.AC)
                    .HasColumnName ("ac");
                entity.Property (e => e.Cost)
                    .HasColumnName ("cost");
                entity.Property (e => e.Encumbrance)
                    .HasColumnName ("encumbrance");
                entity.Property (e => e.TechLevel)
                    .HasColumnName ("techlevel");
            });

            modelBuilder.Entity<EquipmentArchetype> (entity =>
            {
                entity.HasKey (e => e.ID);
                entity.Property (e => e.ID)
                    .HasColumnName ("ID")
                    .ValueGeneratedOnAdd ();
                entity.Property (e => e.Name)
                    .HasColumnName ("name");
                entity.Property (e => e.Cost)
                    .HasColumnName ("cost");
                entity.Property (e => e.Encumbrance)
                    .HasColumnName ("encumbrance");
                entity.Property (e => e.TechLevel)
                    .HasColumnName ("techlevel");
            });

            modelBuilder.Entity<FociArchetype> (entity =>
            {
                entity.HasKey (e => e.ID);
                entity.Property (e => e.ID)
                    .HasColumnName ("ID")
                    .ValueGeneratedOnAdd ();
                entity.Property (e => e.Name)
                    .HasColumnName ("name");
                entity.Property (e => e.Level)
                    .HasColumnName ("level");
            });

            modelBuilder.Entity<WeaponArchetype> (entity =>
            {
                entity.HasKey (e => e.ID);
                entity.Property (e => e.ID)
                    .HasColumnName ("ID")
                    .ValueGeneratedOnAdd ();
                entity.Property (e => e.Name)
                    .HasColumnName ("name");
                entity.Property (e => e.Damage)
                    .HasColumnName ("damage");
                entity.Property (e => e.Range)
                    .HasColumnName ("range");
                entity.Property (e => e.Cost)
                    .HasColumnName ("cost");
                entity.Property (e => e.Magazine)
                    .HasColumnName ("magazine");
                entity.Property (e => e.Encumbrance)
                    .HasColumnName ("encumbrance");
                entity.Property (e => e.Attribute)
                    .HasColumnName ("attribute");
                entity.Property (e => e.TechLevel)
                    .HasColumnName ("techlevel");
            });

            modelBuilder.Entity<SkillsArchetype> (entity =>
            {
                entity.HasKey (e => e.ID);
                entity.Property (e => e.ID)
                    .HasColumnName ("ID")
                    .ValueGeneratedOnAdd ();
                entity.Property (e => e.Name)
                    .HasColumnName ("name");
                entity.Property (e => e.Level)
                    .HasColumnName ("level");
                entity.Property (e => e.Specialist)
                    .HasColumnName ("specialist");
            });

            modelBuilder.Entity<MeleeArchetype> (entity =>
            {
                entity.HasKey (e => e.ID);
                entity.Property (e => e.ID)
                    .HasColumnName ("ID")
                    .ValueGeneratedOnAdd ();
                entity.Property (e => e.Name)
                    .HasColumnName ("name");
                entity.Property (e => e.Damage)
                    .HasColumnName ("damage");
                entity.Property (e => e.ShockDamage)
                    .HasColumnName ("shockdamage");
                entity.Property (e => e.Attribute)
                    .HasColumnName ("attribute");
                entity.Property (e => e.Cost)
                    .HasColumnName ("cost");
                entity.Property (e => e.Encumbrance)
                    .HasColumnName ("encumbrance");
                entity.Property (e => e.TechLevel)
                    .HasColumnName ("techlevel");
            });

            modelBuilder.Entity<CharacterClassArchetype> (entity =>
            {
                entity.HasKey (e => e.ID);
                entity.Property (e => e.ID)
                    .HasColumnName ("ID")
                    .ValueGeneratedOnAdd ();
                entity.Property (e => e.Name)
                    .HasColumnName ("name");
            });

            modelBuilder.Entity<BackgroundArchetype> (entity =>
            {
                entity.HasKey (e => e.ID);
                entity.Property (e => e.ID)
                    .HasColumnName ("ID")
                    .ValueGeneratedOnAdd ();
                entity.Property (e => e.Name)
                    .HasColumnName ("name");
            });

            modelBuilder.Entity<GenderArchetype> (entity =>
            {
                entity.HasKey (e => e.ID);
                entity.Property (e => e.ID)
                    .HasColumnName ("ID")
                    .ValueGeneratedOnAdd ();
                entity.Property (e => e.Name)
                    .HasColumnName ("name");
            });


            modelBuilder.Entity<CharacterClass> ()
                .HasOne<Character> (x => x.Character)
                .WithMany ();

            modelBuilder.Entity<Background> ()
                .HasOne<Character> (x => x.Character)
                .WithOne ();

            modelBuilder.Entity<Gender> ()
                .HasOne<Character> (x => x.Character)
                .WithOne ();

            modelBuilder.Entity<Skills> ()
                .HasOne<Character> (x => x.Character)
                .WithMany ();

            modelBuilder.Entity<Foci> ()
                .HasOne<Character> (x => x.Character)
                .WithMany ();

            modelBuilder.Entity<Armor> ()
                .HasOne<Character> (x => x.Character)
                .WithOne ();

            modelBuilder.Entity<Weapon> ()
                .HasOne<Character> (x => x.Character)
                .WithMany ();

            modelBuilder.Entity<Equipment> ()
                .HasOne<Character> (x => x.Character)
                .WithMany ();

        }

        public DbSet<DM_helper.Models.Armor> Armor { get; set; }

        public DbSet<DM_helper.Models.Character> Character { get; set; }

        public DbSet<DM_helper.Models.Equipment> Equipment { get; set; }

        public DbSet<DM_helper.Models.Foci> Foci { get; set; }

        public DbSet<DM_helper.Models.Melee> Melee { get; set; }

        public DbSet<DM_helper.Models.Skills> Skills { get; set; }

        public DbSet<DM_helper.Models.Weapon> Weapons { get; set; }

        public DbSet<DM_helper.Archetypes.ArmorArchetype> ArmorArchetype { get; set; }
        public DbSet<DM_helper.Archetypes.EquipmentArchetype> EquipmentArchetype { get; set; }
        public DbSet<DM_helper.Archetypes.FociArchetype> FociArchetype { get; set; }
        public DbSet<DM_helper.Archetypes.MeleeArchetype> MeleeArchetype { get; set; }
        public DbSet<DM_helper.Archetypes.SkillsArchetype> SkillsArchetype { get; set; }
        public DbSet<DM_helper.Archetypes.WeaponArchetype> WeaponArchetype { get; set; }
        public DbSet<DM_helper.Archetypes.CharacterClassArchetype> CharacterClassArchetype { get; set; }
        public DbSet<DM_helper.Archetypes.BackgroundArchetype> BackgroundArchetype { get; set; }
        public DbSet<DM_helper.Archetypes.GenderArchetype> GenderArchetype { get; set; }
    }

}