using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Conversii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            string first_base = "";

            Console.WriteLine("\nSelectati o optiune din meniu: ");
            Console.WriteLine("\n1: Din baza 8 in baza 2");
            Console.WriteLine("\n2: Din baza 2 in baza 10");
            Console.WriteLine("\n3: Din baza 10 in baza 2");
            Console.WriteLine("\n4: Din baza 16 in baza 10");
            Console.WriteLine("\n5: Din baza 10 in baza 16");
            Console.WriteLine("\n6: Din baza 2 in baza 16");
            Console.WriteLine("\n7: Din baza 16 in baza 2");
            Console.WriteLine("\n0: Iesire\n");

            option = Convert.ToInt32(Console.ReadLine());
            string ins = "";

            while (option != 0)
            {


                switch (option)
                {
                    case 1:
                        {
                            Console.WriteLine("Inserati o valoare din baza 8 pentru a converti in baza 2: ");

                            first_base = Console.ReadLine();

                            for (int i = 0; i < first_base.Length; i++)
                            {
                                int t = int.Parse(first_base[i].ToString());
                                switch (t)
                                {
                                    case 0:
                                        {
                                            ins += "000";
                                            break;
                                        }
                                    case 1:
                                        {
                                            ins += "001";
                                            break;
                                        }
                                    case 2:
                                        {
                                            ins += "010";
                                            break;
                                        }
                                    case 3:
                                        {
                                            ins += "011";
                                            break;
                                        }
                                    case 4:
                                        {
                                            ins += "100";
                                            break;
                                        }
                                    case 5:
                                        {
                                            ins += "101";
                                            break;
                                        }
                                    case 6:
                                        {
                                            ins += "110";
                                            break;
                                        }
                                    case 7:
                                        {
                                            ins += "111";
                                            break;
                                        }
                                }

                            }
                            Console.WriteLine("Rezultatul este " + ins);
                            break;

                        }
                    case 2:
                        {
                            Console.WriteLine("Inserati o valoare din baza 2 pentru a converti in baza 10: ");

                            first_base = Console.ReadLine();

                            int result = 0;
                            for (int i = 0; i < first_base.Length; i++)
                            {

                                int t = int.Parse(first_base[i].ToString());


                                int power = 1;

                                for (int j = i; j < first_base.Length - 1; j++)

                                    power *= 2;


                                result += t * power;
                            }
                            Console.Write("Rezultatul este " + result);

                            Console.ReadKey();
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Inserati o valoare din baza 10 pentru a converti in baza 2: ");

                            first_base = Console.ReadLine();
                            string binary = Convert.ToString(int.Parse(first_base), 2);
                            Console.Write("Rezultatul este " + binary);
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Inserati o valoare din baza 16 pentru a converti in baza 10: ");

                            first_base = Console.ReadLine();

                            int result = 0;
                            for (int i = 0; i < first_base.Length; i++)
                            {
                                int t = int.Parse(first_base[i].ToString(), System.Globalization.NumberStyles.HexNumber);

                                int power = 1;

                                for (int j = i; j < first_base.Length - 1; j++)

                                    power *= 16;


                                result += t * power;
                            }
                            Console.WriteLine("Rezultatul este: " + result);

                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Inserati o valoare din baza 10 pentru a converti in baza 16: ");

                            first_base = Console.ReadLine();
                            string hexa = Convert.ToString(int.Parse(first_base), 16);
                            Console.WriteLine("Rezultatul este: " + hexa);
                        }
                        break;
                    case 6:
                        {
                            Console.WriteLine("Inserati o valoare din baza 2 pentru a converti in baza 16: ");

                            first_base = Console.ReadLine();



                            int result = 0;
                            for (int i = 0; i < first_base.Length; i++)
                            {

                                int t = int.Parse(first_base[i].ToString());


                                int power = 1;

                                for (int j = i; j < first_base.Length - 1; j++)

                                    power *= 2;


                                result += t * power;
                            }
                            string binary = Convert.ToString(result, 16);
                            Console.Write("Rezultatul este: " + binary);
                        }
                        break;

                    case 7:
                        {
                            ins = "";
                            Console.WriteLine("Inserati o valoare din baza 16 pentru a converti in baza 2: ");

                            first_base = Console.ReadLine();


                            for (int i = 0; i < first_base.Length; i++)
                            {

                                char t = first_base[i];
                                switch (t)
                                {
                                    case '0':
                                        {
                                            ins += "0000";


                                            break;
                                        }
                                    case '1':
                                        {

                                            ins += "0001";
                                            break;
                                        }
                                    case '2':
                                        {
                                            ins += "0010";
                                            break;
                                        }
                                    case '3':
                                        {
                                            ins += "0011";
                                            break;
                                        }
                                    case '4':
                                        {
                                            ins += "0100";
                                            break;
                                        }
                                    case '5':
                                        {
                                            ins += "0101";
                                            break;
                                        }
                                    case '6':
                                        {
                                            ins += "0110";
                                            break;
                                        }
                                    case '7':
                                        {
                                            ins += "0111";
                                            break;
                                        }
                                    case '8':
                                        {
                                            ins += "1000";
                                            break;
                                        }
                                    case '9':
                                        {
                                            ins += "1001";
                                            break;
                                        }
                                    case 'A':
                                    case 'a':
                                        {
                                            ins += "1010";
                                            break;
                                        }
                                    case 'B':
                                    case 'b':
                                        {
                                            ins += "1011";
                                            break;
                                        }
                                    case 'C':
                                    case 'c':
                                        {
                                            ins += "1100";
                                            break;
                                        }
                                    case 'D':
                                    case 'd':
                                        {
                                            ins += "1101";
                                            break;
                                        }
                                    case 'E':
                                    case 'e':
                                        {
                                            ins += "1110";
                                            break;
                                        }
                                    case 'F':
                                    case 'f':
                                        {
                                            ins += "1111";
                                            break;
                                        }
                                }

                            }
                            Console.Write("Rezultatul este: " + ins);
                            break;
                        }

                }
                Console.WriteLine("\nSelectati o optiune din meniu: ");
                option = int.Parse(Console.ReadLine());
            }
        }
    }
}
