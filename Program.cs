using System;

using DesenvolvedorSP;

namespace DesenvolvedorSP;

public class Program
{
    static void Main(string[] args)
    {
        
        //Desafio 1
        int SomaChallenger = Challenges.Soma();

        Console.WriteLine(SomaChallenger);
        Console.WriteLine("__________________________________________________________");

        // Desafio 2
        int numberToAnalyze = 21;
        string fibonacciChallenger = Challenges.Fibonacci(numberToAnalyze)
            ? "Valor faz parte da sequencia de Fibonacci"
            : "Valor não faz parte da sequencia de Fibonacci"
        ;
        
        Console.WriteLine(fibonacciChallenger);
        Console.WriteLine("__________________________________________________________");

        // Desafio 3
        Models.Resultado BillingResult = Challenges.Faturamento();

        Console.WriteLine($"Maior faturamento no mês foi dia {BillingResult.maxBilling.day} totalizando {BillingResult.maxBilling.value}");
        Console.WriteLine($"Menor faturamento no mês foi dia {BillingResult.minBilling.day} totalizando {BillingResult.minBilling.value}");
        Console.WriteLine($"Dias do faturamento acima da média no mês: {BillingResult.aboveAverage}");
        Console.WriteLine("__________________________________________________________");

        //Desafio 4
        Dictionary<string, Double> BillingPercentage = Challenges.BillingPercentage(new Dictionary<string, Double>(){
            {"São Paulo", 67836.43},
            {"Rio de Janeiro", 36678.66},
            {"Minas Gerais", 29229.88},
            {"Espirito Santo", 27165.48},
            {"Outros", 19849.53}
        });

        foreach (var item in BillingPercentage)
        {
            Console.WriteLine($"{item.Key} - {item.Value}%");
        }
        Console.WriteLine("__________________________________________________________");

        // Desafio 5
        string invertedString= Challenges.invertString("Hello word!");
        Console.WriteLine(invertedString);


    }


}
