
class AreaOfFigures {
    public static void Main (string[]args)
    {

        string shape = Console.ReadLine();
        
        double area=0.0;
        if (shape=="square")
        {
            double side = double.Parse(Console.ReadLine());
            area = side * side;
        } else if (shape == "rectangle")
        {
            double sizeA = double.Parse(Console.ReadLine());
            double sizeB = double.Parse(Console.ReadLine());
            area = sizeA * sizeB;
        } else if (shape=="circle")
        {
            double radius = double.Parse(Console.ReadLine());
            area = Math.PI * radius * radius;
        } else if (shape=="triangle")
        {
            double a = double.Parse(Console.ReadLine());
            double ah = double.Parse(Console.ReadLine());
            area = a * ah / 2;
        }

        Console.WriteLine($"{area:F2}");
    }
}