// Let's call Employee

using UI;

Employee emp = new Employee();

emp.firstName = "Yunus";
emp.lastName = "Khan";

Console.WriteLine($"Employee Id = {emp.id}\nEmployee Name {emp.firstName} {emp.lastName}\nPlanet {Employee.planet}");
emp.DoTask(emp.firstName, emp.lastName, emp.id, 9);

emp.DoTask("Sheen", "Joseph", "102", 20);