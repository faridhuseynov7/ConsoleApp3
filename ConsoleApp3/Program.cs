//using System;
//using System.Collections.Generic;
//namespace ConsoleApp3
//{
//    internal class Program
//    {

//            public class book {
//            public string author { get; set;  }
//            public string isbn { get; set; }
//            public string title { get; set; }

//            private bool iisAvailable;
//            public book(string title,string author,string isbn)
//            {
//                this.title = title;
//                this.author = author;
//                this.isbn = isbn;
//                this.iisAvailable = true;
//            }
//            public bool isAvailable
//            {
//                get { return iisAvailable; }
//            }
//            public void borrowbook()
//            {
//                if (isAvailable)
//                {
//                    iisAvailable = false;
//                    Console.WriteLine($"'{title}' kitabi goturdu");
//                }
//                else
//                {
//                    Console.WriteLine($"Kitab basqasi terefinden goturulub");
//                }
//            }
//            public void ReturnBook()
//            {
//                if (!isAvailable)
//                {
//                    iisAvailable = true;
//                    Console.WriteLine($"'{title}' kitabi kitabxanaya qaytardi");
//                }
//                else
//                {
//                    Console.WriteLine($"'{title}' kitabi kitabxanadadir");
//                }
//            }
//            public void Displayinfo()
//            {
//                string status = isAvailable ? "Movcuddur" : "Goturulub";
//                Console.WriteLine($"[{isbn}] \"{title}\" - {author} status: {status}");
//            }
//        }
//        class program
//        {
//            static void Main(string[] args)
//            {
//                List<book> library = new List<book>
//                {
//                    new book("1999","Nizami Gencevi","ISBN-1"),
//                    new book("2000","Mesheti Gencevi","ISBN-2"),
//                    new book("2006","Sah Ismayil Xwtai","ISBN-3"),
//                    new book("1979","Antonio De Saint","ISBN-4"),
//                    new book("1989","Uzeyir Hacibeyli","ISBN-5")
//                };
//                Console.WriteLine("Kitablar");
//                foreach(var book in library)
//                {
//                    book.Displayinfo();
//                }
//                Console.WriteLine("\n Borrow ");
//                library[0].borrowbook();
//                library[2].borrowbook();
//                Console.WriteLine("\n Son veziyyet");
//                foreach (var book in library)
//                {
//                    book.Displayinfo();
//                }
//            }
//        }
//    }
//}


//using System;
//using System.Collections.Generic;
//namespace ConsoleApp3
//{
//    internal class Program
//    {
//        interface IShape
//        {
//            double calculatearea();
//            double calculateperimetr();
//        }
//        class Circle : IShape
//        {
//            public double radius;
//            public Circle(double r)
//            {
//                radius = r;
//            }
//            public double calculatearea() => Math.PI * Math.Pow(radius, 2);
//            public double calculateperimetr() => Math.PI * radius*2;
//        }
//        class Rectangle : IShape
//        {
//            public double teref1;
//            public double teref2;

//            public Rectangle(double t1,double t2)
//            {
//                teref1 = t1;
//                teref2 = t2;
//            }

//            public double calculatearea() => teref1*teref2;
//            public double calculateperimetr() => (teref1+teref2)* 2;
//        }
//        class Triangle : IShape
//        {
//            public double teref11;
//            public double teref22;
//            public double teref33;

//            public Triangle(double t1,double t2,double t3)
//            {
//                teref11 = t1;
//                teref22 = t2;
//                teref33 = t3;
//            }
//            public double calculateperimetr() => teref11 + teref22 + teref33;
//            public double calculatearea()
//            {
//                double yp = (teref11 + teref22 + teref33) / 2;
//                return Math.Sqrt(yp * (yp - teref11) * (yp - teref22) * (yp - teref33));
//            }
//        }
//        class ShapeHelper
//        {
//            public double calculatearea(double radius)
//            {
//                return Math.PI * Math.Pow(radius, 2);
//            }
//            public double calculatearea(double w,double h)
//            {
//                return w * h;
//            }
//        }
//        static void Main(string[] args)
//        {
//            List<IShape> shapes = new List<IShape>
//            {
//                new Circle(5),
//                new Rectangle(4,6),
//                new Triangle(3,4,5)
//            };
//            Console.WriteLine("Fiqularin sahe ve perimetri");
//            foreach(IShape shape in shapes)
//            {
//                Console.WriteLine($"fiqur: {shape.GetType().Name}");
//                Console.WriteLine($"sahe: {shape.calculatearea():F2}");
//                Console.WriteLine($"perimetr: {shape.calculateperimetr():F2}");
//            }
//            Console.WriteLine("\n ShapeHelper ile");
//            ShapeHelper helper = new ShapeHelper();
//            double circlearea = helper.calculatearea(7);
//            double rearea = helper.calculatearea(5, 10);
//            Console.WriteLine($"daire sahesi: {circlearea:F2}");
//            Console.WriteLine($"duzbucagli sahesi: {rearea:F2}");
//        }

//    }
//}


//using System;
//using System.Collections.Generic;
//using System.Runtime.ConstrainedExecution;
//namespace ConsoleApp3
//{
//        public class vehicle
//        {
//        public string brend { get; set; }
//        public int suret { get; set; }
//        public vehicle()
//        {
//            this.brend = brend;
//            this.suret = suret;
//        }
//            public virtual void MakeSound()
//            {
//                Console.WriteLine("Neqliyyat ve=astiesi ses cixarir...");
//            }
//        }
//    public class car : vehicle
//    {
//        public override void MakeSound()
//        {
//            Console.WriteLine($"{brend} {suret} km suretle ses cixarir");
//        }
//    }
//    class motorcycle : vehicle
//    {
//        public override void MakeSound()
//        {
//            Console.WriteLine($"{brend} {suret} km suretle ses cixarir");
//        }
//    }
//    class bicycle : vehicle
//    {
//        public override void MakeSound()
//        {
//            Console.WriteLine($"{brend} {suret} km suretle ses cixarir");
//        }
//    }
//    internal class program
//    {
//        static void Main(string[] args)
//        {
//            List<vehicle> vehicle = new List<vehicle>
//            {
//                new car {brend="BMW", suret=240},
//                new motorcycle {brend="Yamaha", suret=180},
//                new bicycle {brend="BMX", suret=30}
//            };
//            foreach(vehicle v in vehicle)
//            {
//                v.MakeSound();
//            }
//        }
//    }
//}


using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
namespace ConsoleApp3
{
    public abstract class Employee
    {
        private double basesalary;
        public Employee(double salary)
        {
            SetSalary(salary);
        }
        public double GetSalary()
        {
            return basesalary;
        }
        public void SetSalary(double salary)
        {
            if (salary >= 0)
            {
                basesalary = salary;
            }
        }
        public abstract double calculatebonus();
    }
    public class manager : Employee
    {
        public manager(double salary) : base(salary)
        {
        }
        public override double calculatebonus()
        {
            return GetSalary() * 0.20;
        }
    }
    public class intern : Employee
    {
        public intern(double salary) : base(salary)
        {
        }
        public override double calculatebonus()
        {
            return 100;
        }
    }
    internal class program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new manager(2000),
                new manager(1500),
                new intern(400)
            };
            foreach(Employee emp in employees)
            {
                double totalsalary = emp.GetSalary() + emp.calculatebonus();
                Console.WriteLine($"Esas maas: {emp.GetSalary()} AZN, bonus: {emp.calculatebonus()} AZN, umumi: {totalsalary} AZN");
            }
        }
    }
}