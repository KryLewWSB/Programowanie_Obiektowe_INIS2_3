
    
using ConsoleApp4;

Punkt punkt1 = new Punkt(5, 7);//Tworzenie nowego obiektu na podstawie klasy Punkt
Punkt punkt2 = new Punkt(1, 2);
Punkt punkt3 = new Punkt(1, 1);
Punkt punkt4 = new Punkt(4, 9);


Console.WriteLine($"x= {punkt1.getX()} y= {punkt1.y}");
Console.WriteLine($"x= {punkt2.getX()} y= {punkt2.y}");
Console.WriteLine($"x= {punkt3.getX()} y= {punkt3.y}");
Console.WriteLine($"x= {punkt4.getX()} y= {punkt4.y}");