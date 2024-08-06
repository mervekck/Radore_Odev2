// See https://aka.ms/new-console-template for more information
using Odev_2.Entities.Abstract;
using Odev_2.Entities.Concrete;
using Odev_2.Utilities;

Console.WriteLine("Hello, World!");

//interface için
//      bmw                       mercedes 			        porche
//bmw havada uçuyor		    mercedes havada uçuyor 		
//bmw denizde yüzüyor		mercedes denizde yüzüyor	
//bmw çok hızlı gidiyor                                     porche çok hızlı gidiyor

// bu mesajları interface yada interface leri kullanarak ekrana nasıl yazdırırdınız.

//abstract class
// bmw 60.0 Litre       mercedes 70.0 litre		porche 80.0 litre
// toplamda ne kadar benzin harcıyorlar.

//Tek interface de yazarsak Solid prensiplerinden Interface segregation principle uygun olmaz.

Console.WriteLine("\nAraba Özellikleri");
Console.WriteLine("----------------------------------------");

double bmwLitre = 60.0;
BMW bmw = new BMW(bmwLitre);
bmw.HavadaUc();
bmw.DenizdeYuz();
bmw.HizliGit();

double mercedesLitre = 70.0;
Mercedes mercedes = new Mercedes(mercedesLitre);
mercedes.HavadaUc();
mercedes.DenizdeYuz();

double porscheLitre = 80.0;
Porsche porsche = new Porsche(porscheLitre);
porsche.HizliGit();

Console.WriteLine("\nBenzin Miktarları");
Console.WriteLine("----------------------------------------");

Araba[] araba = { bmw, mercedes, porsche };

double benzinToplam = Matematik.ToplamBenzin(araba);

Console.WriteLine("\nToplam Benzin Miktarı");
Console.WriteLine("----------------------------------------");
Console.WriteLine("Bmw,mercedes,porsche toplam benzin harcama miktarı : " + benzinToplam + " litre");
