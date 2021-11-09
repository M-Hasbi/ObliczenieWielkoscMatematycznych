using System;
using System.Collections.Generic;
using System.Linq;

namespace ObliczenieWielkoscMatematycznych
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program 'Obliczeniewielkoscimatematycznych' umożliwa wielokrotne obliczenie wartosci " +
                "wybranych wielkosci matematycznych");
            Console.WriteLine("\n\nMenu funcjonalne programu :");
            Console.WriteLine("\nA: Obliczenie średniej harmonicznej wyrazów ciągu liczbowego");
            Console.WriteLine("\nB: Obliczenie średniej kwadratowej wyrazów ciągu liczbowego");
            Console.WriteLine("\nC: Obliczenie średniej potęgowej (średniej uogólniej) wyrazów ciągu liczbowego");
            Console.WriteLine("\nD: Obliczenie ceny jednostki paszy (według średniej ważonej)");
            Console.WriteLine("\nE: Obliczenie wartości wielomianu N-tego stopnia");
            Console.WriteLine("\nF: Konwersja znakowego zapisu liczby stałopozycynej na liczbę zapisaną znakowo " +
                "w innym systemie liczbowym (też podanym przez użytkownika programu)");
            Console.WriteLine("\nX: Zakończenie (wyjście z) programu");
            Console.WriteLine("\n\nNaciśnięciem odpowiedniego klawisza wybierz jedną z oferowanych funkcjonalności");
            string użytkownikOdpowiedz = Console.ReadLine();
            switch (użytkownikOdpowiedz)
            {
                case "A":
                    //Obliczenie średniej harmonicznej wyrazów ciągu liczbowego
                    ObliczenieSredniejHarmonicznej();
                    break;
                case "B":
                    //Obliczenie średniej kwadratowej wyrazów ciągu liczbowego
                    ObliczenieŚredniejKwadratowej();
                    break;
                case "C":
                    //Obliczenie średniej potęgowej (średniej uogólniej) wyrazów ciągu liczbowego
                    break;
                case "D":
                    //Obliczenie ceny jednostki paszy (według średniej ważonej)
                    ObliczenieJednostkiPaszy();
                    break;
                case "E":
                    //Obliczenie wartości wielomianu N-tego stopnia
                    break;
                case "F":
                    //Konwersja znakowego zapisu liczby stałopozycynej na liczbę zapisaną znakowo
                    //w innym systemie liczbowym (też podanym przez użytkownika programu)
                    break;
                case "X":
                    //Zakończenie (wyjście z) programu
                    break;
            }

            void ObliczenieSredniejHarmonicznej()
            {
                int n; //liczność ciągu liczbowego
                float a = 0;
                float Suma = 0.0f;
                float MianownikHar;

                Console.WriteLine("\nObliczamy średnią harmoniczną wyrazów ciągu liczbowego");

                do
                {
                    Console.WriteLine("Podaj liczność ciągu liczbowego n: ");
                    while (!int.TryParse(Console.ReadLine(), out n))
                    {
                        Console.WriteLine("\n\tERROR w zapisie liczby n wystąpił" + " niedozwolony znak");
                        Console.Write("\n\tPodaj wartość n jeszcze raz!: ");
                    }
                    if (n <= 0)
                    {
                        Console.WriteLine("\n\tLiczba n musi być większa od 0!");
                        Console.Write("\n\tPodaj wartość n jeszcze raz!: ");
                    }
                    for (int i = 1; i <= n; i++)
                    {
                        Console.Write("\n\tPodaj {0} -ą wartość wyrazu ciągu liczbowego: ", i);
                        while (!float.TryParse(Console.ReadLine(), out a))
                        {
                            Console.WriteLine("\n\tERROR w zapisie {0} -go wyrazu ciągu liczbowego" + " wystąpił niedozowolony\n\t\t znak", i);
                            Console.Write("\n\tPodaj wartość wyrazu ciągu liczbowego jeszcze raz!: ");
                        }
                        Suma = Suma + a;

                    }

                } while (n <= 0);

                MianownikHar = (1 / (float)a + (1 / (float)a));
                float ŚredniaHarmoniczna;
                ŚredniaHarmoniczna = ((float)n / MianownikHar);
                string KomunikatWynikHar;
                KomunikatWynikHar = String.Format("\n\n\tŚrednia harmoniczna " + "{0} wyrazów ciągu liczbowego jest równa: {1,6:F3}", n, ŚredniaHarmoniczna);
                Console.WriteLine(KomunikatWynikHar);
                Console.WriteLine("Dla kontynuacji działa programu naciśnij dowolny klawisz...");
                Console.ReadKey();
            }

            void ObliczenieŚredniejKwadratowej()
            {

                int db_n;
                float db_wynik;
                float db_a, db_D, db_S = 0.0f;
                Console.WriteLine("\n\tObliczenie średniej kwadratowej wyrazów ciągu liczbowego");

                do  //dla zapewnienia spełnienia warunku wejściowego dla n, n>0
                {   //wczytanie wartości n
                    Console.Write("\n\tPodaj wartość (liczbę) n: ");
                    while (!int.TryParse(Console.ReadLine(), out db_n))
                    {
                        Console.WriteLine("\n\tERROR: w zapisie liczby n wystąpił niedozwolony znak");
                        Console.Write("\n\tPodaj wartość n jeszcze raz, ale uważaj, co piszesz.");
                    }

                    //sprawdzenie warunku wejściowego
                    if (db_n <= 0)
                    {
                        Console.WriteLine("\n\tERROR: liczba musi być > 0");
                        Console.Write("\n\tPodaj wartość n jeszcze raz, ale uważaj, co piszesz.");
                    }
                } while (db_n <= 0); /* gdy warunek n <= 0 przyjmie wartość true, 
                                 to nastąpi powtórzenie wartości n */

                //obliczenie sumy wyrazów ciągu liczbowego
                for (int db_i = 1; db_i <= db_n; db_i++)
                {
                    Console.Write("\n\tPodaj {0}-ą wartość ciągu liczbowego: ", db_i);
                    while (!float.TryParse(Console.ReadLine(), out db_a))
                    {
                        Console.WriteLine("\n\tERROR: w zapisie {0}-go wyrazu ciągu liczbowego"
                            + "wystąpił niedozwolony \n\t\t znak", db_i);
                        Console.Write("\n\tPodaj wartość wyrazu ciągu liczbowego jeszcze raz,"
                            + "ale uważaj\n\t co piszesz: ");

                    }
                    /*w tym miejscu wartość wyrazu a jest "poprawna"
                     * obliczenie wyniku ze wzoru na średnią kwadratową */
                    db_S = (float)Math.Pow(db_S, 2) + (float)Math.Pow(db_a, 2); //sumowanie licznika

                }

                db_D = db_S / db_n;     //podzielenie licznika przez n
                db_wynik = (float)Math.Sqrt(db_D);  //pierwiastek kw. z otrzymanej liczby
                Console.WriteLine("\n\tŚrednia kwadratowa podanych wyrazów jest równa {0,6:F3}", db_wynik);
                Console.WriteLine("\n\tDla kontynuacji programu naciśnij dowolny klawisz");
                Console.ReadKey();

            }

            void ObliczenieJednostkiPaszy()
            {
                Console.WriteLine("");
                Console.WriteLine("Ile kilo żyta: ");
                float a, b, kg, kg1;
                double suma;

                while (!float.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz.");
                }
                Console.WriteLine("Podaj cenę za kilo: ");

                while (!float.TryParse(Console.ReadLine(), out kg))
                {
                    Console.WriteLine("Ile kilo przenicy: ");
                }

                while (!float.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz.");
                }
                Console.WriteLine("Podaj cenę za kilo: ");

                while (!float.TryParse(Console.ReadLine(), out kg1))
                {
                    Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz.");
                }

                suma = (a * kg) + (b * kg1) / (kg + kg1);
                Console.WriteLine("Wynik " + suma);
            }

            void ObliczeniewartościwielomianuNtegostopnia()
            {
            }
        }
    }
}
