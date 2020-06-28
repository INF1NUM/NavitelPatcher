using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavitelPatcher
{
    class BinaryTools
    {
        //Переводит шестнадцатиричный символ в число byte
        public static byte LitToByte(char s)
        {
            const string z = "0123456789abcdef";
            return (byte)z.IndexOf(s);
        }

        //Переводит шестнадцатиричное символьное представление в число byte
        public static byte StrToByte(string s)
        {
            return (byte)(LitToByte(s[0]) * 16 + LitToByte(s[1]));
        }

        //Преобразует строку с последовательностью символьных шестнадцатиричных предсавлений в массив байтов
        public static byte[] StrToArrByte(string str)
        {
            str = str.ToLower(); //Приводим строку к нижнему регистру

            const char delimiter = ' '; //Разделитель пробел
            var arr = str.Split(delimiter); //Разбиваем строку в массив по 2 символа

            long length = arr.Length;
            var rArr = new byte[length];

            for (long i = 0; i < length; i++)
            {
                rArr[i] = StrToByte(arr[i]); //Переводим шестнадцатиричное символьное представление в число
            }

            return rArr;
        }
    }
}
