using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace TennisKlubben.Data
{
    public class InputControl
    {
        public bool IsOnlyNumbers(string input)
        {
            foreach (char c in input)
            {
                // check that it's a number (unicode)
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        public bool IsCreditCardNumberValid(string input)
        {
            // 1
            char lastNumber = input[input.Length - 1];

            // 2
            char[] toArray = input.Substring(0, input.Length - 1).ToCharArray();
            Array.Reverse(toArray);
            string reverse = new string(toArray);

            // 3

            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < reverse.Length; i++)
            {
                if ((i + 1) % 2 == 0) continue;

                int doubled = Int32.Parse(reverse[i].ToString()) * 2;
                string toString = doubled.ToString();

                if (toString.Length > 1)
                {
                    int final = Int32.Parse(toString[0].ToString()) + Int32.Parse(toString[1].ToString());
                    builder.Append(final.ToString());
                }
                else
                {
                    builder.Append(toString);
                }
            }

            string done = builder.ToString();

            // 6

            int added = 0;

            for (int i = 0; i < done.Length; i++)
            {
                added += Int32.Parse(done[i].ToString());
            }

            // 7

            int lastCheck = 10 - Int32.Parse(added.ToString()[1].ToString());


            return lastCheck == lastNumber;


        }
    }
}