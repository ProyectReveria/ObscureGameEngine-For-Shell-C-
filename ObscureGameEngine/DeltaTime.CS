using Game_engine_Obscure;
using Game_engine_Obscure.Mathematics;
using System;
using System.Diagnostics;

namespace Game_engine_Obscure.DeltaTime;

internal class DeltaTime : Math_Alogirth
{

    static void Update_Deltatime(double DeltaTime)
    {
        double Delta_Time_Speed = 5f;
        double Delta_Time_movement = Delta_Time_Speed * DeltaTime;
    }

    public static void Main()
    {
        Stopwatch Delta_Watch = new Stopwatch();
        Delta_Watch.Start();

        double Start_frame = 0;

        while (true)
        {
            double Corrunt_frame = Delta_Watch.Elapsed.TotalSeconds;
            double deltatime = Start_frame - Corrunt_frame;

            Update_Deltatime(deltatime);
        }
    }
}
