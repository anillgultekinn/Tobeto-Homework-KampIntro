using System.Collections.Generic;

namespace Koleksiyonlar
{
    public class Program
    {
        static void Main(string[] args)
        {
            //dizileri genişletemiyoruz  
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" }; // 4 elemanlı bir array tanımladığımız zaman 5 elemanlı yapamıyoruz
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];   //new dediğimiz için bellekte yeni bir adres oluşturduk (5 elemanlı boş bir array) o yüzden 0,1,2,3 boş 
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);


            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

        }
    }

}