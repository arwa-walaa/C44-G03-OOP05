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
           
            INotificationService emailService = new EmailNotificationService();
            INotificationService smsService = new SmsNotificationService();
            INotificationService pushService = new PushNotificationService();

            emailService.SendNotification("user@example.com", "Hello via Email!");
            smsService.SendNotification("+1234567890", "Hello via SMS!");
            pushService.SendNotification("device123", "Hello via Push Notification!");
            #endregion
        }
    }
}
