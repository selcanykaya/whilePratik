//Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
int sayac = 1;
while (sayac <= 10)
{
    Console.WriteLine($"{sayac}.Kendime inanıyorum, ben bu yazılım işini hallederim!");
    sayac++;
}
Console.WriteLine("--------------------------------------------------------");
//1 ile 20 arasındaki sayıları konsol ekranına yazdırınız. 
int sayi = 1;
while (sayi <= 20)
{
    Console.WriteLine(sayi);
    sayi++;
}
Console.WriteLine("--------------------------------------------------------");
//1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
int ciftSayi = 1;
while (ciftSayi <= 10) 
{ Console.WriteLine(ciftSayi*2);
    ciftSayi++;
}
Console.WriteLine("--------------------------------------------------------");
// 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
int i = 50;
int toplam = 0;
while (i <=150)
{
    toplam += i;
    i++;
    
}
Console.WriteLine($"Toplam --> {toplam}");
Console.WriteLine("--------------------------------------------------------");
//1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
int x = 1;
int ciftToplam = 0;
int tekToplam = 0;
while (x <= 120) 
{
    if (x % 2 == 0)
    {
        ciftToplam += x;
        x++;
    }
    else 
    {
        tekToplam += x;
        x++;
    }
}
Console.WriteLine($"Çift sayıların toplamı -> {ciftToplam}, Tek sayıların toplamı -> {tekToplam}'dır.");