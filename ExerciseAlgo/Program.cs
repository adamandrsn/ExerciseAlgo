using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseAlgo
{
    class Program
    {
       
        //Deklarasi array int dengan ukuran 2 nim belakang +10+20+20-2x15
        private int[] adam = new int[55];

        //Deklarasi variabel int untuk menyimpan banyaknya data pada array
        private int n;

        //Fungsi / Method untuk menerima masukan
        public void read()
        {
            //Menerima angka untuk menentukan banyaknya data yang disimpan pada array
            while (true)
            {
                Console.Write("Exercise Adam------------");
                Console.Write("Masukkan banyaknya elemen pada Array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 55)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 55 elemen.\n");

            }
            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine("Masukkan Elemen array");
            Console.WriteLine("---------------------");

            //Pengguna memasukkan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + "> ");
                string s1 = Console.ReadLine();
                adam[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            //Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Elemen array yang telah tersusun");
            Console.WriteLine("--------------------------------");
            for (int AY = 0 ; AY < n; AY++)
            {
                Console.WriteLine(adam[AY]);
            }
            Console.WriteLine("");
        }
        public void BubbleSortArray()
        {
            for (int i = 0; i < n; i++) //For n - 1 passes
            {
                // Pada pass i, bandingkan n - i elemen pertama dengan elemen selanjutnya
                
                for (int AY = n-2 ; AY < n - i; AY++)
                {
                    if (adam[AY] > adam[AY + i])    //Jika elemen tidak dalam urutan yang benar
                    {
                        //Tukar Elemen
                        int temp;
                        temp = adam[AY];
                        adam[AY] = adam[i];
                        adam[i] = temp;

                     
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //Creating the object of the BubbleSort class
            Program myList = new Program();
            //Pemanggilan fungsi untuk menerima elemen array
            myList.read();
            //Pemanggilan fungsi untuk mengurutkan array
            myList.BubbleSortArray();
            //Pemanggilan fungsi untuk menampilkan array yang tersusun
            myList.display();
            //exit
            Console.WriteLine("\n\nTekan Tombol Apa Saja Untuk Keluar.");
            Console.Read();
        }
    }
}
