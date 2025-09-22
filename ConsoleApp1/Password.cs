using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    public class Password
    {
        public string UserPassword { get; set; }
        public bool CheckPassword()
        {
            Regex number = new Regex(@"\d");
            return number.IsMatch(UserPassword)&&UserPassword.Length>=6;
        }
    }
}
