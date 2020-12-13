using System;

namespace ZadaciVezba
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrvaZadaca();
            //VtoraZadaca();
            //TretaZadaca();
            //CetvrtaZadaca();
            for (; ; )
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Odberete zadaca:");
                Console.WriteLine("1. Proveri dali brojot e od 1 do 10");
                Console.WriteLine("2. Najdi maksimum od 2 broja");
                Console.WriteLine("3. Proveri dali slikata e landspace ili portrait");
                Console.WriteLine("4. Schumacher");
                Console.ResetColor();

                var zadaca = Console.ReadLine();
                switch (zadaca)
                {
                    case "1":
                        PrvaZadaca();
                        break;
                    case "2":
                        VtoraZadaca();
                        break;
                    case "3":
                        TretaZadaca();
                        break;
                    case "4":
                        CetvrtaZadaca();
                        break;
                    case "exit":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Pogresen vnes!");
                        break;
                }
            }
        }

        public static void PrvaZadaca()
        {
            Console.WriteLine("Vnesete eden broj od 1 do 10");
            var number = Convert.ToInt32(Console.ReadLine());
            if(number <= 10 && number >= 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                //Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("Valid");
                Console.ResetColor();
                

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not Valid!");
                Console.ResetColor();

            }
        }

        public static void VtoraZadaca()
        {
            Console.WriteLine("Da se napise programa koja na vlez bara 2 broja i da se ispecati pogolemiot broj");

            Console.WriteLine("Vnesete go prviot broj");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vnesete go vtoriot broj");
            var num2 = Convert.ToInt32(Console.ReadLine());

            if(num1 > num2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Maksimumot od broevite e:" + num1);
                Console.ResetColor();
            }
            else if(num1 < num2)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Maksimumot od broevite e:" + num2);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Broevite se ednakvi");
                Console.ResetColor();
            }
        }

        public static void TretaZadaca()
        {
            Console.WriteLine(@"Da se napishe programa koja na vlez bara sirina i dolzina na slika. 
Spored vnesenite informacii da se odredi dali slikata e landscape ili portrait");

            Console.WriteLine("Vnesete sirina na slikata");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vnesete dolzina na slikata");
            var height = Convert.ToInt32(Console.ReadLine());

            var isPortrait = false;
            if (height > width)
            {
                isPortrait = true;
            }

            if (isPortrait)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Slikata e portrait");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Slikata e landscape");
                Console.ResetColor();
            }
        }

        public static void CetvrtaZadaca()
        {
             Console.WriteLine(@"Da se napise programa koja na vlez ja bara brzinata na dvizenje na eden avtomobil i dozvolenata brzina
na dvizenje. Dokolku brzinata na avtomobilot e vo ramki na dozvolenata brzina da se ispeati OK, vo sprotivno da se presmeta razlikata
na dozvolenata brzina i brzinata na avtomobilot i od toa da se presmetaat kaznenite poeni. Dokolku vozacot na voziloto nadmine 100 poeni
da se ispecati 'Odzemi vozacka' a ako ne nadmine 100 poeni da se ispecati 'Kazneni poeni' i kolku kazneni poeni dobil.\n");

            Console.WriteLine("Vnesi brzina na dvizenje na voziloto");
            var speed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vnesi dozvolena brzina na dvizenje");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            if( speed <= speedLimit)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("OK");
                Console.ResetColor();
            }

            else
            {
                var speedDiff = speed - speedLimit;
                var penalty = PenaltyCategory.Below10;
                var penaltyPoints = 0;

                if (speedDiff > 10 && speedDiff <= 20) { penalty = PenaltyCategory.From10to20; }
                else if (speedDiff > 20 && speedDiff <= 50) { penalty = PenaltyCategory.From20to50; }
                else if (speedDiff > 50 && speedDiff <= 80) { penalty = PenaltyCategory.From50to80; }
                else { penalty = PenaltyCategory.Above80; }

                switch (penalty)
                {
                    case PenaltyCategory.Below10:
                        penaltyPoints = 0;
                        break;

                    case PenaltyCategory.From10to20:
                        penaltyPoints = 10;
                        break;
                    case PenaltyCategory.From20to50:
                        penaltyPoints = 25;
                        break;
                    case PenaltyCategory.From50to80:
                        penaltyPoints = 50;
                        break;
                    case PenaltyCategory.Above80:
                        penaltyPoints = 100;
                        break;
                    default:
                        break;
                }

                if (penalty == PenaltyCategory.Below10)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("OK");
                    Console.ResetColor();
                }
                if(penalty != PenaltyCategory.Below10 && penalty != PenaltyCategory.Above80)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"Kazneni poeni {penaltyPoints}");
                    Console.ResetColor();
                }
                if(penalty == PenaltyCategory.Above80)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Odzemi vozacka!");
                    Console.ResetColor();
                }
            }
            
        }
        public enum PenaltyCategory
        {
            Below10,
            From10to20,
            From20to50,
            From50to80,
            Above80
        }
    }

   
}
