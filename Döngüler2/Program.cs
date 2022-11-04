// See https://aka.ms/new-console-template for more information

int[] sayilar = { 10, 17, 5, 21, 40, 7 };
int sayac = 0;
int toplam = 0;
// For
Console.WriteLine("**************");                       
Console.WriteLine("For Döngüsü");
Console.WriteLine("**************");
for (int i = 0; i < sayilar.Length; i++)
{
    Console.WriteLine(sayilar[i]);
    toplam += sayilar[i];                                  // toplam = toplam + sayilar[i]; 
}

Console.WriteLine("------------------------------");
Console.WriteLine("Toplam  : " + toplam);
Console.WriteLine("------------------------------");

// Do
toplam = 0;
sayac = 0;
Console.WriteLine("**************");
Console.WriteLine("Do Döngüsü");
Console.WriteLine("**************");
do
{

    Console.WriteLine(sayilar[sayac]);
    toplam += sayilar[sayac];
    sayac++;     // sayac = sayac + 1; yazılışının kısaltılması
} while (sayac < sayilar.Length);
Console.WriteLine("------------------------------");
Console.WriteLine("Toplam  : " + toplam);
Console.WriteLine("------------------------------");
// While
toplam = 0;
sayac = 0; // sayaç 7'den devam etmemesi için sıfırlandı
Console.WriteLine("**************");
Console.WriteLine("While Döngüsü");
Console.WriteLine("**************");
while (sayac < sayilar.Length)
{

    Console.WriteLine(sayilar[sayac]);
    toplam += sayilar[sayac];
    sayac++;
}
Console.WriteLine("------------------------------");
Console.WriteLine("Toplam  : " + toplam);
Console.WriteLine("------------------------------");
// ForEach Döngüsü
toplam = 0;
Console.WriteLine("**************");
Console.WriteLine("For each Döngüsü");
Console.WriteLine("**************");
foreach (var item in sayilar)        // for döngüsünüz daha kolayı sayaca gerek yok herşeyi kendi ayarlıyor
{
    Console.WriteLine(item);
    toplam += item;
}

Console.WriteLine("------------------------------");
Console.WriteLine("Toplam  : " + toplam);
Console.WriteLine("------------------------------");