using System;
using System.ComponentModel.Design;
using System.IO;
using System.Net.Http.Headers;
using System.Threading;

namespace ConsoleApp4
{

    class Televizyon
    {
        public int maxVolume = 100;
        public int volume = 30;
        public int maxChannel = 0;
        public int channel = 1;
        public bool tvStatus = false;
        public string tvStatusScreen = "--";

        Random rnd = new Random();
        public void volumeUp()
        {
            Console.Clear();
            if (tvStatus == true)
            {
                if (volume < maxVolume)
                {
                    volume++;
                    Console.WriteLine($"\nSes Seviyesi Arttırıldı... \nSes Seviyesi : {volume}");
                }
                else
                {
                    Console.WriteLine("\nEn Yüksek Ses Seviyesindesiniz !");
                }
            }

            else
            {
                Console.WriteLine("\nLütfen İlk Önce Televizyonu Açınız !");
            }
        }

        public void volumeDown()
        {
            Console.Clear();
            if (tvStatus == true)
            {
                if (volume > -1)
                {
                    volume--;
                    Console.WriteLine($"\nSes Seviyesi Azaltıldı... \nSes Seviyesi : {volume}");
                }
                else
                {
                    Console.WriteLine("\nEn Düşük Ses Seviyesindesiniz !");
                }
            }

            else
            {
                Console.WriteLine("\nLütfen İlk Önce Televizyonu Açınız !");
            }
        }

        public void volumeChange(int volumeChange)
        {
            Console.Clear();
            if (tvStatus == true)
            {
                if (volumeChange > 0 && volumeChange < maxVolume)
                {
                    volume = volumeChange;
                }
                else
                {
                    Console.WriteLine("\nSes Seviyesinin Sınırlarını Aşıyorsunuz !");
                }
            }

            else
            {
                Console.WriteLine("\nLütfen İlk Önce Televizyonu Açınız !");
            }
        }

        public void channelScan()
        {
            Console.Clear();
            if (tvStatus == true)
            {
                maxChannel = rnd.Next(100, 150);
                for (int i = 0; i <= maxChannel; i++)
                {
                    Console.Clear();
                    Thread.Sleep(50);
                    Console.WriteLine($"Taranılıyor... \n{i} Tane Kanal Bulundu...");
                }
                Console.Clear();
                Console.WriteLine($"\nKanal Tarama Başarıyla Tamamlandı. \nToplam {maxChannel} Tane Kanal Bulundu.");
            }
            else
            {
                Console.WriteLine("\nLütfen İlk Önce Televizyonu Açınız !");
            }
        }

        public void channelChange(int channelChange)
        {
            Console.Clear();
            if (tvStatus == true)
            {
                if (channelChange > 0 && channelChange < maxChannel)
                {
                    channel = channelChange;
                }
                else
                {
                    Console.WriteLine("\nKanal Listesinin Sınırlarını Aşıyorsunuz !");
                }
            }

            else
            {
                Console.WriteLine("\nLütfen İlk Önce Televizyonu Açınız !");
            }
        }
        public void channelDown()
        {
            Console.Clear();
            if (tvStatus == true)
            {
                if (channel > 0)
                {
                    channel--;
                    Console.WriteLine($"\nKanal Değiştirildi... \nKanal Numarası : {channel}");
                }
                else
                {
                    Console.WriteLine("\nİlk Kanala Ulaştınız !");
                }
            }

            else
            {
                Console.WriteLine("\nLütfen İlk Önce Televizyonu Açınız !");
            }
        }

        public void channelUp()
        {
            Console.Clear();
            if (tvStatus == true)
            {
                if (channel < maxChannel)
                {
                    channel++;
                    Console.WriteLine($"\nKanal Değiştirildi... \nKanal Numarası : {channel}");
                }
                else
                {
                    Console.WriteLine("\nSon Kanala Ulaştınız !");
                }
            }

            else
            {
                Console.WriteLine("\nLütfen İlk Önce Televizyonu Açınız !");
            }
        }

