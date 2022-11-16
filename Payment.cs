

public class Payment
{
    public int Id { get; set; }
    public int Order_id { get; set; }
    public DateTime Date { get; set; }
    public float Amount { get; set; }
    public bool Status { get; set; }
    public List<Order> Orders { get; set; }

}
