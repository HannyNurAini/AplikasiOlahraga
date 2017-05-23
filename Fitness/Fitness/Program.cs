using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness
{
    class Program
    {
        static void Main(string[] args)
        {
            //inisiasi 
            string input;
            int total=0;

            // Looping
            while(true)
            {
                try //kaya buat ngecek dulu coding kita di try ini, kalo ada error baru dilempar dan ditangkap di catch dgn ngeluarin langsung perintah yang dicatch, kita pake ini untuk ngatasin inputan string aneh dari user, inputan minus bukan error krn kalo kita g pake if juga dianggap bukan error tp jadi pengurangan
                {
                    // keluarkan pertanyaan
                    Console.WriteLine("Berapa lama kamu berolahraga?");

                    // minta input dari user
                    input = Console.ReadLine();

                    // keluar bila user masukin "quit"
                    if (input.ToLower() == "quit")
                    {
                        break;
                    }

                    // jika input aneh
                    if (Int32.Parse(input) < 0)
                    {
                        Console.WriteLine("Jangan masukin nilai minus.");
                        continue;
                    }
                    // menambahkan inputnya
                    total = total + Int32.Parse(input);

                    // ngeluarin inputnya
                    Console.WriteLine("Selamat, Anda sudah " + total + " menit" + " berolahraga");
                }
                catch(Exception) //try cuma 1, catch bisa banyak dari yang spesifik ke umum. Yang paling umum namanya exception atau bisa juga format exception
                {
                    Console.WriteLine("Masukin yang bener!");
                    continue;
                }              
                               
            }
        }
    }
}
