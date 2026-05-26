using Game_engine_Obscure;
using Game_engine_Obscure.Mathematics;
using Game_engine_Obscure.Game_Manager;
using System;
using System.Diagnostics;

namespace Game_engine_Obscure.DeltaTime;

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
        }
    }
}
