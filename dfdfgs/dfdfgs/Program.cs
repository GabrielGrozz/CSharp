using dfdfgs;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int yearOld = int.Parse(Console.ReadLine());
            Person pessoa1 = new Person(name, yearOld);

            string name2 = Console.ReadLine();
            int yearOld2 = int.Parse(Console.ReadLine());
            Person pessoa2 = new Person(name2, yearOld2);

            if (pessoa1.YeOld > pessoa2.YeOld)
            {
                Console.WriteLine("mais velho: " + pessoa1.Name);
            }
            else
            {
                Console.WriteLine("mais velho: " + pessoa2.Name); ;
            }


        }
    }

}
