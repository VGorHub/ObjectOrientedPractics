using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    class ValueValidator
    {
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value == null||value == "")
            {
                throw new Exception($"{propertyName} должен быть не пустым");
            }
            if (value.Length > maxLength)
            {
                throw new Exception($"{propertyName} должен быть меньше {maxLength} символов");
            }   
            
        }
    }
}
