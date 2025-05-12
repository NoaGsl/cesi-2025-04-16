using Dip.Exercice01.Interfaces;

namespace Dip.Exercice01.Classes
{
    public class OrderProcessor
    {
        private readonly INotificationService _notificationService;

        public OrderProcessor(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public void Process()
        {
            // Traitement de la commande...
            _notificationService.Send("Commande traitée.");
        }
    }

}
