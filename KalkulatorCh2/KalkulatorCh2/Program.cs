using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorChallenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULATOR CHALLENGE 2");
            Console.WriteLine("================================\n");
            int hasil = 0;                           
            Console.Write("Masukkan operasi hitung [berisi angka dan simbol] : ");
            string input = Console.ReadLine().Replace(" ","");

            if (input.Contains("="))
            {
                char[] simbol = { '+', '-', '*',':', '/' };
                int posisi = input.IndexOfAny(simbol);
                int posisiEquals = input.IndexOf('=');
                int x = input.Length - (posisi + 1) - 1;
                int pertama = Convert.ToInt32(input.Substring(0, posisi));
                int kedua = Convert.ToInt32(input.Substring(posisi + 1, x));
                char operasi = input[posisi];

                switch (operasi)
                {
                    case '+':
                        hasil = pertama + kedua;
                        Console.Write($"{pertama} {operasi} {kedua} = {hasil}");
                        break;
                    case '-':
                        hasil = pertama - kedua;
                        Console.Write($"{pertama} {operasi} {kedua} = {hasil}");
                        break;
                    case '*':
                        hasil = pertama * kedua;
                        Console.Write($"{pertama} {operasi} {kedua} = {hasil}");
                        break;
                    case '/':
                    case ':':
                        hasil = pertama / kedua;
                        Console.Write($"{pertama} {operasi} {kedua} = {hasil}");
                        break;
                    default:
                        Console.Write("\nPilihan anda tidak tersedia");
                        break;
                }
                
                while (true)
                {
                    string lanjut = Console.ReadLine();
                    string[] Lanjut = lanjut.Split(simbol);
                    int tempat = lanjut.IndexOfAny(simbol);
                    char Operasi = lanjut[tempat];
                    
                        switch (Operasi)
                        {
                            case '+':
                                int num2 = int.Parse(Lanjut[1]);
                                int hasil1 = hasil;
                                hasil = hasil1 + num2;
                                Console.WriteLine($"{hasil1} {Operasi} {num2} = {hasil}");
                                Console.Write($"{hasil}");
                                break;
                            case '-':
                                num2 = int.Parse(Lanjut[1]);
                                hasil1 = hasil;
                                hasil = hasil1 - num2;
                                Console.WriteLine($"{hasil1} {Operasi} {num2} = {hasil}");
                                Console.Write($"{hasil}");
                                break;
                            case '*':
                                num2 = int.Parse(Lanjut[1]);
                                hasil1 = hasil;
                                hasil = hasil1 * num2;
                                Console.WriteLine($"{hasil1} {Operasi} {num2} = {hasil}");
                                Console.Write($"{hasil}");
                                break;
                        case '/':
                            case ':':
                                num2 = int.Parse(Lanjut[1]);
                                hasil1 = hasil;
                                hasil = hasil1 / num2;
                                Console.WriteLine($"{hasil1} {Operasi} {num2} = {hasil}");
                                Console.Write($"{hasil}");
                                break;
                        default:
                                Console.Write("\nPilihan anda tidak tersedia");
                                break;
                        }                    
                }
            }
            else
            {
                Console.Write("Operasi tidak valid karena tidak ada tanda = ");
            }
        }
    }
}