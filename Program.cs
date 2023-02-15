using System;

namespace Menue
{

    class program
    {
    static void Main(string[] args)
        {

            bool finished = false;
            
            do
            {
                
                //MAKING MAIN OPTION MENUE

                System.Console.WriteLine("Welcome To Triangle Palooza!");
                System.Console.WriteLine("");
                System.Console.WriteLine("Please choose desired activity!");
                System.Console.WriteLine("");
                System.Console.WriteLine("1. Create Full Triangle");
                System.Console.WriteLine("2. Randomly Generate Partial Triangle");
                System.Console.WriteLine("3. Exit Application");
                System.Console.WriteLine("");
                System.Console.WriteLine("Choose:");

                //Read Option
                int option = int.Parse(Console.ReadLine());



                //Get if valid input 

 

                
                //MENUE SWITCH 

                switch(option)
                {
                    case 1:
                    System.Console.WriteLine("How many rows would you like?");
                    int Rows = int.Parse(Console.ReadLine());

                    string Pyramid = string.Empty;
                    int n = Rows;
                    for (int i = 0; i <= n; i++)
                    {
                        for (int j = i; j < n; j++)
                        {
                            Pyramid += " ";
                        }
                        for (int k = 0; k < 2 * i - 1; k++)
                        {
                            Pyramid += "*";
                        }
                        Pyramid += Environment.NewLine;       
                    }
                    System.Console.WriteLine(Pyramid);
                    
                    break;

                    case 2:
                    int val = new Random().Next(2,30);  
                    int i2, j2, k2 ;  
                    for (i2 = 1; i2 <= val; i2++)  
                    {  
                        for (j2 = 1; j2 <= val-i2; j2++)  
                        {  
                            Console.Write(" ");  
                        }  
                        for (k2 = 1; k2 <= i2; k2++)  
                        {  
                            Console.Write("*");  
                        }  
                        Console.WriteLine("");  
                    }  
                    Console.ReadLine();
                    
                    break;


                    case 3:

                    System.Console.WriteLine("To Exit Press Any Key.");
                    Console.ReadKey();
                    Console.Clear();

                    break;
                }








                //OPTION TO RESTART OR END

                System.Console.WriteLine("Would you like to restart? (y/n)");
                char c = char.Parse(Console.ReadLine());

                if (c == 'n')
                {
                    finished = false;
                }
                else if (c == 'y')
                {
                    finished = true;
                }
                Console.Clear();

            }while (finished);








        }
    }
}
