using System.Collections;
namespace passwordGenerator // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many characters would you like in your password?");
            int characters = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many special characters would you like in your password?");
            int specialCharacters = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many numbers would you like in your password?");
            int numbers = Convert.ToInt32(Console.ReadLine());

            Random randomSelection = new Random();

            ArrayList password = new ArrayList();
            char c;
            // for each character required do the following
            for (int i = 0; i < characters; i++)
            {
                // generate a random character a-z (lowercase)
                c = (char)(randomSelection.Next(26) + 97);

                // if a random number is even AKA divisible by 2, convert character to uppercase
                if (randomSelection.Next(100) % 2 == 0)
                {
                    password.Add(char.ToUpper(c));
                }
                else
                {
                    // otherwise leave it as lowercase
                    password.Add(c);
                }

            }

            // for each special character required do the following
            for (int i = 0; i < specialCharacters; i++)
            {
                // generate a random special character
                c = (char)(randomSelection.Next(6) + 33);
                // add to password
                password.Add(c);

            }
            // for each number required do the following
            for (int i = 0; i < numbers; i++)
            {
                // generate a random number from 0-9
                c = (char)(randomSelection.Next(10) + 48);
                // add to password
                password.Add(c);

            }

          
            int m =password.Count;
            ArrayList passwordShuffled = new ArrayList();
            int n = randomSelection.Next(0) + m;
            int prev = randomSelection.Next(0) + m;
            char j = (char)password[0];
            passwordShuffled.Insert(j,n);
            // print out the password to the user
            foreach (char i in password){
                 n = randomSelection.Next(0) + m;
                prev = randomSelection.Next(0) + m;
                if(prev == n){
                   n = randomSelection.Next(0) + m; 
                }else{
                passwordShuffled.Insert(i,n);
                }

            }

        foreach (char i in passwordShuffled){
                Console.WriteLine(i);
            }

        }
    }
}