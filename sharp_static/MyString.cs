using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp_static
{
    static class MyString
    {
        public static int MyIndexOf(this string str, string value)
        {
            if (IsNull(str, value))
            {
                throw new NullReferenceException();
            }

            if (str.Length == 0 || str.Length < value.Length ) // -1 
            {
                return -1;
            }

            if (value.Length == 0) // 0
            {
                return 0;
            }

            for (int i = 0; i <= str.Length - value.Length; i++)
            {
                if (str.Substring(i, value.Length) == value)
                {
                    return i;
                }
            }
            

            

            return -1;
        }

        public static string MySubstring(this string str, int startIndex)
        {
            return str.MySubstring(startIndex, str.Length - 1 - startIndex);
        }

        public static string MySubstring(this string str, int startIndex, int length)
        {
            if (str == null)
            {
                return null;
            }

            string res = "";

            ValidateInputSubstring(str, startIndex, length);
            if (length == 0)
            {
                return "";
            }
            for (int i = startIndex; i <= startIndex + length; i++)
            {
                res = string.Concat(res, str[i]);
            }
            

            return res;
        }

        private static void ValidateInputSubstring(string str, int start, int length)
        {
            if (IsNull(str))
            {
                throw new NullReferenceException();
            }
            if (start < 0 || start > str.Length - 1 || length < 0 || (length + start) > str.Length)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        private static bool IsNull(params Object[] obj)
        {
            for (int i = 0; i < obj.Length; i++)
            {
                if(obj[i] == null)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
