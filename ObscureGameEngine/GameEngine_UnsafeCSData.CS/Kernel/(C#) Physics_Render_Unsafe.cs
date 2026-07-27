using System;
using System.Diagnostics.Metrics;
using System.Numerics;
using ObscureEngine._Declare__Library;
using ObscureEngine.Physics; 
using ObscureEngine.Game_Manager; 
using ObscureEngine.DeltaTime; 
using ObscureEngine.Kernel.Diana.Manager;
using ObscureEngine.Mathematics;
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

public static class @Service_Physics
{
    public static async Task  CalculatePhysics_jump(float timer, float force, Vector2 playerP, Vector2 floor)
    {
        float varianza = force * timer; 
        int Repetition = 0;
        int Count = 0; 
        Vector2 origin = playerP;
        for (int i = 0; i < varianza; ++i)
        {
            
            if (Count == timer)
            {
                Repetition = 1; 
            }
            
            if (Repetition == 0)
            {
                playerP.Y = playerP.Y + varianza * Math_Alogirth.Get_Sin(varianza);
                Count++;
            }else if (Repetition == 1)
            {
                playerP.Y = playerP.Y - varianza * Math_Alogirth.Get_Sin(varianza);
                Count++;
                if (playerP.Y == origin.Y)
                {
                    break; 
                }
            }
        }
    }
}

public static class Physics_Rendering_Internal
{
    private static _Declaration_Enviorment_variables Physics_Enviorment_variables;
    private static string? referencial_Enviorment; 
    public static void PhysicsStart(double? delta, Vector2? floor, Vector2? Playerposition, bool? vertical_Axis, bool IfPrivate)
    {


        if (delta != null && floor != null && Playerposition != null && vertical_Axis == true)
        {
            
            if (IfPrivate == true)
            {
                Physics_Enviorment_variables = new _Declaration_Enviorment_variables("Iprivate");
            } else 

            {
                Physics_Enviorment_variables = new _Declaration_Enviorment_variables("Ipublic");
            }
            
            
        }else if (delta != null && floor != null && Playerposition != null && vertical_Axis == false)
        {
            Physics_Enviorment_variables = new _Declaration_Enviorment_variables("informal"); 
        }
        referencial_Enviorment = Physics_Enviorment_variables.Get_Declare_Property();

        if (referencial_Enviorment != null && referencial_Enviorment != "informal")
        {
            if (referencial_Enviorment == "Iprivate")
            {
                
            }else if (referencial_Enviorment == "Ipublic")
            {
                
            }
        }
        

        

    }
}