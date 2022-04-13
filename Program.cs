using System;
class TestClass
{
    static void Main(string[] args)
    {
        StreamReader streamDriver = new StreamReader("resources/data_drive.txt");
        int numDriver = int.Parse(streamDriver.ReadLine()!);

        Driver[] ListDriver = new Driver[numDriver];
        for (int i = 0; i < numDriver; i++)
        {
            string name = streamDriver.ReadLine()!;
            string license = streamDriver.ReadLine()!;
            int exp = int.Parse(streamDriver.ReadLine()!);
            int year = int.Parse(streamDriver.ReadLine()!);
            ListDriver[i] = new Driver(name, license, exp, year);
        }
        streamDriver.Close();

        StreamReader streamGoods = new StreamReader("resources/data_goods.txt");
        int numGoods = int.Parse(streamGoods.ReadLine()!);
        Goods[] ListGoods = new Goods[numGoods];
        for (int i = 0; i < numGoods; i++)
        {
            string category = streamGoods.ReadLine()!;
            string id = streamGoods.ReadLine()!;
            string receivingAddress = streamGoods.ReadLine()!;
            string sendingAddress = streamGoods.ReadLine()!;
            int weight = int.Parse(streamGoods.ReadLine()!);
            string type = streamGoods.ReadLine()!;
            int price = int.Parse(streamGoods.ReadLine()!);
            ListGoods[i] = new Goods(category, id, receivingAddress, sendingAddress, weight, type, price);
        }
        streamGoods.Close();
        StreamReader streamTruck = new StreamReader("resources/data_cars.txt");
        int numTruck = int.Parse(streamTruck.ReadLine()!);
        Truck[] ListTruck = new Truck[numTruck];
        for (int i = 0; i < numTruck; i++)
        {
            string typeTruck = streamTruck.ReadLine()!;
            string numbPlate = streamTruck.ReadLine()!;
            int speed = int.Parse(streamTruck.ReadLine()!);
        }
        streamTruck.Close();
        
    }
}
