namespace ObscureEngine.Threading_Physics_Render; 
using System;
using System.Diagnostics.Metrics;
using System.Numerics;
using ObscureEngine._Declare__Library;
using ObscureEngine.API.HerrorHandler;
using ObscureEngine.Physics; 
using ObscureEngine.Game_Manager; 
using ObscureEngine.DeltaTime; 
using ObscureEngine.Kernel.Diana.Manager;
using ObscureEngine.Mathematics;
using ObscureEngine.Treading.Delta;


public unsafe class Physics_Render_Unsafe
{
    public static _Declaration_Enviorment_variables Get_Set_Declaration = new _Declaration_Enviorment_variables("undeclarate"); 
    public static string? Get_Referencial_Enviorment = Get_Set_Declaration.Get_Declare_Property();
    public static int errorcounter; 
    public static async Task PhysicsStart()
    {
        try
        {
            Physics_Kernel.Physics_Delta();

            Get_Set_Declaration = new _Declaration_Enviorment_variables("Declarete");
            if (Physics_Kernel.Timer_Elapsed != 0)
            {
                Get_Set_Declaration = new _Declaration_Enviorment_variables("onRun");
            }
            else
            {
                Physics_Kernel.Timer.Start();
                ++errorcounter;
                Get_Set_Declaration = new _Declaration_Enviorment_variables("_errorProces");
                 Thread.Sleep(20); 
                PhysicsStart();
                if (errorcounter == 10)
                {
                    throw new ArgumentException(nameof(errorcounter), ILoveCorrectPeapol.Physics_2); 
                }
            }

            Get_Set_Declaration = new _Declaration_Enviorment_variables("informal");

        }
        catch (Exception @ServiceEnviormentVariable_PhysicsErrorCatch)
        {
            if (Get_Referencial_Enviorment == "_ErrorProces")
            {
                Console.WriteLine(ILoveCorrectPeapol.Physics_1);
            }
        }
        finally
        {
            Console.WriteLine("Physics start and compile until end");
            Get_Set_Declaration = new _Declaration_Enviorment_variables("undeclarate");
        }
    }

    public static async Task PhysicsStops()
    {
        Physics_Kernel.Timer.Stop(); 
        Get_Set_Declaration = new _Declaration_Enviorment_variables("_ErrorProces");
        
        
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