// See https://aka.ms/new-console-template for more information
using OCP;
using OCP.Services;

Console.WriteLine("Hello, World!");

// Notification details
INotifier emailNotifier = new EmailNotification();
emailNotifier.SendNotification("Hellow via email notification.");

emailNotifier=new SMSNotification();
emailNotifier.SendNotification("Hellow via SMS notification.");

emailNotifier = new PushNotification();
emailNotifier.SendNotification("Hellow via push notification.");

// Invoice details
IGenerateInvoice invoice = new LumsumInvoice();
invoice.GenerateInvoice(1000);

invoice = new FinalInvoice();
invoice.GenerateInvoice(1000);





// Employee details
Employee employee = new EmployeeService();
employee.EmployeeDetails();
employee.EmployeeMinSalary();
employee.EmployeeBonus();

employee=new TemporaryEmployeeService();
employee.EmployeeDetails();
employee.EmployeeMinSalary();
employee.EmployeeBonus();

//we can extend based on our employee type
employee = new ContractEmployeeService();
employee.EmployeeDetails();
employee.EmployeeMinSalary();
employee.EmployeeBonus();       // this will throw an exception as Interns do not receive bonuses and this is violating LSP principle, so we need to refactor this code to avoid this exception.