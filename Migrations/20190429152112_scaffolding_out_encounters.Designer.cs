﻿// <auto-generated />
using System;
using DM_helper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DM_helper.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20190429152112_scaffolding_out_encounters")]
    partial class scaffolding_out_encounters
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2l.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("DM_helper.Archetypes.ArmorArchetype", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<int>("AC")
                        .HasColumnName("ac");

                    b.Property<long>("Cost")
                        .HasColumnName("cost");

                    b.Property<long>("Encumbrance")
                        .HasColumnName("encumbrance");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.Property<long>("TechLevel")
                        .HasColumnName("techlevel");

                    b.HasKey("ID");

                    b.ToTable("ArmorArchetype");
                });

            modelBuilder.Entity("DM_helper.Archetypes.BackgroundArchetype", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.HasKey("ID");

                    b.ToTable("BackgroundArchetype");
                });

            modelBuilder.Entity("DM_helper.Archetypes.CharacterClassArchetype", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.HasKey("ID");

                    b.ToTable("CharacterClassArchetype");
                });

            modelBuilder.Entity("DM_helper.Archetypes.EquipmentArchetype", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<string>("Cost")
                        .HasColumnName("cost");

                    b.Property<string>("Encumbrance")
                        .HasColumnName("encumbrance");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.Property<string>("TechLevel")
                        .HasColumnName("techlevel");

                    b.HasKey("ID");

                    b.ToTable("EquipmentArchetype");
                });

            modelBuilder.Entity("DM_helper.Archetypes.FociArchetype", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<int>("Level")
                        .HasColumnName("level");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.HasKey("ID");

                    b.ToTable("FociArchetype");
                });

            modelBuilder.Entity("DM_helper.Archetypes.GenderArchetype", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.HasKey("ID");

                    b.ToTable("GenderArchetype");
                });

            modelBuilder.Entity("DM_helper.Archetypes.MeleeArchetype", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<string>("Attribute")
                        .HasColumnName("attribute");

                    b.Property<long>("Cost")
                        .HasColumnName("cost");

                    b.Property<string>("Damage")
                        .HasColumnName("damage");

                    b.Property<long>("Encumbrance")
                        .HasColumnName("encumbrance");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.Property<string>("ShockDamage")
                        .HasColumnName("shockdamage");

                    b.Property<long>("TechLevel")
                        .HasColumnName("techlevel");

                    b.HasKey("ID");

                    b.ToTable("MeleeArchetype");
                });

            modelBuilder.Entity("DM_helper.Archetypes.SkillsArchetype", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<int>("Level")
                        .HasColumnName("level");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.Property<int>("Specialist")
                        .HasColumnName("specialist");

                    b.HasKey("ID");

                    b.ToTable("SkillsArchetype");
                });

            modelBuilder.Entity("DM_helper.Archetypes.WeaponArchetype", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<string>("Attribute")
                        .HasColumnName("attribute");

                    b.Property<string>("Cost")
                        .HasColumnName("cost");

                    b.Property<string>("Damage")
                        .HasColumnName("damage");

                    b.Property<string>("Encumbrance")
                        .HasColumnName("encumbrance");

                    b.Property<string>("Magazine")
                        .HasColumnName("magazine");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.Property<string>("Range")
                        .HasColumnName("range");

                    b.Property<int>("TechLevel")
                        .HasColumnName("techlevel");

                    b.HasKey("ID");

                    b.ToTable("WeaponArchetype");
                });

            modelBuilder.Entity("DM_helper.Background", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<int?>("ArchetypeID");

                    b.Property<int>("CharacterID");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.HasKey("ID");

                    b.HasIndex("ArchetypeID");

                    b.HasIndex("CharacterID")
                        .IsUnique();

                    b.ToTable("Backgrounds");
                });

            modelBuilder.Entity("DM_helper.CharacterClass", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<int?>("ArchetypeID");

                    b.Property<int>("CharacterID");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.HasKey("ID");

                    b.HasIndex("ArchetypeID");

                    b.HasIndex("CharacterID")
                        .IsUnique();

                    b.ToTable("CharacterClasses");
                });

            modelBuilder.Entity("DM_helper.Gender", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<int?>("ArchetypeID");

                    b.Property<int>("CharacterID");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.HasKey("ID");

                    b.HasIndex("ArchetypeID");

                    b.HasIndex("CharacterID")
                        .IsUnique();

                    b.ToTable("Genders");
                });

            modelBuilder.Entity("DM_helper.Models.Armor", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<int>("AC")
                        .HasColumnName("ac");

                    b.Property<long?>("ArchetypeID");

                    b.Property<int?>("CharacterID");

                    b.Property<long>("Cost")
                        .HasColumnName("cost");

                    b.Property<long>("Encumbrance")
                        .HasColumnName("encumbrance");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.Property<long>("TechLevel")
                        .HasColumnName("techlevel");

                    b.HasKey("ID");

                    b.HasIndex("ArchetypeID");

                    b.HasIndex("CharacterID");

                    b.ToTable("Armor");
                });

            modelBuilder.Entity("DM_helper.Models.Character", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<int>("AtkBonus")
                        .HasColumnName("atkbonus");

                    b.Property<int>("BaseAC")
                        .HasColumnName("baseac");

                    b.Property<int>("Charisma")
                        .HasColumnName("charisma");

                    b.Property<int>("Constitution")
                        .HasColumnName("constitution");

                    b.Property<int>("Credits")
                        .HasColumnName("credits");

                    b.Property<int>("CurrentHP")
                        .HasColumnName("currenthp");

                    b.Property<int>("CurrentSystemStrain")
                        .HasColumnName("currentsystemstrain");

                    b.Property<int>("CurrentXP")
                        .HasColumnName("currentxp");

                    b.Property<int>("Dexterity")
                        .HasColumnName("dexterity");

                    b.Property<string>("Faction")
                        .HasColumnName("faction");

                    b.Property<string>("Goals")
                        .HasColumnName("goals");

                    b.Property<string>("Homeworld")
                        .HasColumnName("homeworld");

                    b.Property<int>("Intelligence")
                        .HasColumnName("intelligence");

                    b.Property<int>("Level")
                        .HasColumnName("level");

                    b.Property<int>("MaxHP")
                        .HasColumnName("maxhp");

                    b.Property<int>("MaxSystemStrain")
                        .HasColumnName("maxsystemstrain");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.Property<string>("Notes")
                        .HasColumnName("notes");

                    b.Property<int>("PermanentStrain")
                        .HasColumnName("permanentstrain");

                    b.Property<int>("Strength")
                        .HasColumnName("strength");

                    b.Property<int>("Wisdom")
                        .HasColumnName("wisdom");

                    b.Property<int>("XPTilNextLevel")
                        .HasColumnName("xptilnextlevel");

                    b.HasKey("ID");

                    b.ToTable("Character");
                });

            modelBuilder.Entity("DM_helper.Models.CharacterEncounter", b =>
                {
                    b.Property<int>("ID");

                    b.Property<int>("CharacterID");

                    b.Property<int>("EncounterID");

                    b.HasKey("ID");

                    b.ToTable("CharacterEncounter");
                });

            modelBuilder.Entity("DM_helper.Models.Encounter", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.Property<string>("Notes")
                        .HasColumnName("notes");

                    b.HasKey("ID");

                    b.ToTable("Encounter");
                });

            modelBuilder.Entity("DM_helper.Models.Equipment", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<long?>("ArchetypeID");

                    b.Property<int?>("CharacterID");

                    b.Property<string>("Cost")
                        .HasColumnName("cost");

                    b.Property<string>("Encumbrance")
                        .HasColumnName("encumbrance");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.Property<string>("TechLevel")
                        .HasColumnName("techlevel");

                    b.HasKey("ID");

                    b.HasIndex("ArchetypeID");

                    b.HasIndex("CharacterID");

                    b.ToTable("Equipment");
                });

            modelBuilder.Entity("DM_helper.Models.Foci", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<int?>("ArchetypeID");

                    b.Property<int?>("CharacterID");

                    b.Property<int>("Level")
                        .HasColumnName("level");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.HasKey("ID");

                    b.HasIndex("ArchetypeID");

                    b.HasIndex("CharacterID");

                    b.ToTable("Foci");
                });

            modelBuilder.Entity("DM_helper.Models.Melee", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<long?>("ArchetypeID");

                    b.Property<string>("Attribute")
                        .HasColumnName("attribute");

                    b.Property<int?>("CharacterID");

                    b.Property<long>("Cost")
                        .HasColumnName("cost");

                    b.Property<string>("Damage")
                        .HasColumnName("damage");

                    b.Property<long>("Encumbrance")
                        .HasColumnName("encumbrance");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.Property<string>("ShockDamage")
                        .HasColumnName("shockdamage");

                    b.Property<long>("TechLevel")
                        .HasColumnName("techlevel");

                    b.HasKey("ID");

                    b.HasIndex("ArchetypeID");

                    b.HasIndex("CharacterID");

                    b.ToTable("Melee");
                });

            modelBuilder.Entity("DM_helper.Models.Skills", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<int?>("ArchetypeID");

                    b.Property<int?>("CharacterID");

                    b.Property<int>("Level")
                        .HasColumnName("level");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.Property<int>("Specialist")
                        .HasColumnName("specialist");

                    b.HasKey("ID");

                    b.HasIndex("ArchetypeID");

                    b.HasIndex("CharacterID");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("DM_helper.Models.Weapon", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<int?>("ArchetypeID");

                    b.Property<string>("Attribute")
                        .HasColumnName("attribute");

                    b.Property<int?>("CharacterID");

                    b.Property<string>("Cost")
                        .HasColumnName("cost");

                    b.Property<string>("Damage")
                        .HasColumnName("damage");

                    b.Property<string>("Encumbrance")
                        .HasColumnName("encumbrance");

                    b.Property<string>("Magazine")
                        .HasColumnName("magazine");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.Property<string>("Range")
                        .HasColumnName("range");

                    b.Property<int>("TechLevel")
                        .HasColumnName("techlevel");

                    b.HasKey("ID");

                    b.HasIndex("ArchetypeID");

                    b.HasIndex("CharacterID");

                    b.ToTable("Weapons");
                });

            modelBuilder.Entity("DM_helper.Background", b =>
                {
                    b.HasOne("DM_helper.Archetypes.BackgroundArchetype", "Archetype")
                        .WithMany()
                        .HasForeignKey("ArchetypeID");

                    b.HasOne("DM_helper.Models.Character", "Character")
                        .WithOne("Background")
                        .HasForeignKey("DM_helper.Background", "CharacterID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DM_helper.CharacterClass", b =>
                {
                    b.HasOne("DM_helper.CharacterClass", "Archetype")
                        .WithMany()
                        .HasForeignKey("ArchetypeID");

                    b.HasOne("DM_helper.Models.Character", "Character")
                        .WithOne("Class")
                        .HasForeignKey("DM_helper.CharacterClass", "CharacterID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DM_helper.Gender", b =>
                {
                    b.HasOne("DM_helper.Archetypes.GenderArchetype", "Archetype")
                        .WithMany()
                        .HasForeignKey("ArchetypeID");

                    b.HasOne("DM_helper.Models.Character", "Character")
                        .WithOne("Gender")
                        .HasForeignKey("DM_helper.Gender", "CharacterID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DM_helper.Models.Armor", b =>
                {
                    b.HasOne("DM_helper.Archetypes.ArmorArchetype", "Archetype")
                        .WithMany()
                        .HasForeignKey("ArchetypeID");

                    b.HasOne("DM_helper.Models.Character", "Character")
                        .WithMany("Armor")
                        .HasForeignKey("CharacterID");
                });

            modelBuilder.Entity("DM_helper.Models.CharacterEncounter", b =>
                {
                    b.HasOne("DM_helper.Models.Character", "Character")
                        .WithMany("CharacterEncounter")
                        .HasForeignKey("ID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DM_helper.Models.Encounter", "Encounter")
                        .WithMany("CharacterEncounter")
                        .HasForeignKey("ID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DM_helper.Models.Equipment", b =>
                {
                    b.HasOne("DM_helper.Archetypes.EquipmentArchetype", "Archetype")
                        .WithMany()
                        .HasForeignKey("ArchetypeID");

                    b.HasOne("DM_helper.Models.Character", "Character")
                        .WithMany("Equipment")
                        .HasForeignKey("CharacterID");
                });

            modelBuilder.Entity("DM_helper.Models.Foci", b =>
                {
                    b.HasOne("DM_helper.Archetypes.FociArchetype", "Archetype")
                        .WithMany()
                        .HasForeignKey("ArchetypeID");

                    b.HasOne("DM_helper.Models.Character", "Character")
                        .WithMany("Foci")
                        .HasForeignKey("CharacterID");
                });

            modelBuilder.Entity("DM_helper.Models.Melee", b =>
                {
                    b.HasOne("DM_helper.Archetypes.MeleeArchetype", "Archetype")
                        .WithMany()
                        .HasForeignKey("ArchetypeID");

                    b.HasOne("DM_helper.Models.Character", "Character")
                        .WithMany("Melee")
                        .HasForeignKey("CharacterID");
                });

            modelBuilder.Entity("DM_helper.Models.Skills", b =>
                {
                    b.HasOne("DM_helper.Archetypes.SkillsArchetype", "Archetype")
                        .WithMany()
                        .HasForeignKey("ArchetypeID");

                    b.HasOne("DM_helper.Models.Character", "Character")
                        .WithMany("Skills")
                        .HasForeignKey("CharacterID");
                });

            modelBuilder.Entity("DM_helper.Models.Weapon", b =>
                {
                    b.HasOne("DM_helper.Archetypes.WeaponArchetype", "Archetype")
                        .WithMany()
                        .HasForeignKey("ArchetypeID");

                    b.HasOne("DM_helper.Models.Character", "Character")
                        .WithMany("Weapon")
                        .HasForeignKey("CharacterID");
                });
#pragma warning restore 612, 618
        }
    }
}
