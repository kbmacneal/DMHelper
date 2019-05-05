using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DM_helper.Models
{
    public class PsionicSchool
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class PsionicSkillArchetype
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Level { get; set; } = -1;
        public int PsionicSchoolID { get; set; }
        public PsionicSchool PsionicSchool { get; set; }
    }
}