
namespace AccessControlSystem.Services
{
    public class FileService
    {
        string filePath = "C:\\Users\\dell\\Desktop\\Code Academy\\C#\\16-20 Paskaita\\Praejimo Kontroles Sistema\\Test.txt";
        public void Menu()
        {
            bool isAlive = true;
            while (isAlive)
            {
                Console.WriteLine("1. Press to Read Data from file");
                Console.WriteLine("9. Exit from program");
                var input = GetSelection();
                switch (input)
                {
                    case 1:
                        Read();
                        Console.WriteLine("\n " + "----------------------------END OF LIST-------------");
                        break;
                    case 9:
                        Console.WriteLine("...Exiting...");
                        isAlive = false;
                        ExitProgram();
                        break;
                }
            }
        }
        public void Write()
        {
            Console.WriteLine("Enter your Name again to register that you have Passed to the Office");
            var userInput = Console.ReadLine();
            DateTime now = DateTime.Now;
            if (!File.Exists(filePath))
            {
            }
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(" " + userInput + " Time " + now.ToString() +" Has an access");
                sw.Close();
            }
        }
        public void WriteWithoutAccess()
        {
            Console.WriteLine("Enter your Name again to register your visit");
            var userInput = Console.ReadLine();
            DateTime now = DateTime.Now;
            if (!File.Exists(filePath))
            {
            }
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(" " + userInput + " Time " + now.ToString() + " Without Access");
                sw.Close();
            }
        }
        public int GetSelection()
        {
            bool isSuccess = Int32.TryParse(Console.ReadLine(), out int result);
            if (isSuccess)
            {
                return result;
            }
            Console.WriteLine("Try enter number from the list");
            return 0;
        }
        private void Read()
        {
            string userInput;
            using (StreamReader sr = File.OpenText(filePath))
            {
                while ((userInput = sr.ReadLine()) != null)
                {
                    Console.WriteLine(userInput);
                }
                sr.Close();
            }
        }
        public void ExitProgram()
        {
            System.Environment.Exit(1);
        }
    }
}
