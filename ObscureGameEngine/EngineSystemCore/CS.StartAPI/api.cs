using System;
using System.Numerics;
using Game_engine_Obscure.DeltaTime;
using Game_engine_Obscure.Mathematics;
using Game_engine_Obscure.InputManager;
using Game_engine_Obscure.InputManager.IA;
using Game_engine_Obscure.Game_user_Interface_Library;
using Game_engine_Obscure.Hitbox;
using Game_engine_Obscure.Game_Manager;
using System.Runtime.Versioning;
using Game_engine_Obscure.Kernel; 
using Game_engine_Obscure.accesKey;

namespace Game_engine_Obscure.API; 

// La clase debe ser publica para que el resto del motor la pueda ver
public class Api 
{
    public static bool NegativeLimit = false; 
    // Corregido el orden: 'static' va antes que el tipo 'bool'
    private static bool Active_Custom_API = false; 
    public static bool Debug_Mode_API = false; 

    // public static para que el Kernel pueda levantar la API al iniciar el motor
    public static void API_MAIN()
    {
        Console.WriteLine("API is off: Obscure engine custom functions for execute data is on beta");
        if (Debug_Mode_API == true)
        {
            GUI.Game_Engine_API();
        }
    }

    public static void Active_API(bool statement)
    {
        // Optimizacion limpia: Asignas directamente el valor booleano sin ifs redundantes
        Active_Custom_API = statement;
    }

    public static bool Api_Console(string command)
    {
        if (command == "./EnterGameConsole.GameEngineObscure")
        {
            Console.Clear();
            Console.WriteLine("Restart Game Engine, Game engine in UserMode"); // Corregido typo "un UserMode"
            return false;
        }
        if (command == "./EnterGameConsole.GameEngineObscure(Start.Debug)")
        {
            Console.Clear();
            Console.WriteLine("Engine on Debug Mode");
            return false;
        }
        if (command == "./dotnet Cnet Check(check Score)")
        {
            Console.WriteLine($"Puntuacion {GameBeheivorData.Points}"); 
            return false;
        }
        if (command == "./dotnet Cnet Check(ResetScore)")
        {
            GameBeheivorData.Points = 0; 
            return false;
        }
        if (command == "./PrintConfigs(Kernel)")
        {
            Console.WriteLine("for check the kernel check in the Engine EngineSystemCore->GameEngine_UnsafeCSData.CS -> Kernel"); // Corregidos typos
            return false; 
        }
        if (command == "./Help()")
        {
            Console.WriteLine("Work in progress!");
            return false; 
        }
        
        if (command == "Cryptodata")
        {
            Console_Cryptodata.Console_AccesKey(command);     
            return true; 
        }

        if (command == "MARCUS! I WANT NEGATIVES AND I DON'T CARE ABOUT YAGNI!")
        {
            NegativeLimit = true;

            return true; 
        }
        

        return false;
    }
}