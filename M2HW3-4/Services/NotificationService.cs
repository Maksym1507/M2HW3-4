using M2HW3_4.Interfaces;

namespace M2HW3_4.Services
{
    public class NotificationService : INotificationService
    {
        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
