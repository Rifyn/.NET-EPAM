using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUPER_STRING
{
    public static class StringExtentions
    {
        public enum Languages
        {
            Mixed = 0,
            Russian = 1,
            English = 2,
            Number = 3
        }

        public static Languages CheckLanguage(this string text)
        {
            if(text == null)
            {
                return Languages.Mixed;
            }


            if (char.IsDigit(text[0]))
            {
                if (text.Any(x => !char.IsDigit(x)))
                {
                    return Languages.Mixed;
                }
                return Languages.Number;
            }


            if (char.IsLetter(text[0]))
            {
                if (text.Any(x=>!char.IsLetter(x)))
                {
                    return Languages.Mixed;
                }


                if ((text[0] >= 'А' && text[0] <= 'я') || text[0] == 'ё' || text[0] == 'Ё')
                {
                    if (text.Any(x => (x < 'А' || (x > 'я' && x != 'ё' && x != 'Ё'))))
                    {
                        return Languages.Mixed;
                    }
                    return Languages.Russian;
                }


                if (text[0] >= 'A' && text[0] <= 'z')
                {
                    if (text.Any(x => (x < 'A' || x > 'z')))
                    {
                        return Languages.Mixed;
                    }
                    return Languages.English;
                }
            }
            return Languages.Mixed;
        }
    }
}
