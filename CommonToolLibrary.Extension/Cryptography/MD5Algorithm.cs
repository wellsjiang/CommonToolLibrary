using System;
using System.Text;

namespace CommonToolLibrary.Extension.Cryptography
{
    public static class MD5Algorithm
    {
        /// <summary>对字节数据进行MD5加密</summary>
        /// <param name="encryptArray">需加密的字节数组</param>
        /// <returns>加密后的字符串</returns>
        public static string Encode(byte[] encryptArray)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] result = md5.ComputeHash(encryptArray);
            string t = "";
            const int BitLength = 2;
            foreach (byte item in result)
            {
                string tTemp = Convert.ToString(item, 16);
                if (tTemp.Length != BitLength)
                {
                    switch (tTemp.Length)
                    {
                        case 0: tTemp = "00"; break;
                        case 1: tTemp = "0" + tTemp; break;
                        default: tTemp = tTemp.Substring(0, 2); break;
                    }
                }
                t += tTemp;
            }
            return t;
        }

        /// <summary>对字符串进行MD5加密(默认编码为UTF-8)</summary>
        /// <param name="encryptString">需加密的字符串</param>
        /// <returns>加密后字符串</returns>
        public static string Encode(string encryptString)
        {
            byte[] data = Encoding.UTF8.GetBytes(encryptString);
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] result = md5.ComputeHash(data);
            string t = string.Empty;
            foreach (var item in result)
            {
                t += Convert.ToString(item, 16);
            }
            return t;
        }

        /// <summary>对字符串进行MD5加密</summary>
        /// <param name="encryptString">需加密的字符串</param>
        /// <param name="encode">编码方式</param>
        /// <returns>加密后字符串</returns>
        public static string Encode(string encryptString, Encoding encode)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] result = md5.ComputeHash(encode.GetBytes(encryptString));
            StringBuilder strbText = new StringBuilder();
            foreach (byte item in result)
            {
                strbText.Append(item.ToString("x2"));
            }
            return strbText.ToString();
        }
    }
}
