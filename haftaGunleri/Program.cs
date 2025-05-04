namespace haftaGunleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 İLE 7 ARASINDA BİRSAYI GİRİNİZ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            switch (sayi)
            {
                case 1:
                    Console.WriteLine("pazartesi");
                    break;
                case 2:
                    Console.WriteLine("sali");
                    break;
                case 3:
                    Console.WriteLine("carsamba");
                    break;
                case 4:
                    Console.WriteLine("persembe");
                    break;
                case 5:
                    Console.WriteLine("cuma");
                    break;
                 case 6:
                    Console.WriteLine("cumartesi");
                    break;
                    case 7:
                    Console.WriteLine("pazar");
                    break;

                    default:

                    Console.WriteLine("lütfen 1 ile 7 arasında bir sayı giriniz");
                  break;







            }

            }
        }
    }
