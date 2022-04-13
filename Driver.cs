public enum License
{
    A = 0,
    B = 1,
    C = 2
}
public class Driver
{
    public string Name;
    public License TypeLicense;
    public int Experience;
    public int Birthday;
    
    public Driver(string name, string license, int exp, int year)
    {
        Name = name;
        TypeLicense = Enum.Parse<License>(license);
        Experience = exp;
        Birthday = year;
    }
}