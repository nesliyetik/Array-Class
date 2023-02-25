using System;

namespace diziarraysinifimetodlari
{
    
    class Program
    {
        static void Main (string[] args)

        {
            //sort
            int[] sayiDizisi = {23,12,4,86,72,3,11,17};
            
            Console.WriteLine("*****Sırasız Dizi*****");
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            Console.WriteLine("*****Sıralı Dizi*****");
            Array.Sort(sayiDizisi);

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //clear
            Console.WriteLine("*****Array Clear*****");
            //sayi dizisi elemanlarını kullanarak 2.indexten başlayarak 2 tane elemanı 0'lar.
            Array.Clear(sayiDizisi,2,2);

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //reverse
            Console.WriteLine("*****Array Reverse*****");
            Array.Reverse(sayiDizisi);

             foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //indexOf
            Console.WriteLine("*****Array indexOf*****");
            
            Console.WriteLine(Array.IndexOf(sayiDizisi,23));

            //resize
            Console.WriteLine("****Array Resize****");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8] = 98;
            
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
        
        }

    }

}