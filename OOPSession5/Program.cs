using OOPSession5.Binding;
using OOPSession5.Example01Interface;
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
            SeriesOne seriesOne = new SeriesOne();   
            //SeriesToPrintFiveNums(seriesOne);
            SeriesTow seriesTow = new SeriesTow();
            SeriesToPrintFiveNums(seriesTow);

            #endregion


        }
    }
}
