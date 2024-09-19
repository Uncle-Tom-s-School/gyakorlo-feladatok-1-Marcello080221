namespace vegyes_feladatok
{
    internal class Program
    {
        static void feladat1()
        {
            Console.Write("Add meg az összes értékelés számát: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Add meg a pozitív értékelések számát: ");
            int p = int.Parse(Console.ReadLine());

            int százalék = n > 0 ? (int)Math.Round((double)p / n * 100) : 0;


            if (százalék >= 90)
            {
                Console.Write("Az értékelés nagyon pozitív volt");
            }
            if (százalék <= 90 & százalék >= 75)
            {
                Console.Write("Az értékelés pozitív volt");
            }
            if (százalék <= 74 & százalék >= 55)
            {
                Console.Write("Az értékelés többnyire pozitív volt");
            }
            if (százalék <= 54 & százalék >= 45)
            {
                Console.Write("Az értékelés vegyes volt");
            }
            if (százalék <= 44 & százalék >= 25)
            {
                Console.Write("Az értékelés többnyire negatív volt");
            }
            if (százalék <= 24 & százalék >= 10)
            {
                Console.Write("Az értékelés negatív volt");
            }
            if (százalék <= 9 & százalék >= 0)
            {
                Console.Write("Az értékelés nagyon negatív volt");
            }

        }




        static void feladat2() { }

        static void feladat3() { }

        static void feladat4() { }

        static void Main(string[] args)
        {
            feladat1();
            feladat2();
            feladat3();
            feladat4();
            





        }
    }
}
