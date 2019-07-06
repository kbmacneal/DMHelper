using System.Collections.Generic;
using System.Linq;

namespace DM_helper.Classes

{
    public class StatMod
    {
        public int value { get; set; }
        public int mod { get; set; }

        public static int mod_from_stat_val(int stat_val)
        {
            int rtn = 0;

            List<StatMod> mods = gen_mods();

            rtn = mods.FirstOrDefault(e => e.value == stat_val).mod;

            return rtn;
        }

        public static List<StatMod> gen_mods()
        {
            List<StatMod> rtn = new List<StatMod>();

            for (int i = 1; i < 19; i++)
            {
                if (i <= 3)
                {
                    StatMod mod = new StatMod
                    {
                        value = i,
                        mod = -2
                    };
                    rtn.Add(mod);
                }

                if (i >= 4 && i <= 7)
                {
                    StatMod mod = new StatMod
                    {
                        value = i,
                        mod = -1
                    };

                    rtn.Add(mod);
                }

                if (i >= 8 && i <= 13)
                {
                    StatMod mod = new StatMod
                    {
                        value = i,
                        mod = 0
                    };
                    rtn.Add(mod);
                }

                if (i >= 14 && i <= 17)
                {
                    StatMod mod = new StatMod
                    {
                        value = i,
                        mod = 1
                    };
                    rtn.Add(mod);
                }

                if (i == 18)
                {
                    StatMod mod = new StatMod
                    {
                        value = i,
                        mod = 2
                    };
                    rtn.Add(mod);
                }
            }

            return rtn;
        }
    }
}