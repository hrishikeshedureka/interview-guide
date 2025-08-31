// See https://aka.ms/new-console-template for more information
using DIP;
using DIP.service;

Console.WriteLine("Hello, World!");

UserServiceViolate userService = new UserServiceViolate(new IDataStorageViolate());

UserService service = new UserService(new DatabaseService());