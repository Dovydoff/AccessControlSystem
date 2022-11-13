using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessControlSystem.Services
{
    public class PassThroughControllerService : HumanRepository
    {

        HumanRepository humanList = new HumanRepository();
        


        
/*        public void HasAccess()
        {
            Random random = new Random();
            int hiddenNumber = random.Next(0, 1000);
            bool hasAccess = false;
            int guessCounter = 0;

            while (hasAccess == false)
            {
                guessCounter++;
                Console.Clear();
                Console.WriteLine("You don`t have an access", guessCounter);
            }
            int responseValue = int.Parse(Console.ReadLine());

            if (responseValue == hiddenNumber)
            {
                Console.WriteLine("You have an access", hiddenNumber, guessCounter);
                hasAccess = true;
            }*/
/*        }*/
            
    }
}

