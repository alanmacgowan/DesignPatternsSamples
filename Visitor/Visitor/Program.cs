
// Setup employee collection
Employees employee = new Employees();
employee.Attach(new Clerk());
employee.Attach(new Director());
employee.Attach(new President());

// Employees are 'visited'
employee.Accept(new IncomeVisitor());
employee.Accept(new VacationVisitor());

// Wait for user
Console.ReadKey();