        public void openTelevision()
        {
            if(tvStatus == false)
            {
                tvStatus = true;
                tvStatusScreen = "**";
            }
            else
            {
                Console.WriteLine("Televizyon Zaten Açık");
            }
        }

        public void closeTelevision()
        {
            if (tvStatus == true)
            {
                tvStatus = false;
                tvStatusScreen = "--";
            }
            else
            {
                Console.WriteLine("Televizyon Zaten Kapalı");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int secim, secim2;
            Televizyon kumanda1 = new Televizyon();
            while(true)
            {   sec:
                Console.Clear();
                Console.WriteLine($"--------------------------------------------------------------");
                Console.WriteLine($"|                                                            |");
                Console.WriteLine($"|                                                            |");
                Console.WriteLine($"|                                                            |");
                Console.WriteLine($"|                                                            |");
                Console.WriteLine($"|                                                            |");
                Console.WriteLine($"|                                                            |");
                Console.WriteLine($"|  Ses : {kumanda1.volume}                                     Kanal : {kumanda1.channel}    |");
                Console.WriteLine($"|                                                            |");
                Console.WriteLine($"|                                                            |");
                Console.WriteLine($"|                                                            |");
                Console.WriteLine($"|                                                            |");
                Console.WriteLine($"|                                                            |");
                Console.WriteLine($"|                                                            |");
                Console.WriteLine($"-------------------------    Bosh   ----------------------{kumanda1.tvStatusScreen}--");
                Console.WriteLine($"--------------------------------------------------------------");
                Console.WriteLine($"\nMenüye Bakmak İçin 3'e Basınız.");

                try
                {
                    secim = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Lütfen Doğru Şekilde Seçim Yapınız !");
                    Thread.Sleep(2000);
                    goto sec;
                }

                if (secim == 3)
                {
                menu:
                    Console.Clear();
                    Console.WriteLine("--------------Menü--------------");
                    Console.WriteLine("| 1 - Televizyonu Aç           |");
                    Console.WriteLine("| 2 - Televizyonu Kapat        |");
                    Console.WriteLine("| 3 - Kanal Tarama             |");
                    Console.WriteLine("| 4 - Kanal Seç                |");
                    Console.WriteLine("| 5 - Yukarı Kanal             |");
                    Console.WriteLine("| 6 - Aşağı Kanal              |");
                    Console.WriteLine("| 7 - Ses Sesviyesi Seç        |");
                    Console.WriteLine("| 8 - Sesi Yükselt             |");
                    Console.WriteLine("| 9 - Sesi Azalt               |");
                    Console.WriteLine("--------------------------------");
                    Console.Write("Seçim Yapınız : ");
                    try
                    {
                        secim2 = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Lütfen Doğru Şekilde Seçim Yapınız !");
                        Thread.Sleep(2000);
                        goto menu;
                    }

                    switch(secim2)
                    {
                        case 1:
                            kumanda1.openTelevision();
                            break;
                        case 2:
                            kumanda1.closeTelevision();
                            break;
                        case 3:
                            kumanda1.channelScan();
                            break;
                        case 4:
                            Console.Write("Gitmek İstediğiniz Kanal Numarası : ");
                            int kanalno = Convert.ToInt32(Console.ReadLine());
                            kumanda1.channelChange(kanalno);
                            break;
                        case 5:
                            kumanda1.channelUp();
                            break;
                        case 6:
                            kumanda1.channelDown();
                            break;
                        case 7:
                            Console.Write("Ayarlamak İstediğiniz Ses Seviyesi : ");
                            int ses = Convert.ToInt32(Console.ReadLine());
                            kumanda1.volumeChange(ses);
                            break;
                        case 8:
                            kumanda1.volumeUp();
                            break;
                        case 9:
                            kumanda1.volumeDown();
                            break;
                    }
                }

                else
                {
                    Console.WriteLine("Lütfen Doğru Seçim Yapınız !");
                    Thread.Sleep(2000);
                    goto sec;
                }

                Console.Write("Devam Etmek İçin Herhangi Bir Tuşa Basınız...");
                Console.ReadKey();
            }
        }
    }
}