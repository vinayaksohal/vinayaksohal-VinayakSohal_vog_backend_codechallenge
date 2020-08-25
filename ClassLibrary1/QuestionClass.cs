using System;
using System.Collections.Generic;

namespace QuestionClass
{
    public static class QuestionClass
    {
        static List<string> NamesList = new List<string>()
        {
            "Jimmy",
            "jeffrey"
        };

        public static void TestQuestion()
        {
            using (var enumerator = NamesList.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    Console.WriteLine(enumerator.Current);
                }
            }

            //alternate Implementation of above code
            foreach (string s in NamesList)
            {
                Console.WriteLine(s);
            }
        }
    }
}
