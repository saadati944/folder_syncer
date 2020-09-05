using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace folder_sync
{
    public class packet
    {

        public short mode;
        public int seriesID;
        public short serieIndex;
        public short contentLength;
        public int totalLength;
        public byte[] content = new byte[4082];


        public packet(byte[] array, int offset)
        {
            mode = BitConverter.ToInt16(array, offset);
            seriesID = BitConverter.ToInt32(array, 2);
            serieIndex = BitConverter.ToInt16(array, 6);
            contentLength = BitConverter.ToInt16(array, 8);
            totalLength = BitConverter.ToInt32(array, 10);
            writeOnArray(array, content, 14, 0, 4082);
        }
        public packet(short mode, int seriesID, short serieIndex, short contentLength, int totalLength, byte[] content, int offset = 0)
        {
            this.mode = mode;
            this.seriesID = seriesID;
            this.serieIndex = serieIndex;
            this.contentLength = contentLength;
            this.totalLength = totalLength;
            writeOnArray(content, this.content, offset, 0, contentLength);
        }
        public byte[] getBytes()
        {
            byte[] v = new byte[4096];
            BitConverter.GetBytes(mode).CopyTo(v, 0);
            BitConverter.GetBytes(seriesID).CopyTo(v, 2);
            BitConverter.GetBytes(serieIndex).CopyTo(v, 6);
            BitConverter.GetBytes(contentLength).CopyTo(v, 8);
            BitConverter.GetBytes(totalLength).CopyTo(v, 10);
            writeOnArray(content, v, 0, 14, 4082);
            return v;
        }

        void writeOnArray(byte[] readfrom, byte[] writeto, int readfromind, int writefromind, int count)
        {
            for (int i = 0; i < count; i++)
                writeto[i + writefromind] = readfrom[i + readfromind];
        }

    }
}
