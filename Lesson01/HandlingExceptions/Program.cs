using System;

namespace HandlingExceptions
{
    class Program
    {
        private static void ExceptionTest(){
            StreamReader sr = null;
            try {
                sr = File.OpenText(@"/Users/steven/Projects/CSharpFundamentals");
                Console.WriteLine(sr.ReadToEnd());
            } catch (FileNotFoundException fnfe) {
                Console.WriteLine(fnfe.Message);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            ExceptionTest();
        }
    }
}
