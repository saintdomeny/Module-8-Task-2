namespace Module_8_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь:");
            string path = Console.ReadLine();
            DirectoryInfo di = new DirectoryInfo(path);
            if (di.Exists)
            {
                Console.WriteLine("Размер: " + DirectoryExtension.CountSize(di) + " байт");
            }
            else
            {
                Console.WriteLine("Папки не существует");
            }
        }
    }
}