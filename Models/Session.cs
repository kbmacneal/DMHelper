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
    public class Session
    {
       public int ID {get;set;}
       public string Name {get;set;}
       public List<Encounter> Encounters {get;set;}
       public string Notes {get;set;}

    }
}