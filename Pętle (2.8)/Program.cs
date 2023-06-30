namespace Pętle__2._8_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("=============== Pętle ==============");
                Console.WriteLine("Wybierz zadanie 1-10 albo 11.Wyjście");
                string operation = Console.ReadLine();
                switch (operation)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Zadanie 1 - Sprawdź ile jest liczb pierwszych w zakresie 0 - 100" + "\n");
                        int start = 0;
                        int end = 100;
                        int count = 0;

                        for (int number = start; number <= end; number++)
                        {
                            if (IsPrime(number))
                            {
                                count++;
                            }
                        }

                        Console.WriteLine("Liczba liczb pierwszych w zakresie {0} - {1} wynosi: {2}", start, end, count + "\n");
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Zadanie 2 - Sprawdż ile jest liczb parzystych w zakresie 0 - 1000 za pomocą pętli Do...While" + "\n");
                        int start1 = 0;
                        int end1 = 1000;
                        int number1 = start1;
                        int count1 = 0;

                        Console.WriteLine("Liczby parzyste w zakresie {0} - {1}:", start1, end1 + "\n");

                        do
                        {
                            if (number1 % 2 == 0)
                            {
                                Console.WriteLine(number1);
                                count1++;
                            }
                            number1++;
                        }
                        while (number1 <= end1);
                         Console.WriteLine("Liczba liczb parzystych w zakresie {0} - {1}: {2}", start1, end1, count1 + "\n");
                        Console.WriteLine();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Zadanie 3 -Program który zaimplementuje ciąg Fibonacciego i wyświetli go na ekranie ");
                        Console.Write("Wprowadź liczbę: ");
                        int n = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ciąg Fibonacciego dla n = {0}:", n);

                        int[] fibonacci = GenerateFibonacciSequence(n);

                        foreach (int number in fibonacci)
                        {
                            Console.WriteLine(number);
                        }
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Zadanie 4 - Po podaniu liczby całkowitej, wyświetli piramidę liczb od 1 do podanej liczby");
                        Console.Write("Podaj liczbę całkowitą: ");
                        int n1 = int.Parse(Console.ReadLine());

                        int currentNumber = 1;
                        int numbersInRow = 1;

                        for (int row = 1; row <= n1; row++)
                        {
                            for (int i = 0; i < numbersInRow; i++)
                            {
                                Console.Write(currentNumber + " ");
                                currentNumber++;

                                if (currentNumber > n1)
                                {
                                    break;
                                }
                            }

                            Console.WriteLine();
                            numbersInRow++;

                            if (currentNumber > n1)
                            {
                                break;
                            }
                        }
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Zadanie 5 -Program który wyświetli 3 potęgę liczb od 1 do 20  ");
                        for (int i = 1; i <= 20; i++)
                        {
                            int result = CalculateCube(i);
                            Console.WriteLine("Liczba: {0}, Trzecia potęga: {1}", i, result);
                        }
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("Zadanie 6 - Napisz program, który dla liczb od 0 do 20 obliczy sumę wg wzoru");
                        double sum = 0.0;

                        for (int i = 1; i <= 20; i++)
                        {
                            sum += 1.0 / i;
                        }

                        Console.WriteLine("Suma: {0}", sum);
                        break;
                    case "7":
                        Console.Clear();
                        Console.WriteLine("Zadanie 7 - Program który dla liczby podanej przez użytkowników narysuje diament o krótszej przekątnej p długości wprowadzonej przez użytkowników" + "\n");
                        Console.Write("Podaj długość krótszej przekątnej: ");
                        int n2 = int.Parse(Console.ReadLine());

                        int halfLength = n2 / 2;
                        int spaces = halfLength;
                        //Górna część diamentu
                        for (int i = 1; i <= halfLength + 1; i++)
                        {
                            for (int j = 1; j <= spaces; j++)
                            {
                                Console.Write(" ");
                            }

                            for (int j = 1; j <= 2 * i - 1; j++)
                            {
                                Console.Write("*");
                            }

                            Console.WriteLine();
                            spaces--;
                        }

                        spaces = 1;

                        // Dolna części diamentu
                        for (int i = halfLength; i >= 1; i--)
                        {
                            for (int j = 1; j <= spaces; j++)
                            {
                                Console.Write(" ");
                            }

                            for (int j = 1; j <= 2 * i - 1; j++)
                            {
                                Console.Write("*");
                            }

                            Console.WriteLine();
                            spaces++;
                        }
                        break;
                    case "8":
                        Console.Clear();
                        Console.WriteLine("Zadanie 8 - Program który odwróci ciąg znaków." + "\n");
                        Console.Write("Prawidłowy ciąg znaków: SzkołaDotneta/Rezultat/Programowanie" + "\n");
                        Console.Write("\n" + "Odwrócony ciąg znakó :" + "\n");
                        string String = "SzkołaDotneta" + "\n" + "Rezultat" + "\n" + "Programowanie";

                        char[] Invertedstring = new char[String.Length];

                        for (int i = 0; i < String.Length; i++)
                        {
                            Invertedstring[i] = String[String.Length - 1 - i];
                        }

                        string result1 = new string(Invertedstring);
                        Console.WriteLine("\n" + "Wynik: " + "\n" + result1);
                        break;
                    case "9":
                        Console.Clear();
                        Console.WriteLine("Zadanie 9 - Program który zmieni liczbę dziesiętną na liczbę binarną" + "\n");
                        Console.Write("Wprowadź liczbę dziesiętną: ");
                        int decimalnumber = int.Parse(Console.ReadLine());

                        string binarynumber = "";

                        while (decimalnumber > 0)
                        {
                            int rest = decimalnumber % 2;
                            binarynumber = rest.ToString() + binarynumber;
                            decimalnumber = decimalnumber / 2;
                        }

                        Console.WriteLine("\n" + "Liczba binarna: " + binarynumber );
                        break;
                    case "10":
                        Console.Clear();
                        Console.WriteLine("Zadanie 10 - Program który znajdzie najmniejszą wspólną wielokrotność dla 2 wprowadzonych liczb " + "\n");
                        Console.Write("Pierwsza liczba: ");
                        int numb1 = int.Parse(Console.ReadLine());

                        Console.Write("Druga liczba: ");
                        int number2 = int.Parse(Console.ReadLine());

                        int lcm = CalculateLCM(numb1, number2);

                        Console.WriteLine("Najmniejsza wspólna wielokrotość: " + lcm);
                        break;
                    case "11":
                        Console.WriteLine("Do zobaczenia!");
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Nieprawidłowa operacja!");
                        break;
                }
                //Zadanie numer 1
                static bool IsPrime(int number)
                {
                    if (number < 2)
                    {
                        return false;
                    }

                    for (int i = 2; i <= Math.Sqrt(number); i++)
                    {
                        if (number % i == 0)
                        {
                            return false;
                        }
                    }

                    return true;
                }
                //Zadanie numer 3
                static int[] GenerateFibonacciSequence(int n)
                {
                    int[] fibonacci = new int[n];

                    if (n >= 1)
                    {
                        fibonacci[0] = 0;
                    }
                    if (n >= 2)
                    {
                        fibonacci[1] = 1;
                    }

                    for (int i = 2; i < n; i++)
                    {
                        fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                    }

                    return fibonacci;
                }
                //Zadanie numer 5
                static int CalculateCube(int number)
                {
                    return number * number * number;
                }
                //Zadanie numer 10
                static int CalculateLCM(int a, int b)
                {
                    int max = Math.Max(a, b);
                    int lcm = max;

                    while (true)
                    {
                        if (lcm % a == 0 && lcm % b == 0)
                            return lcm;

                        lcm += max;
                    }
                }
            }
        }
    }
}