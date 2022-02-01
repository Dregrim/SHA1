using System.Text;
using XSystem.Security.Cryptography;
class SHA1
{
    static void Main(string[] args)
    {
        Console.Write("Enter text (print \"exit\" to exit): ");
        string text = Console.ReadLine();
        while (text != "exit")
        {
            getsha1(text);
            Console.Write("\nEnter text (print \"exit\" to exit): ");
            text = Console.ReadLine();
        }
    }

    public static string getsha1 (string text)
    {
        SHA1CryptoServiceProvider sh = new SHA1CryptoServiceProvider();
        sh.ComputeHash(System.Text.UTF8Encoding.UTF8.GetBytes(text));
        byte[] re = sh.Hash;
        StringBuilder ab = new StringBuilder();
        foreach (byte b in re)
        {
                Console.Write(b.ToString("x2"));
        }
        return "";
    }
}