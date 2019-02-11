using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_7_Delegates.Extension_Methods
{
    public static class StringListExtension
    {
        public delegate string StringFormatter(string text);     
        public static List<String> Format(this List<String> source, StringFormatter formatter)
        {
            List<String> result = new List<String>();
            foreach (var item in source)
            {
                var formattedString = formatter(item);
                result.Add(formatter(formattedString));
            }
            return result;

        }
    }
}
