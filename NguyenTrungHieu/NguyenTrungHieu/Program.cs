using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenTrungHieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student run = new Student();
            while (true)
            {
                Console.WriteLine("       Please select an option:");
                Console.WriteLine("     =======================================================");
                Console.WriteLine("       1. Insert new student....");
                Console.WriteLine("       2. Display all the student list....");
                Console.WriteLine("       3. Calculator average mark....");
                Console.WriteLine("       4. Search....");
                Console.WriteLine("       5. Exit program.");
                Console.WriteLine("     =======================================================");
                Console.Write("       Option: ");
                int key = System.Int32.Parse(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("=>>>Add new Student");
                        run.AddStud();
                        Console.WriteLine("DONE!");
                        break;
                    case 2:
                        Console.WriteLine("=>>>Display all Student list");
                        run.ShowStud(run.getListStudent());
                        break;
                    case 3:
                        Console.WriteLine("=>>>Calculator average markt");
                        break;
                    case 4:
                            Console.WriteLine("               Select an option:");
                            Console.WriteLine("               =================================");
                            Console.WriteLine("                1. By ID....");
                            Console.WriteLine("                2. By Name....");
                            Console.WriteLine("                3. By Class....");
                            Console.WriteLine("                4. Back....");
                            Console.WriteLine("              ==================================");
                            Console.Write("               Option: ");
                            int key1 = System.Int32.Parse(Console.ReadLine());
                            switch (key1)
                            {
                                case 1:
                                    Console.WriteLine(" =>>> Find by ID");
                                break;
                                case 2:
                                    Console.WriteLine(" =>>> Find by Name");
                                    break;
                                case 3:
                                    Console.WriteLine(" =>>> Find by Class");
                                    break;
                                case 4:
                                    Console.WriteLine("Back!");
                                    break;
                                default:
                                    Console.WriteLine("Input is invalid! Please try again: ");
                                    break;
                            }                        
                            break;
                    case 5:
                        Console.WriteLine("Exit!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Input is invalid! Please try again: ");
                        break;
                }
            }
        }
    }
}
