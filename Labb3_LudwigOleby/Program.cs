using System;
using Microsoft.EntityFrameworkCore;
using Labb3_LudwigOleby.Models;
using System.Linq;

namespace Labb3_LudwigOleby
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }

            static void menu()
        {
            Console.Clear();
            using SampleContext Context = new SampleContext();

            Console.WriteLine("1. Hämta ut alla elever");
            Console.WriteLine("2. Hämta ut alla elever i en viss klass");
            Console.WriteLine("3. Lägga till ny personal");

            int userChoice = Int32.Parse(Console.ReadLine());
            switch (userChoice)

            {
                case 1:
                    displayStudents(Context);
                    Console.ReadKey();
                    break;
                case 2:
                    displayClass(Context);
                    Console.ReadKey();
                    break;
                case 3:
                    AddEmployee(Context);
                    Console.ReadKey();
                    break;
            }
            static void displayStudents(SampleContext context)
            {
                Console.WriteLine("1. Sortera på förnamn");
                Console.WriteLine("2. Sortera på efternamn");
                int userChoice = Int32.Parse(Console.ReadLine());
                switch (userChoice)
                {
                    case 1: //Förnamn
                        Console.WriteLine("Sorterar efter förnamn");
                        Console.WriteLine("1. stigande");
                        Console.WriteLine("2. Fallande");
                        int menuChoice = Int32.Parse(Console.ReadLine());

                        if (menuChoice == 1) //Stigande
                        {
                            
                            var student = from TblElever in context.TblElever
                                          orderby TblElever.FörNamn ascending
                                          select TblElever;
                            foreach (var item in student)
                            {
                                Console.WriteLine("ID: " + item.ElevId);
                                Console.WriteLine("Förnamn " + item.FörNamn);
                                Console.WriteLine("Efternamn " + item.EfterNamn);
                                Console.WriteLine("Klass " + item.Klass);
                                Console.WriteLine("Telefon " + item.Telefon);
                                Console.WriteLine("**********");
                            }
                            Console.WriteLine("Tryck på valfri tangent för att komma tillbaka till menyn!");
                            Console.ReadKey();
                            menu();
                        }
                        else if (menuChoice == 2) //Fallande
                        {
                            var student = from TblElever in context.TblElever
                                          orderby TblElever.FörNamn descending
                                          select TblElever;
                            foreach (var item in student)
                            {
                                Console.WriteLine("ID: " + item.ElevId);
                                Console.WriteLine("Förnamn " + item.FörNamn);
                                Console.WriteLine("Efternamn " + item.EfterNamn);
                                Console.WriteLine("Klass " + item.Klass);
                                Console.WriteLine("Telefon " + item.Telefon);
                                Console.WriteLine("**********");
                            }
                            Console.WriteLine("Tryck på valfri tangent för att komma tillbaka till menyn!");
                            Console.ReadKey();
                            menu();
                        }
                                             

                        break;
                    case 2: //Efternamn
                        Console.WriteLine("Sorterar efter förnamn");
                        Console.WriteLine("1. stigande");
                        Console.WriteLine("2. Fallande");
                        int menuChoice2 = Int32.Parse(Console.ReadLine());

                        if (menuChoice2 == 1) //Stigande
                        {

                            var student = from TblElever in context.TblElever
                                          orderby TblElever.EfterNamn ascending
                                          select TblElever;
                            foreach (var item in student)
                            {
                                Console.WriteLine("ID: " + item.ElevId);
                                Console.WriteLine("Förnamn " + item.FörNamn);
                                Console.WriteLine("Efternamn " + item.EfterNamn);
                                Console.WriteLine("Klass " + item.Klass);
                                Console.WriteLine("Telefon " + item.Telefon);
                                Console.WriteLine("**********");
                            }
                            Console.WriteLine("Tryck på valfri tangent för att komma tillbaka till menyn!");
                            Console.ReadKey();
                            menu();
                        }
                        else if (menuChoice2 == 2) //Fallande
                        {
                            var student = from TblElever in context.TblElever
                                          orderby TblElever.EfterNamn descending
                                          select TblElever;
                            foreach (var item in student)
                            {
                                Console.WriteLine("ID: " + item.ElevId);
                                Console.WriteLine("Förnamn " + item.FörNamn);
                                Console.WriteLine("Efternamn " + item.EfterNamn);
                                Console.WriteLine("Klass " + item.Klass);
                                Console.WriteLine("Telefon " + item.Telefon);
                                Console.WriteLine("**********");
                            }
                            Console.WriteLine("Tryck på valfri tangent för att komma tillbaka till menyn!");
                            Console.ReadKey();
                            menu();
                        }
                        break;
                }
            }

            static void displayClass(SampleContext context)
            {
                Console.WriteLine("Välj klass:");
                Console.WriteLine("1. DIV 1");
                Console.WriteLine("2. DIV 2");
                Console.WriteLine("3. DIV 3");

                int menuChoice = Int32.Parse(Console.ReadLine());

                if (menuChoice == 1) //DIV1
                {
                    var student = from TblElever in context.TblElever
                                  orderby TblElever.Klass where TblElever.Klass == "DIV01"
                                  select TblElever;
                    foreach (var item in student)
                    {
                        Console.WriteLine("ID: " + item.ElevId);
                        Console.WriteLine("Förnamn " + item.FörNamn);
                        Console.WriteLine("Efternamn " + item.EfterNamn);
                        Console.WriteLine("Klass " + item.Klass);
                        Console.WriteLine("Telefon " + item.Telefon);
                        Console.WriteLine("**********");
                    }
                    Console.WriteLine("Tryck på valfri tangent för att komma tillbaka till menyn!");
                    Console.ReadKey();
                    menu();
                }
                else if (menuChoice == 2) //DIV2
                {
                    var student = from TblElever in context.TblElever
                                  orderby TblElever.Klass
                                  where TblElever.Klass == "DIV02"
                                  select TblElever;
                    foreach (var item in student)
                    {
                        Console.WriteLine("ID: " + item.ElevId);
                        Console.WriteLine("Förnamn " + item.FörNamn);
                        Console.WriteLine("Efternamn " + item.EfterNamn);
                        Console.WriteLine("Klass " + item.Klass);
                        Console.WriteLine("Telefon " + item.Telefon);
                        Console.WriteLine("**********");
                    }
                    Console.WriteLine("Tryck på valfri tangent för att komma tillbaka till menyn!");
                    Console.ReadKey();
                    menu();
                }
                else if (menuChoice == 3) //DIV3
                {
                    var student = from TblElever in context.TblElever
                                  orderby TblElever.Klass
                                  where TblElever.Klass == "DIV03"
                                  select TblElever;
                    foreach (var item in student)
                    {
                        Console.WriteLine("ID: " + item.ElevId);
                        Console.WriteLine("Förnamn " + item.FörNamn);
                        Console.WriteLine("Efternamn " + item.EfterNamn);
                        Console.WriteLine("Klass " + item.Klass);
                        Console.WriteLine("Telefon " + item.Telefon);
                        Console.WriteLine("**********");
                    }
                    Console.WriteLine("Tryck på valfri tangent för att komma tillbaka till menyn!");
                    Console.ReadKey();
                    menu();
                }

            }

            static void AddEmployee(SampleContext context)
            {

                TblPersonal P = new TblPersonal();

                Console.WriteLine("Lägg till personal");
                Console.WriteLine("Ange förnamn:");
                P.FörNamn = Console.ReadLine();
                Console.WriteLine("Ange efternamn:");
                P.EfterNamn = Console.ReadLine();
                Console.WriteLine("Ange telefonnummer:");
                P.Telefon = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ange roll:");
                P.Roll = Console.ReadLine();
                context.TblPersonal.Add(P);
                context.SaveChanges();

                Console.WriteLine("Du har lagt till personal med följande uppgifter:");
                Console.WriteLine("Förnamn: " + P.FörNamn);
                Console.WriteLine("Efternamn " + P.EfterNamn);
                Console.WriteLine("Telefon: " + P.Telefon);
                Console.WriteLine("Roll: " + P.Roll);
                Console.WriteLine("Tryck på valfri tangent för att komma tillbaka till menyn!");
                Console.ReadKey();
                menu();

            }
        }
    }
}






