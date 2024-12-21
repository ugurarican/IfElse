// Konsol ekranında bir sayı girmemizi istiyoruz.
Console.Write("Lütfen bir sayı giriniz: ");

// Girilen sayının değerini değişkene atama.
int number = int.Parse(Console.ReadLine());
int div = number % 2;

// karşılaştırma bloğuyla sayının 10 dan büyük mü eşit mi küçük mü olduğunu karşılaştırıyoruz.
// İç içe if bloğu oluşturup çift mi tek miş olduğunu kontrol ediyoruz.
if (number > 10)
{
    if (div ==  0) { 
    Console.WriteLine($"{number} sayısı 10'dan büyüktür ve çifttir.");
    }
    else if (div == 1)
    {
        Console.WriteLine($"{number} sayısı 10'dan büyüktür ve tektir..");
    }
}
else if (number == 10)
{
    Console.WriteLine($"{number} sayısı 10'a eşittir.");
}
else if (number < 10) { 
    if (number == 0)
{
    Console.WriteLine($"{number} sayısı 10'dan küçüktür ve çifttir.");
}
Console.WriteLine($"{number} sayısı 10'dan küçüktür ve tektir.");
}