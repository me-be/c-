using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace csharpegitim1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("merhaba dünya");
            Console.WriteLine();
            Console.WriteLine(".......yemek kategorisi.....");
            Console.WriteLine();
            Console.WriteLine("1 corbalar");
            Console.WriteLine("2 soguk yemek");
            Console.WriteLine("3 ana yemekler");
            Console.WriteLine("4 salata");
            Console.WriteLine("5 tatlı");
            Console.WriteLine();
            Console.WriteLine("..........yemek kategorileri....");

            degişkenler

            string name;
            name = "mehmet";
            Console.Write(name);


            string customername;
            string customersurname;
            string customerphone;
            string customeremail, district, city;


            customername = "mehmet";
            customersurname = "balık";
            customerphone = "050008000";
            customeremail = "aaaassdffgkfok";
            district = "orhangazi";
            city = "brusa";




            Console.WriteLine("-------rezervasyon kartı-----");
            Console.WriteLine();
            Console.WriteLine("müşteri:" + customername + " " + customersurname);
            Console.WriteLine("iletişim:" + customerphone);
            Console.WriteLine("emailadres:" + customeremail);
            Console.WriteLine("adres:" + district + "/" + city);
            Console.WriteLine("-------------------------");

            customername = "aysegul";
            customersurname = "al";
            customerphone = "500000040000";
            customeremail = "ermıfmgıfgı";
            district = "yavari";
            city = "istanbu";

            Console.WriteLine("müşteri:" + customername + " " + customersurname);
            Console.WriteLine("iletişim:" + customerphone);
            Console.WriteLine("emailadres:" + customeremail);
            Console.WriteLine("adres:" + district + "/" + city);

            int number = 24;
            Console.WriteLine(number);

            int hamburgerprice = 300;
            int pizzaprice = 50;
            int lemontprice = 75;




            Console.WriteLine("------restorant menü fiyat-----");
            Console.WriteLine();
            Console.WriteLine("hamburger" + hamburgerprice)
            Console.WriteLine("pizza" + pizzaprice);
            Console.WriteLine("limonata" + lemontprice);
            Console.WriteLine();

            int hamburgercount;
            int pizzacount;
            int lemontcount;

            int totalhamburgerprice; 0

            hamburgercount = 5;
            pizzacount = 4;
            lemontcount = 5;
            totalhamburgerprice = hamburgercount * hamburgerprice;
            Console.WriteLine("menü tutarı" + totalhamburgerprice + "tl");



            int hamburgerprice = 300;
            int cokeprice = 35;
            int waterprice = 10;
            int friesprice = 50;
            int pizzaprice = 250;
            int lemodeprice = 30;

            Console.WriteLine("---restorant menü fiyat----");
            Console.WriteLine();
            Console.WriteLine("-----hamburger fiyat:" + hamburgerprice + "tl");
            Console.WriteLine("-----pizza:" + pizzaprice + "tl");
            Console.WriteLine("-----kola:" + cokeprice + "tl");
            Console.WriteLine("-----limonata:" + lemodeprice + "tl");
            Console.WriteLine("-----kızartma fiyatı:" + friesprice + "tl");
            Console.WriteLine("-----su fiyatı:" + waterprice + "tl");
            Console.WriteLine("---restorant menü fiyat----");
            Console.WriteLine();

            int hamburgercount;
            int cokecount;
            int watercount;
            int friescount;
            int pizzacount;
            int lemonadecount;

            int totalhamburgerprice = 0;
            int totalcokeprice;
            int totalwaterprice;
            int totalfriesprice;
            int totalpizzaprice;
            int totallemonadeprice;

            hamburgercount = 3;
            cokecount = 3;
            watercount = 3;
            friescount = 1;
            pizzacount = 0;
            lemonadecount = 0;

            totalhamburgerprice = hamburgerprice * hamburgercount;
            totalcokeprice = cokecount * cokeprice;
            totalwaterprice = watercount * waterprice;
            totallemonadeprice = lemonadecount * lemodeprice;
            totalfriesprice = friescount * friesprice;
            totalpizzaprice = pizzacount * pizzaprice;
            Console.WriteLine("-------------------------------");
            Console.WriteLine("hamburger tutarı:" + totalhamburgerprice + "tl");
            Console.WriteLine("kızartma tutarı:" + totalfriesprice + "tl");
            Console.WriteLine("su tutarı:" + totalwaterprice + "tl");
            Console.WriteLine("kola tutarı:" + totalcokeprice + "tl");
            Console.WriteLine("limonata tutarı:" + totallemonadeprice + "tl");
            Console.WriteLine("pizza tutarı:" + totalpizzaprice + "tl");

            Console.WriteLine();

            int totalprice = totalcokeprice + totallemonadeprice + totalhamburgerprice + totalwaterprice + totalpizzaprice + totalfriesprice;

            Console.WriteLine("toplam ödenecek tutar:" + totalprice + "tl");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine();


            int lemonprice = 5;
            int tomatoprice = 6;
            int bananaprice = 7;

            Console.WriteLine("limon fiyatı:" + lemonprice);
            Console.WriteLine("domates fiyatı:" + tomatoprice);
            Console.WriteLine("muz fiyatı:" + bananaprice);

            int lemoncount = 3;
            int tomatocount = 4;
            int bananacount = 8;

            int totallemonprice = lemoncount * lemonprice;




            Console.WriteLine("limon tutarı:" + totallemonprice);
            Console.WriteLine("---------------------");



            int tomatoprice = 4;

            int tomatocount = 5;

            int totaltomatoprice = tomatocount * tomatoprice;
            Console.WriteLine("tomates ücreti:" + totaltomatoprice);

            Console.WriteLine("araba özelleştirme uygulaması");

            int carbag = 5000;
            int carwhell = 6000;
            int carshell = 7000;

            Console.WriteLine("araba cantası ücreti:" + carbag + "tl");
            Console.WriteLine("araba lastik ücreti:" + carwhell + "tl");
            Console.WriteLine("araba sheli ücreti:" + carshell + "tl");
            int totalcarprice = carshell + carbag;
            Console.WriteLine("sectiginiz ürünlerin ücreti:" + totalcarprice + "tl");

            int tomatoprice = 50;
            int patatoprice = 60;
            int lemonprice = 70;
            int juiceprice = 80;
            int honeyprice = 90;
            Console.WriteLine("market fiyatları:");
            Console.WriteLine("domates fiyatı:" + tomatoprice);
            Console.WriteLine("patates fiyatı:" + patatoprice);
            Console.WriteLine("limon fiyatı:" + lemonprice);
            Console.WriteLine("meyve suyu fiyatı:" + juiceprice);
            Console.WriteLine("bal fiyatı:" + honeyprice);

            int tomatocount = 5;
            int patatocount = 6;
            int lemoncount = 8;
            int juicecount = 9;
            int honeycount = 10;

            int totalbagtomato = tomatoprice * tomatocount;
            int totalbagpatato = patatoprice * patatocount;
            Console.WriteLine("tomates ücretiniz:" + totalbagtomato);

            // 2 derssssssss baslangıcııııı

            Console.WriteLine("------- fiyat listesi ------");
            Console.WriteLine();

            double appleprice, orangeprica, cilekprice, patatoprice, domatoprice;

            appleprice = 14.85;
            orangeprica = 20.95;
            cilekprice = 45;
            patatoprice = 9.74;
            domatoprice = 6.88;
            Console.WriteLine("elma birim fiyatı:" + appleprice + "tl");
            Console.WriteLine("portakal birim fiyatı:" + orangeprica + "tl");
            Console.WriteLine("cilek birim fiyatı:" + cilekprice + "tl");
            Console.WriteLine(" patates birim fiyatı:" + patatoprice + "tl");
            Console.WriteLine("domates birim fiyatı:" + domatoprice + "tl");

            double applegram, orangegram, cilekgram, patatogram, domatogram;
            applegram = 1.245;
            orangegram = 2.650;
            cilekgram = 0.750;
            patatogram = 4.859;
            domatogram = 3.745;
            double totalappleprice = appleprice * applegram;
            double totalorrangeprice = orangeprica * orangegram;
            double totalcilerprice = cilekprice * cilekgram;
            double totalpatatoprice = patatoprice * patatogram;
            double totaldomatoprice = domatogram * domatoprice;


            Console.WriteLine("alınan ürün:elma - birim fiyat" + appleprice + "grmajı" + applegram + "toplam tutar" + totalappleprice + "tl");
            Console.WriteLine("alınan ürün:portakal -  birim fiyat:" + orangeprica + "gramajı" + applegram + "toplam tutar" + totalorrangeprice + "tl");
            Console.WriteLine("alınan ürün :cilek - birim fiyatı:" + cilekprice + "gramjı" + cilekgram + "toplam tutar" + totalcilerprice + "tl");
            Console.WriteLine("alınan ürün :patates - birim fiyat:" + patatoprice + "gramajı" + patatogram + "toplam tutar" + totalpatatoprice + "tl");
            Console.WriteLine("alınan ürün : domates - birim fiyat:" + domatoprice + "gramjı" + domatogram + "toplam tutar" + totaldomatoprice + "tl");
            double totalshopping = totaldomatoprice + totalappleprice + totalorrangeprice + totalpatatoprice + totalcilerprice;
            Console.WriteLine("topla alişveriş tutarı:" + totalshopping + "tl");

            sring passengername, passengersurname;
            Console.Write("yolcu adı : ");
            passengername = Console.ReadLine();
            Console.WriteLine();
            Console.Write("yolcu soyadı :");
            passengersurname = Console.ReadLine();
            Console.WriteLine("------------------------------");

            Console.WriteLine("yolcu ad : " + passengername + "yolcu soyad : " + passengersurname);


            Console.WriteLine("5 dakikada kimliginizi oluşturun :");
            string passengername, passengersurname, passengerdate, passengercity, passengermothername, passengerfathername, passengertc;


            Console.Write("yolcu adı : ");
            passengername = Console.ReadLine();
            Console.WriteLine();
            Console.Write("yolcu soyadı:");
            passengersurname = Console.ReadLine();
            Console.WriteLine();
            Console.Write("yolcu dogum tarihi :");
            passengerdate = Console.ReadLine();
            Console.WriteLine();
            Console.Write("yolcu dogdugu şehir :");
            passengercity = Console.ReadLine();
            Console.WriteLine();
            Console.Write("yolcu anne adı :");
            passengermothername = Console.ReadLine();
            Console.WriteLine();
            Console.Write("yolcu baba adı :");
            passengerfathername = Console.ReadLine();
            Console.WriteLine();
            Console.Write("yolcu tc kimlik numarası :");
            passengertc = Console.ReadLine();

            Console.WriteLine("yolcu adı : " + passengername + " " + "yolcu soyadı :" + passengersurname + " " + "yolcu dogum tarihi :" + passengerdate + " " + "yolcu dogdugu şehir :" + passengercity
                + " " + "yolcu anne adı :" + passengermothername + " " + "yolcu baba adı :" + passengerfathername + " " + "yolcu tc kimlik numarası : " + passengertc + "iyi yolculuklar");

            int shoesprice, computerprice, chairprice, tvprice;
            shoesprice = 5000;
            computerprice = 6000;
            chairprice = 7000;
            tvprice = 8000;
            int shoescount, computercount, chaircount, tvcount;
            Console.Write("lütfen aldıgınız ayakkabı sayısını giriniz :");
            shoescount = int.Parse(Console.ReadLine());
            Console.Write("lütfen aldıgınız bilgisayar sayısını giriniz :");
            computercount = int.Parse(Console.ReadLine());
            Console.Write("lütfen aldıgınız sandalye sayısını giriniz :");
            chaircount = int.Parse(Console.ReadLine());
            Console.Write("lütfen aldıgınız tv sayısını giriniz :");
            tvcount = int.Parse(Console.ReadLine());


            int totalprice = shoesprice * shoescount + computerprice * computercount + chairprice * chaircount + tvprice * tvcount;
            Console.WriteLine("toplam alişveriş tutarınız :" + totalprice + "tl");

            int exam1, exam2, exam3, results;
            Console.Write("lütfen 1 sınav notonu gir :");
            exam1 = int.Parse(Console.ReadLine());
            Console.Write("lütfen 2 sınav notu gir :");
            exam2 = int.Parse(Console.ReadLine());
            Console.Write("lütfen 3 sınav notu gir :");
            exam3 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            int totalresults = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine("sınav ortalamanız :" + totalresults);
            Console.WriteLine("basarılar");

            char gende;
            Console.Write("lütfen cinsiyetinizi giriniz :");
            gende = char.Parse(Console.ReadLine());
            Console.Write("cinsiyetiniz : " + gende);




            
 








            




            










































            Console.Read();

        }
    }
}
//yazdırma komutları