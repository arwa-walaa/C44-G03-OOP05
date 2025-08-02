using OOPSession5.Binding;

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

        static void Main(string[] args)
        {
            #region Binding
            TypeA type = new TypeB(10,5);
            type.A = 20;
            //type.B = 30;

            //type.funct01(); // Calls TypeA's funct01 due to 'new' keyword in TypeB
            //type.funct02(); // Calls TypeB's funct02 due to 'override' keyword in TypeB

            #endregion

            #region Binding Usage
            Employee FullTimeEmp = new FullTimeEmployee();
            Employee PartTimeEmp = new PartTimeEmployee();
            ProcessEmp(FullTimeEmp);
            ProcessEmp(PartTimeEmp);

            #endregion


        }
    }
}
