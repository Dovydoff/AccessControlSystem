using AccessControlSystem;
using AccessControlSystem.Services;

public class Program
{
    public static void Main(string[] args)
    {




        //************************************


        List<Human> humans = new()
        {
            new Human{Id = 1, FirstName = "Dovydas", SecondName = "Ivanauskas"},
            new Human{Id = 2, FirstName = "Gabriele", SecondName = "Ivanauskė"},
            new Human{Id = 3, FirstName = "Tautvydas", SecondName = "Lisauskas"},
            new Human{Id = 4, FirstName = "Bronius", SecondName = "Galvanauskas"},
            new Human{Id = 5, FirstName = "Vanda", SecondName = "Kunigunda"},
            new Human{Id = 6, FirstName = "Girts", SecondName = "Gintars"}

    };
        Console.WriteLine(humans[4].FirstName);


        //************************************



        //Create File Service Object
        FileService fs = new FileService();

        //User message to enter name
        Console.WriteLine("Enter your name: ");
        //Read User input
        var userInput = Convert.ToString(Console.ReadLine());

        //List of people, that have access
        var myList = new List<string> { "Dovydas", "Tomas", "Gerda"};
        var firstPerson = myList.ElementAt(0);
        var secondPerson = myList.ElementAt(1);
        var thirdPerson = myList.ElementAt(2);

        if (userInput == firstPerson || userInput == secondPerson || userInput == thirdPerson)
        {
            //Message for people with access
            Console.WriteLine("Checking if you have an access..." +"\n");
            Console.WriteLine($"{userInput} has an access");
        }
        else 
        {
            //Message for people without access
            Console.WriteLine("Checking if you have an access..." + "\n");
            Console.WriteLine($"{userInput} You dont have an access");
            //Method to write it into file
            fs.WriteWithoutAccess();

            Console.WriteLine("...Exiting...");
            // Calling method to exit Program
            fs.ExitProgram();

        } 
        //Method to write data to file
        fs.Write();
        //Method for Main Menu
        fs.Menu();

    }
}