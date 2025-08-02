using OOPSession5.Binding;
using OOPSession5.BuiltInIo;
using OOPSession5.Example01Interface;
using OOPSession5.Example02Interface;
using OOPSession5.Interface;


namespace OOPSession5
{
    internal class Program
    {
        #region Binding usege
        //public static void ProcessEmp(FullTimeEmployee emp)
        //{
        //    if (emp is not null)
        //    {
        //        emp.func01();
        //        emp.func02();
        //    }

        //}
        //public static void ProcessEmp(PartTimeEmployee emp)
        //{
        //    if (emp is not null)
        //    {
        //        emp.func01();
        //        emp.func02();
        //    }

        //}
        public static void ProcessEmp(Employee emp)
        {
            if (emp is not null)
            {
                emp.func01();
                emp.func02();
            }

        }
        #endregion

        #region Inface EX 01
        static void SeriesToPrintFiveNums(ISeries series)
        {
            if (series is not null)
            {
                for (int i = 1; i < 6; i++)
                {
                    Console.WriteLine(series.Current);
                    series.GetNextValue();

                }
                series.ResetSeries();
            }
            else { 
                return;
            }
        }

        #endregion

        static void Main(string[] args)
        {
            #region Binding
            //TypeA type = new TypeB(10,5);
            //type.A = 20;
            //type.B = 30;

            //type.funct01(); // Calls TypeA's funct01 due to 'new' keyword in TypeB
            //type.funct02(); // Calls TypeB's funct02 due to 'override' keyword in TypeB

            #endregion

            #region Binding Usage
            //Employee FullTimeEmp = new FullTimeEmployee();
            //Employee PartTimeEmp = new PartTimeEmployee();
            //ProcessEmp(FullTimeEmp);
            //ProcessEmp(PartTimeEmp);

            #endregion

            #region Interface 
            //Itype refType ;
            //refType = new Itype(); // Cannot instantiate an interface directly
            //refType = new TypeIO();
            //refType.MyProperty = 100;
            //refType.MyMethod();
            //refType.print(); // Calls the default implementation in the interface
            //TypeIO typeIO = new TypeIO();
            //typeIO.MyProperty = 200;
            //typeIO.MyMethod();
            ////typeIO.print(); 
            #endregion

            #region Ex 01 Interface 
            //SeriesOne seriesOne = new SeriesOne();   
            ////SeriesToPrintFiveNums(seriesOne);
            //SeriesTow seriesTow = new SeriesTow();
            //SeriesToPrintFiveNums(seriesTow);

            #endregion

            #region Ex 02 Interface
            //Car car = new Car();
            //car.Speed= 100;
            //car.Forward();
            //car.Backward();
            //car.Left();
            //car.Right();
            //AirPlane airPlane = new AirPlane();
            //airPlane.Speed= 600;
            //airPlane.Forward();
            //airPlane.Backward();
            //airPlane.Left();
            //airPlane.Right();

            //IMoveOnAir moveOnAir = new AirPlane();
            //IMoveOnGround moveOnGround = new Car();
            //IMoveOnGround moveOnGround2 = new AirPlane();

            //moveOnGround2.Backward();

            #endregion

            #region Built-in Interfaces

            #region IClonble
            //User user01 = new User
            //{
            //    Id = 1,
            //    Name = "John Doe",
            //    Salary = 50000
            //};
            //User user02 = new User
            //{
            //    Id = 2,
            //    Name = "Alaa",
            //    Salary = 60000
            //};

            //Console.WriteLine($"User 01: {user01.GetHashCode()}");
            //Console.WriteLine($"User 02: {user02.GetHashCode()}");
            //Console.WriteLine($"User 01: {user01}");
            //Console.WriteLine($"User 02: {user02}");

            //// Cloning user01
            //user02=(User) user01.Clone() ;
            // Console.WriteLine("After Cloning User 01 to User 02");
            //Console.WriteLine($"User 01: {user01.GetHashCode()}");
            //Console.WriteLine($"User 02: {user02.GetHashCode()}");
            //Console.WriteLine($"User 01: {user01}");
            //Console.WriteLine($"User 02: {user02}");

            //clone() : Creates a new object that is a copy of the current instance.


            #endregion

            #region IComparable

            int[] numbers = { 6,3,1,2,5,4 };

            User[] users = {
                new User { Id = 10, Name = "Alice", Salary = 70000 },
                new User { Id = 20, Name = "Bob", Salary = 50000 },
                new User { Id = 30, Name = "Charlie", Salary = 60000 },
                new User { Id = 40, Name = "ALi", Salary = 15000 }
            };

            Array.Sort(users);

            ////Array.Sort(numbers);
            //foreach (User user in users)
            //{
            //    Console.WriteLine(user);
            //}

            #endregion

            #region IComparer

            //sort pased on name
            Array.Sort(users, new UserNameComparer());

            foreach (User user in users)
            {
                Console.WriteLine(user);
            }

            #endregion

            #endregion

        }
    }
}
