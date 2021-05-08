using System;

namespace _2thConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string umumisecim;
            do
            {
            menuhissesi:
                Console.WriteLine("\n====================================================");
                Console.WriteLine("1 - Menyu uzerinde emeliyyat aparamaq");
                Console.WriteLine("2 - Sifarisler uzerinde emeliyyat aparmaq");
                Console.WriteLine("3 - Sistemden cixmaq");
                Console.WriteLine("=====================================================\n");
                Console.Write("Seciminizi edin: ");
                umumisecim = Console.ReadLine();
                if (umumisecim == "1")
                {
                    string menu;
                    do
                    {
                        Console.WriteLine("\n--------------------------------------------------");
                        Console.WriteLine("1 - Yeni item elave etmek");
                        Console.WriteLine("2 - Item uzerinde duselis etmek");
                        Console.WriteLine("3 - Item silmek");
                        Console.WriteLine("4 - Butun item-lari gostermek");
                        Console.WriteLine("5 - Categoriyasina gore menu item-lari gostermek");
                        Console.WriteLine("6 - Qiymet araligina gore menu item-lari gostermek");
                        Console.WriteLine("7 - Menu item-lar arasinda ada gore axtaris etmek");
                        Console.WriteLine("0 - Evvelki menyuya qayitmaq");
                        Console.WriteLine("--------------------------------------------------\n");
                        Console.Write("Menyu uzerinde hansi prosesi icra etmek isteyirsiz? - ");
                        menu = Console.ReadLine();
                        if (menu=="1")
                        {

                        }
                        else if (menu == "2")
                        {

                        }
                        else if (menu == "3")
                        {

                        }
                        else if (menu == "4")
                        {

                        }
                        else if (menu == "5")
                        {

                        }
                        else if (menu == "6")
                        {

                        }
                        else if (menu == "7")
                        {

                        }
                        else if (menu == "0")
                        {
                            goto menuhissesi;
                        }
                        else
                        {
                            Console.WriteLine("\nMenyu uzerinde duzgun secim etmediz");
                        }

                    } while (menu!="1" && menu != "2" && menu != "3" && menu != "4" && menu != "5" && menu != "6" && menu != "7" && menu != "0");


                }
                else if (umumisecim == "2")
                {
                    string sifaris;

                    do
                    {
                        Console.WriteLine("\n**************************************************");
                        Console.WriteLine("1 - Yeni sifaris elave etmek");
                        Console.WriteLine("2 - Sifarisi legv etmek");
                        Console.WriteLine("3 - Butun sifarisleri gostermek");
                        Console.WriteLine("4 - Verilen tarix araligina gore sifarisleri gostermek");
                        Console.WriteLine("5 - Verilen mebleg araligina gore sifarisleri gostermek");
                        Console.WriteLine("6 - Verilmis bir tarixde olan sifarislerin gosterilmesi");
                        Console.WriteLine("7 - Verilmis nomreye esasen hemin nomreli sifarisi gostermek");
                        Console.WriteLine("0 - Evvelki menyuya qayitmaq");
                        Console.WriteLine("**************************************************\n");
                        Console.Write("Sifarisler uzerinde hansi prosesi icra etmek isterdiz? - ");
                        sifaris = Console.ReadLine();
                        if (sifaris == "1")
                        {

                        }
                        else if (sifaris == "2")
                        {

                        }
                        else if (sifaris == "3")
                        {

                        }
                        else if (sifaris == "4")
                        {

                        }
                        else if (sifaris == "5")
                        {

                        }
                        else if (sifaris == "6")
                        {

                        }
                        else if (sifaris == "7")
                        {

                        }
                        else if (sifaris == "0")
                        {
                            goto menuhissesi;
                        }
                        else
                        {
                            Console.WriteLine("\nSifaris uzerinde duzgun secim etmediz");
                        }

                    } while (true);


                }
                else if (umumisecim == "3")
                {
                    Console.WriteLine("Proses sonlandirildi");
                    return;
                }
                else if (umumisecim != "1" && umumisecim != "2" && umumisecim != "3")
                {
                    Console.WriteLine("\nDuzgun secim edin");
                }
            } while (umumisecim!="1" && umumisecim != "2" && umumisecim != "3");




        }
    }
}
