using System;
using System.Collections.Generic;
using System.Text;

namespace HW_08
{
    public static class Security
    {
        public static string[] danger = { "drugs", "gun", "alcohol", "knife", "fuel", "sword", "rum", "vodka", "bat"};
        public static bool search (string a)
        {            
                foreach (var item in danger)
                {
                    if (a == item)
                        return false;
                }          
                        
            return true;
        }
    }
}
