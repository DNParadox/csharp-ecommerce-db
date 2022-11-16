public class Order
{
    public int Id { get; set; }
    public string Customer_id { get; set; }
    public string Empoloyee_id { get; set; }
    public DateTime Date { get; set; }
    // Numero ordini
    public int Amount { get; set; }
    
    public bool Status { get; set; }

    // Liste
    // Many to / (In questo caso Many e To 1)
    public List<Product> Products { get; set; }
    public List<Employee> Employees { get; set; }
    public List<Customer> Customers { get; set; }

    // 1 to / (In questo caso Many)
    public Payment Payments { get; set; }

}
