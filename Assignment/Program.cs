namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01
          
            IShape circle = new Circle(5);
            circle.DisplayShapeInfo();

            IShape rectangle = new Rectangle(4, 6);
            rectangle.DisplayShapeInfo();
           
            #endregion
        }
    }
}
