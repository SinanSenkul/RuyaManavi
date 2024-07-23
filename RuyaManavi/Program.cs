Console.WriteLine("Rüya manavına hoşgeldiniz!");
Console.WriteLine("Elma = 2 TL");
Console.WriteLine("Armut = 3 TL");
Console.WriteLine("Çilek = 2 TL");
Console.WriteLine("Muz = 3 TL");
Console.WriteLine("Diğer bütün meyveler = 4 TL");
Console.Write("Hangi meyveyi satın almak istersiniz? (Elma/Armut/Çilek/Muz): ");
string fruit = Console.ReadLine().ToLower(); //standardize the input for preventing case related errors

//solution with switch statement:

switch (fruit)
{
    case "elma":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
        break;
    case "armut":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
        break;
    case "çilek":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
        break;
    case "muz":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
        break;
    default: //if any fruit name other than the ones above
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 4 TL");
        break;
}

//solution with if/else statement:
/*
if (fruit == "elma")
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
}
else if (fruit == "armut")
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
}
else if (fruit == "çilek")
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
}
else if (fruit == "muz")
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
}
else //if any input other than the ones above
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 4 TL");
}
*/
