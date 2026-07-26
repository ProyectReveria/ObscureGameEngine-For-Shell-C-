using System;
using System.Numerics;
using ObscureEngine.Physics; 
using ObscureEngine.Game_Manager; 
using ObscureEngine.DeltaTime; 
using ObscureEngine.Kernel.Diana.Manager;
using ObscureEngine.Treading.Delta;


public unsafe class Physics_Render_Unsafe
{
    public static async Task PhysicsStart()
    {
        Physics_Kernel.Physics_Delta();

        if (  Physics_Kernel.Timer_Elapsed != 0)
        {
            
        }
        else
        {
            Physics_Kernel.Timer.Start();
            PhysicsStart(); 
        }
    }

}