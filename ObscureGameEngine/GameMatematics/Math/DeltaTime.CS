using Game_engine_Obscure;
using Game_engine_Obscure.Mathematics;
using Game_engine_Obscure.Game_Manager;
using System;
using System.Diagnostics;

namespace Game_engine_Obscure.DeltaTime;

/// <ok dejemos las bromas un minuto esto es de hecho importante>
/// 
/// Delta time, notaras que en todos los game engine se llama igual (excepto en rpgmaker, son especialitos aun no descubren que java no funciona para game development)
/// esto mide el timepo en ticks y los devuelve en segundos.
/// y si, se llama Aldente.
/// 
/// italia te pido perdon
/// 
/// </:3>

internal class _DeltaTime_ : Math_Alogirth
{

    public static float _RunDeltaTime_ {get; private set;}

    static void Update_Deltatime(double DeltaTime)
    {
        double  Delta_Time_Speed = Game_Manager.GameBeheivorData.Delta_Time_Speed;
        double Delta_Time_movement = Delta_Time_Speed * DeltaTime;
    }

    public static void RunDeltaTime()
    {
        Stopwatch Delta_Watch = new Stopwatch();
        Delta_Watch.Start();

        double Start_frame = 0;

        while (true)
        {
            double Corrunt_frame = Delta_Watch.Elapsed.TotalSeconds;
            double deltatime = Corrunt_frame - Start_frame;

            Update_Deltatime(deltatime);

            if (deltatime < 0.016666)
            {
                System.Threading.Thread.Sleep(1);
            }
        }
    }
}
