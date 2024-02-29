using System;
using System.IO;

namespace CSharpRevisionOOPS
{
    public class ExceptionFile
    {
        

        public static void Main(string[] args)
        {
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(@"D:\Data.txt");
                Console.WriteLine(reader.ReadToEnd());
                //reader.Close();
            }
            catch (FileNotFoundException ef)
            {
                Console.WriteLine(ef.Message);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally{
                reader.Close();
            }
        }
    }
}
