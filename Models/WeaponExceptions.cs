using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapontask.Models
{
    public class WeaponException : Exception
    {
        public WeaponException(string message) : base(message) 
        { 
        
        }
    }
    public class InvalidFireModeException : WeaponException
    {
        public InvalidFireModeException(string message) : base(message) 
        { 
        
        }
    }
}
