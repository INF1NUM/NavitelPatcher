using System.Collections.Generic;

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
    }

    struct NavitelCOMSpeed
    {
        public static readonly byte[] speed2400 = { 0x96, 0x3E, 0xA0, 0xE3 };
        public static readonly byte[] speed4800 = { 0x4B, 0x3D, 0xA0, 0xE3 };
        public static readonly byte[] speed9600 = { 0x96, 0x3D, 0xA0, 0xE3 };
        public static readonly byte[] speed19200 = { 0x4B, 0x3C, 0xA0, 0xE3 };
        public static readonly byte[] speed38400 = { 0x96, 0x3C, 0xA0, 0xE3 };
        public static readonly byte[] speed57600 = { 0xE1, 0x3C, 0xA0, 0xE3 };
    }
}
