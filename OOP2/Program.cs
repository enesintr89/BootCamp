using OOP2;


Individual customer1 = new Individual();
customer1.Id = 1;
customer1.CustomerNum = "123456";
customer1.Name = "Enes";
customer1.Surname = "Akan";
customer1.SSN = "12345678910";

Corporate customer2 = new Corporate();
customer2.Id = 2;
customer2.CustomerNum = "564789";
customer2.CorporateName = "TreeSoft";
customer2.TaxId = "313541354";

Customer customer3= new Individual();

Customer customer4 = new Corporate();

CustomerManager customerManager = new CustomerManager();
customerManager.Add(customer1);