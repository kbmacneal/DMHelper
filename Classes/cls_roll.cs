using DM_helper.Classes.Utilities;
using System;
using System.Collections.Generic;

namespace DM_helper.Classes
{
    public class RollDice
    {
        public static List<int> Roll(string roll)
        {
            List<int> dice_results = new List<int>();

            DiceBag db = new DiceBag();
            char[] dice_splits = { 'd', 'D' };
            if (roll.Contains('-') || roll.Contains('+'))
            {
                char[] splits = new char[] { '+', '-' };
                string[] two_parts = roll.Split(splits);
                int mod = 0;
                if (roll.Contains('-'))
                {
                    mod = -1 * Convert.ToInt32(two_parts[1]);
                }
                else
                {
                    mod = Convert.ToInt32(two_parts[1]);
                }
                string[] parameters = two_parts[0].Split(dice_splits);
                uint num_dice = 1;
                int dice_sides = 2;

                if (parameters[0] != "")
                {
                    num_dice = Convert.ToUInt32(parameters[0]);
                    dice_sides = Convert.ToInt32(parameters[1]);
                }
                else
                {
                    dice_sides = Convert.ToInt32(parameters[1]);
                }

                DiceBag.Dice dice = (DiceBag.Dice)System.Enum.Parse(typeof(DiceBag.Dice), dice_sides.ToString());

                dice_results = db.RollQuantity(dice, num_dice);

                dice_results.Add(mod);
            }
            else
            {
                string[] parameters = roll.Split(dice_splits);
                uint num_dice = 1;
                int dice_sides = 2;

                if (parameters[0] != "")
                {
                    num_dice = Convert.ToUInt32(parameters[0]);
                    dice_sides = Convert.ToInt32(parameters[1]);
                }
                else
                {
                    dice_sides = Convert.ToInt32(parameters[1]);
                }

                DiceBag.Dice dice = (DiceBag.Dice)System.Enum.Parse(typeof(DiceBag.Dice), dice_sides.ToString());

                dice_results = db.RollQuantity(dice, num_dice);
            }

            return dice_results;
        }
    }
}