using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavitelPatcher
{
    class NavitelCOMPort
    {
        NavitelCOMPort(int portNumber, byte[] signature)
        {
            this.PortNumber = portNumber;
            this.Signature = signature;
        }
        public static readonly byte[] com1 = { 0xD0, 0x4D, 0xE2, 0x01, 0x60, 0xA0, 0xE1, 0x00, 0x40, 0xA0, 0xE1, 0x2C };
        public static readonly byte[] com2 = { 0xD0, 0x4D, 0xE2, 0x02, 0x60, 0xA0, 0xE3, 0x00, 0x40, 0xA0, 0xE1, 0x2C };
        public static readonly byte[] com3 = { 0xD0, 0x4D, 0xE2, 0x03, 0x60, 0xA0, 0xE3, 0x00, 0x40, 0xA0, 0xE1, 0x2C };
        public static readonly byte[] com4 = { 0xD0, 0x4D, 0xE2, 0x04, 0x60, 0xA0, 0xE3, 0x00, 0x40, 0xA0, 0xE1, 0x2C };
        public static readonly byte[] com5 = { 0xD0, 0x4D, 0xE2, 0x05, 0x60, 0xA0, 0xE3, 0x00, 0x40, 0xA0, 0xE1, 0x2C };
        public static readonly byte[] com6 = { 0xD0, 0x4D, 0xE2, 0x06, 0x60, 0xA0, 0xE3, 0x00, 0x40, 0xA0, 0xE1, 0x2C };
        public static readonly byte[] com7 = { 0xD0, 0x4D, 0xE2, 0x07, 0x60, 0xA0, 0xE3, 0x00, 0x40, 0xA0, 0xE1, 0x2C };
        public static readonly byte[] com8 = { 0xD0, 0x4D, 0xE2, 0x08, 0x60, 0xA0, 0xE3, 0x00, 0x40, 0xA0, 0xE1, 0x2C };
        public static readonly byte[] com9 = { 0xD0, 0x4D, 0xE2, 0x09, 0x60, 0xA0, 0xE3, 0x00, 0x40, 0xA0, 0xE1, 0x2C };

        public int PortNumber { get; private set; }
        public int OffsetInFile { get; set; }
        public byte[] Signature { get; private set; }

        public static List<NavitelCOMPort> GetPortList()
        {
            List<NavitelCOMPort> portList = new List<NavitelCOMPort>();
            portList.Add(new NavitelCOMPort(1, com1));
            portList.Add(new NavitelCOMPort(2, com2));
            portList.Add(new NavitelCOMPort(3, com3));
            portList.Add(new NavitelCOMPort(4, com4));
            portList.Add(new NavitelCOMPort(5, com5));
            portList.Add(new NavitelCOMPort(6, com6));
            portList.Add(new NavitelCOMPort(7, com7));
            portList.Add(new NavitelCOMPort(8, com8));
            portList.Add(new NavitelCOMPort(9, com9));
            return portList;
        }   

        //public static string COM1 { get { return "D0 4D E2 01 60 A0 E1 00 40 A0 E1 2C"; } }
        //public static string COM2 { get { return "D0 4D E2 02 60 A0 E3 00 40 A0 E1 2C"; } }
        //public static string COM3 { get { return "D0 4D E2 03 60 A0 E3 00 40 A0 E1 2C"; } }
        //public static string COM4 { get { return "D0 4D E2 04 60 A0 E3 00 40 A0 E1 2C"; } }
        //public static string COM5 { get { return "D0 4D E2 05 60 A0 E3 00 40 A0 E1 2C"; } }
        //public static string COM6 { get { return "D0 4D E2 06 60 A0 E3 00 40 A0 E1 2C"; } }
        //public static string COM7 { get { return "D0 4D E2 07 60 A0 E3 00 40 A0 E1 2C"; } }
        //public static string COM8 { get { return "D0 4D E2 08 60 A0 E3 00 40 A0 E1 2C"; } }
        //public static string COM9 { get { return "D0 4D E2 09 60 A0 E3 00 40 A0 E1 2C"; } }
        //public static byte[] COM1Byte { get { return ConvertHexToByteArray(COM1); } }
        //public static byte[] COM2Byte { get { return ConvertHexToByteArray(COM2); } }
        //public static byte[] COM3Byte { get { return ConvertHexToByteArray(COM3); } }
        //public static byte[] COM4Byte { get { return ConvertHexToByteArray(COM4); } }
        //public static byte[] COM5Byte { get { return ConvertHexToByteArray(COM5); } }
        //public static byte[] COM6Byte { get { return ConvertHexToByteArray(COM6); } }
        //public static byte[] COM7Byte { get { return ConvertHexToByteArray(COM7); } }
        //public static byte[] COM8Byte { get { return ConvertHexToByteArray(COM8); } }
        //public static byte[] COM9Byte { get { return ConvertHexToByteArray(COM9); } }
        //// convert hex values of file back to bytes
        //public static byte[] ConvertHexToByteArray(string hexString)
        //{
        //    byte[] byteArray = new byte[hexString.Length / 2];

        //    for (int index = 0; index < byteArray.Length; index++)
        //    {
        //        string byteValue = hexString.Substring(index * 2, 2);
        //        byteArray[index] = byte.Parse(byteValue, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
        //    }

        //    return byteArray;
        //}
    }

    struct NavitelCOMSpeed
    {
        public static readonly byte[] speed2400 = { 0x96, 0x3E, 0xA0, 0xE3 };
        public static readonly byte[] speed4800 = { 0x4B, 0x3D, 0xA0, 0xE3 };
        public static readonly byte[] speed9600 = { 0x96, 0x3D, 0xA0, 0xE3 };
        public static readonly byte[] speed19200 = { 0x4B, 0x3C, 0xA0, 0xE3 };
        public static readonly byte[] speed38400 = { 0x96, 0x3C, 0xA0, 0xE3 };
        public static readonly byte[] speed57600 = { 0xE1, 0x3C, 0xA0, 0xE3 };

        //public static string Speed2400 { get { return "96 3E A0 E3"; } }
        //public static string Speed4800 { get { return "4B 3D A0 E3"; } }
        //public static string Speed9600 { get { return "96 3D A0 E3"; } }
        //public static string Speed19200 { get { return "4B 3C A0 E3"; } }
        //public static string Speed38400 { get { return "96 3C A0 E3"; } }
        //public static string Speed57600 { get { return "E1 3C A0 E3"; } }
    }
}
