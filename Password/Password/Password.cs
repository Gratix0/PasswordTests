using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    public class Password
    {
        public int TestingPassword(string password)
        {
            int result = 0;
            foreach (char c in password)
            {
                if (char.IsDigit(c)) {
                    result += 1;
                    break;
                }
                else
                {
                    result += 0;
                }
            }
  
            foreach (char c in password)
            {
                if (char.IsLower(c))
                {
                    result += 1;
                    break;
                }
                else
                {
                    result += 0;
                }
            }

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    result += 1;
                    break;
                }
                else
                {
                    result += 0;
                }
            }
        
            foreach (char c in password)
            {
                if (char.IsSymbol(c))
                {
                    result += 1;
                    break;
                }
                else
                {
                    result += 0;
                }
            }

            foreach (char c in password)
            {
                if (password.Length >= 7)
                {
                    result += 1;
                    break;
                }
                else
                {
                    result += 0;
                }
            }
            
            foreach (char c in password)
            {
                if (c == Convert.ToChar("P"))
                {
                    result += 1;


                }
                else
                {
                    result += 0;
                }
            }

            return result;
        }
}
    
}
