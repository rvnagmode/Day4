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


            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("deligates");
            Calculation cal = new Calculation();
            deladd add = new deladd(cal.Add);
            Console.WriteLine(add.Invoke(10,20));

            delsub sub = new delsub(cal.Sub);
            Console.WriteLine(sub.Invoke(20, 10));

            delmulti multi = new delmulti(cal.Multi);
            Console.WriteLine(multi.Invoke(10, 20));

            deldiv div = new deldiv(cal.Div);
            Console.WriteLine(div.Invoke(20, 10));

            delstr str = new delstr(cal.Name);
            Console.WriteLine(str.Invoke("calculator"));
        }
    }
}
