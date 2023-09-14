using Tsbe.CodeCracker;
namespace oop_aufgabe8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hash= Tsbe.CodeCracker.MD5Hash.GeneratePassword("adb");
            Console.WriteLine(hash);

            Tsbe.CodeCracker.MD5Hash.CrackPassword(hash, 3);
            MD5Hash.CrackPassword(hash, 3);
        }
    }
}