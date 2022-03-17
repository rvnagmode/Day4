using Day4;
namespace Day4
{
    public class Testing
    {
        static void Main(string[] args)
        {
            Console.WriteLine("area of circle");
            Circle c = new Circle(12);
            c.CalculateArea();
            Console.WriteLine(c);
            Console.WriteLine("printing area using interface : " + c.print());

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("area of rectangle");
            Rectangle r = new Rectangle(10,20);
            r.CalculateArea();
            Console.WriteLine(r);


            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("exception");
            User u = new User();
            try
            {
                Console.WriteLine("enterd name is = " + u.Acceptname(null));
            }
            catch(NameException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
