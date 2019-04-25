using System.ComponentModel;
using Humanizer;
using DM_helper.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DM_helper
{

    public class CharacterClass
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CharacterID { get; set; }
        [ForeignKey("CharacterID")]
        public Character Character {get;set;}
    }
    public class Background
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CharacterID { get; set; }
        [ForeignKey("CharacterID")]
        public Character Character {get;set;}
    }
    public class Gender
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CharacterID { get; set; }
        [ForeignKey("CharacterID")]
        public Character Character {get;set;}
    }
}