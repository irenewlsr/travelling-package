using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HW10_61421037
{
    class Program
    {
        static void Main(string[] args)
        {
            //Irene Wonlopsiri 6142103726

            DateTime datea = new DateTime(2019, 11, 8);
            DateTime dateb = new DateTime(2020, 7, 7);

            TourProgram[] p = new TourProgram[2];
            p[0] = new TourProgram("ProgramA", 20, datea, 2000);
            p[1] = new TourProgram("ProgramB", 30, dateb, 3000);

            SortedList c = new SortedList();

            int choice,i;
            int sequence = 1;

            Console.WriteLine("Menu\n1.Book Tour\n2.Cancel tour\n3.Exit");
            choice = Convert.ToInt32(Console.ReadLine());

            while(choice != 3)
            {
                if(choice == 1)
                {
                    Console.WriteLine("Enter customer name : ");
                    string cn = Console.ReadLine();
                    Console.WriteLine("Enter customer phone number : ");
                    string pn = Console.ReadLine();
                    for(i = 0;i<2;i++)
                    {
                        Console.WriteLine("Program : " + (i + 1) + "." + p[i].ProgramName + " Price " + p[i].Price + " bht  Date " + p[i].TourDate);
                    }
                    Console.WriteLine("Chose program : ");
                    int chosep = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter seat : ");
                    int cs = Convert.ToInt32(Console.ReadLine());

                    c.Add(sequence, new customer(cn, pn, cs, chosep, sequence));

                    if(cs <= p[chosep-1].AvaliSeat)
                    {
                        int booked = ((customer)c[sequence]).booktour(cs, p[chosep - 1]);

                        if (booked != 0)
                        {
                            Console.WriteLine("You have to pay " + booked);
                        }

                        Console.WriteLine("Service no. : " + sequence);
                    }

                    else
                    {
                        Console.WriteLine("You cant book this tour.");
                    }
                    sequence++;

                }

                else if (choice == 2)
                {
                    Console.WriteLine("Enter service number : ");
                    int serno = Convert.ToInt32(Console.ReadLine());
                    int cus = ((customer)c[serno]).ProgramChosen;
                    ((customer)c[serno]).canceltour(DateTime.Now, p[cus - 1]);
                }

            Console.WriteLine("\nMenu\n1.Book Tour\n2.Cancel tour\n3.Exit");
            choice = Convert.ToInt32(Console.ReadLine());

            }

        }
    }
}
