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
        static byte LitToByte(char s)
        {
            const string z = "0123456789abcdef";
            return (byte)z.IndexOf(s);
        }

        //Переводит шестнадцатиричное символьное представление в число byte
        static byte StrToByte(string s)
        {
            return (byte)(LitToByte(s[0]) * 16 + LitToByte(s[1]));
        }

        //Преобразует строку с последовательностью символьных шестнадцатиричных предсавлений в массив байтов
        private static byte[] StrToArrByte(string str)
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


        //Проверяет побайтовое совпадение переданного массива начиная с fs.Position
        static bool ListEquality(FileStream fs, byte[] arrB)
        {
            // fs.Position - должен быть уже коректно задан 
            long length = arrB.Length;

            for (long i = 0; i < length; i++)
            {
                if (fs.ReadByte() != arrB[i])
                {
                    return false;
                }
            }

            return true;
        }


        //Поиск позиции в файле. Возвращает позицию или -1
        public static long SearchPos(FileStream fs, string str)
        {

            var arrB = StrToArrByte(str); //Переводим строку вида "... ff ff ..." в массив байтов

            fs.Seek(0, SeekOrigin.Begin);
            var num = fs.Length - arrB.Length;

            for (long i = 0; i < num; i++)
            {
                fs.Position = i;

                if (ListEquality(fs, arrB))
                {
                    return i;
                }
            }

            return -1;
        }


        //Записывает массив байтов в файл
        public static void WriteBytes(FileStream fs, string str)
        {

            var arrB = StrToArrByte(str); //Переводим строку вида "... ff ff ..." в массив байтов

            for (int i = 0; i < arrB.Length; i++)
            {
                fs.WriteByte(arrB[i]);
            }

        }
    }
}
