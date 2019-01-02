using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.App.CommonLib
{
    public static class Greeting
    {
        public static string ComposeGreetingMsg(string msg)
        {
            string result = $"This is greeting message: {msg}";
            return result;
        }
    }
}
