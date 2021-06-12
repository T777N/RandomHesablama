using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace lesson_2___task_1___strings
{
    class Program
    {
        static int count;
        static int Get_randomNumber1()
        {
            Random random1 = new Random();
            int randomNumber1 = random1.Next(1, 16);
            return randomNumber1;
        }
        static int Get_randomNumber2()
        {
            Random random2 = new Random();
            int randomNumber2 = random2.Next(1, 14);
            return randomNumber2;
        }
        static int Get_randomOperation()
        {
            Random random = new Random();
            int randomOperation = random.Next(1, 4);
            return randomOperation;
        }
        static void True_fuction()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"     




                                                   True     ");
                Thread.Sleep(500);
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
        }
        static void False_fuction()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@"     




                                                   False     ");
                Thread.Sleep(500);
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
        }
        static void Five()
        {
            Console.Clear();
            Console.WriteLine(@"

                     55555555                     55                     55555555           
                     55                          55                      55 
                     55555555                   55                       55555555  
                           55                  55                              55  
                           55                 55                               55      
                           55                55                                55  
                     55555555               55                           55555555   




                         BBBB  RRRR  AAAA  V  V  OOOO
                         B  B  R  R  A  A  V  V  O  O
                         BBB   RRR   AAAA  V  V  O  O
                         B  B  R  R  A  A  V  V  O  O
                         BBBB  R  R  A  A   VV   OOOO




            ");
        }
        static void Four()
        {
            Console.Clear();
            Console.WriteLine(@"

                     55555555                     54                    4444                                
                     55                          54                    44 44 
                     55555555                   54                    44  44 
                           55                  54                    44   44       
                           55                 54                    444444444               
                           55                54                           44       
                     55555555               54                            44  




            ");
        }
        static void Three()
        {
            Console.Clear();
            Console.WriteLine(@"

                     55555555                     53                  3333333                                                    
                     55                          53                        33
                     55555555                   53                         33   
                           55                  53                     3333333        
                           55                 53                           33      
                           55                53                            33    
                     55555555               53                        3333333    




            ");
        }
        static void Two()
        {
            Console.Clear();
            Console.WriteLine(@"

                     55555555                     52                 222222                                                     
                     55                          52                 22    22  
                     55555555                   52                       22    
                           55                  52                      22     
                           55                 52                      22         
                           55                52                      22        
                     55555555               52                      22222222      




            ");
        }
        static void One()
        {
            Console.Clear();
            Console.WriteLine(@"

                     55555555                     51                111111                                                               
                     55                          51                11   11     
                     55555555                   51                      11    
                           55                  51                       11    
                           55                 51                        11        
                           55                51                         11       
                     55555555               51                     11111111111      




            ");
        }
        static void Zero()
        {
            Console.Clear();
            Console.WriteLine(@"

                     55555555                     50             00000000                                                                                  
                     55                          50              00    00  
                     55555555                   50               00    00      
                           55                  50                00    00      
                           55                 50                 00    00          
                           55                50                  00    00          
                     55555555               50                   00000000       




            ");
        }
        static void Start()
        {
            int sum = 0;
            int firstNumber = Get_randomNumber1();
            int secondNumber = Get_randomNumber2();
            int randomOperation = Get_randomOperation();
            string Operation = " ";
            if (randomOperation == 1)
            {
                sum = firstNumber + secondNumber;
                Operation = "+";
            }
            else if (randomOperation == 2)
            {
                sum = firstNumber - secondNumber;
                Operation = "-";
            }
            else if (randomOperation == 3)
            {
                sum = firstNumber * secondNumber;
                Operation = "*";
            }
            else if (randomOperation == 4)
            {
                sum = firstNumber / secondNumber;
                Operation = "/";
            }
            Console.WriteLine(@"          Fint and Enter the ansver          ");
            Console.WriteLine();

            Console.Write("     " + firstNumber + " " + Operation + " " + secondNumber + " = ");
            //dynamic rasuelt =int.Parse(Console.ReadLine());
            //string rasuelt = string.Parse(Console.ReadLine());
            bool rasuelt = int.TryParse(Console.ReadLine(), out int result);


            if (result == sum)
            {
                True_fuction();
                ++count;
            }
            else if (result != sum)
            {
                False_fuction();
            }
            else
            {
                False_fuction();
            }




        }
        static void Numbers()
        {
            if (count == 5)
            {
                Five();
            }
            else if (count == 4)
            {
                Four();
            }
            else if (count == 3)
            {
                Three();
            }
            else if (count == 2)
            {
                Two();
            }
            else if (count == 1)
            {
                One();
            }
            else if (count == 0)
            {
                Zero();
            }
        }

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            bool Y = true;
            while (Y)
            {
                Console.Clear();
                for (int i = 0; i < 5; i++)
                {

                    Start();

                }
                Numbers();

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" Retry [1]           Exit [2]   ");
                Console.Write(" Enter : ");
                //int check = int.Parse(Console.ReadLine());
                bool rasuelt2 = int.TryParse(Console.ReadLine(), out int result2);
                if (result2 == 1)
                {
                    count = 0;
                    Y = true;
                }
                else if (result2 == 2)
                {
                    Y = false;
                    break;
                }
                else
                {
                    False_fuction();
                    Y = false;
                    break;
                }
            }
        }
    }
}
