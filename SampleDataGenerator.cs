using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psiz_p_zd4
{
    public class SampleDataGenerator
    {
        public static void GenerateTest1(string fileNameOne, string fileNameTwo)
        {
            using (BinaryWriter binWriterOne = new BinaryWriter(File.Open(fileNameOne, FileMode.Create), Encoding.UTF8, false))
            using (BinaryWriter binWriterTwo = new BinaryWriter(File.Open(fileNameTwo, FileMode.Create), Encoding.UTF8, false))
            {
                for (int i = 0; i < 100; i++)
                {
                    binWriterOne.Write((byte) 0x55);
                    binWriterTwo.Write((byte) 0x55);
                }
            }
        }

        public static void GenerateTest2(string fileNameOne, string fileNameTwo)
        {
            using (BinaryWriter binWriterOne = new BinaryWriter(File.Open(fileNameOne, FileMode.Create), Encoding.UTF8, false))
            using (BinaryWriter binWriterTwo = new BinaryWriter(File.Open(fileNameTwo, FileMode.Create), Encoding.UTF8, false))
            {
                for (int i = 0; i < 100; i++)
                {
                    binWriterOne.Write((byte)0x55);

                    if (i == 98)
                    {
                        binWriterTwo.Write((byte)0x55);
                    } else if (i == 99)
                    {
                        binWriterTwo.Write((byte)0xAA);
                    }
                    else
                    {
                        binWriterTwo.Write((byte)0x55);
                    }
                }
            }
        }

        public static void GenerateTest3(string fileNameOne, string fileNameTwo)
        {
            using (BinaryWriter binWriterOne = new BinaryWriter(File.Open(fileNameOne, FileMode.Create), Encoding.UTF8, false))
            using (BinaryWriter binWriterTwo = new BinaryWriter(File.Open(fileNameTwo, FileMode.Create), Encoding.UTF8, false))
            {
                for (int i = 0; i < 419430400; i++)
                {
                    binWriterOne.Write((byte)0x55);
                    binWriterTwo.Write((byte)0x50);
                }
            }
        }
    }
}
