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
    private static bool onUp = false;

    public static void Physics_Gravity(float gravity, ref Vector2 playerP, Vector2 floor_Y, float tiempo, float delta)
    {

        int Delta_int = (int)(delta * 1000f);
        if (Delta_int <= 1)
            Delta_int = 1;

        //Digase que Tiempo es lo que dure el salto o el movimiento en si; 
        if (playerP.Y > floor_Y.Y)
        {
            _Physics_.Velocidad_Inicial(Game_Physics.Gravity_OnEngine, Game_Physics.aceleration, tiempo);
            if (onUp == true)
            {
                ///<Calculo en mi jupa que probablementen o ande>
                ///  [0,0] => [1...X+1,0]
                ///  [Y,X] => [Y,X] 
                /// 
                ///  
                /// <end>
                for (int i = 0; i < tiempo; ++i)
                {
                    Thread.Sleep(Delta_int);
                    ++playerP.Y;
                }
            }
            else if (onUp == false)
            {
                for (int i = 0; i > tiempo; --i)
                {
                    Thread.Sleep(Delta_int);
                    --playerP.Y;
                }
            }
        }


    }

    public static void CalculatePhysics_jump(float timer, float force, ref Vector2 playerP, Vector2 floor)
    {
        //Hacer que el jugador pueda decidir donde caer en ves de en el punto de partida. 
        Vector2 origin_point = playerP;
        int Ttimer = (int)(timer * 1000f);

        for (int i = 0; i < Ttimer; ++i)
        {
            float varianza = ((float)i / timer) * AlgebraicVariables.pi;

            onUp = (i < Ttimer / 2);

            playerP.Y = origin_point.Y - (force * Math_Alogirth.Get_Sin(varianza));
        }

        playerP.Y = origin_point.Y;
    }

    public static class Physics_Rendering_Internal
    {
        private static _Declaration_Enviorment_variables Physics_Enviorment_variables;
        private static string? referencial_Enviorment;

        public static void PhysicsStart(double? delta, Vector2? floor, Vector2? Playerposition, bool? vertical_Axis,
            bool IfPrivate)
        {


            if (delta != null && floor != null && Playerposition != null && vertical_Axis == true)
            {

                if (IfPrivate == true)
                {
                    Physics_Enviorment_variables = new _Declaration_Enviorment_variables("Iprivate");
                }
                else

                {
                    Physics_Enviorment_variables = new _Declaration_Enviorment_variables("Ipublic");
                }


            }
            else if (delta != null && floor != null && Playerposition != null && vertical_Axis == false)
            {
                Physics_Enviorment_variables = new _Declaration_Enviorment_variables("informal");
            }

            referencial_Enviorment = Physics_Enviorment_variables.Get_Declare_Property();

            if (referencial_Enviorment != null && referencial_Enviorment != "informal")
            {
                if (referencial_Enviorment == "Iprivate")
                {

                }
                else if (referencial_Enviorment == "Ipublic")
                {

                }
            }




        }
    }
}

