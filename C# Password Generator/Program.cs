//Lance Rogan
//This is a simple program in C# to generate a random password for a user
//Note: This program / comments are very similar to my java version of the password generator
using System.Collections;
namespace passwordGenerator
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




            //initialize variables m to be size of arraylist, n=0
            int m = password.Count;
            int n = 0;
            //inititalize boolean array to keep track of which index's are full
            Boolean[] track = new Boolean[password.Count];
            Boolean validity = false;
            int count = 0; //counter for index
            //new array list with the shuffled password
            ArrayList passwordShuffled = new ArrayList();

            //loop trhough each char in password and shuffle it and add it into passwordShuffled
            foreach (char i in password)
            {
                //generates number between 0 and array list size
                n = randomSelection.Next(0, m);
                //reset validity to false
                validity = false;
                //we continue to generate a new number until we add it in a open slot
                while (!validity)
                {
                    //if the boolean array at index n is false, aka not taken, we add the element at this position and set to true
                    if (track[n] == false)
                    {
                        //set index to true noting we added here already
                        track[n] = true;
                        //insert at counter index the password element at index n
                        passwordShuffled.Insert(count, password[n]);
                        //increment counter, setr validity to true, and break
                        validity = true;
                        count++;
                        break;

                        //otherwise, we generate another number and repeatedly check again
                    }
                    else
                    {
                        n = randomSelection.Next(0, m);
                    }



                }
            }
            //some code to test the shuffling works
            // Console.WriteLine("Password before shuffle: ");
            //             foreach (char i in password)
            //             {
            //                 Console.Write(i);
            //             }
            // Console.WriteLine("Password after shuffle: ");

            // prints out shuffled password to user
            foreach (char i in passwordShuffled)
            {
                Console.Write(i);
            }

        }
    }
}