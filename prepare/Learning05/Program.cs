using System;

class Program
{
    static void Main(string[] args)
    {

        List<Shape> shapes= new List<Shape>();
        
        Square squa= new Square("Red",2);
        shapes.Add(squa);
        Rectangle rec=new Rectangle("Purple",5,5);
        shapes.Add(rec);
        Circle circ=new Circle("Black",3);
        shapes.Add(circ);


        foreach (Shape shap in shapes)
        {
            string c= shap.GetColor();
            double a=shap.GetArea();

            Console.WriteLine($"The color is {c} and the area is {a}.");
    
        }

    }

       
        
}