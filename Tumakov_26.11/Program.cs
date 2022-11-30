namespace Tumakov10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 10.1");
            ACipher aCipher = new ACipher();
            int k = 1;
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();
            string ciphertext = aCipher.Encoding(text, k);
            Console.WriteLine($"Зашифрованный текст в классе ACipher: {ciphertext}");

            BCipher bCipher = new BCipher();
            ciphertext = bCipher.Encoding(text, k);
            string decryptedtext = bCipher.Decoding(ciphertext, k);
            Console.WriteLine($"Этот же текст, зашифрованный в классе BCipher: {ciphertext}");
            Console.WriteLine($"Расшифрованный текст: {decryptedtext}");

            Console.WriteLine("Домашнее упражнение 10.1");
            Point point = new Point(6, 1, "белый", Figure.condition.invisible);
            Rectangle rectangle = new Rectangle(9, 3, -5, 0, "синий", Figure.condition.visible);
            Circle circle = new Circle(7, 20, 6, "желтый", Figure.condition.invisible);
            ((ISquare)circle).Square();
            ((ISquare)rectangle).Square();

        }
    }
}
