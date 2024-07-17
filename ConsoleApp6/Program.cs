using System.Transactions;

Console.WriteLine("Elma = 3");
Console.WriteLine("armut = 4");
Console.WriteLine("Çilek = 5");
Console.WriteLine("Diğer ürünler = 3");
Console.Write("Hangi Meyveyi Almak İstersiniz? (ELma/Armut/Çilek/Diğer) : ");
string isim = Console.ReadLine();


switch (isim)
{
    case  "elma" :
        Console.WriteLine("Seçtiğiniz Meyvenin Fiyatı : 3 TL");
        break;
    case "Çilek":
        Console.WriteLine("Seçtiğiniz Meyvenin Fiyatı : 4 TL");
        break;
    case "Armut":
        Console.WriteLine("Seçtiğiniz Meyvenin Fiyatı : 5 TL");
        break;
    default:
        Console.WriteLine("Seçtiğiniz Meyvenin Fiyatı : 3 TL");
        break;
    

}