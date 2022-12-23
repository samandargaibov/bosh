using System;

namespace ders1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  int saniye = 31600000;
            //  int gun;
            //  int saat;
            //  int deg;
            //  int san;

            //  gun = saniye / (24 * 60 * 60);  //365
            //  //saat = (saniye - gun * (24 * 60 * 60)) / (60 * 60);  //17
            //  saat = (saniye % (24 * 60 * 60)) / (60 * 60);
            //  //deg = (saniye - gun * 24 * 60 * 60 - saat * 60 * 60) / 60;     //46
            //  deg = ((saniye % 60 *60)) / 60;
            //  san = saniye % 60;  //40

            ////  Console.WriteLine(gun + " Gun," + saat + " saat," + deg + " deg," + san + " san");
            //  Console.WriteLine($"{gun} Gun {saat} saat {deg} deg {san} san");
            //  Console.WriteLine(" ");
            //  int d = 5 << 3;
            //  Console.WriteLine("d "+ d);


            //  Console.WriteLine("100 ile 200 arasi reqem daxil edin: ");
            //  int a = int.Parse(Console.ReadLine());
            //  Console.WriteLine("200 ile 300 arasi reqem daxil edin: ");
            //  int b = int.Parse(Console.ReadLine());

            //  if (a < 100 || a > 200)
            //  {
            //      Console.WriteLine("1-ci reqem yanlishdir!");
            //      return;

            //      /*if (a > b)
            //      {
            //          Console.WriteLine($"{a} boyukdur {b}-den");
            //      }
            //      else
            //      {
            //          Console.WriteLine($"{b} boyukdur {a}-dan");
            //      }*/
            //  }
            //  else {
            //      Console.WriteLine("Yanlish reqem");
            //  }

            //int i = 0;
            //while (i<10)
            //{
            //    if (i == 3 || i==7)
            //    {
            //        i++;
            //        continue;

            //    }

            //    Console.WriteLine(i++);

            //}

            //int a = int.Parse(Console.ReadLine());
            //int b;


            //b = a %10;
            //a = a / 10;

            //Console.WriteLine($"{a}+{b}");  

            //Console.Write("Ededi daxil edin: ");
            //int a = int.Parse(Console.ReadLine());
            //int sum = 0;

            //for (int i = 1; i <= a; i++)
            //{

            //    if (i%2==0 && i % 3 == 0)
            //    {
            //        sum+=i;


            //    }

            //}
            //Console.WriteLine(sum);

            Console.Write("1-ci ededi daxil edin: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("2-ci ededi daxil edin: ");
            int b = int.Parse(Console.ReadLine());
            int count=0;
            int sum = 0;


            //for (int i = a; i <= b; i++)
            //{
            //        count++;
            //        sum += i;

            //}
            //int i = a;

            //while (i <= b)
            //{
            //    count++;
            //    sum += i;
            //    i++;
            //}

            int i = a;

            do
            {
                count++;
                sum += i;
                i++;

            } while (i<=b);

            Console.WriteLine(count);
            Console.WriteLine(sum);
        }
        
    }
}
