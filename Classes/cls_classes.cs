using System.ComponentModel;
using Humanizer;

namespace DM_helper
{

    public enum CharacterClass
    {
        [Description("Expert")]
        Expert,
        [Description("Warrior")]
        Warrior,
        [Description("Psychic")]
        Psychic,
        [Description("Adventurer")]
        Adventurer
    }

    public enum Backgrounds
    {
        [Description("Barbarian")]
        Barbarian,
        [Description("Clergy")]
        Clergy,
        [Description("Courtesan")]
        Courtesan,
        [Description("Criminal")]
        Criminal,
        [Description("Dilettante")]
        Dilettante,
        [Description("Entertainer")]
        Entertainer,
        [Description("Merchant")]
        Merchant,
        [Description("Noble")]
        Noble,
        [Description("Official")]
        Official,
        [Description("Peasant")]
        Peasant,
        [Description("Physician")]
        Physician,
        [Description("Pilot")]
        Pilot,
        [Description("Politician")]
        Politician,
        [Description("Scholar")]
        Scholar,
        [Description("Soldier")]
        Soldier,
        [Description("Spacer")]
        Spacer,
        [Description("Technician")]
        Technician,
        [Description("Thug")]
        Thug,
        [Description("Vagabond")]
        Vagabond,
        [Description("Worker")]
        Worker
    }

    public enum Gender
    {
        [Description("Male")]
        Male,
        [Description("Female")]
        Female,
        [Description("Other")]
        Other
    }
}