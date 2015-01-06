/* ULTRA BETA
 * LO TRANSCRIBÍ NO ME GASTE EN PENSAR
 * NI SE SI ANDA
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace ClienteAOCS.protocol
{
    public class ByteQueue
    {
        #region Properties
        const int DATA_BUFFER = 10240;

        byte[] data;
        int QueueCapacity { get; set; }
        int QueueLength { get; set; }

        #region Import {REPLACE}
        [DllImport("kernel32.dll", EntryPoint = "RtlMoveMemory")]
        static extern void CopyMemory(byte Destination, byte Source, uint Length);
        static extern void CopyMemory(byte Destination, short Source, uint Length);
        static extern void CopyMemory(byte Destination, int Source, uint Length);
        static extern void CopyMemory(byte Destination, long Source, uint Length);
        static extern void CopyMemory(byte Destination, Single Source, uint Length);
        static extern void CopyMemory(byte Destination, double Source, uint Length);
        static extern void CopyMemory(short Destination, byte Source, uint Length);
        static extern void CopyMemory(int Destination, byte Source, uint Length);
        static extern void CopyMemory(long Destination, byte Source, uint Length);
        static extern void CopyMemory(Single Destination, byte Source, uint Length);
        static extern void CopyMemory(double Destination, byte Source, uint Length);
        static extern void CopyMemory(bool Destination, byte Source, uint Length);
        #endregion

        #endregion

        #region Constructors
        public ByteQueue()
        {
            data = new byte[DATA_BUFFER];
            QueueCapacity = DATA_BUFFER;
        }

        public ByteQueue(ref ByteQueue Source)
        {
            //CopyBuffer

            if (Source.QueueLength != 0)
            {
                this.QueueCapacity = Source.QueueCapacity;
                data = new byte[QueueCapacity];

                byte[] buf = new byte[Source.QueueLength];

                Source.PeekBlock(ref buf,Source.QueueLength);

                this.QueueLength = 0;

                WriteBlock(ref buf,Source.QueueLength);
            }
            else
            {
                RemoveData(QueueLength);
            }
        }

        #endregion
        #region Methods
        public void End()
        {
            data = null;
        }

        public int RemoveData(int dataLength)
        {
            int r;

            if (dataLength > QueueLength)
                r = QueueLength;
            else
                r = dataLength;

            if (r != QueueCapacity)
                CopyMemory(data[0], data[r], (uint)(QueueLength - r));

            QueueLength -=  r;

            return r;
        }

        public int PeekBlock(ref byte[] block, int dataLength)
        {
            if (dataLength > 0)
                return ReadData(ref block, dataLength);

            return 0;
        }

        public int WriteBlock(ref byte[] value, int Length = -1)
        {
            if (Length > value.GetUpperBound(0) + 1 || Length < 0)
                Length = value.GetUpperBound(0) + 1;

            return WriteData(ref value, Length);

        }
        private int ReadData(ref byte[] buf, int dataLength)
        {
            if (dataLength <= QueueLength)
            {
                CopyMemory(buf[0], data[0], (uint)dataLength);

                return dataLength;
            }
            else
                return 0;
        }
        private int WriteData(ref byte[] buf, int dataLength)
        {
            if (QueueCapacity - QueueLength - dataLength >= 0)
            {
                CopyMemory(data[QueueLength], buf[0], (uint)(dataLength));
                QueueLength = QueueLength + dataLength;
                return dataLength;
            }
            else
                return 0;
        }

        public int WriteByte(byte value)
        {
            byte[] buf = new byte[1];

            buf[0] = value;

            return WriteData(ref buf, 1);
        }

        public int WriteShort(short value)
        {
            byte[] buf = new byte[2];

            CopyMemory(buf[0], value, 2);

            return WriteData(ref buf, 2);
        }

        public int WriteInteger(int value)
        {
            byte[] buf = new byte[4];

            CopyMemory(buf[0], value, 4);

            return WriteData(ref buf, 4);
        }

        public int WriteLong(long value)
        {
            byte[] buf = new byte[8];

            CopyMemory(buf[0], value, 8);

            return WriteData(ref buf, 8);
        }

        public int WriteSingle(Single value)
        {
            byte[] buf = new byte[4];

            CopyMemory(buf[0],value,4);

            return WriteData(ref buf,4);
        }

        public int WriteDouble(double value)
        {
            byte[] buf = new byte[8];

            CopyMemory(buf[0], value, 8);

            return WriteData(ref buf, 8);
        }

        public int WriteBoolean(bool value)
        {
            byte[] buf = new byte[4];

            if (value == true)
                buf[0] = 1;

            return WriteData(ref buf, 4);
        }

        public int WriteASCIIStringFixed(String value)
        {
            byte[] buf = new byte[value.Length];
            System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
            
            GCHandle gh = GCHandle.Alloc(encoding.GetBytes(value), GCHandleType.Pinned);

            CopyMemory(buf[0], gh.AddrOfPinnedObject().ToInt32(), (uint)(value.Length));
            gh.Free();

            return WriteData(ref buf, value.Length);
        }

        public int WriteUnicodeStringFixed(String value)
        {
            byte[] buf = new byte[value.Length];
            GCHandle gh = GCHandle.Alloc(value, GCHandleType.Pinned);

            CopyMemory(buf[0], gh.AddrOfPinnedObject().ToInt32(), (uint)(value.Length));
            gh.Free();

            return WriteData(ref buf, value.Length);
        }

        public int WriteASCIIString(String value)
        {
            byte[] buf = new byte[value.Length];
            System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();

            CopyMemory(buf[0], value.Length, 2);

            if (value.Length > 0)
            {
                GCHandle gh = GCHandle.Alloc(encoding.GetBytes(value), GCHandleType.Pinned);

                CopyMemory(buf[2], gh.AddrOfPinnedObject().ToInt32(), (uint)(value.Length));
                gh.Free();
            }

            return WriteData(ref buf, value.Length+2);
        }

        public int WriteUnicodeString(String value)
        {
            byte[] buf = new byte[value.Length];

            CopyMemory(buf[0], value.Length, 2);

            if (value.Length > 0)
            {
                GCHandle gh = GCHandle.Alloc(value, GCHandleType.Pinned);

                CopyMemory(buf[2], gh.AddrOfPinnedObject().ToInt32(), (uint)(value.Length));
                gh.Free();
            }

            return WriteData(ref buf, value.Length+2);
        }

        public byte ReadByte()
        {
            byte[] buf = new byte[1];

            RemoveData(ReadData(ref buf,1));

            return buf[0];
        }

        public short ReadShort()
        {
            byte[] buf = new byte[2];
            short r = 0;
            RemoveData(ReadData(ref buf, 2));
            
            CopyMemory(r, buf[0], 2);

            return r;
        }

        public int ReadInteger()
        {
            byte[] buf = new byte[4];
            int r = 0;

            RemoveData(ReadData(ref buf, 4));

            CopyMemory(r, buf[0], 4);

            return r;
        }

        public long ReadLong()
        {
            byte[] buf = new byte[8];
            long r = 0;

            RemoveData(ReadData(ref buf, 8));

            CopyMemory(r, buf[0], 8);

            return r;
        }

        public Single ReadSingle()
        {
            byte[] buf = new byte[4];
            Single r = 0.0f;

            RemoveData(ReadData(ref buf, 4));

            CopyMemory(r, buf[0], 4);

            return r;
        }

        public double ReadDouble()
        {
            byte[] buf = new byte[8];
            double r = 0;

            RemoveData(ReadData(ref buf, 8));

            CopyMemory(r, buf[0], 8);

            return r;
        }

        public bool ReadBoolean()
        {
            byte[] buf = new byte[4];
            bool r=false;

            RemoveData(ReadData(ref buf, 4));

            CopyMemory(r, buf[0], 4);

            return r;
        }

        /*public String ReadASCIIStringFixed(int Length)
        {
            if (Length > 0)
            {
                if (QueueLength >= Length)
                {
                    byte[] buf = new byte[Length];

                    RemoveData(ReadData(ref buf, Length));
                }
            }
        }*/
        #endregion

    }
}
