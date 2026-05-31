using System.IO; 
using System.Text.Json; 

namespace ObscureEngine.WorldConfigs; 

public class GameData
{
    public WorldConfigs WorldConfigs { get; set; }
    public PlayerStadistics PlayerStadistics { get; set; }
    public IA_Stadistics IA_Stadistics { get; set; }

}

public class WorldConfigs
{
    public float x {get; set; }
    public float Y {get; set;}
}

public class PlayerStadistics
{
    
    public Health Health {get; set;}

}

public class Health
{
    public string? Small_Text {get; set;}
    public int Value {get; set;}
}

public class IA_Stadistics
{
    
    public Active Active {get; set;}
}

public class Active
{
        
    public bool? Status {get; set;}
    public bool In_Use {get; set;}

}



public class WorldConfigs_Extract_Json
{
 
    public static void Deserialization_WC()
    {
        string JsonString = File.ReadAllText("WorldConfigs.Json"); 
        
        GameData data = JsonSerializer.Deserialize<GameData>(JsonString);

    }


}