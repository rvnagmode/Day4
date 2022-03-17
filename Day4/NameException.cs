using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public class NameException : Exception
    {
        public NameException(string msg) : base(msg)
        { 
        }
    }
    public class User
    {
        string nm;
        public string Acceptname (string nm)
        {
            if (string.IsNullOrEmpty(nm))
            {
                throw new NameException("pls enter the name, name cant be null or empty");
                
            }
            return nm;
        } 
    }

}
