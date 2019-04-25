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
    [Migration("20190425181212_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2l.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("DM_helper.Background", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<int>("CharacterID")
                        .HasColumnName("characterid");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.HasKey("ID");

                    b.HasIndex("CharacterID")
                        .IsUnique();

                    b.ToTable("Background");
                });

            modelBuilder.Entity("DM_helper.CharacterClass", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<int>("CharacterID")
                        .HasColumnName("characterid");

                    b.Property<int?>("CharacterID1");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.HasKey("ID");

                    b.HasIndex("CharacterID");

                    b.HasIndex("CharacterID1");

                    b.ToTable("CharacterClass");
                });

            modelBuilder.Entity("DM_helper.Gender", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<int>("CharacterID")
                        .HasColumnName("characterid");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.HasKey("ID");

                    b.HasIndex("CharacterID")
                        .IsUnique();

                    b.ToTable("Gender");
                });

            modelBuilder.Entity("DM_helper.Models.Armor", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<int>("AC")
                        .HasColumnName("ac");

                    b.Property<int>("CharacterID");

                    b.Property<long>("Cost")
                        .HasColumnName("cost");

                    b.Property<long>("Encumbrance")
                        .HasColumnName("encumbrance");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.Property<long>("TechLevel")
                        .HasColumnName("techlevel");

                    b.HasKey("ID");

                    b.HasIndex("CharacterID")
                        .IsUnique();

                    b.ToTable("Armor");
                });

            modelBuilder.Entity("DM_helper.Models.Character", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<int>("AC")
                        .HasColumnName("ac");

                    b.Property<int>("ArmorID")
                        .HasColumnName("armorid");

                    b.Property<long?>("ArmorID1");

                    b.Property<int>("AtkBonus")
                        .HasColumnName("atkbonus");

                    b.Property<int>("BackgroundID")
                        .HasColumnName("backgroundid");

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

                    b.Property<int>("GenderID")
                        .HasColumnName("genderid");

                    b.Property<string>("Goals")
                        .HasColumnName("goals");

                    b.Property<string>("Homeworld")
                        .HasColumnName("homeworld");

                    b.Property<int>("Intelligence")
                        .HasColumnName("intelligence");

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

                    b.HasIndex("ArmorID1");

                    b.HasIndex("BackgroundID");

                    b.HasIndex("GenderID");

                    b.ToTable("Character");
                });

            modelBuilder.Entity("DM_helper.Models.Equipment", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<int>("CharacterID");

                    b.Property<int?>("CharacterID1");

                    b.Property<string>("Cost")
                        .HasColumnName("cost");

                    b.Property<string>("Encumbrance")
                        .HasColumnName("encumbrance");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.Property<string>("TechLevel")
                        .HasColumnName("techlevel");

                    b.HasKey("ID");

                    b.HasIndex("CharacterID");

                    b.HasIndex("CharacterID1");

                    b.ToTable("Equipment");
                });

            modelBuilder.Entity("DM_helper.Models.Foci", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<int>("CharacterID");

                    b.Property<int?>("CharacterID1");

                    b.Property<int>("Level")
                        .HasColumnName("level");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.HasKey("ID");

                    b.HasIndex("CharacterID");

                    b.HasIndex("CharacterID1");

                    b.ToTable("Foci");
                });

            modelBuilder.Entity("DM_helper.Models.Melee", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<string>("Attribute")
                        .HasColumnName("attribute");

                    b.Property<int>("CharacterID")
                        .HasColumnName("characterid");

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

                    b.HasIndex("CharacterID");

                    b.ToTable("Melee");
                });

            modelBuilder.Entity("DM_helper.Models.Skills", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<int>("CharacterID");

                    b.Property<int?>("CharacterID1");

                    b.Property<int>("Level")
                        .HasColumnName("level");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.Property<int>("Specialist")
                        .HasColumnName("specialist");

                    b.HasKey("ID");

                    b.HasIndex("CharacterID");

                    b.HasIndex("CharacterID1");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("DM_helper.Models.Weapon", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<string>("Attribute")
                        .HasColumnName("attribute");

                    b.Property<int>("CharacterID");

                    b.Property<int?>("CharacterID1");

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

                    b.HasIndex("CharacterID");

                    b.HasIndex("CharacterID1");

                    b.ToTable("Weapons");
                });

            modelBuilder.Entity("DM_helper.Background", b =>
                {
                    b.HasOne("DM_helper.Models.Character", "Character")
                        .WithOne()
                        .HasForeignKey("DM_helper.Background", "CharacterID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DM_helper.CharacterClass", b =>
                {
                    b.HasOne("DM_helper.Models.Character", "Character")
                        .WithMany()
                        .HasForeignKey("CharacterID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DM_helper.Models.Character")
                        .WithMany("Class")
                        .HasForeignKey("CharacterID1");
                });

            modelBuilder.Entity("DM_helper.Gender", b =>
                {
                    b.HasOne("DM_helper.Models.Character", "Character")
                        .WithOne()
                        .HasForeignKey("DM_helper.Gender", "CharacterID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DM_helper.Models.Armor", b =>
                {
                    b.HasOne("DM_helper.Models.Character", "Character")
                        .WithOne()
                        .HasForeignKey("DM_helper.Models.Armor", "CharacterID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DM_helper.Models.Character", b =>
                {
                    b.HasOne("DM_helper.Models.Armor", "Armor")
                        .WithMany()
                        .HasForeignKey("ArmorID1");

                    b.HasOne("DM_helper.Background", "Background")
                        .WithMany()
                        .HasForeignKey("BackgroundID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DM_helper.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DM_helper.Models.Equipment", b =>
                {
                    b.HasOne("DM_helper.Models.Character", "Character")
                        .WithMany()
                        .HasForeignKey("CharacterID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DM_helper.Models.Character")
                        .WithMany("Equipment")
                        .HasForeignKey("CharacterID1");
                });

            modelBuilder.Entity("DM_helper.Models.Foci", b =>
                {
                    b.HasOne("DM_helper.Models.Character", "Character")
                        .WithMany()
                        .HasForeignKey("CharacterID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DM_helper.Models.Character")
                        .WithMany("Foci")
                        .HasForeignKey("CharacterID1");
                });

            modelBuilder.Entity("DM_helper.Models.Melee", b =>
                {
                    b.HasOne("DM_helper.Models.Character", "Character")
                        .WithMany()
                        .HasForeignKey("CharacterID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DM_helper.Models.Skills", b =>
                {
                    b.HasOne("DM_helper.Models.Character", "Character")
                        .WithMany()
                        .HasForeignKey("CharacterID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DM_helper.Models.Character")
                        .WithMany("Skills")
                        .HasForeignKey("CharacterID1");
                });

            modelBuilder.Entity("DM_helper.Models.Weapon", b =>
                {
                    b.HasOne("DM_helper.Models.Character", "Character")
                        .WithMany()
                        .HasForeignKey("CharacterID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DM_helper.Models.Character")
                        .WithMany("Weapons")
                        .HasForeignKey("CharacterID1");
                });
#pragma warning restore 612, 618
        }
    }
}