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
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace DM_helper.Models
{
    public class Encounter
    {
       public int ID {get;set;}
       public string Name {get;set;}
       public List<CharacterEncounter> CharacterEncounter {get;set;}
       public string Notes {get;set;}
       public int Session {get;set;}

    }

    //join model

    public class CharacterEncounter
    {
        public int ID {get;set;}
        public int EncounterID{get;set;}
        public Encounter Encounter {get;set;}
        public int CharacterID {get;set;}
        public Character Character{get;set;}
    }
}