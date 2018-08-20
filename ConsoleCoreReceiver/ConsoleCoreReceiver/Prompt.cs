using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreReceiver
{
    public static class Prompt
    {
        public static string ReturnPrompt(string msg)
        {
            int periodIndex = msg.IndexOf(',');
            periodIndex = periodIndex + 1;
            msg = msg.Substring(periodIndex);
            return "Hello " + msg.Trim() + " , I am your father!";
        }
    
    }
}
