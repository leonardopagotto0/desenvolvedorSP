using Newtonsoft.Json;

namespace DesenvolvedorSP.Models;

public class Faturamento
{
    [JsonProperty(PropertyName = "dia")]
    public int day {get; set;}
    [JsonProperty(PropertyName = "valor")]
    public float value {get; set;}

    public void setData(int day, float value){
        this.day = day;
        this.value = value;
    }
}