using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__8
{
    public static class PhoneHelper
    {
        public static bool IsPhoneValid(string phoneNumber)
        {
            if (phoneNumber.Length != 12)
            {
                return false;
            }
            if (!phoneNumber.StartsWith("375"))
            {
                return false;
            }
            for(int i = 3; i < phoneNumber.Length; i++)
            {
                int buffer;
                bool result = int.TryParse(phoneNumber[i].ToString(), out buffer);
                if (!result)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
