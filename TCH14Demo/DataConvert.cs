using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TM200Demo
{
    public class DataConvert
    {
        public static bool IsValidIP(string strIP)
        {
            // 先检查有无非数字字符
            if (!Regex.IsMatch(strIP, "^[0-9.]+$"))
            {
                return false;
            }
            // 再检查数据范围是否合理
            string[] strNumArray = strIP.Split('.');
            if (strNumArray.Length != 4)
            {
                return false;
            }
            int n = 0;
            for (int i = 0; i < 4; ++i)
            {
                n = int.Parse(strNumArray[i]);
                if (n > 255)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsHexCharacter(string str)
        {
            return Regex.IsMatch(str, "^[0-9A-Fa-f]+$");
        }

        public static bool IsDecimalismCharacter(string str)
        {
            return Regex.IsMatch(str, "^[0-9]+$");
        }

        // 大小端转换
        public static UInt16 ReverseByte(UInt16 value)
        {
            return (UInt16)((value & 0xFFU) << 8 | (value & 0xFF00U) >> 8);
        }

        public static bool IsDecNumber(string str)
        {
            return Regex.IsMatch(str, "^[0-9]+$");
        }


        public static string IPAddPoint(byte[] value)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                sb.Append(value[i]);
                if (i != 3)
                {
                    sb.Append(".");
                }
            }
            return sb.ToString();
        }

        public static byte[] IPCutPoint(string value)
        {
            byte[] data = new byte[4];
            string[] ip = value.Split('.');
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = Byte.Parse(ip[i]);
            }
            return data;
        }

        /// <summary>
        /// 字节数组转16进制字符串
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static string BytesToHexStr(byte[] bytes, int length)
        {
            string returnStr = "";
            if (bytes != null)
            {
                for (int i = 0; i < length; i++)
                {
                    returnStr += bytes[i].ToString("X2") + "";
                }
            }
            return returnStr;
        }

        private static byte toByte(char c)
        {
            byte b = (byte)"0123456789ABCDEF".IndexOf(c);
            return b;
        }

        /// <summary>
        /// 十六进制字符串转字节数组
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        public static byte[] HexStrToBytes(string hex)
        {
            hex = hex.ToUpper();
            int len = hex.Length / 2;
            byte[] result = new byte[len];
            char[] achar = hex.ToCharArray();
            for (int i = 0; i < len; i++)
            {
                int pos = i * 2;
                result[i] = ((byte)(toByte(achar[pos]) << 4 | toByte(achar[(pos + 1)])));
            }
            return result;
        }
    }
}
