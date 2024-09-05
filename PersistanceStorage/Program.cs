using Persistence;

namespace Executive
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            StoreBase textFileStore = new TextFileStore();

            textFileStore.InsertData("Student1", 80);
            textFileStore.InsertData("Student2", 100);
            Console.WriteLine("Data inserted");
            
        }
    }
}
