using System; 
using  ObscureEngine.DeltaTime; 
namespace ObscureEngine.Game_Manager;

/// <manger>
/// te presento al todo poderoso, señor de todos nosotros, sumo pontifise de la catedral de marcus, gran dios y slvador de todos nosotors juanito el manger.
/// 
/// esto es game manager, contine datos que son importantes y son basicamente un Json en esteroides,porque podes programar funciones aqui.
/// 
/// tiene un par de cosas importanets (como el start delta time) por si queiren revisarlas y darles una ojeada. 
/// </juanito>

public static class GameBeheivorData
{
    public static bool Sincron = true;
    public static bool Asincron = false;

    public const int GameEngine_Speed = 1; 
    public static float _IA_ROV = 7.0f;
    public static float _Ia_speed = 1.0f;
    
    public static  int Points = 0;

    public static int Delta_Time_Speed = 1; 

    //playerStats
    public static int JumpForce = 2;

    public static int Musical_Thread = 100; 
}



public class GameManager_OperativeBehavior
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


