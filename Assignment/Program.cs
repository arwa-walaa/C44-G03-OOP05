namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01

            //IShape circle = new Circle(5);
            //circle.DisplayShapeInfo();

            //IShape rectangle = new Rectangle(4, 6);
            //rectangle.DisplayShapeInfo();

            #endregion

            #region Question 02

            //IAuthenticationService authService = new BasicAuthenticationService();
            //bool isAuthenticated = authService.AuthenticateUser("admin", "password123");
            //bool isAuthorized = authService.AuthorizeUser("admin", "Admin");

            //Console.WriteLine($"Authentication: {isAuthenticated}");
            //Console.WriteLine($"Authorization: {isAuthorized}");
            //Console.WriteLine();

            //IAuthenticationService authService02 = new BasicAuthenticationService();
            //bool isAuthenticated02 = authService02.AuthenticateUser("admin", "password");
            //bool isAuthorized02 = authService02.AuthorizeUser("user", "User");

            //Console.WriteLine($"Authentication: {isAuthenticated02}");
            //Console.WriteLine($"Authorization: {isAuthorized02}");

            #endregion

            #region Question 03

            //INotificationService emailService = new EmailNotificationService();
            //INotificationService smsService = new SmsNotificationService();
            //INotificationService pushService = new PushNotificationService();

            //emailService.SendNotification("user@example.com", "Hello via Email!");
            //smsService.SendNotification("+1234567890", "Hello via SMS!");
            //pushService.SendNotification("device123", "Hello via Push Notification!");
            #endregion

            #region Question 04
           

         
            Console.WriteLine("Enter user type (Regular/Premium/Guest):");
            string userType = Console.ReadLine();

            Console.WriteLine("Enter product price:");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter product quantity:");
            int quantity = int.Parse(Console.ReadLine());

         
            User user;
            switch (userType.ToLower())
            {
                case "regular":
                    user = new RegularUser();
                    break;
                case "premium":
                    user = new PremiumUser();
                    break;
                case "guest":
                    user = new GuestUser();
                    break;
                default:
                    Console.WriteLine("Invalid user type. Defaulting to Guest.");
                    user = new GuestUser();
                    break;
            }

          
            Discount discount = user.GetDiscount();
            decimal discountAmount = discount?.CalculateDiscount(price, quantity) ?? 0;
            decimal total = (price * quantity) - discountAmount;

          
            if (discount != null)
            {
                Console.WriteLine($"Discount Applied: {discount.Name}");
                Console.WriteLine($"Discount Amount: {discountAmount:C}");
            }
            else
            {
                Console.WriteLine("No discount applied");
            }
            Console.WriteLine($"Total After Discount: {total:C}");
            #endregion

        }
    }
}
