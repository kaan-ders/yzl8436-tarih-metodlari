namespace TarihMetodlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime bugun = DateTime.Now;

            //DateTime dogumTarihi = new DateTime(1985, 1, 20);

            //var ts = bugun.Subtract(dogumTarihi);
            //Console.WriteLine(bugun.Subtract(dogumTarihi).TotalMilliseconds);

            //DateTime satinAlmaTarihi = new DateTime(2022, 11, 1);
            ////if(DateTime.Now >= satinAlmaTarihi.AddDays(10))
            //Console.WriteLine(satinAlmaTarihi.AddDays(10));

            //if (DateTime.Now <= satinAlmaTarihi.AddDays(10))
            //    Console.WriteLine("Garanti dolmadı");
            //else
            //    Console.WriteLine("Garanti doldu");

            Console.WriteLine(bugun);
            Console.WriteLine(bugun.Day + "." + bugun.Month + "." + bugun.Year);
            Console.WriteLine(bugun.ToShortDateString());
            Console.WriteLine(bugun.ToShortTimeString());

            Console.WriteLine(bugun.ToString("dd.MM.yyyy"));
            Console.WriteLine(bugun.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
}