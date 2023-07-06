using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-------------------------------------");

        Customer C1=new Customer();
        Console.WriteLine(C1.GetName());
        Console.WriteLine();

        Product P1=new Product();
        Console.WriteLine(P1.GetProduct());
        Console.WriteLine($"The product price: {P1.GetPriceP()}");
        Console.WriteLine();

        Product P4=new Product("Book","1097-14",25.50,2);
        Console.WriteLine(P4.GetProduct());
        Console.WriteLine($"The product price: {P4.GetPriceP()}");
        Console.WriteLine();
        

        Address A1=new Address();
        Console.WriteLine(A1.GetInside());
        Console.WriteLine();

        double _total=P1.GetPriceP() + P4.GetPriceP() + 5;
        Console.WriteLine($" The total price of your purchase: {_total}");

        
        Console.WriteLine("-------------------------------------");

        Customer C2=new Customer("Meredith Keen");
        Console.WriteLine(C2.GetName());
        Console.WriteLine();
        
        Product P2=new Product("Necklace","3019-73",50.00,2);
        Console.WriteLine(P2.GetProduct());
        Console.WriteLine($"The product price: {P2.GetPriceP()}");
        Console.WriteLine();

        Product P3=new Product("Dress","8281-99",100.00,1);
        Console.WriteLine(P3.GetProduct());
        Console.WriteLine($"The product price: {P3.GetPriceP()}");
        Console.WriteLine();

        Address A2=new Address("Avenida Brasil", "Rio de Janeiro", "Rio de Janeiro", "Brazil");
        Console.WriteLine(A2.GetOutside());
        Console.WriteLine();

        double total=P2.GetPriceP() + P3.GetPriceP() + 35;
        Console.WriteLine($" The total price of your purchase: {total}");

        
        
    }  
}
