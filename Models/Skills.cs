using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DM_helper.Models {
    public class Skills

    {
        public int Level { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Specialist { get; set; }
    }
}