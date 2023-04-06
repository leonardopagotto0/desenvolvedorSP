using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections;

namespace DesenvolvedorSP;

public static class Challenges
{
    public static int Soma()
    {
        int indice = 13, soma = 0, k = 0;

        while (k < indice)
        {
            k = k + 1;
            soma = soma + k;
        }

        return soma;
    }

    public static bool Fibonacci (int param)
    {
        List<long> fibonacciNumbers = new List<long>{0, 1};

        bool result = false;

        for (int i = 0; i < fibonacciNumbers.Count; i++)
        {
            long currentNumber = fibonacciNumbers[i];
            long lastNumber = fibonacciNumbers.Last();

            if(param == currentNumber){
                result = true;
                break;
            }
            if(param < currentNumber){
                result = true;
                break;
            }

            fibonacciNumbers.Add(lastNumber + currentNumber);
        }

        return result;
    }

    public static Models.Resultado Faturamento()
    {
        string file = File.ReadAllText("./dados.json");

        List<Models.Faturamento>? faturamentos = JsonConvert.DeserializeObject<List<Models.Faturamento>>(file);

        Models.Faturamento minBilling = new Models.Faturamento();
        Models.Faturamento maxBilling = new Models.Faturamento();
        int aboveAverage = 0;

        int validDays = 0;
        float grossProfit = 0;
        bool definedMin = false;

        for (int i = 0; i < faturamentos.Count; i++)
        {
            float currentValue = faturamentos[i].value;
            int currentDay = faturamentos[i].day;

            if(currentValue != 0){
                validDays++;
                grossProfit += currentValue;
                if(definedMin == false){
                    minBilling.value = currentValue;
                    definedMin = true;
                }
                if(currentValue < minBilling.value){
                    minBilling.setData(currentDay, currentValue);
                }
                if(maxBilling.value < currentValue) maxBilling.setData(currentDay, currentValue);
            }
        }

        float average = grossProfit / validDays;
        aboveAverage = faturamentos.FindAll(f => f.value > average).Count;

        return new Models.Resultado(){
            maxBilling = maxBilling,
            minBilling = minBilling,
            aboveAverage = aboveAverage,
        };
    }

    public static Dictionary<string, Double> BillingPercentage(Dictionary<string, Double> states)
    {
        Double BillingTotal = states.Sum(s => s.Value);
        Dictionary<string, Double> result = new Dictionary<string, Double>();

        foreach (KeyValuePair<string, Double> state in states)
        {
            result.Add(state.Key, 100-(((BillingTotal - state.Value)/BillingTotal)*100));
        }

        return result;
    }

    public static string invertString(string s){
        char[] cArray = s.ToCharArray();
        string reverse = String.Empty;
        for (int i = cArray.Length - 1; i > -1; i--)
        {
            reverse += cArray[i];
        }
        return reverse;
    }
}