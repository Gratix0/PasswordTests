using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    public class Password
    {
        public int NumberPassword(string password)
        {
            int result = 0;
            foreach (char c in password)
            {
                if (char.IsDigit(c)) {
                    result = 1;
                    break;
                }
                else
                {
                    result = 0;
                }
            }
            return result;
        }

        public int StrokeSimbInThePass(string password)
        {
            int result = 0;
            foreach (char c in password)
            {
                if (char.IsLower(c))
                {
                    result = 1;
                    break;
                }
                else
                {
                    result = 0;
                }
            }
            return result;
        }

        public int UpperCaseSimbInThePass(string password)
        {
            int result = 0;
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    result = 1;
                    break;
                }
                else
                {
                    result = 0;
                }
            }
            return result;
        }

        public int SpecSimbInThePass(string password)
        {
            int result = 0;
            foreach (char c in password)
            {
                if (char.IsSymbol(c))
                {
                    result = 1;
                    break;
                }
                else
                {
                    result = 0;
                }
            }
            return result;
        }

        public int SevenSimbInThePass(string password)
        {
            int result = 0;
            foreach (char c in password)
            {
                if (password.Length >= 7)
                {
                    result = 1;
                    break;
                }
                else
                {
                    result = 0;
                }
            }
            return result;
        }

        public int NalichiePass(string password)
        {
            int result = 0;

                if (password.Length >= 1)
                {
                    result = 1;
                    
                }
                else
                {
                    result = 0;
                }
            return result;
        }
    }
}
