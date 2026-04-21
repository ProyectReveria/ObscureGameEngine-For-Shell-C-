using System; 
using  Game_engine_Obscure.DeltaTime; 
namespace Game_engine_Obscure.Game_Manager;

public static class GameBeheivorData
{
    public static bool Sincron = true;
    public static bool Asincron = false;

    public const int GameEngine_Speed = 1; 
    public static float _IA_ROV = 7.0f;
    public static float _Ia_speed = 1.0f;
    
    public static  int Points = 0;
}



public static class GameManager_OperativeBehavior
{

    public static bool Game_Active = false;
    public static bool Game_oveer = false;

}

public class Game_FrameUpdate
{
    public static Game_FrameUpdate? Instance {get; private set;}
    public float DeltaTime {get;private set;}

    public void  Update_Manager()
    {
        Instance = this; 
    }

    public async Task Start_Engine()
    {
        while (true)
        {
            _DeltaTime_.RunDeltaTime();
            await Task.Delay(1000);
        }
    }
}


