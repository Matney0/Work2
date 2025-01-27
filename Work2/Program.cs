using System;

namespace Work2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Added a user imput as an example
            int score =73;
            {
                //First if condition.
                if (score >= 89.5)
                {
                    //Presents Letter grade A if equal of more than 89.5
                    Console.WriteLine("Grade:A")
                }
                //Second condition or option
                else if (score >=79.5)
                {
                    //Presents Letter grade B if equal of more than 79.5
                    Console.WriteLine("Grade:B")
                }
                //Third condition
                else if (score >=69.5)
                {
                    //Presents Letter grade C if equal of more than 69.5
                    Console.WriteLine("Grade:C")
                }
                //Fourth condition
                else if (score >=59.5)
                {
                    //Presents Letter grade D if equal of more than 59.5
                    Console.WriteLine("Grade:D")
                }
                //Last condition doesnt need to be tested as all other options tested first
                else
                {
                    //Presents Letter grade F if all other if, and else if conditions exhuasted
                    Console.WriteLine("Grade:F")
                }
            }
               
        }
    }
}

