using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Market.Services
{
    public class Password
    {
        public bool isCorrect(string password)
        {
            bool result = true;
            for (int i = 0; i < password.Length; i++)
            {
                if (!(Char.IsDigit(password[i]) || password[i] >= 'a' && password[i] <= 'z' || password[i] >= 'A' && password[i] <= 'Z'))
                {
                    result = false;
                    break;
                }
            }
            return result;
           
        }
    }
}
