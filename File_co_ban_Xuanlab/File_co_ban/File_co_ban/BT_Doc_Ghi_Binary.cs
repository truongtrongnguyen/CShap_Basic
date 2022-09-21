using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace File_co_ban
{
    internal class BT_Doc_Ghi_Binary
    {
        public void BT()
        {
            BinaryWriter bw;
            BinaryReader br;

            int i = 25;
            double d = 3.14157;
            bool b = true;
            string s = "I am happy";

            //writing into the file
            try
            {
               
                FileStream sw = new FileStream(@"C:\temp\MyTest.txt", FileMode.Create);
                bw = new BinaryWriter(sw);
                bw.Write(i);
                bw.Write(d);
                bw.Write(b);
                bw.Write(s);

                
                bw.Flush();
                bw.Close();
                sw.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot write to file.");
                return;
            }


            //reading from the file
            try
            {
                br = new BinaryReader(new FileStream(@"C:\temp\MyTest.txt", FileMode.Open));
                
                i = br.ReadInt32();
                Console.WriteLine("Integer data: {0}", i);
                d = br.ReadDouble();
                Console.WriteLine("Double data: {0}", d);
                b = br.ReadBoolean();
                Console.WriteLine("Boolean data: {0}", b);
                s = br.ReadString();
                Console.WriteLine("String data: {0}", s);

                br.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot read from file.");
                return;
            }

        }
               
    }
}
