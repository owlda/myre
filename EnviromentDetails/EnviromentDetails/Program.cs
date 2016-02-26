using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace EnviromentDetails
{
    class Program
    {
        static void Main(string[] args)
         {
            ShowEnviromentDateils();

            Console.ReadLine();
            
        }


        static void ShowEnviromentDateils()
            {
                Console.Title = "System computer information";
                Console.SetWindowSize(90, 40);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("------------System info--------------- ");
                Console.WriteLine("Computer's name: {0} ", Environment.MachineName);
                Console.WriteLine("OS: {0} ", Environment.OSVersion);
                Console.WriteLine("Version OS: {0} ", Environment.Version);
                Console.WriteLine("Is x64?: {0}", Environment.Is64BitOperatingSystem);
                Console.WriteLine("Number of processors: {0} ", Environment.ProcessorCount);
                Console.WriteLine("System directory: {0} ", Environment.SystemDirectory);
                Console.WriteLine("Acive user's session: {0} ", Environment.UserName);
                
               foreach (string drive in Environment.GetLogicalDrives())
                    Console.WriteLine("Drive: {0}", drive);
               Console.WriteLine("------------End system info-----------");
                
            }
        static void ChangeConsoleDesign()
        {
            
        }
    }
}
