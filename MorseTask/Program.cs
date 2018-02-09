namespace MorseTask
{
    class Program
    {
        static void Main(string[] args)
        {
            IEncryptor encryptor = new MorseEncryptor();
            string result = encryptor.Encode("cat in hat");
            System.Console.WriteLine(result);
            System.Console.ReadKey();
        }
    }
}