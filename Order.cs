public class Order
{
    public int Id { get; set; }
    public string Customer_id { get; set; }
    public string Empoloyee_id { get; set; }
    public DateTime Date { get; set; }
    // Numero ordini
    public int Amount { get; set; }
    
    public bool Status { get; set; }

    // Foreign Key

    // Liste // Many to / (In questo caso Many e To 1)
    public List<Product> Products { get; set; }
    public List<Payment> Payments { get; set; }

    //Singole //  1 to / (In questo caso Many)
    public Customer Customers { get; set; }
    public int Customers_id { get; set; }

    public Employee Employees { get; set; }
    public int Employee_id { get; set; }

}
