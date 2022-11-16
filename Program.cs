// Domando Cliente o Dipendente
bool loop = true;
EcommerceDbContext db = new EcommerceDbContext();
while (loop)
{
    Console.Write("Sei un cliente o un dipendente");
   
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "cliente":
            Console.WriteLine("Bravo, sei un cliente");
            break;
        case "dipendente":
            // Employee
            Console.WriteLine("Sei un nuovo dipendente? [y/n]");
            choice = Console.ReadLine();
            if(choice == "y")
            {
                Console.Write("Siamo nella risposta sì");
            }
           if(choice == "n")
            {
                Console.WriteLine("Risposta scelta no:");
              
                List<Employee> employees = db.Employees.OrderBy(employees => employees.name).ToList<Employee>();
                foreach (Employee employee in employees)
                {
                    if(employee.name ==  "Claudio")
                    {
                        Console.WriteLine("Ah sei {0} {1}", employee.surname, employee.name);
                    }
                }
                
            }
            break;
    }

}

// Creo 10 prodotti unici che hanno un nome, prezzo e una descrizione

// Se dipendente creo Ordine (es.: 5 mozzarelle, 3 provola) utilizzando gli ordini creati prima


// Se Cliente





    // Funziona
    // Create
    //Employee newEmployee = new Employee { name = "Claudio", surname = "Pastello"};
    //Console.WriteLine(newEmployee.name + "Esecuzione di test");
    //db.Add(newEmployee);
    //// Salva cambiamento apportati al db
    //db.SaveChanges();

void ListaDipendenti()
{
    // Read
    List<Employee> employees = db.Employees.OrderBy(employees => employees.name).ToList<Employee>();

    foreach (Employee employee in employees)
        {
            Console.WriteLine("{0} {1}", employee.name, employee.surname);
        }
}



