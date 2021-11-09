using System;

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
        }

        void WybierzFuncja(string użytkownikOdpowiedz)
        {
            switch (użytkownikOdpowiedz)
            {
                case "A":
                    //Obliczenie średniej harmonicznej wyrazów ciągu liczboweg
                    break;
                case "B":
                    //Obliczenie średniej kwadratowej wyrazów ciągu liczbowego
                    break;
                case "C":
                    //Obliczenie średniej potęgowej (średniej uogólniej) wyrazów ciągu liczbowego
                    break;
                case "D":
                    //Obliczenie ceny jednostki paszy (według średniej ważonej
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
        }
    }
}
