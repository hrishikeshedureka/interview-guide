// See https://aka.ms/new-console-template for more information
using FactoryMethodDesignPattern;

Console.WriteLine("Hello, World!");


CreditCardFactory factory = new PlatinumFactory();
CreditCard card = factory.CreateCard();
Console.WriteLine(card.GetCardType()); // Output: Platinum
Console.WriteLine($"Credit Limit: {card.GetCreditLimit()}"); // Output: Credit Limit: 50000

factory = new MoneyBackFactory();
card = factory.CreateCard();
Console.WriteLine(card.GetCardType()); // Output: MoneyBack
Console.WriteLine($"Credit Limit: {card.GetCreditLimit()}"); // Output: Credit Limit: 50000


NotificationFactory notificationFactory = new EmailNotificationFactory();
Notification notification = notificationFactory.CreateNotification();
notification.Send("Hello via Email!"); // Output: Sending EMAIL: Hello via Email!

notificationFactory = new SmsNotificationFactory();
notification = notificationFactory.CreateNotification();
notification.Send("Hello via SMS!"); // Output: Sending SMS: Hello via SMS!

notificationFactory = new WhatsAppNotificationFactory();
notification = notificationFactory.CreateNotification();
notification.Send("Hello via WhatsApp!"); // Output: Sending Whatsapp: Hello via WhatsApp!