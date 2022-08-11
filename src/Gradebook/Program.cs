using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var book = new Book("Mi book");
            
                var done = false;
                while (!done)
                {
                    Console.WriteLine("Please Enter a Grade or 'q' to quit: ");
                    var inputgrade = Console.ReadLine();

                    if (inputgrade == "q")
                    {
                        break;
                    }

                    try
                    {
                        var grade= double.Parse(inputgrade);
                        book.AddGrade(grade);   
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch(FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally //execute even if invalid
                    {
                        Console.WriteLine("**********");
                    }
                }
                
     
            
            

            var stats = book.GetStatistics();
            Console.WriteLine($"The lowest of grades is  {stats.Low}");
            Console.WriteLine($"The highest of grades is  {stats.High}");
            Console.WriteLine($"The average of grades is {stats.Average:N1}");      
            Console.WriteLine($"The letter grade is {stats.Letter}");
           
        }
    }
}
