using Newtonsoft.Json;

namespace DesenvolvedorSP.Models;

public class Resultado
{
    public Faturamento minBilling {get; set;}
    public Faturamento maxBilling {get; set;}
    public int aboveAverage {get; set;} = 0;
}