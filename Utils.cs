using System;
using System.Text;
using XRL;
using XRL.Core;
using XRL.Rules;

namespace Custom_Soundtrack.Utilities
{
    [HasGameBasedStaticCache]
    public static class Custom_Soundtrack_Random
    {
        private static Random _rand;
        public static Random Rand
        {
            get
            {
                if (_rand == null)
                {
                    if (XRLCore.Core?.Game == null)
                    {
                        throw new Exception(
                            "Custom_Soundtrack mod attempted to retrieve Random, but Game is not created yet."
                        );
                    }
                    else if (XRLCore.Core.Game.IntGameState.ContainsKey("Custom_Soundtrack:Random"))
                    {
                        int seed = XRLCore.Core.Game.GetIntGameState("Custom_Soundtrack:Random");
                        _rand = new Random(seed);
                    }
                    else
                    {
                        _rand = Stat.GetSeededRandomGenerator("Custom_Soundtrack");
                    }
                    XRLCore.Core.Game.SetIntGameState("Custom_Soundtrack:Random", _rand.Next());
                }
                return _rand;
            }
        }

        [GameBasedCacheInit]
        public static void ResetRandom()
        {
            _rand = null;
        }

        public static int Next(int minInclusive, int maxInclusive)
        {
            return Rand.Next(minInclusive, maxInclusive + 1);
        }
    }

    public static class Utils
    {
        public static string AddSpacesToCapitalizedString(string text)
        {
            StringBuilder newText = new StringBuilder(text.Length * 2);
            newText.Append(text[0]);
            for (int i = 1; i < text.Length; i++)
            {
                if (char.IsUpper(text[i]))
                {
                    if (
                        (text[i - 1] != ' ' && !char.IsUpper(text[i - 1]))
                        || (
                            char.IsUpper(text[i - 1])
                            && i < text.Length - 1
                            && !char.IsUpper(text[i + 1]) //prevents acronyms from having spaces
                        )
                    )
                    {
                        newText.Append(' ');
                    }
                }

                //Support numbers included in the text
                if (char.IsNumber(text[i]))
                {
                    if (
                        (text[i - 1] != ' ' && !char.IsNumber(text[i - 1]))
                        || (
                            char.IsNumber(text[i - 1])
                            && i < text.Length - 1
                            && !char.IsNumber(text[i + 1])
                        )
                    )
                    {
                        newText.Append(' ');
                    }
                }

                newText.Append(text[i]);
            }

            return newText.ToString();
        }
    }
}
