using OOPSession5.Binding;

namespace OOPSession5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Binding
            TypeA type = new TypeB(10,5);
            type.A = 20;
            //type.B = 30;

            type.funct01(); // Calls TypeA's funct01 due to 'new' keyword in TypeB
            type.funct02(); // Calls TypeB's funct02 due to 'override' keyword in TypeB

            #endregion
        }
    }
}
