// See https://aka.ms/new-console-template for more information

using LSP;
using LSP.services;

IFileReader fileReader = new Admin();
IFileWriter fileWriter = new Admin();
fileReader.ReadFile("Reading file as Admin.");
fileWriter.WriteFile("Writing file as Admin.");

fileWriter = new Registered();
fileWriter.WriteFile("Writing file as Registered user.");

fileWriter = new Guest();
fileWriter.WriteFile("Writing file as Guest.");



IEmployeeDetails employeeDetails = new PermanentEmployee();
IEmployeeBonusDetails employeeBonusDetails = new PermanentEmployee();

employeeDetails.DisplayEmployeeDetails("John Doe", "Software Engineer", 60000);
employeeBonusDetails.CalculateBonus(60000, 0.10m);


employeeDetails = new TemporaryEmployee();
employeeBonusDetails = new TemporaryEmployee();
employeeDetails.DisplayEmployeeDetails("Jane Smith", "Data Analyst", 50000);
employeeBonusDetails.CalculateBonus(50000, 0.05m);

employeeDetails = new ContractEmployee();
employeeDetails.DisplayEmployeeDetails("Alice Johnson", "Project Manager", 70000);