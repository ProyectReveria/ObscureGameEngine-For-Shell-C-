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
using Game_engine_Obscure.Kernel.Diana; 

namespace Game_engine_Obscure.API; 

/// <summary>
/// 
/// Este es el API o Aplication Interface.
/// 
/// Obscure Game Engine funciona en su micro consola (o consola del Engine) de forma muy diferente a otros sistemas.
/// 
/// Lo primero es que tienes que activarlo manualmente, en la Core class de ejemplo encontraras una implementacion extremadamente basica de esta consola.
/// Notaras que particularmente Obscure Engine Carece de algo vital: No devuelve textos ni confirmaciones si no boleanos.
/// 
/// Aquellos comandos devuelven false no alteran algo en el sistema o son de activar o desactivar la consola en si
/// Por su parte los comandos grandes devuelven siempre true y unicamente true.
/// 
/// mantenga este estandar si ocupa una consola mas avanzada o si bien modifica esta.
/// 
/// </summary>
public class Api 
{
    /// <exception cref="NegativeLimit">///
    /// Este es especialmente importante, sirve para activar los ejes negativos en la consola
    /// 
    /// no es completamente funcional ocupa una implementacion ya del usuario
    /// 
    /// Y si quedaste advertido programe dialogos de Marcus solo para demostrar mi des-aprobacion a esto.
    /// 
    /// AVISADO QUEDAS!
    /// 
    /// </end_ofText>
    public static bool NegativeLimit = false;  

    private static bool Active_Custom_API = false; 
    public static bool Debug_Mode_API = false; 

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

        Active_Custom_API = statement;
    }

    public static bool Api_Console(string command)
    {
        if (command == "./EnterGameConsole.GameEngineObscure")
        {
            Console.Clear();
            Console.WriteLine("Restart Game Engine, Game engine in UserMode"); 
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
            Console.WriteLine("for check the kernel check in the Engine EngineSystemCore->GameEngine_UnsafeCSData.CS -> Kernel"); 
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

        if (command == "Diana, how much you eat today?.Kernel")
        {
            Console.WriteLine($"GPU cicles = {SafeKernelData.Tick_Public}");
            return true;
        }
        

        return false;
    }
}