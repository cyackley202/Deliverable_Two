using System;

namespace Deliverable_Two_for_Grand_Circus
{
    class Sneaky
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What secret do you wish to conceal from prying eyes?");
            int checksum = 0;
            string message = "";
            string input = Console.ReadLine();
            string bigInput = input.ToUpper();
            foreach (char i in bigInput)
            {
                int coded = System.Convert.ToInt32(i);
                message += ((coded - 64) + "-");
                checksum += coded;
            }
            Console.WriteLine("Your encoded message is " + message);
            Console.WriteLine("Message checksum is " + checksum);
            
        }
    }
}
