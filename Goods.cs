
public class Goods
{
    public string Id = "";
    public string ReceivingAddress = "";
    public string SendingAddress = "";
    public int Weight;
    public string Type = "";
    public string Category = "";
    public float Price;
    public Goods(string category, string id, string receivingAddress, string sendingAddress, int weighet, string type, int price)
    {
        Category = category;
        Id = id;
        ReceivingAddress = receivingAddress;
        SendingAddress = sendingAddress;
        Weight = weighet;
        Type = type;
        Price = price;
    }
}
