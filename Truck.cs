public enum Type
{
    Truck5T = 1,
    Truck10T = 2,
    Container = 3

}
public class Truck
{
    public Type TypeTruck;
    public string NumbPlate = "";
    public int Speed;
    public Truck(string typeTruck, string numbPlate, int speed)
    {
        TypeTruck = Enum.Parse<Type>(typeTruck);
        NumbPlate = numbPlate;
        Speed = speed;
    }
}
