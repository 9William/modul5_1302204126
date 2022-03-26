using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302204126
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            //panggil object
            SayaTubeVideo f1 = new SayaTubeVideo("");
            SayaTubeVideo f2 = new SayaTubeVideo("Review Film Spedermen oleh Gerry William Mathew");
            SayaTubeVideo f3 = new SayaTubeVideo("Review Film Betmen oleh Gerry William Mathew Kurniawan");
            SayaTubeVideo f4 = new SayaTubeVideo("Review Film Spedermen2 oleh Gerry William Mathew Kurniawan");
            SayaTubeVideo f5 = new SayaTubeVideo("Review Film Betmen2 oleh Gerry William Mathew Kurniawan");
            SayaTubeVideo f6 = new SayaTubeVideo("Review Film Antmen oleh Gerry William Mathew Kurniawan");
            SayaTubeVideo f7 = new SayaTubeVideo("Review Film Wonderwomen oleh Gerry William Mathew Kurniawan");
            SayaTubeVideo f8 = new SayaTubeVideo("Review Film Sperdermen Yes Way oleh Gerry William Mathew Kurniawan");
            SayaTubeVideo f9 = new SayaTubeVideo("Review Film Betmen Black Knight oleh Gerry William Mathew Kurniawan");
            SayaTubeVideo f10 = new SayaTubeVideo("Review Film Toi Stori oleh Gerry William Mathew Kurniawan");
            SayaTubeUser ss = new SayaTubeUser("Gerry William");

            //menambahkan playcount dari setiap video
            f1.IncreasePlayCount(1);
            f2.IncreasePlayCount(3);
            f3.IncreasePlayCount(5);
            f4.IncreasePlayCount(7);
            f5.IncreasePlayCount(3);
            f6.IncreasePlayCount(3);
            f7.IncreasePlayCount(3);
            f8.IncreasePlayCount(3);
            f9.IncreasePlayCount(3);
            f10.IncreasePlayCount(3);

            //menambahkan ke video kedalam list user
            ss.AddVideo(f1);
            ss.AddVideo(f2);
            ss.AddVideo(f3);
            ss.AddVideo(f4);
            ss.AddVideo(f5);
            ss.AddVideo(f6);
            ss.AddVideo(f7);
            ss.AddVideo(f8);
            ss.AddVideo(f9);
            ss.AddVideo(f10);

            f1.PrintVideoDetails();
            f2.PrintVideoDetails();

            ss.PrintAllVideoPlaycount();
        }
    }
}
