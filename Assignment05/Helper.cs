using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment05
{
   public static class Helper
    {
        public static bool CheckPhone(string phone)
        {
            Regex regex = new Regex(@"^[0-9]{7,}$");
            Match match = regex.Match(phone);

            return match.Success;
        }

        public static bool CheckEmail(string email)
        {
            Regex regex = new Regex(@"^[a-zA-z0-9_]+@[]$[a-zA-z0-9_]+\.[a-zA-z0-9_]+");
            Match match = regex.Match(email);

            return match.Success;
        }
    }
}
