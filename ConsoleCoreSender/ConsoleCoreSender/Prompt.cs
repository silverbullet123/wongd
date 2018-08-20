using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreSender
{
    public static class Prompt
    {
        public static string DisplayEnterMsg()
        {
           return "Enter name.";     
        }

        public static string DisplaySentMessage(string msg)
        { 
            return "Sent message : "+ msg;     
        }

        
    }
}
