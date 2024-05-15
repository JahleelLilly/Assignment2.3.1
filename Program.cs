using System.IO;
using System.Text;


namespace Assignment2._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteFile();
            ReadFile();
        }

        static void WriteFile()
        {

            Console.WriteLine("Enter your name:");
            string YourName = Console.ReadLine();
            Console.WriteLine("Enter your city:");
            string YourCity = Console.ReadLine();
            Console.WriteLine("Enter your state:");
            string YourState = Console.ReadLine();



            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("C:\\MSSA\\Sample.txt");
                //Write a line of text
                sw.WriteLine("My Name" + YourName);
                //Write a second line of text
                sw.WriteLine("My Age" + YourCity);
                //Close the file
                sw.WriteLine("My Address" + YourState);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }


            finally
            {
                Console.WriteLine("File save loading. . .");
                Console.WriteLine("File save completed");
                Console.WriteLine();
                Console.ReadLine();
            }


            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("C:\\MSSA\\Sample.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}




