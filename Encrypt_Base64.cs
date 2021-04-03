using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    static class Encrypt
    {
        // Mã hóa chuỗi văn bản thành Base64
        public static string ToBase64(this string str)
        {
            UTF8Encoding encoding = new System.Text.UTF8Encoding();
            byte[] b = encoding.GetBytes(str);
            return Convert.ToBase64String(b);
        }

        // Giải mã chuỗi Base64 thành văn bản
        public static string Base64ToString(this string str)
        {
            UTF8Encoding encoding = new System.Text.UTF8Encoding();
            byte[] b = Convert.FromBase64String(str);
            return encoding.GetString(b);
        }

        // Cách sử dụng
        // string plainText = "Non Nguyen Blog";
        // string encodeText = "YmxvZy5ub25uZ3V5ZW4uY29t";

        // Console.WriteLine(plainText + " to Base64: " + plainText.ToBase64());
        // Console.WriteLine(encodeText + " to string: " + encodeText.Base64ToString());

        // Kết quả output:
        // Non Nguyen Blog to Base64: Tm9uIE5ndXllbiBCbG9n
        // YmxvZy5ub25uZ3V5ZW4uY29t to string: blog.nonnguyen.com


    }
}
